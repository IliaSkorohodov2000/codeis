﻿namespace Project_2
{
    partial class Form5
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
            this.exitb = new System.Windows.Forms.Button();
            this.ordersb = new System.Windows.Forms.Button();
            this.sprav = new System.Windows.Forms.Button();
            this.sklad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bdb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitb
            // 
            this.exitb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitb.Location = new System.Drawing.Point(125, 380);
            this.exitb.Name = "exitb";
            this.exitb.Size = new System.Drawing.Size(170, 39);
            this.exitb.TabIndex = 11;
            this.exitb.Text = "Выход";
            this.exitb.UseVisualStyleBackColor = true;
            this.exitb.Click += new System.EventHandler(this.exitb_Click);
            // 
            // ordersb
            // 
            this.ordersb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ordersb.Location = new System.Drawing.Point(125, 227);
            this.ordersb.Name = "ordersb";
            this.ordersb.Size = new System.Drawing.Size(170, 39);
            this.ordersb.TabIndex = 10;
            this.ordersb.Text = "Заказы";
            this.ordersb.UseVisualStyleBackColor = true;
            this.ordersb.Click += new System.EventHandler(this.ordersb_Click);
            // 
            // sprav
            // 
            this.sprav.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sprav.Location = new System.Drawing.Point(125, 170);
            this.sprav.Name = "sprav";
            this.sprav.Size = new System.Drawing.Size(170, 39);
            this.sprav.TabIndex = 9;
            this.sprav.Text = "Справочник";
            this.sprav.UseVisualStyleBackColor = true;
            this.sprav.Click += new System.EventHandler(this.sprav_Click);
            // 
            // sklad
            // 
            this.sklad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sklad.Location = new System.Drawing.Point(125, 114);
            this.sklad.Name = "sklad";
            this.sklad.Size = new System.Drawing.Size(170, 39);
            this.sklad.TabIndex = 8;
            this.sklad.Text = "Склад";
            this.sklad.UseVisualStyleBackColor = true;
            this.sklad.Click += new System.EventHandler(this.sklad_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(132, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 51);
            this.label2.TabIndex = 7;
            this.label2.Text = "Выберите \r\nнеобходимый раздел \r\nпри помощи нажатия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(121, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Добро пожаловать!";
            // 
            // bdb
            // 
            this.bdb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bdb.Location = new System.Drawing.Point(125, 285);
            this.bdb.Name = "bdb";
            this.bdb.Size = new System.Drawing.Size(170, 39);
            this.bdb.TabIndex = 12;
            this.bdb.Text = "БД клиентов";
            this.bdb.UseVisualStyleBackColor = true;
            this.bdb.Click += new System.EventHandler(this.bdb_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 450);
            this.Controls.Add(this.bdb);
            this.Controls.Add(this.exitb);
            this.Controls.Add(this.ordersb);
            this.Controls.Add(this.sprav);
            this.Controls.Add(this.sklad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitb;
        private System.Windows.Forms.Button ordersb;
        private System.Windows.Forms.Button sprav;
        private System.Windows.Forms.Button sklad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bdb;
    }
}