namespace EaSystem
{
    partial class ViewSupplier
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductSearch = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 105;
            this.label1.Text = "label1";
            // 
            // txtProductSearch
            // 
            this.txtProductSearch.Location = new System.Drawing.Point(102, 71);
            this.txtProductSearch.Name = "txtProductSearch";
            this.txtProductSearch.Size = new System.Drawing.Size(156, 20);
            this.txtProductSearch.TabIndex = 104;
            this.txtProductSearch.TextChanged += new System.EventHandler(this.SearchSupplier);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(14, 74);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 13);
            this.label17.TabIndex = 103;
            this.label17.Text = "Buscador";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplierId,
            this.SupplierName});
            this.dataGridView1.DataSource = this.supplierBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(244, 233);
            this.dataGridView1.TabIndex = 102;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AddSuppliersToList);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(DataAccess.Entities.Supplier);
            // 
            // SupplierId
            // 
            this.SupplierId.DataPropertyName = "SupplierId";
            this.SupplierId.HeaderText = "Código Proveedor";
            this.SupplierId.Name = "SupplierId";
            // 
            // SupplierName
            // 
            this.SupplierName.DataPropertyName = "SupplierName";
            this.SupplierName.HeaderText = "Proveedor";
            this.SupplierName.Name = "SupplierName";
            // 
            // ViewSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 367);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProductSearch);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewSupplier";
            this.Text = "ViewSupplier";
            this.Load += new System.EventHandler(this.ViewSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductSearch;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.BindingSource supplierBindingSource;
    }
}