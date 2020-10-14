namespace project_org
{
    partial class Form3
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
            this.exitb = new System.Windows.Forms.Button();
            this.backb = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.projectorgequipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.learnDBDataSet = new project_org.LearnDBDataSet();
            this.bdelete = new System.Windows.Forms.Button();
            this.editb = new System.Windows.Forms.Button();
            this.addb = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.projectorg_equipmentTableAdapter = new project_org.LearnDBDataSetTableAdapters.projectorg_equipmentTableAdapter();
            this.projectorg_employersTableAdapter1 = new project_org.LearnDBDataSetTableAdapters.projectorg_employersTableAdapter();
            this.projectorg_contractsTableAdapter1 = new project_org.LearnDBDataSetTableAdapters.projectorg_contractsTableAdapter();
            this.projectorg_customersTableAdapter1 = new project_org.LearnDBDataSetTableAdapters.projectorg_customersTableAdapter();
            this.projectorg_departmentsTableAdapter1 = new project_org.LearnDBDataSetTableAdapters.projectorg_departmentsTableAdapter();
            this.projectorg_equipmentTableAdapter1 = new project_org.LearnDBDataSetTableAdapters.projectorg_equipmentTableAdapter();
            this.projectorg_ownershipTableAdapter1 = new project_org.LearnDBDataSetTableAdapters.projectorg_ownershipTableAdapter();
            this.projectorg_projectsTableAdapter1 = new project_org.LearnDBDataSetTableAdapters.projectorg_projectsTableAdapter();
            this.projectorg_rolesTableAdapter1 = new project_org.LearnDBDataSetTableAdapters.projectorg_rolesTableAdapter();
            this.projectorg_statusesTableAdapter1 = new project_org.LearnDBDataSetTableAdapters.projectorg_statusesTableAdapter();
            this.projectorg_usersTableAdapter1 = new project_org.LearnDBDataSetTableAdapters.projectorg_usersTableAdapter();
            this.projectorg_workonprojectTableAdapter1 = new project_org.LearnDBDataSetTableAdapters.projectorg_workonprojectTableAdapter();
            this.projectorgemployersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectorgcustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectorgcontractsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectorgprojectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectorgdepartmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectorgstatusesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectorgownershipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectorgusersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.findb = new System.Windows.Forms.Button();
            this.updateb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectorgequipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectorgemployersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectorgcustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectorgcontractsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectorgprojectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectorgdepartmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectorgstatusesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectorgownershipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectorgusersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // exitb
            // 
            this.exitb.Location = new System.Drawing.Point(393, 530);
            this.exitb.Name = "exitb";
            this.exitb.Size = new System.Drawing.Size(75, 23);
            this.exitb.TabIndex = 33;
            this.exitb.Text = "Выход";
            this.exitb.UseVisualStyleBackColor = true;
            this.exitb.Click += new System.EventHandler(this.exitb_Click);
            // 
            // backb
            // 
            this.backb.Location = new System.Drawing.Point(393, 478);
            this.backb.Name = "backb";
            this.backb.Size = new System.Drawing.Size(75, 23);
            this.backb.TabIndex = 32;
            this.backb.Text = "Назад";
            this.backb.UseVisualStyleBackColor = true;
            this.backb.Click += new System.EventHandler(this.backb_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(82, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(736, 246);
            this.dataGridView1.TabIndex = 31;
            // 
            // projectorgequipmentBindingSource
            // 
            this.projectorgequipmentBindingSource.DataMember = "projectorg_equipment";
            this.projectorgequipmentBindingSource.DataSource = this.learnDBDataSet;
            // 
            // learnDBDataSet
            // 
            this.learnDBDataSet.DataSetName = "LearnDBDataSet";
            this.learnDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdelete
            // 
            this.bdelete.BackColor = System.Drawing.Color.Red;
            this.bdelete.Location = new System.Drawing.Point(721, 373);
            this.bdelete.Name = "bdelete";
            this.bdelete.Size = new System.Drawing.Size(97, 29);
            this.bdelete.TabIndex = 30;
            this.bdelete.Text = "Удалить";
            this.bdelete.UseVisualStyleBackColor = false;
            this.bdelete.Click += new System.EventHandler(this.bdelete_Click);
            // 
            // editb
            // 
            this.editb.Location = new System.Drawing.Point(82, 408);
            this.editb.Name = "editb";
            this.editb.Size = new System.Drawing.Size(119, 29);
            this.editb.TabIndex = 29;
            this.editb.Text = "Изменить данные";
            this.editb.UseVisualStyleBackColor = true;
            this.editb.Click += new System.EventHandler(this.editb_Click);
            // 
            // addb
            // 
            this.addb.Location = new System.Drawing.Point(82, 373);
            this.addb.Name = "addb";
            this.addb.Size = new System.Drawing.Size(119, 29);
            this.addb.TabIndex = 28;
            this.addb.Text = "+ Добавить данные";
            this.addb.UseVisualStyleBackColor = true;
            this.addb.Click += new System.EventHandler(this.addb_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(377, 46);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(132, 20);
            this.search.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(305, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Поиск:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(385, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Undefined";
            // 
            // projectorg_equipmentTableAdapter
            // 
            this.projectorg_equipmentTableAdapter.ClearBeforeFill = true;
            // 
            // projectorg_employersTableAdapter1
            // 
            this.projectorg_employersTableAdapter1.ClearBeforeFill = true;
            // 
            // projectorg_contractsTableAdapter1
            // 
            this.projectorg_contractsTableAdapter1.ClearBeforeFill = true;
            // 
            // projectorg_customersTableAdapter1
            // 
            this.projectorg_customersTableAdapter1.ClearBeforeFill = true;
            // 
            // projectorg_departmentsTableAdapter1
            // 
            this.projectorg_departmentsTableAdapter1.ClearBeforeFill = true;
            // 
            // projectorg_equipmentTableAdapter1
            // 
            this.projectorg_equipmentTableAdapter1.ClearBeforeFill = true;
            // 
            // projectorg_ownershipTableAdapter1
            // 
            this.projectorg_ownershipTableAdapter1.ClearBeforeFill = true;
            // 
            // projectorg_projectsTableAdapter1
            // 
            this.projectorg_projectsTableAdapter1.ClearBeforeFill = true;
            // 
            // projectorg_rolesTableAdapter1
            // 
            this.projectorg_rolesTableAdapter1.ClearBeforeFill = true;
            // 
            // projectorg_statusesTableAdapter1
            // 
            this.projectorg_statusesTableAdapter1.ClearBeforeFill = true;
            // 
            // projectorg_usersTableAdapter1
            // 
            this.projectorg_usersTableAdapter1.ClearBeforeFill = true;
            // 
            // projectorg_workonprojectTableAdapter1
            // 
            this.projectorg_workonprojectTableAdapter1.ClearBeforeFill = true;
            // 
            // projectorgemployersBindingSource
            // 
            this.projectorgemployersBindingSource.DataMember = "projectorg_employers";
            this.projectorgemployersBindingSource.DataSource = this.learnDBDataSet;
            // 
            // projectorgcustomersBindingSource
            // 
            this.projectorgcustomersBindingSource.DataMember = "projectorg_customers";
            this.projectorgcustomersBindingSource.DataSource = this.learnDBDataSet;
            // 
            // projectorgcontractsBindingSource
            // 
            this.projectorgcontractsBindingSource.DataMember = "projectorg_contracts";
            this.projectorgcontractsBindingSource.DataSource = this.learnDBDataSet;
            // 
            // projectorgprojectsBindingSource
            // 
            this.projectorgprojectsBindingSource.DataMember = "projectorg_projects";
            this.projectorgprojectsBindingSource.DataSource = this.learnDBDataSet;
            // 
            // projectorgdepartmentsBindingSource
            // 
            this.projectorgdepartmentsBindingSource.DataMember = "projectorg_departments";
            this.projectorgdepartmentsBindingSource.DataSource = this.learnDBDataSet;
            // 
            // projectorgstatusesBindingSource
            // 
            this.projectorgstatusesBindingSource.DataMember = "projectorg_statuses";
            this.projectorgstatusesBindingSource.DataSource = this.learnDBDataSet;
            // 
            // projectorgownershipBindingSource
            // 
            this.projectorgownershipBindingSource.DataMember = "projectorg_ownership";
            this.projectorgownershipBindingSource.DataSource = this.learnDBDataSet;
            // 
            // projectorgusersBindingSource
            // 
            this.projectorgusersBindingSource.DataMember = "projectorg_users";
            this.projectorgusersBindingSource.DataSource = this.learnDBDataSet;
            // 
            // findb
            // 
            this.findb.Location = new System.Drawing.Point(525, 44);
            this.findb.Name = "findb";
            this.findb.Size = new System.Drawing.Size(75, 23);
            this.findb.TabIndex = 34;
            this.findb.Text = "Найти";
            this.findb.UseVisualStyleBackColor = true;
            this.findb.Click += new System.EventHandler(this.findb_Click);
            // 
            // updateb
            // 
            this.updateb.Location = new System.Drawing.Point(207, 373);
            this.updateb.Name = "updateb";
            this.updateb.Size = new System.Drawing.Size(119, 29);
            this.updateb.TabIndex = 35;
            this.updateb.Text = "Обновить";
            this.updateb.UseVisualStyleBackColor = true;
            this.updateb.Click += new System.EventHandler(this.updateb_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 561);
            this.Controls.Add(this.updateb);
            this.Controls.Add(this.findb);
            this.Controls.Add(this.exitb);
            this.Controls.Add(this.backb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bdelete);
            this.Controls.Add(this.editb);
            this.Controls.Add(this.addb);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectorgequipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectorgemployersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectorgcustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectorgcontractsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectorgprojectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectorgdepartmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectorgstatusesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectorgownershipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectorgusersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitb;
        private System.Windows.Forms.Button backb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bdelete;
        private System.Windows.Forms.Button editb;
        private System.Windows.Forms.Button addb;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private LearnDBDataSet learnDBDataSet;
        private System.Windows.Forms.BindingSource projectorgequipmentBindingSource;
        private LearnDBDataSetTableAdapters.projectorg_equipmentTableAdapter projectorg_equipmentTableAdapter;
        private LearnDBDataSetTableAdapters.projectorg_employersTableAdapter projectorg_employersTableAdapter1;
        private LearnDBDataSetTableAdapters.projectorg_contractsTableAdapter projectorg_contractsTableAdapter1;
        private LearnDBDataSetTableAdapters.projectorg_customersTableAdapter projectorg_customersTableAdapter1;
        private LearnDBDataSetTableAdapters.projectorg_departmentsTableAdapter projectorg_departmentsTableAdapter1;
        private LearnDBDataSetTableAdapters.projectorg_equipmentTableAdapter projectorg_equipmentTableAdapter1;
        private LearnDBDataSetTableAdapters.projectorg_ownershipTableAdapter projectorg_ownershipTableAdapter1;
        private LearnDBDataSetTableAdapters.projectorg_projectsTableAdapter projectorg_projectsTableAdapter1;
        private LearnDBDataSetTableAdapters.projectorg_rolesTableAdapter projectorg_rolesTableAdapter1;
        private LearnDBDataSetTableAdapters.projectorg_statusesTableAdapter projectorg_statusesTableAdapter1;
        private LearnDBDataSetTableAdapters.projectorg_usersTableAdapter projectorg_usersTableAdapter1;
        private LearnDBDataSetTableAdapters.projectorg_workonprojectTableAdapter projectorg_workonprojectTableAdapter1;
        private System.Windows.Forms.BindingSource projectorgemployersBindingSource;
        private System.Windows.Forms.BindingSource projectorgcustomersBindingSource;
        private System.Windows.Forms.BindingSource projectorgcontractsBindingSource;
        private System.Windows.Forms.BindingSource projectorgprojectsBindingSource;
        private System.Windows.Forms.BindingSource projectorgdepartmentsBindingSource;
        private System.Windows.Forms.BindingSource projectorgstatusesBindingSource;
        private System.Windows.Forms.BindingSource projectorgownershipBindingSource;
        private System.Windows.Forms.BindingSource projectorgusersBindingSource;
        private System.Windows.Forms.Button findb;
        private System.Windows.Forms.Button updateb;
    }
}