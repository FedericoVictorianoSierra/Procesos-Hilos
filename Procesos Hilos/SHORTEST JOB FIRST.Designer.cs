﻿namespace Procesos_Hilos
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
            this.procesadorImg = new System.Windows.Forms.PictureBox();
            this.img0 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.img1 = new System.Windows.Forms.PictureBox();
            this.img2 = new System.Windows.Forms.PictureBox();
            this.img3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.procesadorImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img3)).BeginInit();
            this.SuspendLayout();
            // 
            // procesadorImg
            // 
            this.procesadorImg.Image = global::Procesos_Hilos.Properties.Resources.procesador;
            this.procesadorImg.Location = new System.Drawing.Point(264, 29);
            this.procesadorImg.Margin = new System.Windows.Forms.Padding(2);
            this.procesadorImg.Name = "procesadorImg";
            this.procesadorImg.Size = new System.Drawing.Size(325, 320);
            this.procesadorImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.procesadorImg.TabIndex = 0;
            this.procesadorImg.TabStop = false;
            // 
            // img0
            // 
            this.img0.Image = global::Procesos_Hilos.Properties.Resources.proceso;
            this.img0.Location = new System.Drawing.Point(33, 54);
            this.img0.Margin = new System.Windows.Forms.Padding(2);
            this.img0.Name = "img0";
            this.img0.Size = new System.Drawing.Size(68, 70);
            this.img0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img0.TabIndex = 1;
            this.img0.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(96)))), ((int)(((byte)(97)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(10, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tarea";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // img1
            // 
            this.img1.Image = global::Procesos_Hilos.Properties.Resources.proceso;
            this.img1.Location = new System.Drawing.Point(33, 129);
            this.img1.Margin = new System.Windows.Forms.Padding(2);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(68, 70);
            this.img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img1.TabIndex = 3;
            this.img1.TabStop = false;
            // 
            // img2
            // 
            this.img2.Image = global::Procesos_Hilos.Properties.Resources.proceso;
            this.img2.Location = new System.Drawing.Point(33, 204);
            this.img2.Margin = new System.Windows.Forms.Padding(2);
            this.img2.Name = "img2";
            this.img2.Size = new System.Drawing.Size(68, 70);
            this.img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img2.TabIndex = 4;
            this.img2.TabStop = false;
            // 
            // img3
            // 
            this.img3.Image = global::Procesos_Hilos.Properties.Resources.proceso;
            this.img3.Location = new System.Drawing.Point(33, 279);
            this.img3.Margin = new System.Windows.Forms.Padding(2);
            this.img3.Name = "img3";
            this.img3.Size = new System.Drawing.Size(68, 70);
            this.img3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img3.TabIndex = 5;
            this.img3.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.img3);
            this.Controls.Add(this.img2);
            this.Controls.Add(this.img1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.img0);
            this.Controls.Add(this.procesadorImg);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.procesadorImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox procesadorImg;
        private System.Windows.Forms.PictureBox img0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox img1;
        private System.Windows.Forms.PictureBox img2;
        private System.Windows.Forms.PictureBox img3;
    }
}