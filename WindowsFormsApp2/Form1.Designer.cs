
namespace WindowsFormsApp2
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testBD1DataSet1 = new WindowsFormsApp2.TestBD1DataSet1();
            this.employeesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.organizationsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.testBD1DataSet = new WindowsFormsApp2.TestBD1DataSet();
            this.organizationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.organizationsTableAdapter = new WindowsFormsApp2.TestBD1DataSetTableAdapters.OrganizationsTableAdapter();
            this.employeesTableAdapter = new WindowsFormsApp2.TestBD1DataSet1TableAdapters.EmployeesTableAdapter();
            this.employeesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewOrganizations = new System.Windows.Forms.DataGridView();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.organizationsIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBD1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBD1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrganizations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.testBD1DataSet1;
            // 
            // testBD1DataSet1
            // 
            this.testBD1DataSet1.DataSetName = "TestBD1DataSet1";
            this.testBD1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource1
            // 
            this.employeesBindingSource1.DataMember = "Employees";
            this.employeesBindingSource1.DataSource = this.testBD1DataSet1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Организации";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(968, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Сотрудники";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(460, 383);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Импорт";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(573, 383);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Экспорт";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // organizationsBindingSource1
            // 
            this.organizationsBindingSource1.DataMember = "Organizations";
            this.organizationsBindingSource1.DataSource = this.testBD1DataSet;
            // 
            // testBD1DataSet
            // 
            this.testBD1DataSet.DataSetName = "TestBD1DataSet";
            this.testBD1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // organizationsBindingSource
            // 
            this.organizationsBindingSource.DataMember = "Organizations";
            this.organizationsBindingSource.DataSource = this.testBD1DataSet;
            // 
            // organizationsTableAdapter
            // 
            this.organizationsTableAdapter.ClearBeforeFill = true;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // employeesBindingSource2
            // 
            this.employeesBindingSource2.DataMember = "Employees";
            this.employeesBindingSource2.DataSource = this.testBD1DataSet1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(599, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Сотрудники";
            // 
            // dataGridViewOrganizations
            // 
            this.dataGridViewOrganizations.AutoGenerateColumns = false;
            this.dataGridViewOrganizations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrganizations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.iNNDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.dataGridViewOrganizations.DataSource = this.organizationsBindingSource;
            this.dataGridViewOrganizations.Location = new System.Drawing.Point(40, 29);
            this.dataGridViewOrganizations.Name = "dataGridViewOrganizations";
            this.dataGridViewOrganizations.RowHeadersWidth = 51;
            this.dataGridViewOrganizations.RowTemplate.Height = 24;
            this.dataGridViewOrganizations.Size = new System.Drawing.Size(269, 321);
            this.dataGridViewOrganizations.TabIndex = 7;
            this.dataGridViewOrganizations.SelectionChanged += new System.EventHandler(this.dataGridViewOrganizations_SelectionChanged);
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.AutoGenerateColumns = false;
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.iINDataGridViewTextBoxColumn,
            this.organizationsIdDataGridViewTextBoxColumn});
            this.dataGridViewEmployees.DataSource = this.employeesBindingSource1;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(396, 29);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.RowHeadersWidth = 51;
            this.dataGridViewEmployees.RowTemplate.Height = 24;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(486, 321);
            this.dataGridViewEmployees.TabIndex = 8;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // iNNDataGridViewTextBoxColumn
            // 
            this.iNNDataGridViewTextBoxColumn.DataPropertyName = "INN";
            this.iNNDataGridViewTextBoxColumn.HeaderText = "INN";
            this.iNNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iNNDataGridViewTextBoxColumn.Name = "iNNDataGridViewTextBoxColumn";
            this.iNNDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            this.middleNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // iINDataGridViewTextBoxColumn
            // 
            this.iINDataGridViewTextBoxColumn.DataPropertyName = "IIN";
            this.iINDataGridViewTextBoxColumn.HeaderText = "IIN";
            this.iINDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iINDataGridViewTextBoxColumn.Name = "iINDataGridViewTextBoxColumn";
            this.iINDataGridViewTextBoxColumn.Width = 125;
            // 
            // organizationsIdDataGridViewTextBoxColumn
            // 
            this.organizationsIdDataGridViewTextBoxColumn.DataPropertyName = "OrganizationsId";
            this.organizationsIdDataGridViewTextBoxColumn.HeaderText = "OrganizationsId";
            this.organizationsIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.organizationsIdDataGridViewTextBoxColumn.Name = "organizationsIdDataGridViewTextBoxColumn";
            this.organizationsIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Controls.Add(this.dataGridViewOrganizations);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Organizations&Employee";
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBD1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBD1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrganizations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private TestBD1DataSet testBD1DataSet;
        private System.Windows.Forms.BindingSource organizationsBindingSource;
        private TestBD1DataSetTableAdapters.OrganizationsTableAdapter organizationsTableAdapter;
        private System.Windows.Forms.BindingSource organizationsBindingSource1;
        private TestBD1DataSet1 testBD1DataSet1;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private TestBD1DataSet1TableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource employeesBindingSource1;
        private System.Windows.Forms.BindingSource employeesBindingSource2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewOrganizations;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn organizationsIdDataGridViewTextBoxColumn;
    }
}

