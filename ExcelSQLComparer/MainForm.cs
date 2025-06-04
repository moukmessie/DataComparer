using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace ExcelSQLComparer
{
    public partial class MainForm : Form
    {
        private DataTable excelTable = new();
        private DataTable sqlTable = new();
        private DataTable correspondTable = new();
        private DataTable nonFoundTable = new();

        public MainForm()
        {
            InitializeComponent();
            dgvExcel.DataSource = excelTable;
            dgvSQL.DataSource = sqlTable;
            dgvCorrespondance.DataSource = correspondTable;
            dgvNonTrouve.DataSource = nonFoundTable;
        }

        private void btnLoadExcel_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel Files|*.xlsx";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using var workbook = new XLWorkbook(ofd.FileName);
                var ws = workbook.Worksheet(1);
                excelTable = ws.RangeUsed().AsTable().AsNativeDataTable();
                dgvExcel.DataSource = excelTable;
            }
        }

        private void btnLoadSQL_Click(object sender, EventArgs e)
        {
            string connStr = "Server=localhost;Trusted_Connection=True;Database=YourDatabase";
            using var conn = new SqlConnection(connStr);
            var cmd = new SqlCommand("SELECT Societe, Enseigne, CodePostal, Ville, Pays, ID_Societe FROM PointsDeVente", conn);
            var adapter = new SqlDataAdapter(cmd);
            sqlTable.Clear();
            adapter.Fill(sqlTable);
            dgvSQL.DataSource = sqlTable;
        }

        private void btnComparer_Click(object sender, EventArgs e)
        {
            correspondTable.Clear();
            nonFoundTable.Clear();
            correspondTable = excelTable.Clone();
            correspondTable.Columns.Add("ID_Societe", typeof(int));
            nonFoundTable = excelTable.Clone();

            foreach (DataRow xRow in excelTable.Rows)
            {
                string filter = $"Societe = '{xRow["Societe"]}' AND Enseigne = '{xRow["Enseigne"]}' AND CodePostal = '{xRow["CodePostal"]}' AND Ville = '{xRow["Ville"]}' AND Pays = '{xRow["Pays"]}'";
                DataRow[] found = sqlTable.Select(filter);
                if (found.Length > 0)
                {
                    var newRow = correspondTable.NewRow();
                    newRow.ItemArray = xRow.ItemArray.Clone() as object[] ?? Array.Empty<object>();
                    newRow["ID_Societe"] = found[0]["ID_Societe"];
                    correspondTable.Rows.Add(newRow);
                }
                else
                {
                    nonFoundTable.Rows.Add(xRow.ItemArray);
                }
            }

            dgvCorrespondance.DataSource = correspondTable;
            dgvNonTrouve.DataSource = nonFoundTable;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using var wb = new XLWorkbook();
            wb.Worksheets.Add(correspondTable, "Correspondance");
            wb.Worksheets.Add(nonFoundTable, "NonCorrespondance");
            wb.SaveAs("ResultatComparaison.xlsx");
            MessageBox.Show("Export termine", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
