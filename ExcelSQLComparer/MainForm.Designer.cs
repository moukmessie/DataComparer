namespace ExcelSQLComparer
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnLoadExcel;
        private System.Windows.Forms.Button btnLoadSQL;
        private System.Windows.Forms.Button btnComparer;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridView dgvExcel;
        private System.Windows.Forms.DataGridView dgvSQL;
        private System.Windows.Forms.DataGridView dgvCorrespondance;
        private System.Windows.Forms.DataGridView dgvNonTrouve;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnLoadExcel = new System.Windows.Forms.Button();
            this.btnLoadSQL = new System.Windows.Forms.Button();
            this.btnComparer = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.dgvExcel = new System.Windows.Forms.DataGridView();
            this.dgvSQL = new System.Windows.Forms.DataGridView();
            this.dgvCorrespondance = new System.Windows.Forms.DataGridView();
            this.dgvNonTrouve = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSQL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorrespondance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNonTrouve)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadExcel
            // 
            this.btnLoadExcel.Location = new System.Drawing.Point(12, 12);
            this.btnLoadExcel.Name = "btnLoadExcel";
            this.btnLoadExcel.Size = new System.Drawing.Size(100, 23);
            this.btnLoadExcel.TabIndex = 0;
            this.btnLoadExcel.Text = "Charger Excel";
            this.btnLoadExcel.UseVisualStyleBackColor = true;
            this.btnLoadExcel.Click += new System.EventHandler(this.btnLoadExcel_Click);
            // 
            // btnLoadSQL
            // 
            this.btnLoadSQL.Location = new System.Drawing.Point(118, 12);
            this.btnLoadSQL.Name = "btnLoadSQL";
            this.btnLoadSQL.Size = new System.Drawing.Size(125, 23);
            this.btnLoadSQL.TabIndex = 1;
            this.btnLoadSQL.Text = "Charger SQL";
            this.btnLoadSQL.UseVisualStyleBackColor = true;
            this.btnLoadSQL.Click += new System.EventHandler(this.btnLoadSQL_Click);
            // 
            // btnComparer
            // 
            this.btnComparer.Location = new System.Drawing.Point(249, 12);
            this.btnComparer.Name = "btnComparer";
            this.btnComparer.Size = new System.Drawing.Size(100, 23);
            this.btnComparer.TabIndex = 2;
            this.btnComparer.Text = "Comparer";
            this.btnComparer.UseVisualStyleBackColor = true;
            this.btnComparer.Click += new System.EventHandler(this.btnComparer_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(355, 12);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(125, 23);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Exporter Resultat";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // dgvExcel
            // 
            this.dgvExcel.AllowUserToAddRows = false;
            this.dgvExcel.AllowUserToDeleteRows = false;
            this.dgvExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExcel.Location = new System.Drawing.Point(12, 41);
            this.dgvExcel.Name = "dgvExcel";
            this.dgvExcel.ReadOnly = true;
            this.dgvExcel.RowTemplate.Height = 25;
            this.dgvExcel.Size = new System.Drawing.Size(468, 150);
            this.dgvExcel.TabIndex = 4;
            // 
            // dgvSQL
            // 
            this.dgvSQL.AllowUserToAddRows = false;
            this.dgvSQL.AllowUserToDeleteRows = false;
            this.dgvSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSQL.Location = new System.Drawing.Point(12, 197);
            this.dgvSQL.Name = "dgvSQL";
            this.dgvSQL.ReadOnly = true;
            this.dgvSQL.RowTemplate.Height = 25;
            this.dgvSQL.Size = new System.Drawing.Size(468, 150);
            this.dgvSQL.TabIndex = 5;
            // 
            // dgvCorrespondance
            // 
            this.dgvCorrespondance.AllowUserToAddRows = false;
            this.dgvCorrespondance.AllowUserToDeleteRows = false;
            this.dgvCorrespondance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCorrespondance.Location = new System.Drawing.Point(12, 353);
            this.dgvCorrespondance.Name = "dgvCorrespondance";
            this.dgvCorrespondance.ReadOnly = true;
            this.dgvCorrespondance.RowTemplate.Height = 25;
            this.dgvCorrespondance.Size = new System.Drawing.Size(468, 150);
            this.dgvCorrespondance.TabIndex = 6;
            // 
            // dgvNonTrouve
            // 
            this.dgvNonTrouve.AllowUserToAddRows = false;
            this.dgvNonTrouve.AllowUserToDeleteRows = false;
            this.dgvNonTrouve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNonTrouve.Location = new System.Drawing.Point(12, 509);
            this.dgvNonTrouve.Name = "dgvNonTrouve";
            this.dgvNonTrouve.ReadOnly = true;
            this.dgvNonTrouve.RowTemplate.Height = 25;
            this.dgvNonTrouve.Size = new System.Drawing.Size(468, 150);
            this.dgvNonTrouve.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 671);
            this.Controls.Add(this.dgvNonTrouve);
            this.Controls.Add(this.dgvCorrespondance);
            this.Controls.Add(this.dgvSQL);
            this.Controls.Add(this.dgvExcel);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnComparer);
            this.Controls.Add(this.btnLoadSQL);
            this.Controls.Add(this.btnLoadExcel);
            this.Name = "MainForm";
            this.Text = "ExcelSQLComparer";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSQL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorrespondance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNonTrouve)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
