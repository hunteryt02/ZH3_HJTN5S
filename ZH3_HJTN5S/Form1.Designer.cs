namespace ZH3_HJTN5S
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxCustomers = new System.Windows.Forms.TextBox();
            this.textBoxOrders = new System.Windows.Forms.TextBox();
            this.listBoxCustomers = new System.Windows.Forms.ListBox();
            this.listBoxOrders = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productPerUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridbeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonExcel = new System.Windows.Forms.Button();
            this.buttonSuppliers = new System.Windows.Forms.Button();
            this.buttonEmployees = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridbeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCustomers
            // 
            this.textBoxCustomers.Location = new System.Drawing.Point(24, 46);
            this.textBoxCustomers.Name = "textBoxCustomers";
            this.textBoxCustomers.Size = new System.Drawing.Size(152, 23);
            this.textBoxCustomers.TabIndex = 0;
            this.textBoxCustomers.TextChanged += new System.EventHandler(this.textBoxCustomers_TextChanged);
            // 
            // textBoxOrders
            // 
            this.textBoxOrders.Location = new System.Drawing.Point(208, 46);
            this.textBoxOrders.Name = "textBoxOrders";
            this.textBoxOrders.Size = new System.Drawing.Size(152, 23);
            this.textBoxOrders.TabIndex = 1;
            this.textBoxOrders.TextChanged += new System.EventHandler(this.textBoxOrders_TextChanged);
            // 
            // listBoxCustomers
            // 
            this.listBoxCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxCustomers.FormattingEnabled = true;
            this.listBoxCustomers.ItemHeight = 15;
            this.listBoxCustomers.Location = new System.Drawing.Point(24, 85);
            this.listBoxCustomers.Name = "listBoxCustomers";
            this.listBoxCustomers.Size = new System.Drawing.Size(152, 334);
            this.listBoxCustomers.TabIndex = 2;
            this.listBoxCustomers.SelectedIndexChanged += new System.EventHandler(this.listBoxCustomers_SelectedIndexChanged);
            // 
            // listBoxOrders
            // 
            this.listBoxOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxOrders.FormattingEnabled = true;
            this.listBoxOrders.ItemHeight = 15;
            this.listBoxOrders.Location = new System.Drawing.Point(208, 85);
            this.listBoxOrders.Name = "listBoxOrders";
            this.listBoxOrders.Size = new System.Drawing.Size(152, 334);
            this.listBoxOrders.TabIndex = 3;
            this.listBoxOrders.SelectedIndexChanged += new System.EventHandler(this.listBoxOrders_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.productIdDataGridViewTextBoxColumn,
            this.productPerUnitDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gridbeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(418, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(447, 334);
            this.dataGridView1.TabIndex = 4;
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            this.orderIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.DataSource = this.productsBindingSource;
            this.productIdDataGridViewTextBoxColumn.DisplayMember = "ProductName";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.productIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.productIdDataGridViewTextBoxColumn.ValueMember = "ProductId";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(ZH3_HJTN5S.Models.Products);
            // 
            // productPerUnitDataGridViewTextBoxColumn
            // 
            this.productPerUnitDataGridViewTextBoxColumn.DataPropertyName = "ProductPerUnit";
            this.productPerUnitDataGridViewTextBoxColumn.HeaderText = "ProductPerUnit";
            this.productPerUnitDataGridViewTextBoxColumn.Name = "productPerUnitDataGridViewTextBoxColumn";
            this.productPerUnitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gridbeBindingSource
            // 
            this.gridbeBindingSource.DataSource = typeof(ZH3_HJTN5S.Gridbe);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPlus.Location = new System.Drawing.Point(917, 144);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(61, 56);
            this.buttonPlus.TabIndex = 5;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinus.Location = new System.Drawing.Point(917, 227);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(61, 56);
            this.buttonMinus.TabIndex = 6;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonExcel
            // 
            this.buttonExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExcel.Location = new System.Drawing.Point(902, 382);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(85, 37);
            this.buttonExcel.TabIndex = 7;
            this.buttonExcel.Text = "Excel";
            this.buttonExcel.UseVisualStyleBackColor = true;
            this.buttonExcel.Click += new System.EventHandler(this.buttonExcel_Click);
            // 
            // buttonSuppliers
            // 
            this.buttonSuppliers.Location = new System.Drawing.Point(485, 46);
            this.buttonSuppliers.Name = "buttonSuppliers";
            this.buttonSuppliers.Size = new System.Drawing.Size(75, 23);
            this.buttonSuppliers.TabIndex = 8;
            this.buttonSuppliers.Text = "Suppliers";
            this.buttonSuppliers.UseVisualStyleBackColor = true;
            this.buttonSuppliers.Click += new System.EventHandler(this.buttonSuppliers_Click);
            // 
            // buttonEmployees
            // 
            this.buttonEmployees.Location = new System.Drawing.Point(742, 46);
            this.buttonEmployees.Name = "buttonEmployees";
            this.buttonEmployees.Size = new System.Drawing.Size(75, 23);
            this.buttonEmployees.TabIndex = 9;
            this.buttonEmployees.Text = "Employees";
            this.buttonEmployees.UseVisualStyleBackColor = true;
            this.buttonEmployees.Click += new System.EventHandler(this.buttonEmployees_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 450);
            this.Controls.Add(this.buttonEmployees);
            this.Controls.Add(this.buttonSuppliers);
            this.Controls.Add(this.buttonExcel);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBoxOrders);
            this.Controls.Add(this.listBoxCustomers);
            this.Controls.Add(this.textBoxOrders);
            this.Controls.Add(this.textBoxCustomers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridbeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxCustomers;
        private TextBox textBoxOrders;
        private ListBox listBoxCustomers;
        private DataGridView dataGridView1;
        private Button buttonPlus;
        private Button buttonMinus;
        private Button buttonExcel;
        private DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn productIdDataGridViewTextBoxColumn;
        private BindingSource productsBindingSource;
        private DataGridViewTextBoxColumn productPerUnitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private BindingSource gridbeBindingSource;
        private Button buttonSuppliers;
        private ListBox listBoxOrders;
        private Button buttonEmployees;
    }
}