namespace Project_2
{
    partial class Form7
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.exitb = new System.Windows.Forms.Button();
            this.backb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(21, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(110, 303);
            this.listBox1.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(146, 56);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(378, 303);
            this.webBrowser1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(193, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Справочник";
            // 
            // exitb
            // 
            this.exitb.Location = new System.Drawing.Point(210, 417);
            this.exitb.Name = "exitb";
            this.exitb.Size = new System.Drawing.Size(75, 23);
            this.exitb.TabIndex = 22;
            this.exitb.Text = "Выход";
            this.exitb.UseVisualStyleBackColor = true;
            this.exitb.Click += new System.EventHandler(this.exitb_Click);
            // 
            // backb
            // 
            this.backb.Location = new System.Drawing.Point(210, 376);
            this.backb.Name = "backb";
            this.backb.Size = new System.Drawing.Size(75, 23);
            this.backb.TabIndex = 21;
            this.backb.Text = "Назад";
            this.backb.UseVisualStyleBackColor = true;
            this.backb.Click += new System.EventHandler(this.backb_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 450);
            this.Controls.Add(this.exitb);
            this.Controls.Add(this.backb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitb;
        private System.Windows.Forms.Button backb;
    }
}