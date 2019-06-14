namespace EaSystem
{
    partial class AllCashiers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllCashiers));
            this.txtSearchCashier = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtBuyTickets = new System.Windows.Forms.DataGridView();
            this.cashierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CashierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtBuyTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchCashier
            // 
            this.txtSearchCashier.Location = new System.Drawing.Point(159, 92);
            this.txtSearchCashier.Name = "txtSearchCashier";
            this.txtSearchCashier.Size = new System.Drawing.Size(164, 20);
            this.txtSearchCashier.TabIndex = 11;
            this.txtSearchCashier.TextChanged += new System.EventHandler(this.SearchCashier);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(93, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Buscador";
            // 
            // dtBuyTickets
            // 
            this.dtBuyTickets.AutoGenerateColumns = false;
            this.dtBuyTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtBuyTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CashierId,
            this.openDateTimeDataGridViewTextBoxColumn,
            this.closeDateTimeDataGridViewTextBoxColumn,
            this.closeDataGridViewCheckBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.dtBuyTickets.DataSource = this.cashierBindingSource;
            this.dtBuyTickets.Location = new System.Drawing.Point(96, 149);
            this.dtBuyTickets.Name = "dtBuyTickets";
            this.dtBuyTickets.Size = new System.Drawing.Size(612, 245);
            this.dtBuyTickets.TabIndex = 8;
            // 
            // cashierBindingSource
            // 
            this.cashierBindingSource.DataSource = typeof(DataAccess.Entities.Cashier);
            // 
            // CashierId
            // 
            this.CashierId.DataPropertyName = "CashierId";
            this.CashierId.HeaderText = "Codigo caja";
            this.CashierId.Name = "CashierId";
            this.CashierId.Width = 115;
            // 
            // openDateTimeDataGridViewTextBoxColumn
            // 
            this.openDateTimeDataGridViewTextBoxColumn.DataPropertyName = "OpenDateTime";
            this.openDateTimeDataGridViewTextBoxColumn.HeaderText = "Fecha apertura";
            this.openDateTimeDataGridViewTextBoxColumn.Name = "openDateTimeDataGridViewTextBoxColumn";
            this.openDateTimeDataGridViewTextBoxColumn.Width = 120;
            // 
            // closeDateTimeDataGridViewTextBoxColumn
            // 
            this.closeDateTimeDataGridViewTextBoxColumn.DataPropertyName = "CloseDateTime";
            this.closeDateTimeDataGridViewTextBoxColumn.HeaderText = "Fecha cierre";
            this.closeDateTimeDataGridViewTextBoxColumn.Name = "closeDateTimeDataGridViewTextBoxColumn";
            this.closeDateTimeDataGridViewTextBoxColumn.Width = 120;
            // 
            // closeDataGridViewCheckBoxColumn
            // 
            this.closeDataGridViewCheckBoxColumn.DataPropertyName = "Close";
            this.closeDataGridViewCheckBoxColumn.HeaderText = "Cerrada";
            this.closeDataGridViewCheckBoxColumn.Name = "closeDataGridViewCheckBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Total caja";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Histórico de cajas";
            // 
            // AllCashiers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchCashier);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtBuyTickets);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AllCashiers";
            this.Text = "Histórico de cajas";
            this.Load += new System.EventHandler(this.AllCashiers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtBuyTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchCashier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtBuyTickets;
        private System.Windows.Forms.BindingSource cashierBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn CashierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn openDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closeDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn closeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}