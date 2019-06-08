namespace EaSystem
{
    partial class Buys
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btCleanInsert = new System.Windows.Forms.Button();
            this.btInsertBuy = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtDateIn = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btSearchSupplier = new System.Windows.Forms.Button();
            this.SupplierId = new System.Windows.Forms.Label();
            this.btSearchUser = new System.Windows.Forms.Button();
            this.UserId = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dtBuy = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtInsertTotal = new System.Windows.Forms.TextBox();
            this.txtInsertAmount = new System.Windows.Forms.TextBox();
            this.txtInsertSupplier = new System.Windows.Forms.TextBox();
            this.txtInsertUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 452);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(795, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Compras";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btCleanInsert);
            this.tabPage2.Controls.Add(this.btInsertBuy);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dtDateIn);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.btSearchSupplier);
            this.tabPage2.Controls.Add(this.SupplierId);
            this.tabPage2.Controls.Add(this.btSearchUser);
            this.tabPage2.Controls.Add(this.UserId);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dtBuy);
            this.tabPage2.Controls.Add(this.txtInsertTotal);
            this.tabPage2.Controls.Add(this.txtInsertAmount);
            this.tabPage2.Controls.Add(this.txtInsertSupplier);
            this.tabPage2.Controls.Add(this.txtInsertUser);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(795, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Insertar Compra";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btCleanInsert
            // 
            this.btCleanInsert.Location = new System.Drawing.Point(198, 332);
            this.btCleanInsert.Name = "btCleanInsert";
            this.btCleanInsert.Size = new System.Drawing.Size(75, 23);
            this.btCleanInsert.TabIndex = 19;
            this.btCleanInsert.Text = "Limpiar";
            this.btCleanInsert.UseVisualStyleBackColor = true;
            // 
            // btInsertBuy
            // 
            this.btInsertBuy.Location = new System.Drawing.Point(65, 332);
            this.btInsertBuy.Name = "btInsertBuy";
            this.btInsertBuy.Size = new System.Drawing.Size(75, 23);
            this.btInsertBuy.TabIndex = 18;
            this.btInsertBuy.Text = "Insertar";
            this.btInsertBuy.UseVisualStyleBackColor = true;
            this.btInsertBuy.Click += new System.EventHandler(this.btInsertBuy_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(470, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Seleccionar productos";
            // 
            // dtDateIn
            // 
            this.dtDateIn.Location = new System.Drawing.Point(91, 259);
            this.dtDateIn.Name = "dtDateIn";
            this.dtDateIn.Size = new System.Drawing.Size(200, 20);
            this.dtDateIn.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Fecha";
            // 
            // btSearchSupplier
            // 
            this.btSearchSupplier.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btSearchSupplier.FlatAppearance.BorderSize = 0;
            this.btSearchSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearchSupplier.Image = global::EaSystem.Properties.Resources.lupaIcono;
            this.btSearchSupplier.Location = new System.Drawing.Point(211, 93);
            this.btSearchSupplier.Name = "btSearchSupplier";
            this.btSearchSupplier.Size = new System.Drawing.Size(30, 23);
            this.btSearchSupplier.TabIndex = 14;
            this.btSearchSupplier.UseVisualStyleBackColor = true;
            this.btSearchSupplier.Click += new System.EventHandler(this.btSearchSupplier_Click);
            // 
            // SupplierId
            // 
            this.SupplierId.AutoSize = true;
            this.SupplierId.Location = new System.Drawing.Point(247, 100);
            this.SupplierId.Name = "SupplierId";
            this.SupplierId.Size = new System.Drawing.Size(35, 13);
            this.SupplierId.TabIndex = 13;
            this.SupplierId.Text = "label6";
            this.SupplierId.Visible = false;
            // 
            // btSearchUser
            // 
            this.btSearchUser.BackColor = System.Drawing.Color.Transparent;
            this.btSearchUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btSearchUser.FlatAppearance.BorderSize = 0;
            this.btSearchUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearchUser.Image = global::EaSystem.Properties.Resources.lupaIcono;
            this.btSearchUser.Location = new System.Drawing.Point(211, 40);
            this.btSearchUser.Name = "btSearchUser";
            this.btSearchUser.Size = new System.Drawing.Size(30, 23);
            this.btSearchUser.TabIndex = 12;
            this.btSearchUser.UseVisualStyleBackColor = false;
            this.btSearchUser.Click += new System.EventHandler(this.btSearchUser_Click);
            // 
            // UserId
            // 
            this.UserId.AutoSize = true;
            this.UserId.Location = new System.Drawing.Point(247, 45);
            this.UserId.Name = "UserId";
            this.UserId.Size = new System.Drawing.Size(35, 13);
            this.UserId.TabIndex = 11;
            this.UserId.Text = "label5";
            this.UserId.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(690, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(690, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Añadir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtBuy
            // 
            this.dtBuy.AllowUserToOrderColumns = true;
            this.dtBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtBuy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProductName});
            this.dtBuy.Location = new System.Drawing.Point(363, 79);
            this.dtBuy.Name = "dtBuy";
            this.dtBuy.Size = new System.Drawing.Size(321, 255);
            this.dtBuy.TabIndex = 8;
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "Código Producto";
            this.ProductId.Name = "ProductId";
            this.ProductId.Width = 150;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Producto";
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 130;
            // 
            // txtInsertTotal
            // 
            this.txtInsertTotal.Location = new System.Drawing.Point(91, 207);
            this.txtInsertTotal.Name = "txtInsertTotal";
            this.txtInsertTotal.Size = new System.Drawing.Size(100, 20);
            this.txtInsertTotal.TabIndex = 7;
            // 
            // txtInsertAmount
            // 
            this.txtInsertAmount.Location = new System.Drawing.Point(91, 150);
            this.txtInsertAmount.Name = "txtInsertAmount";
            this.txtInsertAmount.Size = new System.Drawing.Size(100, 20);
            this.txtInsertAmount.TabIndex = 6;
            // 
            // txtInsertSupplier
            // 
            this.txtInsertSupplier.Location = new System.Drawing.Point(91, 96);
            this.txtInsertSupplier.Name = "txtInsertSupplier";
            this.txtInsertSupplier.Size = new System.Drawing.Size(100, 20);
            this.txtInsertSupplier.TabIndex = 5;
            // 
            // txtInsertUser
            // 
            this.txtInsertUser.Location = new System.Drawing.Point(91, 42);
            this.txtInsertUser.Name = "txtInsertUser";
            this.txtInsertUser.Size = new System.Drawing.Size(100, 20);
            this.txtInsertUser.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Importe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Proveedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(DataAccess.Entities.Product);
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataSource = typeof(DataAccess.Entities.Product);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(DataAccess.Entities.Category);
            // 
            // Buys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Buys";
            this.Text = "Buys";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtBuy;
        private System.Windows.Forms.TextBox txtInsertTotal;
        private System.Windows.Forms.TextBox txtInsertAmount;
        private System.Windows.Forms.TextBox txtInsertSupplier;
        private System.Windows.Forms.TextBox txtInsertUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DateTimePicker dtDateIn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btSearchSupplier;
        private System.Windows.Forms.Label SupplierId;
        private System.Windows.Forms.Button btSearchUser;
        private System.Windows.Forms.Label UserId;
        private System.Windows.Forms.Button btCleanInsert;
        private System.Windows.Forms.Button btInsertBuy;
        private System.Windows.Forms.Label label5;
    }
}