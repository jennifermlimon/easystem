namespace EaSystem
{
    partial class Category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Category));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbId = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dtgridCatgory = new System.Windows.Forms.DataGridView();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.lbCategory = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btClean = new System.Windows.Forms.Button();
            this.btInsert = new System.Windows.Forms.Button();
            this.txtInsertarDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInsertarCategoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorCategory = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCategoryUpdate = new System.Windows.Forms.ErrorProvider(this.components);
            this.CategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridCatgory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCategoryUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbId);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.txtSearch);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.dtgridCatgory);
            this.tabPage1.Controls.Add(this.txtDescripcion);
            this.tabPage1.Controls.Add(this.lbDescription);
            this.tabPage1.Controls.Add(this.txtCategoryName);
            this.tabPage1.Controls.Add(this.lbCategory);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Categoría";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(603, 33);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(35, 13);
            this.lbId.TabIndex = 78;
            this.lbId.Text = "label3";
            this.lbId.Visible = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(346, 387);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 77;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(464, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 76;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(221, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 75;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(161, 201);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 20);
            this.txtSearch.TabIndex = 74;
            this.txtSearch.TextChanged += new System.EventHandler(this.SearchCategory);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(73, 204);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 13);
            this.label17.TabIndex = 73;
            this.label17.Text = "Buscador";
            // 
            // dtgridCatgory
            // 
            this.dtgridCatgory.AllowUserToAddRows = false;
            this.dtgridCatgory.AutoGenerateColumns = false;
            this.dtgridCatgory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridCatgory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryId,
            this.CategoryName,
            this.CategoryDescription});
            this.dtgridCatgory.DataSource = this.categoryBindingSource;
            this.dtgridCatgory.Location = new System.Drawing.Point(76, 242);
            this.dtgridCatgory.Name = "dtgridCatgory";
            this.dtgridCatgory.ReadOnly = true;
            this.dtgridCatgory.Size = new System.Drawing.Size(644, 121);
            this.dtgridCatgory.TabIndex = 72;
            this.dtgridCatgory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditCategory);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(DataAccess.Entities.Category);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(191, 79);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(263, 78);
            this.txtDescripcion.TabIndex = 71;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.Location = new System.Drawing.Point(68, 82);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(74, 13);
            this.lbDescription.TabIndex = 70;
            this.lbDescription.Text = "Descripción";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(191, 31);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(141, 20);
            this.txtCategoryName.TabIndex = 69;
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.Location = new System.Drawing.Point(68, 34);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(63, 13);
            this.lbCategory.TabIndex = 68;
            this.lbCategory.Text = "Categoría";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btClean);
            this.tabPage2.Controls.Add(this.btInsert);
            this.tabPage2.Controls.Add(this.txtInsertarDescripcion);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtInsertarCategoria);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Insertar categoría";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btClean
            // 
            this.btClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClean.Location = new System.Drawing.Point(410, 296);
            this.btClean.Name = "btClean";
            this.btClean.Size = new System.Drawing.Size(75, 23);
            this.btClean.TabIndex = 77;
            this.btClean.Text = "Limpiar";
            this.btClean.UseVisualStyleBackColor = true;
            this.btClean.Click += new System.EventHandler(this.btClean_Click);
            // 
            // btInsert
            // 
            this.btInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsert.Location = new System.Drawing.Point(282, 296);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(75, 23);
            this.btInsert.TabIndex = 76;
            this.btInsert.Text = "Insertar";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // txtInsertarDescripcion
            // 
            this.txtInsertarDescripcion.Location = new System.Drawing.Point(310, 135);
            this.txtInsertarDescripcion.Multiline = true;
            this.txtInsertarDescripcion.Name = "txtInsertarDescripcion";
            this.txtInsertarDescripcion.Size = new System.Drawing.Size(263, 78);
            this.txtInsertarDescripcion.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "Descripción";
            // 
            // txtInsertarCategoria
            // 
            this.txtInsertarCategoria.Location = new System.Drawing.Point(310, 78);
            this.txtInsertarCategoria.Name = "txtInsertarCategoria";
            this.txtInsertarCategoria.Size = new System.Drawing.Size(141, 20);
            this.txtInsertarCategoria.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "Categoría";
            // 
            // errorCategory
            // 
            this.errorCategory.ContainerControl = this;
            // 
            // errorCategoryUpdate
            // 
            this.errorCategoryUpdate.ContainerControl = this;
            // 
            // CategoryId
            // 
            this.CategoryId.DataPropertyName = "CategoryId";
            this.CategoryId.HeaderText = "CategoryId";
            this.CategoryId.Name = "CategoryId";
            this.CategoryId.ReadOnly = true;
            this.CategoryId.Visible = false;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.FillWeight = 200F;
            this.CategoryName.HeaderText = "Categoría";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            this.CategoryName.Width = 200;
            // 
            // CategoryDescription
            // 
            this.CategoryDescription.DataPropertyName = "CategoryDescription";
            this.CategoryDescription.FillWeight = 400F;
            this.CategoryDescription.HeaderText = "Descripción";
            this.CategoryDescription.Name = "CategoryDescription";
            this.CategoryDescription.ReadOnly = true;
            this.CategoryDescription.Width = 400;
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Category";
            this.Text = "Categorías";
            this.Load += new System.EventHandler(this.Category_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridCatgory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCategoryUpdate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dtgridCatgory;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtInsertarDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInsertarCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btClean;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.ErrorProvider errorCategory;
        private System.Windows.Forms.ErrorProvider errorCategoryUpdate;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryDescription;
    }
}