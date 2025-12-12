namespace PV
{
    partial class Caja
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
            this.title = new System.Windows.Forms.Label();
            this.labelConceptBox = new System.Windows.Forms.Label();
            this.textBoxBoxConcept = new System.Windows.Forms.TextBox();
            this.labelBoxDate = new System.Windows.Forms.Label();
            this.textBoxBoxCode = new System.Windows.Forms.TextBox();
            this.labelSupplierCode = new System.Windows.Forms.Label();
            this.dgvCaja = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.textBoxBoxAmount = new System.Windows.Forms.TextBox();
            this.labelBoxAmount = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxBoxDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaja)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(323, 30);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(76, 34);
            this.title.TabIndex = 58;
            this.title.Text = "Caja";
            // 
            // labelConceptBox
            // 
            this.labelConceptBox.AutoSize = true;
            this.labelConceptBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConceptBox.Location = new System.Drawing.Point(30, 97);
            this.labelConceptBox.Name = "labelConceptBox";
            this.labelConceptBox.Size = new System.Drawing.Size(92, 20);
            this.labelConceptBox.TabIndex = 56;
            this.labelConceptBox.Text = "Concepto";
            // 
            // textBoxBoxConcept
            // 
            this.textBoxBoxConcept.Location = new System.Drawing.Point(121, 97);
            this.textBoxBoxConcept.Name = "textBoxBoxConcept";
            this.textBoxBoxConcept.Size = new System.Drawing.Size(157, 20);
            this.textBoxBoxConcept.TabIndex = 55;
            // 
            // labelBoxDate
            // 
            this.labelBoxDate.AutoSize = true;
            this.labelBoxDate.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBoxDate.Location = new System.Drawing.Point(30, 126);
            this.labelBoxDate.Name = "labelBoxDate";
            this.labelBoxDate.Size = new System.Drawing.Size(60, 20);
            this.labelBoxDate.TabIndex = 54;
            this.labelBoxDate.Text = "Fecha";
            // 
            // textBoxBoxCode
            // 
            this.textBoxBoxCode.Location = new System.Drawing.Point(121, 71);
            this.textBoxBoxCode.Name = "textBoxBoxCode";
            this.textBoxBoxCode.Size = new System.Drawing.Size(157, 20);
            this.textBoxBoxCode.TabIndex = 53;
            // 
            // labelSupplierCode
            // 
            this.labelSupplierCode.AutoSize = true;
            this.labelSupplierCode.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupplierCode.Location = new System.Drawing.Point(30, 71);
            this.labelSupplierCode.Name = "labelSupplierCode";
            this.labelSupplierCode.Size = new System.Drawing.Size(71, 20);
            this.labelSupplierCode.TabIndex = 52;
            this.labelSupplierCode.Text = "Codigo";
            this.labelSupplierCode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvCaja
            // 
            this.dgvCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.concept,
            this.date,
            this.Amount});
            this.dgvCaja.Location = new System.Drawing.Point(34, 223);
            this.dgvCaja.Name = "dgvCaja";
            this.dgvCaja.Size = new System.Drawing.Size(603, 198);
            this.dgvCaja.TabIndex = 51;
            this.dgvCaja.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCaja_CellClick);
            // 
            // Code
            // 
            this.Code.HeaderText = "Codigo";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 60;
            // 
            // concept
            // 
            this.concept.HeaderText = "Concepto";
            this.concept.Name = "concept";
            this.concept.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Fecha";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Monto";
            this.Amount.Name = "Amount";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(643, 341);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(127, 37);
            this.buttonAdd.TabIndex = 50;
            this.buttonAdd.Text = "Agregar";
            this.buttonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(643, 384);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(127, 37);
            this.buttonBack.TabIndex = 49;
            this.buttonBack.Text = "Volver";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // textBoxBoxAmount
            // 
            this.textBoxBoxAmount.Location = new System.Drawing.Point(121, 158);
            this.textBoxBoxAmount.Name = "textBoxBoxAmount";
            this.textBoxBoxAmount.Size = new System.Drawing.Size(157, 20);
            this.textBoxBoxAmount.TabIndex = 60;
            // 
            // labelBoxAmount
            // 
            this.labelBoxAmount.AutoSize = true;
            this.labelBoxAmount.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBoxAmount.Location = new System.Drawing.Point(30, 158);
            this.labelBoxAmount.Name = "labelBoxAmount";
            this.labelBoxAmount.Size = new System.Drawing.Size(64, 20);
            this.labelBoxAmount.TabIndex = 59;
            this.labelBoxAmount.Text = "Monto";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(643, 114);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(127, 37);
            this.buttonUpdate.TabIndex = 62;
            this.buttonUpdate.Text = "Actualizar";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(643, 71);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(127, 37);
            this.buttonDelete.TabIndex = 61;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxBoxDate
            // 
            this.textBoxBoxDate.Location = new System.Drawing.Point(121, 126);
            this.textBoxBoxDate.Name = "textBoxBoxDate";
            this.textBoxBoxDate.Size = new System.Drawing.Size(157, 20);
            this.textBoxBoxDate.TabIndex = 63;
            // 
            // Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxBoxDate);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxBoxAmount);
            this.Controls.Add(this.labelBoxAmount);
            this.Controls.Add(this.title);
            this.Controls.Add(this.labelConceptBox);
            this.Controls.Add(this.textBoxBoxConcept);
            this.Controls.Add(this.labelBoxDate);
            this.Controls.Add(this.textBoxBoxCode);
            this.Controls.Add(this.labelSupplierCode);
            this.Controls.Add(this.dgvCaja);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonBack);
            this.Name = "Caja";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Cajas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label labelConceptBox;
        private System.Windows.Forms.TextBox textBoxBoxConcept;
        private System.Windows.Forms.Label labelBoxDate;
        private System.Windows.Forms.TextBox textBoxBoxCode;
        private System.Windows.Forms.Label labelSupplierCode;
        private System.Windows.Forms.DataGridView dgvCaja;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn concept;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.TextBox textBoxBoxAmount;
        private System.Windows.Forms.Label labelBoxAmount;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DateTimePicker textBoxBoxDate;
    }
}