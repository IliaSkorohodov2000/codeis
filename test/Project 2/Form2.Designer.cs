namespace Project_2
{
    partial class Form2
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
            this.ordersb = new System.Windows.Forms.Button();
            this.assortb = new System.Windows.Forms.Button();
            this.newsb = new System.Windows.Forms.Button();
            this.exitb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(117, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(128, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выберите \r\nнеобходимый раздел \r\nпри помощи нажатия";
            // 
            // ordersb
            // 
            this.ordersb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ordersb.Location = new System.Drawing.Point(121, 114);
            this.ordersb.Name = "ordersb";
            this.ordersb.Size = new System.Drawing.Size(170, 39);
            this.ordersb.TabIndex = 2;
            this.ordersb.Text = "Заказы";
            this.ordersb.UseVisualStyleBackColor = true;
            this.ordersb.Click += new System.EventHandler(this.ordersb_Click);
            // 
            // assortb
            // 
            this.assortb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.assortb.Location = new System.Drawing.Point(121, 170);
            this.assortb.Name = "assortb";
            this.assortb.Size = new System.Drawing.Size(170, 39);
            this.assortb.TabIndex = 3;
            this.assortb.Text = "Ассортимент лекарств";
            this.assortb.UseVisualStyleBackColor = true;
            this.assortb.Click += new System.EventHandler(this.assortb_Click);
            // 
            // newsb
            // 
            this.newsb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newsb.Location = new System.Drawing.Point(121, 227);
            this.newsb.Name = "newsb";
            this.newsb.Size = new System.Drawing.Size(170, 39);
            this.newsb.TabIndex = 4;
            this.newsb.Text = "Новости";
            this.newsb.UseVisualStyleBackColor = true;
            // 
            // exitb
            // 
            this.exitb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitb.Location = new System.Drawing.Point(121, 380);
            this.exitb.Name = "exitb";
            this.exitb.Size = new System.Drawing.Size(170, 39);
            this.exitb.TabIndex = 5;
            this.exitb.Text = "Выход";
            this.exitb.UseVisualStyleBackColor = true;
            this.exitb.Click += new System.EventHandler(this.exitb_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 450);
            this.Controls.Add(this.exitb);
            this.Controls.Add(this.newsb);
            this.Controls.Add(this.assortb);
            this.Controls.Add(this.ordersb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ordersb;
        private System.Windows.Forms.Button assortb;
        private System.Windows.Forms.Button newsb;
        private System.Windows.Forms.Button exitb;
    }
}