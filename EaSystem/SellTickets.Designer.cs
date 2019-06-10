namespace EaSystem
{
    partial class SellTickets
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btCleanInsert = new System.Windows.Forms.Button();
            this.btInsertBuy = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtDateIn = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btSearchSupplier = new System.Windows.Forms.Button();
            this.ClientId = new System.Windows.Forms.Label();
            this.btSearchUser = new System.Windows.Forms.Button();
            this.UserId = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dtBuy = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtInsertTotal = new System.Windows.Forms.TextBox();
            this.txtInsertAmount = new System.Windows.Forms.TextBox();
            this.txtInsertClient = new System.Windows.Forms.TextBox();
            this.txtInsertUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchBuy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dtBuyTickets = new System.Windows.Forms.DataGridView();
            this.BuyTicketId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBuyTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtSearchBuy);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.dtBuyTickets);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ventas";
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
            this.tabPage2.Controls.Add(this.ClientId);
            this.tabPage2.Controls.Add(this.btSearchUser);
            this.tabPage2.Controls.Add(this.UserId);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dtBuy);
            this.tabPage2.Controls.Add(this.txtInsertTotal);
            this.tabPage2.Controls.Add(this.txtInsertAmount);
            this.tabPage2.Controls.Add(this.txtInsertClient);
            this.tabPage2.Controls.Add(this.txtInsertUser);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Insertar Venta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btCleanInsert
            // 
            this.btCleanInsert.Location = new System.Drawing.Point(201, 347);
            this.btCleanInsert.Name = "btCleanInsert";
            this.btCleanInsert.Size = new System.Drawing.Size(75, 23);
            this.btCleanInsert.TabIndex = 39;
            this.btCleanInsert.Text = "Limpiar";
            this.btCleanInsert.UseVisualStyleBackColor = true;
            this.btCleanInsert.Click += new System.EventHandler(this.btCleanInsert_Click);
            // 
            // btInsertBuy
            // 
            this.btInsertBuy.Location = new System.Drawing.Point(68, 347);
            this.btInsertBuy.Name = "btInsertBuy";
            this.btInsertBuy.Size = new System.Drawing.Size(75, 23);
            this.btInsertBuy.TabIndex = 38;
            this.btInsertBuy.Text = "Insertar";
            this.btInsertBuy.UseVisualStyleBackColor = true;
            this.btInsertBuy.Click += new System.EventHandler(this.btInsertBuy_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(423, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Seleccionar productos";
            // 
            // dtDateIn
            // 
            this.dtDateIn.Location = new System.Drawing.Point(94, 274);
            this.dtDateIn.Name = "dtDateIn";
            this.dtDateIn.Size = new System.Drawing.Size(200, 20);
            this.dtDateIn.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Fecha";
            // 
            // btSearchSupplier
            // 
            this.btSearchSupplier.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btSearchSupplier.FlatAppearance.BorderSize = 0;
            this.btSearchSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearchSupplier.Image = global::EaSystem.Properties.Resources.lupaIcono;
            this.btSearchSupplier.Location = new System.Drawing.Point(214, 108);
            this.btSearchSupplier.Name = "btSearchSupplier";
            this.btSearchSupplier.Size = new System.Drawing.Size(30, 23);
            this.btSearchSupplier.TabIndex = 34;
            this.btSearchSupplier.UseVisualStyleBackColor = true;
            // 
            // ClientId
            // 
            this.ClientId.AutoSize = true;
            this.ClientId.Location = new System.Drawing.Point(250, 115);
            this.ClientId.Name = "ClientId";
            this.ClientId.Size = new System.Drawing.Size(35, 13);
            this.ClientId.TabIndex = 33;
            this.ClientId.Text = "label6";
            this.ClientId.Visible = false;
            // 
            // btSearchUser
            // 
            this.btSearchUser.BackColor = System.Drawing.Color.Transparent;
            this.btSearchUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btSearchUser.FlatAppearance.BorderSize = 0;
            this.btSearchUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearchUser.Image = global::EaSystem.Properties.Resources.lupaIcono;
            this.btSearchUser.Location = new System.Drawing.Point(214, 55);
            this.btSearchUser.Name = "btSearchUser";
            this.btSearchUser.Size = new System.Drawing.Size(30, 23);
            this.btSearchUser.TabIndex = 32;
            this.btSearchUser.UseVisualStyleBackColor = false;
            // 
            // UserId
            // 
            this.UserId.AutoSize = true;
            this.UserId.Location = new System.Drawing.Point(250, 60);
            this.UserId.Name = "UserId";
            this.UserId.Size = new System.Drawing.Size(35, 13);
            this.UserId.TabIndex = 31;
            this.UserId.Text = "label5";
            this.UserId.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(693, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(693, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
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
            this.ProductPrice,
            this.ProductName});
            this.dtBuy.Location = new System.Drawing.Point(338, 94);
            this.dtBuy.Name = "dtBuy";
            this.dtBuy.Size = new System.Drawing.Size(325, 276);
            this.dtBuy.TabIndex = 28;
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "Código Producto";
            this.ProductId.Name = "ProductId";
            this.ProductId.Width = 150;
            // 
            // ProductPrice
            // 
            this.ProductPrice.HeaderText = "Precio";
            this.ProductPrice.Name = "ProductPrice";
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Producto";
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 130;
            // 
            // txtInsertTotal
            // 
            this.txtInsertTotal.Enabled = false;
            this.txtInsertTotal.Location = new System.Drawing.Point(94, 222);
            this.txtInsertTotal.Name = "txtInsertTotal";
            this.txtInsertTotal.Size = new System.Drawing.Size(100, 20);
            this.txtInsertTotal.TabIndex = 27;
            // 
            // txtInsertAmount
            // 
            this.txtInsertAmount.Enabled = false;
            this.txtInsertAmount.Location = new System.Drawing.Point(94, 165);
            this.txtInsertAmount.Name = "txtInsertAmount";
            this.txtInsertAmount.Size = new System.Drawing.Size(100, 20);
            this.txtInsertAmount.TabIndex = 26;
            this.txtInsertAmount.Text = "0";
            // 
            // txtInsertClient
            // 
            this.txtInsertClient.Location = new System.Drawing.Point(94, 111);
            this.txtInsertClient.Name = "txtInsertClient";
            this.txtInsertClient.Size = new System.Drawing.Size(100, 20);
            this.txtInsertClient.TabIndex = 25;
            // 
            // txtInsertUser
            // 
            this.txtInsertUser.Location = new System.Drawing.Point(94, 57);
            this.txtInsertUser.Name = "txtInsertUser";
            this.txtInsertUser.Size = new System.Drawing.Size(100, 20);
            this.txtInsertUser.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Importe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Usuario";
            // 
            // txtSearchBuy
            // 
            this.txtSearchBuy.Location = new System.Drawing.Point(146, 41);
            this.txtSearchBuy.Name = "txtSearchBuy";
            this.txtSearchBuy.Size = new System.Drawing.Size(136, 20);
            this.txtSearchBuy.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Buscador";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(91, 360);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Eliminar ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dtBuyTickets
            // 
            this.dtBuyTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtBuyTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BuyTicketId});
            this.dtBuyTickets.Location = new System.Drawing.Point(91, 87);
            this.dtBuyTickets.Name = "dtBuyTickets";
            this.dtBuyTickets.Size = new System.Drawing.Size(612, 245);
            this.dtBuyTickets.TabIndex = 4;
            // 
            // BuyTicketId
            // 
            this.BuyTicketId.DataPropertyName = "BuyTicketId";
            this.BuyTicketId.HeaderText = "Código Ticket";
            this.BuyTicketId.Name = "BuyTicketId";
            this.BuyTicketId.Width = 140;
            // 
            // SellTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "SellTickets";
            this.Text = "SellTickets";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBuyTickets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btCleanInsert;
        private System.Windows.Forms.Button btInsertBuy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtDateIn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btSearchSupplier;
        private System.Windows.Forms.Label ClientId;
        private System.Windows.Forms.Button btSearchUser;
        private System.Windows.Forms.Label UserId;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtBuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.TextBox txtInsertTotal;
        private System.Windows.Forms.TextBox txtInsertAmount;
        private System.Windows.Forms.TextBox txtInsertClient;
        private System.Windows.Forms.TextBox txtInsertUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchBuy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dtBuyTickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyTicketId;
    }
}