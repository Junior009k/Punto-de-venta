namespace PV
{
    partial class Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDateReport = new System.Windows.Forms.Label();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.labelTypeQueryReport = new System.Windows.Forms.Label();
            this.dateTimePickerReportDesde = new System.Windows.Forms.DateTimePicker();
            this.comboBoxTypeQueryReport = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerReporthasta = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDateReport
            // 
            this.labelDateReport.AutoSize = true;
            this.labelDateReport.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateReport.Location = new System.Drawing.Point(504, 107);
            this.labelDateReport.Name = "labelDateReport";
            this.labelDateReport.Size = new System.Drawing.Size(60, 20);
            this.labelDateReport.TabIndex = 40;
            this.labelDateReport.Text = "Fecha";
            this.labelDateReport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Description,
            this.lastName,
            this.age});
            this.dgvReport.Location = new System.Drawing.Point(34, 223);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.Size = new System.Drawing.Size(603, 198);
            this.dgvReport.TabIndex = 39;
            // 
            // Code
            // 
            this.Code.HeaderText = "Codigo";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 60;
            // 
            // Description
            // 
            this.Description.HeaderText = "Descripcion";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Monto";
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            // 
            // age
            // 
            this.age.HeaderText = "Fecha";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            // 
            // buttonQuery
            // 
            this.buttonQuery.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuery.Location = new System.Drawing.Point(643, 341);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(127, 37);
            this.buttonQuery.TabIndex = 38;
            this.buttonQuery.Text = "Consulta";
            this.buttonQuery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(643, 384);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(127, 37);
            this.buttonBack.TabIndex = 37;
            this.buttonBack.Text = "Volver";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(323, 30);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(124, 34);
            this.title.TabIndex = 48;
            this.title.Text = "Reporte";
            // 
            // labelTypeQueryReport
            // 
            this.labelTypeQueryReport.AutoSize = true;
            this.labelTypeQueryReport.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeQueryReport.Location = new System.Drawing.Point(43, 107);
            this.labelTypeQueryReport.Name = "labelTypeQueryReport";
            this.labelTypeQueryReport.Size = new System.Drawing.Size(131, 20);
            this.labelTypeQueryReport.TabIndex = 49;
            this.labelTypeQueryReport.Text = "Tipo Consulta";
            this.labelTypeQueryReport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePickerReportDesde
            // 
            this.dateTimePickerReportDesde.Location = new System.Drawing.Point(570, 128);
            this.dateTimePickerReportDesde.Name = "dateTimePickerReportDesde";
            this.dateTimePickerReportDesde.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerReportDesde.TabIndex = 50;
            this.dateTimePickerReportDesde.Value = new System.DateTime(2025, 11, 10, 0, 4, 0, 0);
            // 
            // comboBoxTypeQueryReport
            // 
            this.comboBoxTypeQueryReport.FormattingEnabled = true;
            this.comboBoxTypeQueryReport.Items.AddRange(new object[] {
            "Ventas totales",
            "Ventas detallada"});
            this.comboBoxTypeQueryReport.Location = new System.Drawing.Point(191, 105);
            this.comboBoxTypeQueryReport.Name = "comboBoxTypeQueryReport";
            this.comboBoxTypeQueryReport.Size = new System.Drawing.Size(187, 21);
            this.comboBoxTypeQueryReport.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(504, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "Desde";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(504, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "Hasta";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePickerReporthasta
            // 
            this.dateTimePickerReporthasta.Location = new System.Drawing.Point(570, 154);
            this.dateTimePickerReporthasta.Name = "dateTimePickerReporthasta";
            this.dateTimePickerReporthasta.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerReporthasta.TabIndex = 54;
            this.dateTimePickerReporthasta.Value = new System.DateTime(2025, 11, 10, 23, 5, 0, 0);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePickerReporthasta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTypeQueryReport);
            this.Controls.Add(this.dateTimePickerReportDesde);
            this.Controls.Add(this.labelTypeQueryReport);
            this.Controls.Add(this.title);
            this.Controls.Add(this.labelDateReport);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.buttonQuery);
            this.Controls.Add(this.buttonBack);
            this.Name = "Report";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDateReport;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label labelTypeQueryReport;
        private System.Windows.Forms.DateTimePicker dateTimePickerReportDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.ComboBox comboBoxTypeQueryReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerReporthasta;
    }
}