namespace EaSystem
{
    partial class Subcategories
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
            this.Subcategorías = new System.Windows.Forms.TabPage();
            this.comboSubcategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSubcatgorySearch = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dtgridSubcatgory = new System.Windows.Forms.DataGridView();
            this.subcategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSubcategoryDescripcion = new System.Windows.Forms.TextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.txtSubcategoryName = new System.Windows.Forms.TextBox();
            this.lbSubcategory = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboInsert = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btCleanSubcatgory = new System.Windows.Forms.Button();
            this.btInsertSubcategory = new System.Windows.Forms.Button();
            this.txtInsertarSubDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInsertarSubcategoria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorInsertSubcategory = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorInsertCatSubcategory = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSubcategoryName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSubcategoryCategory = new System.Windows.Forms.ErrorProvider(this.components);
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.SubcategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubcategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubcategoryDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.Subcategorías.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridSubcatgory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subcategoryBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorInsertSubcategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorInsertCatSubcategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSubcategoryName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSubcategoryCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Subcategorías);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // Subcategorías
            // 
            this.Subcategorías.Controls.Add(this.comboSubcategory);
            this.Subcategorías.Controls.Add(this.label1);
            this.Subcategorías.Controls.Add(this.lbId);
            this.Subcategorías.Controls.Add(this.button3);
            this.Subcategorías.Controls.Add(this.button2);
            this.Subcategorías.Controls.Add(this.button1);
            this.Subcategorías.Controls.Add(this.txtSubcatgorySearch);
            this.Subcategorías.Controls.Add(this.label17);
            this.Subcategorías.Controls.Add(this.dtgridSubcatgory);
            this.Subcategorías.Controls.Add(this.txtSubcategoryDescripcion);
            this.Subcategorías.Controls.Add(this.lbDescription);
            this.Subcategorías.Controls.Add(this.txtSubcategoryName);
            this.Subcategorías.Controls.Add(this.lbSubcategory);
            this.Subcategorías.Location = new System.Drawing.Point(4, 22);
            this.Subcategorías.Name = "Subcategorías";
            this.Subcategorías.Padding = new System.Windows.Forms.Padding(3);
            this.Subcategorías.Size = new System.Drawing.Size(795, 425);
            this.Subcategorías.TabIndex = 0;
            this.Subcategorías.Text = "Subcategorias";
            this.Subcategorías.UseVisualStyleBackColor = true;
            // 
            // comboSubcategory
            // 
            this.comboSubcategory.FormattingEnabled = true;
            this.comboSubcategory.Location = new System.Drawing.Point(194, 138);
            this.comboSubcategory.Name = "comboSubcategory";
            this.comboSubcategory.Size = new System.Drawing.Size(263, 21);
            this.comboSubcategory.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 90;
            this.label1.Text = "Categoria";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(606, 25);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(35, 13);
            this.lbId.TabIndex = 89;
            this.lbId.Text = "label3";
            this.lbId.Visible = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(349, 379);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 88;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(467, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 87;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(224, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 86;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSubcatgorySearch
            // 
            this.txtSubcatgorySearch.Location = new System.Drawing.Point(164, 193);
            this.txtSubcatgorySearch.Name = "txtSubcatgorySearch";
            this.txtSubcatgorySearch.Size = new System.Drawing.Size(200, 20);
            this.txtSubcatgorySearch.TabIndex = 85;
            this.txtSubcatgorySearch.TextChanged += new System.EventHandler(this.SearchSucategory);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(76, 196);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 13);
            this.label17.TabIndex = 84;
            this.label17.Text = "Buscador";
            // 
            // dtgridSubcatgory
            // 
            this.dtgridSubcatgory.AllowUserToAddRows = false;
            this.dtgridSubcatgory.AutoGenerateColumns = false;
            this.dtgridSubcatgory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridSubcatgory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubcategoryId,
            this.SubcategoryName,
            this.SubcategoryDescription,
            this.Category});
            this.dtgridSubcatgory.DataSource = this.subcategoryBindingSource;
            this.dtgridSubcatgory.Location = new System.Drawing.Point(79, 243);
            this.dtgridSubcatgory.Name = "dtgridSubcatgory";
            this.dtgridSubcatgory.ReadOnly = true;
            this.dtgridSubcatgory.Size = new System.Drawing.Size(644, 121);
            this.dtgridSubcatgory.TabIndex = 83;         
            this.dtgridSubcatgory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SubcategoryClick);
            // 
            // subcategoryBindingSource
            // 
            this.subcategoryBindingSource.DataSource = typeof(DataAccess.Entities.Subcategory);
            // 
            // txtSubcategoryDescripcion
            // 
            this.txtSubcategoryDescripcion.Location = new System.Drawing.Point(194, 71);
            this.txtSubcategoryDescripcion.Multiline = true;
            this.txtSubcategoryDescripcion.Name = "txtSubcategoryDescripcion";
            this.txtSubcategoryDescripcion.Size = new System.Drawing.Size(263, 46);
            this.txtSubcategoryDescripcion.TabIndex = 82;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.Location = new System.Drawing.Point(71, 74);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(74, 13);
            this.lbDescription.TabIndex = 81;
            this.lbDescription.Text = "Descripción";
            // 
            // txtSubcategoryName
            // 
            this.txtSubcategoryName.Location = new System.Drawing.Point(194, 23);
            this.txtSubcategoryName.Name = "txtSubcategoryName";
            this.txtSubcategoryName.Size = new System.Drawing.Size(263, 20);
            this.txtSubcategoryName.TabIndex = 80;
            // 
            // lbSubcategory
            // 
            this.lbSubcategory.AutoSize = true;
            this.lbSubcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubcategory.Location = new System.Drawing.Point(71, 26);
            this.lbSubcategory.Name = "lbSubcategory";
            this.lbSubcategory.Size = new System.Drawing.Size(77, 13);
            this.lbSubcategory.TabIndex = 79;
            this.lbSubcategory.Text = "Subategoría";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboInsert);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btCleanSubcatgory);
            this.tabPage2.Controls.Add(this.btInsertSubcategory);
            this.tabPage2.Controls.Add(this.txtInsertarSubDescripcion);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtInsertarSubcategoria);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(795, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Insertar Subcategoria";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboInsert
            // 
            this.comboInsert.FormattingEnabled = true;
            this.comboInsert.Location = new System.Drawing.Point(319, 202);
            this.comboInsert.Name = "comboInsert";
            this.comboInsert.Size = new System.Drawing.Size(263, 21);
            this.comboInsert.TabIndex = 93;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(199, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 92;
            this.label4.Text = "Categoria";
            // 
            // btCleanSubcatgory
            // 
            this.btCleanSubcatgory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCleanSubcatgory.Location = new System.Drawing.Point(427, 310);
            this.btCleanSubcatgory.Name = "btCleanSubcatgory";
            this.btCleanSubcatgory.Size = new System.Drawing.Size(75, 23);
            this.btCleanSubcatgory.TabIndex = 83;
            this.btCleanSubcatgory.Text = "Limpiar";
            this.btCleanSubcatgory.UseVisualStyleBackColor = true;
            this.btCleanSubcatgory.Click += new System.EventHandler(this.btCleanSubcatgory_Click);
            // 
            // btInsertSubcategory
            // 
            this.btInsertSubcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsertSubcategory.Location = new System.Drawing.Point(299, 310);
            this.btInsertSubcategory.Name = "btInsertSubcategory";
            this.btInsertSubcategory.Size = new System.Drawing.Size(75, 23);
            this.btInsertSubcategory.TabIndex = 82;
            this.btInsertSubcategory.Text = "Insertar";
            this.btInsertSubcategory.UseVisualStyleBackColor = true;
            this.btInsertSubcategory.Click += new System.EventHandler(this.btInsertSubcategory_Click);
            // 
            // txtInsertarSubDescripcion
            // 
            this.txtInsertarSubDescripcion.Location = new System.Drawing.Point(319, 114);
            this.txtInsertarSubDescripcion.Multiline = true;
            this.txtInsertarSubDescripcion.Name = "txtInsertarSubDescripcion";
            this.txtInsertarSubDescripcion.Size = new System.Drawing.Size(263, 54);
            this.txtInsertarSubDescripcion.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "Descripción";
            // 
            // txtInsertarSubcategoria
            // 
            this.txtInsertarSubcategoria.Location = new System.Drawing.Point(319, 57);
            this.txtInsertarSubcategoria.Name = "txtInsertarSubcategoria";
            this.txtInsertarSubcategoria.Size = new System.Drawing.Size(263, 20);
            this.txtInsertarSubcategoria.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 78;
            this.label3.Text = "Subcategoría";
            // 
            // errorInsertSubcategory
            // 
            this.errorInsertSubcategory.ContainerControl = this;
            // 
            // errorInsertCatSubcategory
            // 
            this.errorInsertCatSubcategory.ContainerControl = this;
            // 
            // errorSubcategoryName
            // 
            this.errorSubcategoryName.ContainerControl = this;
            // 
            // errorSubcategoryCategory
            // 
            this.errorSubcategoryCategory.ContainerControl = this;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(DataAccess.Entities.Category);
            // 
            // categoryBindingSource1
            // 
            this.categoryBindingSource1.DataSource = typeof(DataAccess.Entities.Category);
            // 
            // SubcategoryId
            // 
            this.SubcategoryId.DataPropertyName = "SubcategoryId";
            this.SubcategoryId.HeaderText = "SubcategoryId";
            this.SubcategoryId.Name = "SubcategoryId";
            this.SubcategoryId.ReadOnly = true;
            this.SubcategoryId.Visible = false;
            this.SubcategoryId.Width = 180;
            // 
            // SubcategoryName
            // 
            this.SubcategoryName.DataPropertyName = "SubcategoryName";
            this.SubcategoryName.HeaderText = "Subcategoria";
            this.SubcategoryName.Name = "SubcategoryName";
            this.SubcategoryName.ReadOnly = true;
            this.SubcategoryName.Width = 180;
            // 
            // SubcategoryDescription
            // 
            this.SubcategoryDescription.DataPropertyName = "SubcategoryDescription";
            this.SubcategoryDescription.HeaderText = "Descripcion";
            this.SubcategoryDescription.Name = "SubcategoryDescription";
            this.SubcategoryDescription.ReadOnly = true;
            this.SubcategoryDescription.Width = 200;
            // 
            // Category
            // 
            this.Category.HeaderText = "Categoría";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Subcategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Subcategories";
            this.Text = "Subcategories";
            this.Load += new System.EventHandler(this.Subcategories_Load);
            this.tabControl1.ResumeLayout(false);
            this.Subcategorías.ResumeLayout(false);
            this.Subcategorías.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridSubcatgory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subcategoryBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorInsertSubcategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorInsertCatSubcategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSubcategoryName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSubcategoryCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Subcategorías;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSubcatgorySearch;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dtgridSubcatgory;
        private System.Windows.Forms.TextBox txtSubcategoryDescripcion;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.TextBox txtSubcategoryName;
        private System.Windows.Forms.Label lbSubcategory;
        private System.Windows.Forms.ComboBox comboSubcategory;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboInsert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btCleanSubcatgory;
        private System.Windows.Forms.Button btInsertSubcategory;
        private System.Windows.Forms.TextBox txtInsertarSubDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInsertarSubcategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorInsertSubcategory;
        private System.Windows.Forms.ErrorProvider errorInsertCatSubcategory;
        private System.Windows.Forms.ErrorProvider errorSubcategoryName;
        private System.Windows.Forms.ErrorProvider errorSubcategoryCategory;
        private System.Windows.Forms.BindingSource subcategoryBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubcategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubcategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubcategoryDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
    }
}