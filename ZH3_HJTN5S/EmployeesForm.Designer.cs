namespace ZH3_HJTN5S
{
    partial class EmployeesForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleOfCourtesyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hireDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homePhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extensionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportsToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoPathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inverseReportsToNavigationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportsToNavigationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.territoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIdDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.titleOfCourtesyDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.hireDateDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.regionDataGridViewTextBoxColumn,
            this.postalCodeDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.homePhoneDataGridViewTextBoxColumn,
            this.extensionDataGridViewTextBoxColumn,
            this.photoDataGridViewImageColumn,
            this.notesDataGridViewTextBoxColumn,
            this.reportsToDataGridViewTextBoxColumn,
            this.photoPathDataGridViewTextBoxColumn,
            this.inverseReportsToNavigationDataGridViewTextBoxColumn,
            this.ordersDataGridViewTextBoxColumn,
            this.reportsToNavigationDataGridViewTextBoxColumn,
            this.territoryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 367);
            this.dataGridView1.TabIndex = 0;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            this.employeeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleOfCourtesyDataGridViewTextBoxColumn
            // 
            this.titleOfCourtesyDataGridViewTextBoxColumn.DataPropertyName = "TitleOfCourtesy";
            this.titleOfCourtesyDataGridViewTextBoxColumn.HeaderText = "TitleOfCourtesy";
            this.titleOfCourtesyDataGridViewTextBoxColumn.Name = "titleOfCourtesyDataGridViewTextBoxColumn";
            this.titleOfCourtesyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            this.birthDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hireDateDataGridViewTextBoxColumn
            // 
            this.hireDateDataGridViewTextBoxColumn.DataPropertyName = "HireDate";
            this.hireDateDataGridViewTextBoxColumn.HeaderText = "HireDate";
            this.hireDateDataGridViewTextBoxColumn.Name = "hireDateDataGridViewTextBoxColumn";
            this.hireDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regionDataGridViewTextBoxColumn
            // 
            this.regionDataGridViewTextBoxColumn.DataPropertyName = "Region";
            this.regionDataGridViewTextBoxColumn.HeaderText = "Region";
            this.regionDataGridViewTextBoxColumn.Name = "regionDataGridViewTextBoxColumn";
            this.regionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postalCodeDataGridViewTextBoxColumn
            // 
            this.postalCodeDataGridViewTextBoxColumn.DataPropertyName = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn.HeaderText = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn.Name = "postalCodeDataGridViewTextBoxColumn";
            this.postalCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // homePhoneDataGridViewTextBoxColumn
            // 
            this.homePhoneDataGridViewTextBoxColumn.DataPropertyName = "HomePhone";
            this.homePhoneDataGridViewTextBoxColumn.HeaderText = "HomePhone";
            this.homePhoneDataGridViewTextBoxColumn.Name = "homePhoneDataGridViewTextBoxColumn";
            this.homePhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // extensionDataGridViewTextBoxColumn
            // 
            this.extensionDataGridViewTextBoxColumn.DataPropertyName = "Extension";
            this.extensionDataGridViewTextBoxColumn.HeaderText = "Extension";
            this.extensionDataGridViewTextBoxColumn.Name = "extensionDataGridViewTextBoxColumn";
            this.extensionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // photoDataGridViewImageColumn
            // 
            this.photoDataGridViewImageColumn.DataPropertyName = "Photo";
            this.photoDataGridViewImageColumn.HeaderText = "Photo";
            this.photoDataGridViewImageColumn.Name = "photoDataGridViewImageColumn";
            this.photoDataGridViewImageColumn.ReadOnly = true;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reportsToDataGridViewTextBoxColumn
            // 
            this.reportsToDataGridViewTextBoxColumn.DataPropertyName = "ReportsTo";
            this.reportsToDataGridViewTextBoxColumn.HeaderText = "ReportsTo";
            this.reportsToDataGridViewTextBoxColumn.Name = "reportsToDataGridViewTextBoxColumn";
            this.reportsToDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // photoPathDataGridViewTextBoxColumn
            // 
            this.photoPathDataGridViewTextBoxColumn.DataPropertyName = "PhotoPath";
            this.photoPathDataGridViewTextBoxColumn.HeaderText = "PhotoPath";
            this.photoPathDataGridViewTextBoxColumn.Name = "photoPathDataGridViewTextBoxColumn";
            this.photoPathDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inverseReportsToNavigationDataGridViewTextBoxColumn
            // 
            this.inverseReportsToNavigationDataGridViewTextBoxColumn.DataPropertyName = "InverseReportsToNavigation";
            this.inverseReportsToNavigationDataGridViewTextBoxColumn.HeaderText = "InverseReportsToNavigation";
            this.inverseReportsToNavigationDataGridViewTextBoxColumn.Name = "inverseReportsToNavigationDataGridViewTextBoxColumn";
            this.inverseReportsToNavigationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordersDataGridViewTextBoxColumn
            // 
            this.ordersDataGridViewTextBoxColumn.DataPropertyName = "Orders";
            this.ordersDataGridViewTextBoxColumn.HeaderText = "Orders";
            this.ordersDataGridViewTextBoxColumn.Name = "ordersDataGridViewTextBoxColumn";
            this.ordersDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reportsToNavigationDataGridViewTextBoxColumn
            // 
            this.reportsToNavigationDataGridViewTextBoxColumn.DataPropertyName = "ReportsToNavigation";
            this.reportsToNavigationDataGridViewTextBoxColumn.HeaderText = "ReportsToNavigation";
            this.reportsToNavigationDataGridViewTextBoxColumn.Name = "reportsToNavigationDataGridViewTextBoxColumn";
            this.reportsToNavigationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // territoryDataGridViewTextBoxColumn
            // 
            this.territoryDataGridViewTextBoxColumn.DataPropertyName = "Territory";
            this.territoryDataGridViewTextBoxColumn.HeaderText = "Territory";
            this.territoryDataGridViewTextBoxColumn.Name = "territoryDataGridViewTextBoxColumn";
            this.territoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataSource = typeof(ZH3_HJTN5S.Models.Employees);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(289, 22);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(231, 23);
            this.textBoxFirstName.TabIndex = 1;
            this.textBoxFirstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmployeesForm";
            this.Text = "EmployeesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleOfCourtesyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hireDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn postalCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn homePhoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn extensionDataGridViewTextBoxColumn;
        private DataGridViewImageColumn photoDataGridViewImageColumn;
        private DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn reportsToDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn photoPathDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn inverseReportsToNavigationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ordersDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn reportsToNavigationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn territoryDataGridViewTextBoxColumn;
        private BindingSource employeesBindingSource;
        private TextBox textBoxFirstName;
    }
}