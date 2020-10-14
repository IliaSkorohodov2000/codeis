namespace Project_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.prim = new System.Windows.Forms.ComboBox();
            this.Filter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.backb = new System.Windows.Forms.Button();
            this.exitb = new System.Windows.Forms.Button();
            this.addb = new System.Windows.Forms.Button();
            this.editb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(339, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заказы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(271, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Поиск:";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(343, 50);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(132, 20);
            this.search.TabIndex = 2;
            // 
            // prim
            // 
            this.prim.FormattingEnabled = true;
            this.prim.Items.AddRange(new object[] {
            "Наружный",
            "Внутренний",
            "Оба",
            "Без фильтрации"});
            this.prim.Location = new System.Drawing.Point(343, 120);
            this.prim.Name = "prim";
            this.prim.Size = new System.Drawing.Size(121, 21);
            this.prim.TabIndex = 3;
            // 
            // Filter
            // 
            this.Filter.FormattingEnabled = true;
            this.Filter.Items.AddRange(new object[] {
            "Текущие",
            "Выполненные",
            "Отклоненные"});
            this.Filter.Location = new System.Drawing.Point(123, 120);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(121, 21);
            this.Filter.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Фильтр заказов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Способ применения";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(736, 246);
            this.dataGridView1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(673, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // backb
            // 
            this.backb.Location = new System.Drawing.Point(343, 477);
            this.backb.Name = "backb";
            this.backb.Size = new System.Drawing.Size(75, 23);
            this.backb.TabIndex = 9;
            this.backb.Text = "Назад";
            this.backb.UseVisualStyleBackColor = true;
            this.backb.Click += new System.EventHandler(this.backb_Click);
            // 
            // exitb
            // 
            this.exitb.Location = new System.Drawing.Point(343, 529);
            this.exitb.Name = "exitb";
            this.exitb.Size = new System.Drawing.Size(75, 23);
            this.exitb.TabIndex = 10;
            this.exitb.Text = "Выход";
            this.exitb.UseVisualStyleBackColor = true;
            this.exitb.Click += new System.EventHandler(this.exitb_Click);
            // 
            // addb
            // 
            this.addb.Enabled = false;
            this.addb.Location = new System.Drawing.Point(34, 434);
            this.addb.Name = "addb";
            this.addb.Size = new System.Drawing.Size(119, 29);
            this.addb.TabIndex = 11;
            this.addb.Text = "+ Добавить заказ";
            this.addb.UseVisualStyleBackColor = true;
            this.addb.Visible = false;
            // 
            // editb
            // 
            this.editb.Enabled = false;
            this.editb.Location = new System.Drawing.Point(34, 469);
            this.editb.Name = "editb";
            this.editb.Size = new System.Drawing.Size(119, 29);
            this.editb.TabIndex = 12;
            this.editb.Text = "Изменить заказ";
            this.editb.UseVisualStyleBackColor = true;
            this.editb.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 574);
            this.Controls.Add(this.editb);
            this.Controls.Add(this.addb);
            this.Controls.Add(this.exitb);
            this.Controls.Add(this.backb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.prim);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.ComboBox prim;
        private System.Windows.Forms.ComboBox Filter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button backb;
        private System.Windows.Forms.Button exitb;
        private System.Windows.Forms.Button addb;
        private System.Windows.Forms.Button editb;
    }
}