namespace Procesos_Hilos
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
            this.img1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.img2 = new System.Windows.Forms.PictureBox();
            this.img3 = new System.Windows.Forms.PictureBox();
            this.img4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.procesadorImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img4)).BeginInit();
            this.SuspendLayout();
            // 
            // procesadorImg
            // 
            this.procesadorImg.Image = global::Procesos_Hilos.Properties.Resources.procesador;
            this.procesadorImg.Location = new System.Drawing.Point(513, 123);
            this.procesadorImg.Name = "procesadorImg";
            this.procesadorImg.Size = new System.Drawing.Size(205, 190);
            this.procesadorImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.procesadorImg.TabIndex = 0;
            this.procesadorImg.TabStop = false;
            // 
            // img1
            // 
            this.img1.Image = global::Procesos_Hilos.Properties.Resources.proceso;
            this.img1.Location = new System.Drawing.Point(44, 67);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(90, 86);
            this.img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img1.TabIndex = 1;
            this.img1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(96)))), ((int)(((byte)(97)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tarea";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // img2
            // 
            this.img2.Image = global::Procesos_Hilos.Properties.Resources.proceso;
            this.img2.Location = new System.Drawing.Point(44, 159);
            this.img2.Name = "img2";
            this.img2.Size = new System.Drawing.Size(90, 86);
            this.img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img2.TabIndex = 3;
            this.img2.TabStop = false;
            // 
            // img3
            // 
            this.img3.Image = global::Procesos_Hilos.Properties.Resources.proceso;
            this.img3.Location = new System.Drawing.Point(44, 251);
            this.img3.Name = "img3";
            this.img3.Size = new System.Drawing.Size(90, 86);
            this.img3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img3.TabIndex = 4;
            this.img3.TabStop = false;
            // 
            // img4
            // 
            this.img4.Image = global::Procesos_Hilos.Properties.Resources.proceso;
            this.img4.Location = new System.Drawing.Point(44, 343);
            this.img4.Name = "img4";
            this.img4.Size = new System.Drawing.Size(90, 86);
            this.img4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img4.TabIndex = 5;
            this.img4.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.img4);
            this.Controls.Add(this.img3);
            this.Controls.Add(this.img2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.img1);
            this.Controls.Add(this.procesadorImg);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.procesadorImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox procesadorImg;
        private System.Windows.Forms.PictureBox img1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox img2;
        private System.Windows.Forms.PictureBox img3;
        private System.Windows.Forms.PictureBox img4;
    }
}