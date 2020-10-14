namespace Project_2
{
    partial class Form11
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
            this.delb = new System.Windows.Forms.Button();
            this.editb = new System.Windows.Forms.Button();
            this.addb = new System.Windows.Forms.Button();
            this.exitb = new System.Windows.Forms.Button();
            this.backb = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // delb
            // 
            this.delb.Location = new System.Drawing.Point(26, 439);
            this.delb.Name = "delb";
            this.delb.Size = new System.Drawing.Size(119, 29);
            this.delb.TabIndex = 36;
            this.delb.Text = "- Удалить данные";
            this.delb.UseVisualStyleBackColor = true;
            // 
            // editb
            // 
            this.editb.Location = new System.Drawing.Point(26, 404);
            this.editb.Name = "editb";
            this.editb.Size = new System.Drawing.Size(119, 29);
            this.editb.TabIndex = 35;
            this.editb.Text = "Изменить данные";
            this.editb.UseVisualStyleBackColor = true;
            // 
            // addb
            // 
            this.addb.Location = new System.Drawing.Point(26, 369);
            this.addb.Name = "addb";
            this.addb.Size = new System.Drawing.Size(119, 29);
            this.addb.TabIndex = 34;
            this.addb.Text = "+ Добавить данные";
            this.addb.UseVisualStyleBackColor = true;
            // 
            // exitb
            // 
            this.exitb.Location = new System.Drawing.Point(338, 533);
            this.exitb.Name = "exitb";
            this.exitb.Size = new System.Drawing.Size(75, 23);
            this.exitb.TabIndex = 33;
            this.exitb.Text = "Выход";
            this.exitb.UseVisualStyleBackColor = true;
            // 
            // backb
            // 
            this.backb.Location = new System.Drawing.Point(338, 493);
            this.backb.Name = "backb";
            this.backb.Size = new System.Drawing.Size(75, 23);
            this.backb.TabIndex = 32;
            this.backb.Text = "Назад";
            this.backb.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(665, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 29);
            this.button1.TabIndex = 31;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(736, 246);
            this.dataGridView1.TabIndex = 30;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(325, 55);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(132, 20);
            this.search.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(253, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Поиск:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(312, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "БД клиентов";
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 575);
            this.Controls.Add(this.delb);
            this.Controls.Add(this.editb);
            this.Controls.Add(this.addb);
            this.Controls.Add(this.exitb);
            this.Controls.Add(this.backb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form11";
            this.Text = "Form11";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delb;
        private System.Windows.Forms.Button editb;
        private System.Windows.Forms.Button addb;
        private System.Windows.Forms.Button exitb;
        private System.Windows.Forms.Button backb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}