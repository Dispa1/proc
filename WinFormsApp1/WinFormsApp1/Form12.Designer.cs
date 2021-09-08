
using System;

namespace WinFormsApp1
{
    partial class Form12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            this.Formyla = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Box1 = new System.Windows.Forms.TextBox();
            this.Box2 = new System.Windows.Forms.TextBox();
            this.Box3 = new System.Windows.Forms.TextBox();
            this.Primer = new System.Windows.Forms.PictureBox();
            this.Reshit1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Formyla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Primer)).BeginInit();
            this.SuspendLayout();
            // 
            // Formyla
            // 
            this.Formyla.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Formyla.BackgroundImage")));
            this.Formyla.Location = new System.Drawing.Point(10, 18);
            this.Formyla.Name = "Formyla";
            this.Formyla.Size = new System.Drawing.Size(488, 119);
            this.Formyla.TabIndex = 0;
            this.Formyla.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Введите n";
            // 
            // Box1
            // 
            this.Box1.Location = new System.Drawing.Point(96, 234);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(100, 23);
            this.Box1.TabIndex = 4;
            this.Box1.TextChanged += new System.EventHandler(this.A1_TextChanged);
            // 
            // Box2
            // 
            this.Box2.Location = new System.Drawing.Point(96, 263);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(100, 23);
            this.Box2.TabIndex = 5;
            this.Box2.TextChanged += new System.EventHandler(this.B1_TextChanged);
            // 
            // Box3
            // 
            this.Box3.Location = new System.Drawing.Point(96, 292);
            this.Box3.Name = "Box3";
            this.Box3.Size = new System.Drawing.Size(100, 23);
            this.Box3.TabIndex = 6;
            this.Box3.TextChanged += new System.EventHandler(this.N1_TextChanged);
            // 
            // Primer
            // 
            this.Primer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Primer.BackgroundImage")));
            this.Primer.Location = new System.Drawing.Point(10, 143);
            this.Primer.Name = "Primer";
            this.Primer.Size = new System.Drawing.Size(241, 85);
            this.Primer.TabIndex = 7;
            this.Primer.TabStop = false;
            // 
            // Reshit1
            // 
            this.Reshit1.Location = new System.Drawing.Point(121, 321);
            this.Reshit1.Name = "Reshit1";
            this.Reshit1.Size = new System.Drawing.Size(75, 23);
            this.Reshit1.TabIndex = 8;
            this.Reshit1.Text = "Решить";
            this.Reshit1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ответ: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 483);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Reshit1);
            this.Controls.Add(this.Primer);
            this.Controls.Add(this.Box3);
            this.Controls.Add(this.Box2);
            this.Controls.Add(this.Box1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Formyla);
            this.Name = "Form12";
            this.Text = "Решение функции";
            ((System.ComponentModel.ISupportInitialize)(this.Formyla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Primer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void NewMethod() => this.Reshit1.Click += new System.EventHandler(this.Reshit1_Click);

        private void Reshit1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox Formyla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Box1;
        private System.Windows.Forms.TextBox Box2;
        private System.Windows.Forms.TextBox Box3;
        private System.Windows.Forms.PictureBox Primer;
        private System.Windows.Forms.Button Reshit1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

