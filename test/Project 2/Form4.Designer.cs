namespace Project_2
{
    partial class Form4
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
            this.search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.prim = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ordersb = new System.Windows.Forms.Button();
            this.updateb = new System.Windows.Forms.Button();
            this.exitb = new System.Windows.Forms.Button();
            this.backb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(316, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ассортимент\r\n    лекарств";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(346, 61);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(132, 20);
            this.search.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(274, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Поиск:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Способ применения";
            // 
            // prim
            // 
            this.prim.FormattingEnabled = true;
            this.prim.Items.AddRange(new object[] {
            "Наружный",
            "Внутренний",
            "Оба",
            "Без фильтрации"});
            this.prim.Location = new System.Drawing.Point(337, 113);
            this.prim.Name = "prim";
            this.prim.Size = new System.Drawing.Size(121, 21);
            this.prim.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Категория:";
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Items.AddRange(new object[] {
            "Все"});
            this.category.Location = new System.Drawing.Point(337, 156);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(121, 21);
            this.category.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(736, 246);
            this.dataGridView1.TabIndex = 11;
            // 
            // ordersb
            // 
            this.ordersb.Location = new System.Drawing.Point(27, 446);
            this.ordersb.Name = "ordersb";
            this.ordersb.Size = new System.Drawing.Size(75, 40);
            this.ordersb.TabIndex = 12;
            this.ordersb.Text = "Текущие\r\nзаказы";
            this.ordersb.UseVisualStyleBackColor = true;
            // 
            // updateb
            // 
            this.updateb.Location = new System.Drawing.Point(666, 446);
            this.updateb.Name = "updateb";
            this.updateb.Size = new System.Drawing.Size(97, 29);
            this.updateb.TabIndex = 13;
            this.updateb.Text = "Обновить";
            this.updateb.UseVisualStyleBackColor = true;
            // 
            // exitb
            // 
            this.exitb.Location = new System.Drawing.Point(346, 547);
            this.exitb.Name = "exitb";
            this.exitb.Size = new System.Drawing.Size(75, 23);
            this.exitb.TabIndex = 15;
            this.exitb.Text = "Выход";
            this.exitb.UseVisualStyleBackColor = true;
            this.exitb.Click += new System.EventHandler(this.exitb_Click);
            // 
            // backb
            // 
            this.backb.Location = new System.Drawing.Point(346, 495);
            this.backb.Name = "backb";
            this.backb.Size = new System.Drawing.Size(75, 23);
            this.backb.TabIndex = 14;
            this.backb.Text = "Назад";
            this.backb.UseVisualStyleBackColor = true;
            this.backb.Click += new System.EventHandler(this.backb_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 591);
            this.Controls.Add(this.exitb);
            this.Controls.Add(this.backb);
            this.Controls.Add(this.updateb);
            this.Controls.Add(this.ordersb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.category);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prim);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox prim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ordersb;
        private System.Windows.Forms.Button updateb;
        private System.Windows.Forms.Button exitb;
        private System.Windows.Forms.Button backb;
    }
}