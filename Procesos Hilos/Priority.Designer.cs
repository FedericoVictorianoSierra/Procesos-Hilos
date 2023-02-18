namespace Procesos_Hilos
{
    partial class Priority
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
            this.button1 = new System.Windows.Forms.Button();
            this.img3 = new System.Windows.Forms.PictureBox();
            this.img2 = new System.Windows.Forms.PictureBox();
            this.img1 = new System.Windows.Forms.PictureBox();
            this.img0 = new System.Windows.Forms.PictureBox();
            this.procesadorImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procesadorImg)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(96)))), ((int)(((byte)(97)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(26, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // img3
            // 
            this.img3.Image = global::Procesos_Hilos.Properties.Resources.proceso;
            this.img3.Location = new System.Drawing.Point(63, 287);
            this.img3.Margin = new System.Windows.Forms.Padding(2);
            this.img3.Name = "img3";
            this.img3.Size = new System.Drawing.Size(68, 70);
            this.img3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img3.TabIndex = 15;
            this.img3.TabStop = false;
            // 
            // img2
            // 
            this.img2.Image = global::Procesos_Hilos.Properties.Resources.proceso;
            this.img2.Location = new System.Drawing.Point(63, 212);
            this.img2.Margin = new System.Windows.Forms.Padding(2);
            this.img2.Name = "img2";
            this.img2.Size = new System.Drawing.Size(68, 70);
            this.img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img2.TabIndex = 14;
            this.img2.TabStop = false;
            // 
            // img1
            // 
            this.img1.Image = global::Procesos_Hilos.Properties.Resources.proceso;
            this.img1.Location = new System.Drawing.Point(63, 137);
            this.img1.Margin = new System.Windows.Forms.Padding(2);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(68, 70);
            this.img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img1.TabIndex = 13;
            this.img1.TabStop = false;
            // 
            // img0
            // 
            this.img0.Image = global::Procesos_Hilos.Properties.Resources.proceso;
            this.img0.Location = new System.Drawing.Point(63, 62);
            this.img0.Margin = new System.Windows.Forms.Padding(2);
            this.img0.Name = "img0";
            this.img0.Size = new System.Drawing.Size(68, 70);
            this.img0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img0.TabIndex = 11;
            this.img0.TabStop = false;
            // 
            // procesadorImg
            // 
            this.procesadorImg.Image = global::Procesos_Hilos.Properties.Resources.procesador;
            this.procesadorImg.Location = new System.Drawing.Point(280, 37);
            this.procesadorImg.Margin = new System.Windows.Forms.Padding(2);
            this.procesadorImg.Name = "procesadorImg";
            this.procesadorImg.Size = new System.Drawing.Size(325, 320);
            this.procesadorImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.procesadorImg.TabIndex = 10;
            this.procesadorImg.TabStop = false;
            // 
            // Priority
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 397);
            this.Controls.Add(this.img3);
            this.Controls.Add(this.img2);
            this.Controls.Add(this.img1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.img0);
            this.Controls.Add(this.procesadorImg);
            this.Name = "Priority";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Priority_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procesadorImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox img3;
        private System.Windows.Forms.PictureBox img2;
        private System.Windows.Forms.PictureBox img1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox img0;
        private System.Windows.Forms.PictureBox procesadorImg;
    }
}