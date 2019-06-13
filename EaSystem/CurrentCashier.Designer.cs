namespace EaSystem
{
    partial class CurrentCashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentCashier));
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtToBank = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dtViewTickets = new System.Windows.Forms.DataGridView();
            this.sellTicketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbIdCashier = new System.Windows.Forms.Label();
            this.sellTicketIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellTicketDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashierIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtViewTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellTicketBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Euros";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(165, 49);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 1;
            // 
            // txtToBank
            // 
            this.txtToBank.Location = new System.Drawing.Point(498, 46);
            this.txtToBank.Name = "txtToBank";
            this.txtToBank.Size = new System.Drawing.Size(100, 20);
            this.txtToBank.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(384, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingreso Banco";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha apertura";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(165, 132);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(575, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cerrar Caja";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtViewTickets
            // 
            this.dtViewTickets.AutoGenerateColumns = false;
            this.dtViewTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtViewTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sellTicketIdDataGridViewTextBoxColumn,
            this.sellTicketDateDataGridViewTextBoxColumn,
            this.Price,
            this.cashierIdDataGridViewTextBoxColumn});
            this.dtViewTickets.DataSource = this.sellTicketBindingSource;
            this.dtViewTickets.Location = new System.Drawing.Point(165, 207);
            this.dtViewTickets.Name = "dtViewTickets";
            this.dtViewTickets.Size = new System.Drawing.Size(501, 150);
            this.dtViewTickets.TabIndex = 7;
            // 
            // sellTicketBindingSource
            // 
            this.sellTicketBindingSource.DataSource = typeof(DataAccess.Entities.SellTicket);
            // 
            // lbIdCashier
            // 
            this.lbIdCashier.AutoSize = true;
            this.lbIdCashier.Location = new System.Drawing.Point(695, 48);
            this.lbIdCashier.Name = "lbIdCashier";
            this.lbIdCashier.Size = new System.Drawing.Size(35, 13);
            this.lbIdCashier.TabIndex = 8;
            this.lbIdCashier.Text = "label4";
            this.lbIdCashier.Visible = false;
            // 
            // sellTicketIdDataGridViewTextBoxColumn
            // 
            this.sellTicketIdDataGridViewTextBoxColumn.DataPropertyName = "SellTicketId";
            this.sellTicketIdDataGridViewTextBoxColumn.HeaderText = "Código Venta";
            this.sellTicketIdDataGridViewTextBoxColumn.Name = "sellTicketIdDataGridViewTextBoxColumn";
            this.sellTicketIdDataGridViewTextBoxColumn.Width = 120;
            // 
            // sellTicketDateDataGridViewTextBoxColumn
            // 
            this.sellTicketDateDataGridViewTextBoxColumn.DataPropertyName = "SellTicketDate";
            this.sellTicketDateDataGridViewTextBoxColumn.HeaderText = "Fecha Venta";
            this.sellTicketDateDataGridViewTextBoxColumn.Name = "sellTicketDateDataGridViewTextBoxColumn";
            this.sellTicketDateDataGridViewTextBoxColumn.Width = 120;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Total";
            this.Price.Name = "Price";
            // 
            // cashierIdDataGridViewTextBoxColumn
            // 
            this.cashierIdDataGridViewTextBoxColumn.DataPropertyName = "CashierId";
            this.cashierIdDataGridViewTextBoxColumn.HeaderText = "Código caja";
            this.cashierIdDataGridViewTextBoxColumn.Name = "cashierIdDataGridViewTextBoxColumn";
            this.cashierIdDataGridViewTextBoxColumn.Width = 120;
            // 
            // CurrentCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbIdCashier);
            this.Controls.Add(this.dtViewTickets);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtToBank);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CurrentCashier";
            this.Text = "Caja Actual";
            this.Load += new System.EventHandler(this.CurrentCashier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtViewTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellTicketBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtToBank;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtViewTickets;
        private System.Windows.Forms.BindingSource sellTicketBindingSource;
        private System.Windows.Forms.Label lbIdCashier;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellTicketIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellTicketDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashierIdDataGridViewTextBoxColumn;
    }
}