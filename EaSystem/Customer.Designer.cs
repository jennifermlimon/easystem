namespace EaSystem
{
    partial class Customer
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lbId = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dtgridCustomer = new System.Windows.Forms.DataGridView();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.dtBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtSurname2 = new System.Windows.Forms.TextBox();
            this.txtSurname1 = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtInsertAddress = new System.Windows.Forms.TextBox();
            this.txtInsertMail = new System.Windows.Forms.TextBox();
            this.txtInsertNif = new System.Windows.Forms.TextBox();
            this.txtInsertPhone = new System.Windows.Forms.TextBox();
            this.dtInsertBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtInsertSurname2 = new System.Windows.Forms.TextBox();
            this.txtInsertSurname1 = new System.Windows.Forms.TextBox();
            this.txtInsertName = new System.Windows.Forms.TextBox();
            this.btClean = new System.Windows.Forms.Button();
            this.btInsert = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.errorNif = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSurname = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorMail = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorNif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSurname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMail)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 471);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtSearch);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.lbId);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dtgridCustomer);
            this.tabPage1.Controls.Add(this.txtAddress);
            this.tabPage1.Controls.Add(this.txtMail);
            this.tabPage1.Controls.Add(this.txtNIF);
            this.tabPage1.Controls.Add(this.txtPhone);
            this.tabPage1.Controls.Add(this.dtBirthDate);
            this.tabPage1.Controls.Add(this.txtSurname2);
            this.tabPage1.Controls.Add(this.txtSurname1);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 445);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cliente";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(131, 236);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 20);
            this.txtSearch.TabIndex = 62;
            this.txtSearch.TextChanged += new System.EventHandler(this.SearchByType);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(43, 239);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 13);
            this.label17.TabIndex = 61;
            this.label17.Text = "Buscador";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(328, 406);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 60;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(43, 4);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(0, 13);
            this.lbId.TabIndex = 59;
            this.lbId.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(446, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 58;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(203, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 57;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dtgridCustomer
            // 
            this.dtgridCustomer.AllowUserToAddRows = false;
            this.dtgridCustomer.AutoGenerateColumns = false;
            this.dtgridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientName,
            this.Id,
            this.Surname2,
            this.Birthdate,
            this.Surname1,
            this.Phone,
            this.dni,
            this.Mail,
            this.Address});
            this.dtgridCustomer.DataSource = this.clientBindingSource;
            this.dtgridCustomer.Location = new System.Drawing.Point(46, 269);
            this.dtgridCustomer.Name = "dtgridCustomer";
            this.dtgridCustomer.ReadOnly = true;
            this.dtgridCustomer.Size = new System.Drawing.Size(644, 121);
            this.dtgridCustomer.TabIndex = 56;
            this.dtgridCustomer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditCustomer);
            // 
            // ClientName
            // 
            this.ClientName.DataPropertyName = "ClientName";
            this.ClientName.HeaderText = "Nombre";
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "ClientId";
            this.Id.HeaderText = "Column1";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Surname2
            // 
            this.Surname2.DataPropertyName = "ClientSurname2";
            this.Surname2.HeaderText = "ClientSurname2";
            this.Surname2.Name = "Surname2";
            this.Surname2.ReadOnly = true;
            this.Surname2.Visible = false;
            // 
            // Birthdate
            // 
            this.Birthdate.DataPropertyName = "ClientDateOfBirth";
            this.Birthdate.HeaderText = "ClientDateOfBirth";
            this.Birthdate.Name = "Birthdate";
            this.Birthdate.ReadOnly = true;
            this.Birthdate.Visible = false;
            // 
            // Surname1
            // 
            this.Surname1.DataPropertyName = "ClientSurname1";
            this.Surname1.HeaderText = "Apellido";
            this.Surname1.Name = "Surname1";
            this.Surname1.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "CLientTelephone";
            this.Phone.HeaderText = "Teléfono";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // dni
            // 
            this.dni.DataPropertyName = "ClientNif";
            this.dni.HeaderText = "NIF";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            // 
            // Mail
            // 
            this.Mail.DataPropertyName = "ClientEmail";
            this.Mail.HeaderText = "Email";
            this.Mail.Name = "Mail";
            this.Mail.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "ClientAdress";
            this.Address.HeaderText = "Dirección";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(DataAccess.Entities.Client);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(516, 166);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 20);
            this.txtAddress.TabIndex = 55;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(152, 166);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(200, 20);
            this.txtMail.TabIndex = 54;
            // 
            // txtNIF
            // 
            this.txtNIF.Location = new System.Drawing.Point(516, 114);
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(200, 20);
            this.txtNIF.TabIndex = 53;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(152, 114);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 20);
            this.txtPhone.TabIndex = 52;
            // 
            // dtBirthDate
            // 
            this.dtBirthDate.Location = new System.Drawing.Point(516, 64);
            this.dtBirthDate.Name = "dtBirthDate";
            this.dtBirthDate.Size = new System.Drawing.Size(200, 20);
            this.dtBirthDate.TabIndex = 51;
            // 
            // txtSurname2
            // 
            this.txtSurname2.Location = new System.Drawing.Point(152, 64);
            this.txtSurname2.Name = "txtSurname2";
            this.txtSurname2.Size = new System.Drawing.Size(200, 20);
            this.txtSurname2.TabIndex = 50;
            // 
            // txtSurname1
            // 
            this.txtSurname1.Location = new System.Drawing.Point(516, 17);
            this.txtSurname1.Name = "txtSurname1";
            this.txtSurname1.Size = new System.Drawing.Size(200, 20);
            this.txtSurname1.TabIndex = 49;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(152, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(379, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Dirección";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(379, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "NIF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(379, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Segundo Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(379, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Primer Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Nombre";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtInsertAddress);
            this.tabPage2.Controls.Add(this.txtInsertMail);
            this.tabPage2.Controls.Add(this.txtInsertNif);
            this.tabPage2.Controls.Add(this.txtInsertPhone);
            this.tabPage2.Controls.Add(this.dtInsertBirthDate);
            this.tabPage2.Controls.Add(this.txtInsertSurname2);
            this.tabPage2.Controls.Add(this.txtInsertSurname1);
            this.tabPage2.Controls.Add(this.txtInsertName);
            this.tabPage2.Controls.Add(this.btClean);
            this.tabPage2.Controls.Add(this.btInsert);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 445);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Insertar Cliente";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtInsertAddress
            // 
            this.txtInsertAddress.Location = new System.Drawing.Point(374, 326);
            this.txtInsertAddress.Name = "txtInsertAddress";
            this.txtInsertAddress.Size = new System.Drawing.Size(200, 20);
            this.txtInsertAddress.TabIndex = 35;
            // 
            // txtInsertMail
            // 
            this.txtInsertMail.Location = new System.Drawing.Point(374, 281);
            this.txtInsertMail.Name = "txtInsertMail";
            this.txtInsertMail.Size = new System.Drawing.Size(200, 20);
            this.txtInsertMail.TabIndex = 34;
            // 
            // txtInsertNif
            // 
            this.txtInsertNif.Location = new System.Drawing.Point(374, 241);
            this.txtInsertNif.Name = "txtInsertNif";
            this.txtInsertNif.Size = new System.Drawing.Size(200, 20);
            this.txtInsertNif.TabIndex = 33;
            // 
            // txtInsertPhone
            // 
            this.txtInsertPhone.Location = new System.Drawing.Point(374, 202);
            this.txtInsertPhone.Name = "txtInsertPhone";
            this.txtInsertPhone.Size = new System.Drawing.Size(200, 20);
            this.txtInsertPhone.TabIndex = 32;
            // 
            // dtInsertBirthDate
            // 
            this.dtInsertBirthDate.Location = new System.Drawing.Point(374, 158);
            this.dtInsertBirthDate.Name = "dtInsertBirthDate";
            this.dtInsertBirthDate.Size = new System.Drawing.Size(200, 20);
            this.dtInsertBirthDate.TabIndex = 31;
            // 
            // txtInsertSurname2
            // 
            this.txtInsertSurname2.Location = new System.Drawing.Point(374, 112);
            this.txtInsertSurname2.Name = "txtInsertSurname2";
            this.txtInsertSurname2.Size = new System.Drawing.Size(200, 20);
            this.txtInsertSurname2.TabIndex = 30;
            // 
            // txtInsertSurname1
            // 
            this.txtInsertSurname1.Location = new System.Drawing.Point(374, 68);
            this.txtInsertSurname1.Name = "txtInsertSurname1";
            this.txtInsertSurname1.Size = new System.Drawing.Size(200, 20);
            this.txtInsertSurname1.TabIndex = 29;
            // 
            // txtInsertName
            // 
            this.txtInsertName.Location = new System.Drawing.Point(374, 21);
            this.txtInsertName.Name = "txtInsertName";
            this.txtInsertName.Size = new System.Drawing.Size(200, 20);
            this.txtInsertName.TabIndex = 28;
            // 
            // btClean
            // 
            this.btClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClean.Location = new System.Drawing.Point(436, 398);
            this.btClean.Name = "btClean";
            this.btClean.Size = new System.Drawing.Size(75, 23);
            this.btClean.TabIndex = 27;
            this.btClean.Text = "Limpiar";
            this.btClean.UseVisualStyleBackColor = true;
            this.btClean.Click += new System.EventHandler(this.btClean_Click);
            // 
            // btInsert
            // 
            this.btInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsert.Location = new System.Drawing.Point(308, 398);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(75, 23);
            this.btInsert.TabIndex = 26;
            this.btInsert.Text = "Insertar";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(234, 329);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Dirección";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(237, 284);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(237, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "NIF";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(237, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Teléfono";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(237, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Fecha de Nacimiento";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(237, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Segundo Apellido";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(237, 71);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "Primer Apellido";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(237, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "Nombre";
            // 
            // errorNif
            // 
            this.errorNif.ContainerControl = this;
            // 
            // errorName
            // 
            this.errorName.ContainerControl = this;
            // 
            // errorSurname
            // 
            this.errorSurname.ContainerControl = this;
            // 
            // errorPhone
            // 
            this.errorPhone.ContainerControl = this;
            // 
            // errorMail
            // 
            this.errorMail.ContainerControl = this;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.tabControl1);
            this.Name = "Customer";
            this.Text = "Formulario Cliente";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorNif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSurname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtgridCustomer;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.DateTimePicker dtBirthDate;
        private System.Windows.Forms.TextBox txtSurname2;
        private System.Windows.Forms.TextBox txtSurname1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtInsertAddress;
        private System.Windows.Forms.TextBox txtInsertMail;
        private System.Windows.Forms.TextBox txtInsertNif;
        private System.Windows.Forms.TextBox txtInsertPhone;
        private System.Windows.Forms.DateTimePicker dtInsertBirthDate;
        private System.Windows.Forms.TextBox txtInsertSurname2;
        private System.Windows.Forms.TextBox txtInsertSurname1;
        private System.Windows.Forms.TextBox txtInsertName;
        private System.Windows.Forms.Button btClean;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ErrorProvider errorNif;
        private System.Windows.Forms.ErrorProvider errorName;
        private System.Windows.Forms.ErrorProvider errorSurname;
        private System.Windows.Forms.ErrorProvider errorPhone;
        private System.Windows.Forms.ErrorProvider errorMail;
    }
}

