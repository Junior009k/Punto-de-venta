namespace PV
{
    partial class Clientes
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
            this.textBoxProductPrice = new System.Windows.Forms.TextBox();
            this.labelProductPrice = new System.Windows.Forms.Label();
            this.textBoxProductAmount = new System.Windows.Forms.TextBox();
            this.labelLastNameClient = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.labelClientName = new System.Windows.Forms.Label();
            this.textBoxProductCode = new System.Windows.Forms.TextBox();
            this.labelClientCode = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxProductPrice
            // 
            this.textBoxProductPrice.Location = new System.Drawing.Point(121, 128);
            this.textBoxProductPrice.Name = "textBoxProductPrice";
            this.textBoxProductPrice.Size = new System.Drawing.Size(157, 20);
            this.textBoxProductPrice.TabIndex = 35;
            // 
            // labelProductPrice
            // 
            this.labelProductPrice.AutoSize = true;
            this.labelProductPrice.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductPrice.Location = new System.Drawing.Point(30, 128);
            this.labelProductPrice.Name = "labelProductPrice";
            this.labelProductPrice.Size = new System.Drawing.Size(51, 20);
            this.labelProductPrice.TabIndex = 34;
            this.labelProductPrice.Text = "Edad";
            // 
            // textBoxProductAmount
            // 
            this.textBoxProductAmount.Location = new System.Drawing.Point(121, 102);
            this.textBoxProductAmount.Name = "textBoxProductAmount";
            this.textBoxProductAmount.Size = new System.Drawing.Size(157, 20);
            this.textBoxProductAmount.TabIndex = 33;
            // 
            // labelLastNameClient
            // 
            this.labelLastNameClient.AutoSize = true;
            this.labelLastNameClient.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastNameClient.Location = new System.Drawing.Point(30, 102);
            this.labelLastNameClient.Name = "labelLastNameClient";
            this.labelLastNameClient.Size = new System.Drawing.Size(83, 20);
            this.labelLastNameClient.TabIndex = 32;
            this.labelLastNameClient.Text = "Apellido";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(121, 76);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(157, 20);
            this.textBoxProductName.TabIndex = 31;
            // 
            // labelClientName
            // 
            this.labelClientName.AutoSize = true;
            this.labelClientName.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientName.Location = new System.Drawing.Point(30, 76);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(79, 20);
            this.labelClientName.TabIndex = 30;
            this.labelClientName.Text = "Nombre";
            // 
            // textBoxProductCode
            // 
            this.textBoxProductCode.Location = new System.Drawing.Point(121, 50);
            this.textBoxProductCode.Name = "textBoxProductCode";
            this.textBoxProductCode.Size = new System.Drawing.Size(157, 20);
            this.textBoxProductCode.TabIndex = 29;
            // 
            // labelClientCode
            // 
            this.labelClientCode.AutoSize = true;
            this.labelClientCode.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientCode.Location = new System.Drawing.Point(30, 50);
            this.labelClientCode.Name = "labelClientCode";
            this.labelClientCode.Size = new System.Drawing.Size(71, 20);
            this.labelClientCode.TabIndex = 28;
            this.labelClientCode.Text = "Codigo";
            this.labelClientCode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.name,
            this.lastName,
            this.age});
            this.dataGridView1.Location = new System.Drawing.Point(34, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(603, 198);
            this.dataGridView1.TabIndex = 27;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(643, 320);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(127, 37);
            this.buttonAdd.TabIndex = 26;
            this.buttonAdd.Text = "Agregar";
            this.buttonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(643, 363);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(127, 37);
            this.buttonBack.TabIndex = 25;
            this.buttonBack.Text = "Volver";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(323, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(114, 34);
            this.title.TabIndex = 36;
            this.title.Text = "Cliente";
            // 
            // Code
            // 
            this.Code.HeaderText = "Codigo";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 60;
            // 
            // name
            // 
            this.name.HeaderText = "Nombre";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Apellido";
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            // 
            // age
            // 
            this.age.HeaderText = "Edad";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.title);
            this.Controls.Add(this.textBoxProductPrice);
            this.Controls.Add(this.labelProductPrice);
            this.Controls.Add(this.textBoxProductAmount);
            this.Controls.Add(this.labelLastNameClient);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.labelClientName);
            this.Controls.Add(this.textBoxProductCode);
            this.Controls.Add(this.labelClientCode);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonBack);
            this.Name = "Clientes";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxProductPrice;
        private System.Windows.Forms.Label labelProductPrice;
        private System.Windows.Forms.TextBox textBoxProductAmount;
        private System.Windows.Forms.Label labelLastNameClient;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.TextBox textBoxProductCode;
        private System.Windows.Forms.Label labelClientCode;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
    }
}