namespace updateEmployee
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.ds = new updateEmployee.AdventureWorksDW2019DataSet();
			this.Employee_list = new System.Windows.Forms.DataGridView();
			this.employeeKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.parentEmployeeKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.employeeNationalIDAlternateKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.parentEmployeeNationalIDAlternateKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.salesTerritoryKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameStyleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hireDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.loginIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.maritalStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emergencyContactNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emergencyContactPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.salariedFlagDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.payFrequencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.baseRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.vacationHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sickLeaveHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.currentFlagDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.salesPersonFlagDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.departmentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.employeePhotoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
			this.conn = new System.Data.SqlClient.SqlConnection();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.adapter = new System.Data.SqlClient.SqlDataAdapter();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.reviewImg_picturebox = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.employeeKey = new System.Windows.Forms.TextBox();
			this.firstName = new System.Windows.Forms.TextBox();
			this.lastName = new System.Windows.Forms.TextBox();
			this.gender = new System.Windows.Forms.TextBox();
			this.emailAddr = new System.Windows.Forms.TextBox();
			this.phone = new System.Windows.Forms.TextBox();
			this.hireDate = new System.Windows.Forms.TextBox();
			this.endDate = new System.Windows.Forms.TextBox();
			this.department = new System.Windows.Forms.TextBox();
			this.title = new System.Windows.Forms.TextBox();
			this.update_btn = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label32 = new System.Windows.Forms.Label();
			this.clear_btn = new System.Windows.Forms.Button();
			this.insert_btn = new System.Windows.Forms.Button();
			this.browse_btn = new System.Windows.Forms.Button();
			this.insertImg = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox19 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.textBox15 = new System.Windows.Forms.TextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.textBox14 = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.textBox13 = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.textBox12 = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.textBox18 = new System.Windows.Forms.TextBox();
			this.label25 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.textBox16 = new System.Windows.Forms.TextBox();
			this.label24 = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.textBox17 = new System.Windows.Forms.TextBox();
			this.textBox20 = new System.Windows.Forms.TextBox();
			this.label31 = new System.Windows.Forms.Label();
			this.imgPath_textbox = new System.Windows.Forms.TextBox();
			this.openFile_btn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_list)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.reviewImg_picturebox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.insertImg)).BeginInit();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// bindingSource1
			// 
			this.bindingSource1.DataMember = "DimEmployee";
			this.bindingSource1.DataSource = this.ds;
			// 
			// ds
			// 
			this.ds.DataSetName = "AdventureWorksDW2019DataSet";
			this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// Employee_list
			// 
			this.Employee_list.AutoGenerateColumns = false;
			this.Employee_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.Employee_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Employee_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeKeyDataGridViewTextBoxColumn,
            this.parentEmployeeKeyDataGridViewTextBoxColumn,
            this.employeeNationalIDAlternateKeyDataGridViewTextBoxColumn,
            this.parentEmployeeNationalIDAlternateKeyDataGridViewTextBoxColumn,
            this.salesTerritoryKeyDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.nameStyleDataGridViewCheckBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.hireDateDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.loginIDDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.maritalStatusDataGridViewTextBoxColumn,
            this.emergencyContactNameDataGridViewTextBoxColumn,
            this.emergencyContactPhoneDataGridViewTextBoxColumn,
            this.salariedFlagDataGridViewCheckBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.payFrequencyDataGridViewTextBoxColumn,
            this.baseRateDataGridViewTextBoxColumn,
            this.vacationHoursDataGridViewTextBoxColumn,
            this.sickLeaveHoursDataGridViewTextBoxColumn,
            this.currentFlagDataGridViewCheckBoxColumn,
            this.salesPersonFlagDataGridViewCheckBoxColumn,
            this.departmentNameDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.employeePhotoDataGridViewImageColumn});
			this.Employee_list.DataSource = this.bindingSource1;
			this.Employee_list.Dock = System.Windows.Forms.DockStyle.Left;
			this.Employee_list.Location = new System.Drawing.Point(0, 0);
			this.Employee_list.Name = "Employee_list";
			this.Employee_list.RowHeadersWidth = 51;
			this.Employee_list.RowTemplate.Height = 27;
			this.Employee_list.Size = new System.Drawing.Size(326, 657);
			this.Employee_list.TabIndex = 4;
			this.Employee_list.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Employee_list_CellFormatting);
			// 
			// employeeKeyDataGridViewTextBoxColumn
			// 
			this.employeeKeyDataGridViewTextBoxColumn.DataPropertyName = "EmployeeKey";
			this.employeeKeyDataGridViewTextBoxColumn.HeaderText = "EmployeeKey";
			this.employeeKeyDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.employeeKeyDataGridViewTextBoxColumn.Name = "employeeKeyDataGridViewTextBoxColumn";
			this.employeeKeyDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// parentEmployeeKeyDataGridViewTextBoxColumn
			// 
			this.parentEmployeeKeyDataGridViewTextBoxColumn.DataPropertyName = "ParentEmployeeKey";
			this.parentEmployeeKeyDataGridViewTextBoxColumn.HeaderText = "ParentEmployeeKey";
			this.parentEmployeeKeyDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.parentEmployeeKeyDataGridViewTextBoxColumn.Name = "parentEmployeeKeyDataGridViewTextBoxColumn";
			this.parentEmployeeKeyDataGridViewTextBoxColumn.Visible = false;
			// 
			// employeeNationalIDAlternateKeyDataGridViewTextBoxColumn
			// 
			this.employeeNationalIDAlternateKeyDataGridViewTextBoxColumn.DataPropertyName = "EmployeeNationalIDAlternateKey";
			this.employeeNationalIDAlternateKeyDataGridViewTextBoxColumn.HeaderText = "EmployeeNationalIDAlternateKey";
			this.employeeNationalIDAlternateKeyDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.employeeNationalIDAlternateKeyDataGridViewTextBoxColumn.Name = "employeeNationalIDAlternateKeyDataGridViewTextBoxColumn";
			this.employeeNationalIDAlternateKeyDataGridViewTextBoxColumn.Visible = false;
			// 
			// parentEmployeeNationalIDAlternateKeyDataGridViewTextBoxColumn
			// 
			this.parentEmployeeNationalIDAlternateKeyDataGridViewTextBoxColumn.DataPropertyName = "ParentEmployeeNationalIDAlternateKey";
			this.parentEmployeeNationalIDAlternateKeyDataGridViewTextBoxColumn.HeaderText = "ParentEmployeeNationalIDAlternateKey";
			this.parentEmployeeNationalIDAlternateKeyDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.parentEmployeeNationalIDAlternateKeyDataGridViewTextBoxColumn.Name = "parentEmployeeNationalIDAlternateKeyDataGridViewTextBoxColumn";
			this.parentEmployeeNationalIDAlternateKeyDataGridViewTextBoxColumn.Visible = false;
			// 
			// salesTerritoryKeyDataGridViewTextBoxColumn
			// 
			this.salesTerritoryKeyDataGridViewTextBoxColumn.DataPropertyName = "SalesTerritoryKey";
			this.salesTerritoryKeyDataGridViewTextBoxColumn.HeaderText = "SalesTerritoryKey";
			this.salesTerritoryKeyDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.salesTerritoryKeyDataGridViewTextBoxColumn.Name = "salesTerritoryKeyDataGridViewTextBoxColumn";
			this.salesTerritoryKeyDataGridViewTextBoxColumn.Visible = false;
			// 
			// firstNameDataGridViewTextBoxColumn
			// 
			this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
			this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
			this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
			this.firstNameDataGridViewTextBoxColumn.Visible = false;
			// 
			// lastNameDataGridViewTextBoxColumn
			// 
			this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
			this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
			this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
			this.lastNameDataGridViewTextBoxColumn.Visible = false;
			// 
			// middleNameDataGridViewTextBoxColumn
			// 
			this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
			this.middleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName";
			this.middleNameDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
			this.middleNameDataGridViewTextBoxColumn.Visible = false;
			// 
			// nameStyleDataGridViewCheckBoxColumn
			// 
			this.nameStyleDataGridViewCheckBoxColumn.DataPropertyName = "NameStyle";
			this.nameStyleDataGridViewCheckBoxColumn.HeaderText = "NameStyle";
			this.nameStyleDataGridViewCheckBoxColumn.MinimumWidth = 6;
			this.nameStyleDataGridViewCheckBoxColumn.Name = "nameStyleDataGridViewCheckBoxColumn";
			this.nameStyleDataGridViewCheckBoxColumn.Visible = false;
			// 
			// titleDataGridViewTextBoxColumn
			// 
			this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
			this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
			this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
			this.titleDataGridViewTextBoxColumn.Visible = false;
			// 
			// hireDateDataGridViewTextBoxColumn
			// 
			this.hireDateDataGridViewTextBoxColumn.DataPropertyName = "HireDate";
			this.hireDateDataGridViewTextBoxColumn.HeaderText = "HireDate";
			this.hireDateDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.hireDateDataGridViewTextBoxColumn.Name = "hireDateDataGridViewTextBoxColumn";
			this.hireDateDataGridViewTextBoxColumn.Visible = false;
			// 
			// birthDateDataGridViewTextBoxColumn
			// 
			this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
			this.birthDateDataGridViewTextBoxColumn.HeaderText = "BirthDate";
			this.birthDateDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
			this.birthDateDataGridViewTextBoxColumn.Visible = false;
			// 
			// loginIDDataGridViewTextBoxColumn
			// 
			this.loginIDDataGridViewTextBoxColumn.DataPropertyName = "LoginID";
			this.loginIDDataGridViewTextBoxColumn.HeaderText = "LoginID";
			this.loginIDDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.loginIDDataGridViewTextBoxColumn.Name = "loginIDDataGridViewTextBoxColumn";
			this.loginIDDataGridViewTextBoxColumn.Visible = false;
			// 
			// emailAddressDataGridViewTextBoxColumn
			// 
			this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress";
			this.emailAddressDataGridViewTextBoxColumn.HeaderText = "EmailAddress";
			this.emailAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
			this.emailAddressDataGridViewTextBoxColumn.Visible = false;
			// 
			// phoneDataGridViewTextBoxColumn
			// 
			this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
			this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
			this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
			this.phoneDataGridViewTextBoxColumn.Visible = false;
			// 
			// maritalStatusDataGridViewTextBoxColumn
			// 
			this.maritalStatusDataGridViewTextBoxColumn.DataPropertyName = "MaritalStatus";
			this.maritalStatusDataGridViewTextBoxColumn.HeaderText = "MaritalStatus";
			this.maritalStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.maritalStatusDataGridViewTextBoxColumn.Name = "maritalStatusDataGridViewTextBoxColumn";
			this.maritalStatusDataGridViewTextBoxColumn.Visible = false;
			// 
			// emergencyContactNameDataGridViewTextBoxColumn
			// 
			this.emergencyContactNameDataGridViewTextBoxColumn.DataPropertyName = "EmergencyContactName";
			this.emergencyContactNameDataGridViewTextBoxColumn.HeaderText = "EmergencyContactName";
			this.emergencyContactNameDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.emergencyContactNameDataGridViewTextBoxColumn.Name = "emergencyContactNameDataGridViewTextBoxColumn";
			this.emergencyContactNameDataGridViewTextBoxColumn.Visible = false;
			// 
			// emergencyContactPhoneDataGridViewTextBoxColumn
			// 
			this.emergencyContactPhoneDataGridViewTextBoxColumn.DataPropertyName = "EmergencyContactPhone";
			this.emergencyContactPhoneDataGridViewTextBoxColumn.HeaderText = "EmergencyContactPhone";
			this.emergencyContactPhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.emergencyContactPhoneDataGridViewTextBoxColumn.Name = "emergencyContactPhoneDataGridViewTextBoxColumn";
			this.emergencyContactPhoneDataGridViewTextBoxColumn.Visible = false;
			// 
			// salariedFlagDataGridViewCheckBoxColumn
			// 
			this.salariedFlagDataGridViewCheckBoxColumn.DataPropertyName = "SalariedFlag";
			this.salariedFlagDataGridViewCheckBoxColumn.HeaderText = "SalariedFlag";
			this.salariedFlagDataGridViewCheckBoxColumn.MinimumWidth = 6;
			this.salariedFlagDataGridViewCheckBoxColumn.Name = "salariedFlagDataGridViewCheckBoxColumn";
			this.salariedFlagDataGridViewCheckBoxColumn.Visible = false;
			// 
			// genderDataGridViewTextBoxColumn
			// 
			this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
			this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
			this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
			this.genderDataGridViewTextBoxColumn.Visible = false;
			// 
			// payFrequencyDataGridViewTextBoxColumn
			// 
			this.payFrequencyDataGridViewTextBoxColumn.DataPropertyName = "PayFrequency";
			this.payFrequencyDataGridViewTextBoxColumn.HeaderText = "PayFrequency";
			this.payFrequencyDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.payFrequencyDataGridViewTextBoxColumn.Name = "payFrequencyDataGridViewTextBoxColumn";
			this.payFrequencyDataGridViewTextBoxColumn.Visible = false;
			// 
			// baseRateDataGridViewTextBoxColumn
			// 
			this.baseRateDataGridViewTextBoxColumn.DataPropertyName = "BaseRate";
			this.baseRateDataGridViewTextBoxColumn.HeaderText = "BaseRate";
			this.baseRateDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.baseRateDataGridViewTextBoxColumn.Name = "baseRateDataGridViewTextBoxColumn";
			this.baseRateDataGridViewTextBoxColumn.Visible = false;
			// 
			// vacationHoursDataGridViewTextBoxColumn
			// 
			this.vacationHoursDataGridViewTextBoxColumn.DataPropertyName = "VacationHours";
			this.vacationHoursDataGridViewTextBoxColumn.HeaderText = "VacationHours";
			this.vacationHoursDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.vacationHoursDataGridViewTextBoxColumn.Name = "vacationHoursDataGridViewTextBoxColumn";
			this.vacationHoursDataGridViewTextBoxColumn.Visible = false;
			// 
			// sickLeaveHoursDataGridViewTextBoxColumn
			// 
			this.sickLeaveHoursDataGridViewTextBoxColumn.DataPropertyName = "SickLeaveHours";
			this.sickLeaveHoursDataGridViewTextBoxColumn.HeaderText = "SickLeaveHours";
			this.sickLeaveHoursDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.sickLeaveHoursDataGridViewTextBoxColumn.Name = "sickLeaveHoursDataGridViewTextBoxColumn";
			this.sickLeaveHoursDataGridViewTextBoxColumn.Visible = false;
			// 
			// currentFlagDataGridViewCheckBoxColumn
			// 
			this.currentFlagDataGridViewCheckBoxColumn.DataPropertyName = "CurrentFlag";
			this.currentFlagDataGridViewCheckBoxColumn.HeaderText = "CurrentFlag";
			this.currentFlagDataGridViewCheckBoxColumn.MinimumWidth = 6;
			this.currentFlagDataGridViewCheckBoxColumn.Name = "currentFlagDataGridViewCheckBoxColumn";
			this.currentFlagDataGridViewCheckBoxColumn.Visible = false;
			// 
			// salesPersonFlagDataGridViewCheckBoxColumn
			// 
			this.salesPersonFlagDataGridViewCheckBoxColumn.DataPropertyName = "SalesPersonFlag";
			this.salesPersonFlagDataGridViewCheckBoxColumn.HeaderText = "SalesPersonFlag";
			this.salesPersonFlagDataGridViewCheckBoxColumn.MinimumWidth = 6;
			this.salesPersonFlagDataGridViewCheckBoxColumn.Name = "salesPersonFlagDataGridViewCheckBoxColumn";
			this.salesPersonFlagDataGridViewCheckBoxColumn.Visible = false;
			// 
			// departmentNameDataGridViewTextBoxColumn
			// 
			this.departmentNameDataGridViewTextBoxColumn.DataPropertyName = "DepartmentName";
			this.departmentNameDataGridViewTextBoxColumn.HeaderText = "DepartmentName";
			this.departmentNameDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.departmentNameDataGridViewTextBoxColumn.Name = "departmentNameDataGridViewTextBoxColumn";
			this.departmentNameDataGridViewTextBoxColumn.Visible = false;
			// 
			// startDateDataGridViewTextBoxColumn
			// 
			this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
			this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
			this.startDateDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
			this.startDateDataGridViewTextBoxColumn.Visible = false;
			// 
			// endDateDataGridViewTextBoxColumn
			// 
			this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
			this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
			this.endDateDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
			this.endDateDataGridViewTextBoxColumn.Visible = false;
			// 
			// statusDataGridViewTextBoxColumn
			// 
			this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
			this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
			this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
			this.statusDataGridViewTextBoxColumn.Visible = false;
			// 
			// employeePhotoDataGridViewImageColumn
			// 
			this.employeePhotoDataGridViewImageColumn.DataPropertyName = "EmployeePhoto";
			this.employeePhotoDataGridViewImageColumn.HeaderText = "EmployeePhoto";
			this.employeePhotoDataGridViewImageColumn.MinimumWidth = 6;
			this.employeePhotoDataGridViewImageColumn.Name = "employeePhotoDataGridViewImageColumn";
			this.employeePhotoDataGridViewImageColumn.Visible = false;
			// 
			// conn
			// 
			this.conn.ConnectionString = "Data Source=.\\sqlexpress;Initial Catalog=AdventureWorksDW2019;Integrated Security" +
    "=True;Encrypt=False";
			this.conn.FireInfoMessageEventOnUserErrors = false;
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "select * from DimEmployee";
			this.sqlSelectCommand1.Connection = this.conn;
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
			this.sqlInsertCommand1.Connection = this.conn;
			this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@ParentEmployeeKey", System.Data.SqlDbType.Int, 0, "ParentEmployeeKey"),
            new System.Data.SqlClient.SqlParameter("@EmployeeNationalIDAlternateKey", System.Data.SqlDbType.NVarChar, 0, "EmployeeNationalIDAlternateKey"),
            new System.Data.SqlClient.SqlParameter("@ParentEmployeeNationalIDAlternateKey", System.Data.SqlDbType.NVarChar, 0, "ParentEmployeeNationalIDAlternateKey"),
            new System.Data.SqlClient.SqlParameter("@SalesTerritoryKey", System.Data.SqlDbType.Int, 0, "SalesTerritoryKey"),
            new System.Data.SqlClient.SqlParameter("@FirstName", System.Data.SqlDbType.NVarChar, 0, "FirstName"),
            new System.Data.SqlClient.SqlParameter("@LastName", System.Data.SqlDbType.NVarChar, 0, "LastName"),
            new System.Data.SqlClient.SqlParameter("@MiddleName", System.Data.SqlDbType.NVarChar, 0, "MiddleName"),
            new System.Data.SqlClient.SqlParameter("@NameStyle", System.Data.SqlDbType.Bit, 0, "NameStyle"),
            new System.Data.SqlClient.SqlParameter("@Title", System.Data.SqlDbType.NVarChar, 0, "Title"),
            new System.Data.SqlClient.SqlParameter("@HireDate", System.Data.SqlDbType.DateTime, 0, "HireDate"),
            new System.Data.SqlClient.SqlParameter("@BirthDate", System.Data.SqlDbType.DateTime, 0, "BirthDate"),
            new System.Data.SqlClient.SqlParameter("@LoginID", System.Data.SqlDbType.NVarChar, 0, "LoginID"),
            new System.Data.SqlClient.SqlParameter("@EmailAddress", System.Data.SqlDbType.NVarChar, 0, "EmailAddress"),
            new System.Data.SqlClient.SqlParameter("@Phone", System.Data.SqlDbType.NVarChar, 0, "Phone"),
            new System.Data.SqlClient.SqlParameter("@MaritalStatus", System.Data.SqlDbType.NChar, 0, "MaritalStatus"),
            new System.Data.SqlClient.SqlParameter("@EmergencyContactName", System.Data.SqlDbType.NVarChar, 0, "EmergencyContactName"),
            new System.Data.SqlClient.SqlParameter("@EmergencyContactPhone", System.Data.SqlDbType.NVarChar, 0, "EmergencyContactPhone"),
            new System.Data.SqlClient.SqlParameter("@SalariedFlag", System.Data.SqlDbType.Bit, 0, "SalariedFlag"),
            new System.Data.SqlClient.SqlParameter("@Gender", System.Data.SqlDbType.NChar, 0, "Gender"),
            new System.Data.SqlClient.SqlParameter("@PayFrequency", System.Data.SqlDbType.TinyInt, 0, "PayFrequency"),
            new System.Data.SqlClient.SqlParameter("@BaseRate", System.Data.SqlDbType.Money, 0, "BaseRate"),
            new System.Data.SqlClient.SqlParameter("@VacationHours", System.Data.SqlDbType.SmallInt, 0, "VacationHours"),
            new System.Data.SqlClient.SqlParameter("@SickLeaveHours", System.Data.SqlDbType.SmallInt, 0, "SickLeaveHours"),
            new System.Data.SqlClient.SqlParameter("@CurrentFlag", System.Data.SqlDbType.Bit, 0, "CurrentFlag"),
            new System.Data.SqlClient.SqlParameter("@SalesPersonFlag", System.Data.SqlDbType.Bit, 0, "SalesPersonFlag"),
            new System.Data.SqlClient.SqlParameter("@DepartmentName", System.Data.SqlDbType.NVarChar, 0, "DepartmentName"),
            new System.Data.SqlClient.SqlParameter("@StartDate", System.Data.SqlDbType.DateTime, 0, "StartDate"),
            new System.Data.SqlClient.SqlParameter("@EndDate", System.Data.SqlDbType.DateTime, 0, "EndDate"),
            new System.Data.SqlClient.SqlParameter("@Status", System.Data.SqlDbType.NVarChar, 0, "Status"),
            new System.Data.SqlClient.SqlParameter("@EmployeePhoto", System.Data.SqlDbType.VarBinary, 0, "EmployeePhoto")});
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
			this.sqlUpdateCommand1.Connection = this.conn;
			this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@ParentEmployeeKey", System.Data.SqlDbType.Int, 0, "ParentEmployeeKey"),
            new System.Data.SqlClient.SqlParameter("@EmployeeNationalIDAlternateKey", System.Data.SqlDbType.NVarChar, 0, "EmployeeNationalIDAlternateKey"),
            new System.Data.SqlClient.SqlParameter("@ParentEmployeeNationalIDAlternateKey", System.Data.SqlDbType.NVarChar, 0, "ParentEmployeeNationalIDAlternateKey"),
            new System.Data.SqlClient.SqlParameter("@SalesTerritoryKey", System.Data.SqlDbType.Int, 0, "SalesTerritoryKey"),
            new System.Data.SqlClient.SqlParameter("@FirstName", System.Data.SqlDbType.NVarChar, 0, "FirstName"),
            new System.Data.SqlClient.SqlParameter("@LastName", System.Data.SqlDbType.NVarChar, 0, "LastName"),
            new System.Data.SqlClient.SqlParameter("@MiddleName", System.Data.SqlDbType.NVarChar, 0, "MiddleName"),
            new System.Data.SqlClient.SqlParameter("@NameStyle", System.Data.SqlDbType.Bit, 0, "NameStyle"),
            new System.Data.SqlClient.SqlParameter("@Title", System.Data.SqlDbType.NVarChar, 0, "Title"),
            new System.Data.SqlClient.SqlParameter("@HireDate", System.Data.SqlDbType.DateTime, 0, "HireDate"),
            new System.Data.SqlClient.SqlParameter("@BirthDate", System.Data.SqlDbType.DateTime, 0, "BirthDate"),
            new System.Data.SqlClient.SqlParameter("@LoginID", System.Data.SqlDbType.NVarChar, 0, "LoginID"),
            new System.Data.SqlClient.SqlParameter("@EmailAddress", System.Data.SqlDbType.NVarChar, 0, "EmailAddress"),
            new System.Data.SqlClient.SqlParameter("@Phone", System.Data.SqlDbType.NVarChar, 0, "Phone"),
            new System.Data.SqlClient.SqlParameter("@MaritalStatus", System.Data.SqlDbType.NChar, 0, "MaritalStatus"),
            new System.Data.SqlClient.SqlParameter("@EmergencyContactName", System.Data.SqlDbType.NVarChar, 0, "EmergencyContactName"),
            new System.Data.SqlClient.SqlParameter("@EmergencyContactPhone", System.Data.SqlDbType.NVarChar, 0, "EmergencyContactPhone"),
            new System.Data.SqlClient.SqlParameter("@SalariedFlag", System.Data.SqlDbType.Bit, 0, "SalariedFlag"),
            new System.Data.SqlClient.SqlParameter("@Gender", System.Data.SqlDbType.NChar, 0, "Gender"),
            new System.Data.SqlClient.SqlParameter("@PayFrequency", System.Data.SqlDbType.TinyInt, 0, "PayFrequency"),
            new System.Data.SqlClient.SqlParameter("@BaseRate", System.Data.SqlDbType.Money, 0, "BaseRate"),
            new System.Data.SqlClient.SqlParameter("@VacationHours", System.Data.SqlDbType.SmallInt, 0, "VacationHours"),
            new System.Data.SqlClient.SqlParameter("@SickLeaveHours", System.Data.SqlDbType.SmallInt, 0, "SickLeaveHours"),
            new System.Data.SqlClient.SqlParameter("@CurrentFlag", System.Data.SqlDbType.Bit, 0, "CurrentFlag"),
            new System.Data.SqlClient.SqlParameter("@SalesPersonFlag", System.Data.SqlDbType.Bit, 0, "SalesPersonFlag"),
            new System.Data.SqlClient.SqlParameter("@DepartmentName", System.Data.SqlDbType.NVarChar, 0, "DepartmentName"),
            new System.Data.SqlClient.SqlParameter("@StartDate", System.Data.SqlDbType.DateTime, 0, "StartDate"),
            new System.Data.SqlClient.SqlParameter("@EndDate", System.Data.SqlDbType.DateTime, 0, "EndDate"),
            new System.Data.SqlClient.SqlParameter("@Status", System.Data.SqlDbType.NVarChar, 0, "Status"),
            new System.Data.SqlClient.SqlParameter("@EmployeePhoto", System.Data.SqlDbType.VarBinary, 0, "EmployeePhoto"),
            new System.Data.SqlClient.SqlParameter("@Original_EmployeeKey", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmployeeKey", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ParentEmployeeKey", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ParentEmployeeKey", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ParentEmployeeKey", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ParentEmployeeKey", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EmployeeNationalIDAlternateKey", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EmployeeNationalIDAlternateKey", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EmployeeNationalIDAlternateKey", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmployeeNationalIDAlternateKey", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ParentEmployeeNationalIDAlternateKey", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ParentEmployeeNationalIDAlternateKey", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ParentEmployeeNationalIDAlternateKey", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ParentEmployeeNationalIDAlternateKey", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SalesTerritoryKey", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SalesTerritoryKey", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SalesTerritoryKey", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SalesTerritoryKey", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_FirstName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_LastName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MiddleName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MiddleName", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MiddleName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MiddleName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_NameStyle", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NameStyle", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Title", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Title", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Title", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Title", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HireDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HireDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HireDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HireDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BirthDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BirthDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BirthDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BirthDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LoginID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LoginID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LoginID", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LoginID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EmailAddress", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EmailAddress", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EmailAddress", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmailAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Phone", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Phone", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Phone", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Phone", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MaritalStatus", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MaritalStatus", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MaritalStatus", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MaritalStatus", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EmergencyContactName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EmergencyContactName", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EmergencyContactName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmergencyContactName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EmergencyContactPhone", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EmergencyContactPhone", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EmergencyContactPhone", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmergencyContactPhone", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SalariedFlag", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SalariedFlag", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SalariedFlag", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SalariedFlag", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Gender", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Gender", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Gender", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Gender", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PayFrequency", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PayFrequency", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PayFrequency", System.Data.SqlDbType.TinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PayFrequency", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BaseRate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BaseRate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BaseRate", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BaseRate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_VacationHours", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VacationHours", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_VacationHours", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VacationHours", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SickLeaveHours", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SickLeaveHours", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SickLeaveHours", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SickLeaveHours", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CurrentFlag", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CurrentFlag", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_SalesPersonFlag", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SalesPersonFlag", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DepartmentName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DepartmentName", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DepartmentName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DepartmentName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_StartDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "StartDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_StartDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StartDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EndDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EndDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EndDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EndDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Status", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Status", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@EmployeeKey", System.Data.SqlDbType.Int, 4, "EmployeeKey")});
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
			this.sqlDeleteCommand1.Connection = this.conn;
			this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_EmployeeKey", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmployeeKey", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ParentEmployeeKey", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ParentEmployeeKey", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ParentEmployeeKey", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ParentEmployeeKey", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EmployeeNationalIDAlternateKey", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EmployeeNationalIDAlternateKey", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EmployeeNationalIDAlternateKey", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmployeeNationalIDAlternateKey", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ParentEmployeeNationalIDAlternateKey", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ParentEmployeeNationalIDAlternateKey", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ParentEmployeeNationalIDAlternateKey", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ParentEmployeeNationalIDAlternateKey", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SalesTerritoryKey", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SalesTerritoryKey", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SalesTerritoryKey", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SalesTerritoryKey", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_FirstName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_LastName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MiddleName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MiddleName", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MiddleName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MiddleName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_NameStyle", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NameStyle", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Title", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Title", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Title", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Title", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HireDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HireDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HireDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HireDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BirthDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BirthDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BirthDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BirthDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LoginID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LoginID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LoginID", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LoginID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EmailAddress", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EmailAddress", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EmailAddress", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmailAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Phone", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Phone", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Phone", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Phone", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MaritalStatus", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MaritalStatus", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MaritalStatus", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MaritalStatus", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EmergencyContactName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EmergencyContactName", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EmergencyContactName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmergencyContactName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EmergencyContactPhone", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EmergencyContactPhone", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EmergencyContactPhone", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmergencyContactPhone", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SalariedFlag", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SalariedFlag", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SalariedFlag", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SalariedFlag", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Gender", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Gender", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Gender", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Gender", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PayFrequency", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PayFrequency", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PayFrequency", System.Data.SqlDbType.TinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PayFrequency", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BaseRate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BaseRate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BaseRate", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BaseRate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_VacationHours", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VacationHours", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_VacationHours", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VacationHours", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SickLeaveHours", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SickLeaveHours", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SickLeaveHours", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SickLeaveHours", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CurrentFlag", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CurrentFlag", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_SalesPersonFlag", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SalesPersonFlag", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DepartmentName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DepartmentName", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DepartmentName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DepartmentName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_StartDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "StartDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_StartDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StartDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EndDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EndDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EndDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EndDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Status", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Status", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, null)});
			// 
			// adapter
			// 
			this.adapter.DeleteCommand = this.sqlDeleteCommand1;
			this.adapter.InsertCommand = this.sqlInsertCommand1;
			this.adapter.SelectCommand = this.sqlSelectCommand1;
			this.adapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "DimEmployee", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("EmployeeKey", "EmployeeKey"),
                        new System.Data.Common.DataColumnMapping("ParentEmployeeKey", "ParentEmployeeKey"),
                        new System.Data.Common.DataColumnMapping("EmployeeNationalIDAlternateKey", "EmployeeNationalIDAlternateKey"),
                        new System.Data.Common.DataColumnMapping("ParentEmployeeNationalIDAlternateKey", "ParentEmployeeNationalIDAlternateKey"),
                        new System.Data.Common.DataColumnMapping("SalesTerritoryKey", "SalesTerritoryKey"),
                        new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
                        new System.Data.Common.DataColumnMapping("LastName", "LastName"),
                        new System.Data.Common.DataColumnMapping("MiddleName", "MiddleName"),
                        new System.Data.Common.DataColumnMapping("NameStyle", "NameStyle"),
                        new System.Data.Common.DataColumnMapping("Title", "Title"),
                        new System.Data.Common.DataColumnMapping("HireDate", "HireDate"),
                        new System.Data.Common.DataColumnMapping("BirthDate", "BirthDate"),
                        new System.Data.Common.DataColumnMapping("LoginID", "LoginID"),
                        new System.Data.Common.DataColumnMapping("EmailAddress", "EmailAddress"),
                        new System.Data.Common.DataColumnMapping("Phone", "Phone"),
                        new System.Data.Common.DataColumnMapping("MaritalStatus", "MaritalStatus"),
                        new System.Data.Common.DataColumnMapping("EmergencyContactName", "EmergencyContactName"),
                        new System.Data.Common.DataColumnMapping("EmergencyContactPhone", "EmergencyContactPhone"),
                        new System.Data.Common.DataColumnMapping("SalariedFlag", "SalariedFlag"),
                        new System.Data.Common.DataColumnMapping("Gender", "Gender"),
                        new System.Data.Common.DataColumnMapping("PayFrequency", "PayFrequency"),
                        new System.Data.Common.DataColumnMapping("BaseRate", "BaseRate"),
                        new System.Data.Common.DataColumnMapping("VacationHours", "VacationHours"),
                        new System.Data.Common.DataColumnMapping("SickLeaveHours", "SickLeaveHours"),
                        new System.Data.Common.DataColumnMapping("CurrentFlag", "CurrentFlag"),
                        new System.Data.Common.DataColumnMapping("SalesPersonFlag", "SalesPersonFlag"),
                        new System.Data.Common.DataColumnMapping("DepartmentName", "DepartmentName"),
                        new System.Data.Common.DataColumnMapping("StartDate", "StartDate"),
                        new System.Data.Common.DataColumnMapping("EndDate", "EndDate"),
                        new System.Data.Common.DataColumnMapping("Status", "Status"),
                        new System.Data.Common.DataColumnMapping("EmployeePhoto", "EmployeePhoto")})});
			this.adapter.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(326, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(796, 657);
			this.tabControl1.TabIndex = 5;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.openFile_btn);
			this.tabPage1.Controls.Add(this.imgPath_textbox);
			this.tabPage1.Controls.Add(this.reviewImg_picturebox);
			this.tabPage1.Controls.Add(this.pictureBox1);
			this.tabPage1.Controls.Add(this.tableLayoutPanel1);
			this.tabPage1.Location = new System.Drawing.Point(4, 33);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(788, 620);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Update";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// reviewImg_picturebox
			// 
			this.reviewImg_picturebox.Location = new System.Drawing.Point(274, 80);
			this.reviewImg_picturebox.Name = "reviewImg_picturebox";
			this.reviewImg_picturebox.Size = new System.Drawing.Size(117, 112);
			this.reviewImg_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.reviewImg_picturebox.TabIndex = 8;
			this.reviewImg_picturebox.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bindingSource1, "EmployeePhoto", true));
			this.pictureBox1.Location = new System.Drawing.Point(31, 16);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(200, 222);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.41058F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.20403F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.896725F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.51385F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.97481F));
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label7, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.label8, 3, 1);
			this.tableLayoutPanel1.Controls.Add(this.label9, 3, 2);
			this.tableLayoutPanel1.Controls.Add(this.label10, 3, 3);
			this.tableLayoutPanel1.Controls.Add(this.employeeKey, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.firstName, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.lastName, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.gender, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.emailAddr, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.phone, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.hireDate, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.endDate, 4, 1);
			this.tableLayoutPanel1.Controls.Add(this.department, 4, 2);
			this.tableLayoutPanel1.Controls.Add(this.title, 4, 3);
			this.tableLayoutPanel1.Controls.Add(this.update_btn, 4, 5);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 250);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 7;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(785, 383);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(100, 313);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Phone";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(26, 254);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(139, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Email Address";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(90, 195);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 23);
			this.label3.TabIndex = 0;
			this.label3.Text = "Gender";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(59, 136);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(106, 23);
			this.label4.TabIndex = 0;
			this.label4.Text = "Last Name";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(57, 77);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(108, 23);
			this.label5.TabIndex = 0;
			this.label5.Text = "First Name";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(132, 18);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(33, 23);
			this.label6.TabIndex = 0;
			this.label6.Text = "ID";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(448, 18);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(97, 23);
			this.label7.TabIndex = 0;
			this.label7.Text = "Hire Date";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(452, 77);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(93, 23);
			this.label8.TabIndex = 0;
			this.label8.Text = "End Date";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(431, 136);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(114, 23);
			this.label9.TabIndex = 0;
			this.label9.Text = "Department";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label10
			// 
			this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(494, 195);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(51, 23);
			this.label10.TabIndex = 0;
			this.label10.Text = "Title";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// employeeKey
			// 
			this.employeeKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.employeeKey.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "EmployeeKey", true));
			this.employeeKey.Location = new System.Drawing.Point(171, 12);
			this.employeeKey.Name = "employeeKey";
			this.employeeKey.ReadOnly = true;
			this.employeeKey.Size = new System.Drawing.Size(207, 35);
			this.employeeKey.TabIndex = 1;
			// 
			// firstName
			// 
			this.firstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.firstName.BackColor = System.Drawing.Color.White;
			this.firstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "FirstName", true));
			this.firstName.Location = new System.Drawing.Point(171, 71);
			this.firstName.Name = "firstName";
			this.firstName.Size = new System.Drawing.Size(207, 35);
			this.firstName.TabIndex = 1;
			// 
			// lastName
			// 
			this.lastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lastName.BackColor = System.Drawing.Color.White;
			this.lastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "LastName", true));
			this.lastName.Location = new System.Drawing.Point(171, 130);
			this.lastName.Name = "lastName";
			this.lastName.Size = new System.Drawing.Size(207, 35);
			this.lastName.TabIndex = 1;
			// 
			// gender
			// 
			this.gender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.gender.BackColor = System.Drawing.Color.White;
			this.gender.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Gender", true));
			this.gender.Location = new System.Drawing.Point(171, 189);
			this.gender.Name = "gender";
			this.gender.Size = new System.Drawing.Size(207, 35);
			this.gender.TabIndex = 1;
			// 
			// emailAddr
			// 
			this.emailAddr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.emailAddr.BackColor = System.Drawing.Color.White;
			this.emailAddr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "EmailAddress", true));
			this.emailAddr.Location = new System.Drawing.Point(171, 248);
			this.emailAddr.Name = "emailAddr";
			this.emailAddr.Size = new System.Drawing.Size(207, 35);
			this.emailAddr.TabIndex = 1;
			// 
			// phone
			// 
			this.phone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.phone.BackColor = System.Drawing.Color.White;
			this.phone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Phone", true));
			this.phone.Location = new System.Drawing.Point(171, 307);
			this.phone.Name = "phone";
			this.phone.Size = new System.Drawing.Size(207, 35);
			this.phone.TabIndex = 1;
			// 
			// hireDate
			// 
			this.hireDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.hireDate.BackColor = System.Drawing.Color.White;
			this.hireDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "HireDate", true));
			this.hireDate.Location = new System.Drawing.Point(551, 12);
			this.hireDate.Name = "hireDate";
			this.hireDate.Size = new System.Drawing.Size(231, 35);
			this.hireDate.TabIndex = 1;
			// 
			// endDate
			// 
			this.endDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.endDate.BackColor = System.Drawing.Color.White;
			this.endDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "EndDate", true));
			this.endDate.Location = new System.Drawing.Point(551, 71);
			this.endDate.Name = "endDate";
			this.endDate.Size = new System.Drawing.Size(231, 35);
			this.endDate.TabIndex = 1;
			// 
			// department
			// 
			this.department.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.department.BackColor = System.Drawing.Color.White;
			this.department.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "DepartmentName", true));
			this.department.Location = new System.Drawing.Point(551, 130);
			this.department.Name = "department";
			this.department.Size = new System.Drawing.Size(231, 35);
			this.department.TabIndex = 1;
			// 
			// title
			// 
			this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.title.BackColor = System.Drawing.Color.White;
			this.title.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Title", true));
			this.title.Location = new System.Drawing.Point(551, 189);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(231, 35);
			this.title.TabIndex = 1;
			// 
			// update_btn
			// 
			this.update_btn.Location = new System.Drawing.Point(551, 298);
			this.update_btn.Name = "update_btn";
			this.update_btn.Size = new System.Drawing.Size(139, 44);
			this.update_btn.TabIndex = 2;
			this.update_btn.Text = "Update";
			this.update_btn.UseVisualStyleBackColor = true;
			this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label32);
			this.tabPage2.Controls.Add(this.clear_btn);
			this.tabPage2.Controls.Add(this.insert_btn);
			this.tabPage2.Controls.Add(this.browse_btn);
			this.tabPage2.Controls.Add(this.insertImg);
			this.tabPage2.Controls.Add(this.tableLayoutPanel2);
			this.tabPage2.Controls.Add(this.label31);
			this.tabPage2.Location = new System.Drawing.Point(4, 33);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(788, 620);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Increase";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// label32
			// 
			this.label32.AutoSize = true;
			this.label32.Location = new System.Drawing.Point(319, 534);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(75, 23);
			this.label32.TabIndex = 5;
			this.label32.Text = "label32";
			this.label32.Visible = false;
			// 
			// clear_btn
			// 
			this.clear_btn.Location = new System.Drawing.Point(644, 557);
			this.clear_btn.Name = "clear_btn";
			this.clear_btn.Size = new System.Drawing.Size(122, 46);
			this.clear_btn.TabIndex = 2;
			this.clear_btn.Text = "Clear";
			this.clear_btn.UseVisualStyleBackColor = true;
			this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
			// 
			// insert_btn
			// 
			this.insert_btn.Location = new System.Drawing.Point(504, 557);
			this.insert_btn.Name = "insert_btn";
			this.insert_btn.Size = new System.Drawing.Size(122, 46);
			this.insert_btn.TabIndex = 2;
			this.insert_btn.Text = "Increase";
			this.insert_btn.UseVisualStyleBackColor = true;
			this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
			// 
			// browse_btn
			// 
			this.browse_btn.Location = new System.Drawing.Point(309, 468);
			this.browse_btn.Name = "browse_btn";
			this.browse_btn.Size = new System.Drawing.Size(122, 46);
			this.browse_btn.TabIndex = 2;
			this.browse_btn.Text = "Browse";
			this.browse_btn.UseVisualStyleBackColor = true;
			this.browse_btn.Click += new System.EventHandler(this.browse_btn_Click);
			// 
			// insertImg
			// 
			this.insertImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.insertImg.Location = new System.Drawing.Point(165, 468);
			this.insertImg.Name = "insertImg";
			this.insertImg.Size = new System.Drawing.Size(138, 144);
			this.insertImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.insertImg.TabIndex = 1;
			this.insertImg.TabStop = false;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 5;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.20725F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.68394F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.036269F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.7772F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.1658F));
			this.tableLayoutPanel2.Controls.Add(this.textBox1, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.textBox2, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.textBox3, 1, 2);
			this.tableLayoutPanel2.Controls.Add(this.textBox4, 1, 3);
			this.tableLayoutPanel2.Controls.Add(this.textBox5, 1, 4);
			this.tableLayoutPanel2.Controls.Add(this.textBox6, 1, 5);
			this.tableLayoutPanel2.Controls.Add(this.textBox19, 4, 8);
			this.tableLayoutPanel2.Controls.Add(this.textBox7, 1, 6);
			this.tableLayoutPanel2.Controls.Add(this.textBox8, 1, 7);
			this.tableLayoutPanel2.Controls.Add(this.textBox9, 1, 8);
			this.tableLayoutPanel2.Controls.Add(this.textBox10, 1, 9);
			this.tableLayoutPanel2.Controls.Add(this.textBox15, 4, 4);
			this.tableLayoutPanel2.Controls.Add(this.label23, 3, 3);
			this.tableLayoutPanel2.Controls.Add(this.textBox14, 4, 3);
			this.tableLayoutPanel2.Controls.Add(this.label17, 3, 2);
			this.tableLayoutPanel2.Controls.Add(this.textBox13, 4, 2);
			this.tableLayoutPanel2.Controls.Add(this.label22, 3, 1);
			this.tableLayoutPanel2.Controls.Add(this.textBox12, 4, 1);
			this.tableLayoutPanel2.Controls.Add(this.label18, 3, 0);
			this.tableLayoutPanel2.Controls.Add(this.textBox11, 4, 0);
			this.tableLayoutPanel2.Controls.Add(this.label20, 0, 9);
			this.tableLayoutPanel2.Controls.Add(this.label19, 0, 8);
			this.tableLayoutPanel2.Controls.Add(this.label21, 0, 7);
			this.tableLayoutPanel2.Controls.Add(this.label16, 0, 6);
			this.tableLayoutPanel2.Controls.Add(this.label15, 0, 5);
			this.tableLayoutPanel2.Controls.Add(this.label14, 0, 4);
			this.tableLayoutPanel2.Controls.Add(this.label13, 0, 3);
			this.tableLayoutPanel2.Controls.Add(this.label12, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.label11, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.label26, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.label28, 3, 9);
			this.tableLayoutPanel2.Controls.Add(this.label27, 3, 8);
			this.tableLayoutPanel2.Controls.Add(this.textBox18, 4, 7);
			this.tableLayoutPanel2.Controls.Add(this.label25, 3, 7);
			this.tableLayoutPanel2.Controls.Add(this.label29, 3, 6);
			this.tableLayoutPanel2.Controls.Add(this.textBox16, 4, 5);
			this.tableLayoutPanel2.Controls.Add(this.label24, 3, 4);
			this.tableLayoutPanel2.Controls.Add(this.label30, 3, 5);
			this.tableLayoutPanel2.Controls.Add(this.textBox17, 4, 6);
			this.tableLayoutPanel2.Controls.Add(this.textBox20, 4, 9);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 6);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 10;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(772, 456);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Location = new System.Drawing.Point(159, 5);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(200, 35);
			this.textBox1.TabIndex = 3;
			// 
			// textBox2
			// 
			this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox2.Location = new System.Drawing.Point(159, 50);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(200, 35);
			this.textBox2.TabIndex = 3;
			this.textBox2.TextChanged += new System.EventHandler(this.LoginID_TextChanged);
			// 
			// textBox3
			// 
			this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox3.Location = new System.Drawing.Point(159, 95);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(200, 35);
			this.textBox3.TabIndex = 3;
			// 
			// textBox4
			// 
			this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox4.Location = new System.Drawing.Point(159, 140);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(200, 35);
			this.textBox4.TabIndex = 3;
			// 
			// textBox5
			// 
			this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox5.Enabled = false;
			this.textBox5.Location = new System.Drawing.Point(159, 185);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(200, 35);
			this.textBox5.TabIndex = 3;
			this.textBox5.Text = "0";
			// 
			// textBox6
			// 
			this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox6.Location = new System.Drawing.Point(159, 230);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(200, 35);
			this.textBox6.TabIndex = 3;
			// 
			// textBox19
			// 
			this.textBox19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox19.Enabled = false;
			this.textBox19.Location = new System.Drawing.Point(572, 365);
			this.textBox19.Name = "textBox19";
			this.textBox19.Size = new System.Drawing.Size(197, 35);
			this.textBox19.TabIndex = 3;
			this.textBox19.Text = "1";
			// 
			// textBox7
			// 
			this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox7.Location = new System.Drawing.Point(159, 275);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(200, 35);
			this.textBox7.TabIndex = 3;
			// 
			// textBox8
			// 
			this.textBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox8.Location = new System.Drawing.Point(159, 320);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(200, 35);
			this.textBox8.TabIndex = 3;
			// 
			// textBox9
			// 
			this.textBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox9.Location = new System.Drawing.Point(159, 365);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(200, 35);
			this.textBox9.TabIndex = 3;
			// 
			// textBox10
			// 
			this.textBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox10.Location = new System.Drawing.Point(159, 413);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(200, 35);
			this.textBox10.TabIndex = 3;
			this.textBox10.TextChanged += new System.EventHandler(this.Title_TextChanged);
			// 
			// textBox15
			// 
			this.textBox15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox15.Location = new System.Drawing.Point(572, 185);
			this.textBox15.Name = "textBox15";
			this.textBox15.Size = new System.Drawing.Size(197, 35);
			this.textBox15.TabIndex = 3;
			// 
			// label23
			// 
			this.label23.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(469, 146);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(97, 23);
			this.label23.TabIndex = 4;
			this.label23.Text = "Hire Date";
			this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox14
			// 
			this.textBox14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox14.Location = new System.Drawing.Point(572, 140);
			this.textBox14.Name = "textBox14";
			this.textBox14.Size = new System.Drawing.Size(197, 35);
			this.textBox14.TabIndex = 3;
			// 
			// label17
			// 
			this.label17.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(427, 101);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(139, 23);
			this.label17.TabIndex = 4;
			this.label17.Text = "Email Address";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox13
			// 
			this.textBox13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox13.Enabled = false;
			this.textBox13.Location = new System.Drawing.Point(572, 95);
			this.textBox13.Name = "textBox13";
			this.textBox13.Size = new System.Drawing.Size(197, 35);
			this.textBox13.TabIndex = 3;
			// 
			// label22
			// 
			this.label22.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(475, 56);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(91, 23);
			this.label22.TabIndex = 2;
			this.label22.Text = "Login ID";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox12
			// 
			this.textBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox12.Enabled = false;
			this.textBox12.Location = new System.Drawing.Point(572, 50);
			this.textBox12.Name = "textBox12";
			this.textBox12.Size = new System.Drawing.Size(197, 35);
			this.textBox12.TabIndex = 3;
			// 
			// label18
			// 
			this.label18.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(501, 11);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(65, 23);
			this.label18.TabIndex = 4;
			this.label18.Text = "Phone";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox11
			// 
			this.textBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox11.Location = new System.Drawing.Point(572, 5);
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(197, 35);
			this.textBox11.TabIndex = 3;
			// 
			// label20
			// 
			this.label20.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(102, 419);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(51, 23);
			this.label20.TabIndex = 4;
			this.label20.Text = "Title";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label19
			// 
			this.label19.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(39, 371);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(114, 23);
			this.label19.TabIndex = 4;
			this.label19.Text = "Department";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label21
			// 
			this.label21.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(20, 326);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(133, 23);
			this.label21.TabIndex = 2;
			this.label21.Text = "Marital Status";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label16
			// 
			this.label16.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(51, 281);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(102, 23);
			this.label16.TabIndex = 4;
			this.label16.Text = "Birth Date";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label15
			// 
			this.label15.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(78, 236);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(75, 23);
			this.label15.TabIndex = 4;
			this.label15.Text = "Gender";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label14
			// 
			this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(39, 191);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(114, 23);
			this.label14.TabIndex = 4;
			this.label14.Text = "Name Style";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label13
			// 
			this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(21, 146);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(132, 23);
			this.label13.TabIndex = 4;
			this.label13.Text = "Middle Name";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label12
			// 
			this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(47, 101);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(106, 23);
			this.label12.TabIndex = 4;
			this.label12.Text = "Last Name";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label11
			// 
			this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(45, 56);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(108, 23);
			this.label11.TabIndex = 2;
			this.label11.Text = "First Name";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label26
			// 
			this.label26.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label26.AutoSize = true;
			this.label26.Location = new System.Drawing.Point(38, 11);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(115, 23);
			this.label26.TabIndex = 2;
			this.label26.Text = "National ID";
			this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label28
			// 
			this.label28.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label28.AutoSize = true;
			this.label28.Location = new System.Drawing.Point(400, 419);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(166, 23);
			this.label28.TabIndex = 4;
			this.label28.Text = "Sales Person Flag";
			this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label27
			// 
			this.label27.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label27.AutoSize = true;
			this.label27.Location = new System.Drawing.Point(445, 371);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(121, 23);
			this.label27.TabIndex = 4;
			this.label27.Text = "Current Flag";
			this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox18
			// 
			this.textBox18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox18.Enabled = false;
			this.textBox18.Location = new System.Drawing.Point(572, 320);
			this.textBox18.Name = "textBox18";
			this.textBox18.Size = new System.Drawing.Size(197, 35);
			this.textBox18.TabIndex = 3;
			this.textBox18.Text = "Current";
			// 
			// label25
			// 
			this.label25.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label25.AutoSize = true;
			this.label25.Location = new System.Drawing.Point(503, 326);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(63, 23);
			this.label25.TabIndex = 4;
			this.label25.Text = "Status";
			this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label29
			// 
			this.label29.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label29.AutoSize = true;
			this.label29.Location = new System.Drawing.Point(424, 281);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(142, 23);
			this.label29.TabIndex = 4;
			this.label29.Text = "Pay Frequency";
			this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox16
			// 
			this.textBox16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox16.Location = new System.Drawing.Point(572, 230);
			this.textBox16.Name = "textBox16";
			this.textBox16.Size = new System.Drawing.Size(197, 35);
			this.textBox16.TabIndex = 3;
			// 
			// label24
			// 
			this.label24.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(467, 191);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(99, 23);
			this.label24.TabIndex = 4;
			this.label24.Text = "Start Date";
			this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label30
			// 
			this.label30.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label30.AutoSize = true;
			this.label30.Location = new System.Drawing.Point(426, 236);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(140, 23);
			this.label30.TabIndex = 4;
			this.label30.Text = "Sales Territory";
			this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox17
			// 
			this.textBox17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox17.Location = new System.Drawing.Point(572, 275);
			this.textBox17.Name = "textBox17";
			this.textBox17.Size = new System.Drawing.Size(197, 35);
			this.textBox17.TabIndex = 3;
			// 
			// textBox20
			// 
			this.textBox20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox20.Enabled = false;
			this.textBox20.Location = new System.Drawing.Point(572, 413);
			this.textBox20.Name = "textBox20";
			this.textBox20.Size = new System.Drawing.Size(197, 35);
			this.textBox20.TabIndex = 3;
			this.textBox20.Text = " ";
			// 
			// label31
			// 
			this.label31.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label31.AutoSize = true;
			this.label31.Location = new System.Drawing.Point(-229, 335);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(61, 23);
			this.label31.TabIndex = 4;
			this.label31.Text = "Photo";
			this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// imgPath_textbox
			// 
			this.imgPath_textbox.Location = new System.Drawing.Point(274, 16);
			this.imgPath_textbox.Name = "imgPath_textbox";
			this.imgPath_textbox.Size = new System.Drawing.Size(234, 35);
			this.imgPath_textbox.TabIndex = 9;
			// 
			// openFile_btn
			// 
			this.openFile_btn.Location = new System.Drawing.Point(524, 10);
			this.openFile_btn.Name = "openFile_btn";
			this.openFile_btn.Size = new System.Drawing.Size(109, 42);
			this.openFile_btn.TabIndex = 10;
			this.openFile_btn.Text = "Browse";
			this.openFile_btn.UseVisualStyleBackColor = true;
			this.openFile_btn.Click += new System.EventHandler(this.openFile_btn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1122, 657);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.Employee_list);
			this.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Employee_list)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.reviewImg_picturebox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.insertImg)).EndInit();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView Employee_list;
        private System.Data.SqlClient.SqlConnection conn;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter adapter;
        private AdventureWorksDW2019DataSet ds;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox reviewImg_picturebox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox employeeKey;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox gender;
        private System.Windows.Forms.TextBox emailAddr;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox hireDate;
        private System.Windows.Forms.TextBox endDate;
        private System.Windows.Forms.TextBox department;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentEmployeeKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNationalIDAlternateKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentEmployeeNationalIDAlternateKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesTerritoryKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn nameStyleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hireDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maritalStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emergencyContactNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emergencyContactPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn salariedFlagDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payFrequencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacationHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sickLeaveHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn currentFlagDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn salesPersonFlagDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn employeePhotoDataGridViewImageColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Button browse_btn;
        private System.Windows.Forms.PictureBox insertImg;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Button openFile_btn;
		private System.Windows.Forms.TextBox imgPath_textbox;
	}
}

