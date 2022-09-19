namespace Procesos_Hilos
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
            this.button1 = new System.Windows.Forms.Button();
            this.procesoImg = new System.Windows.Forms.PictureBox();
            this.procesadorImg = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.procesoImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procesadorImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(96)))), ((int)(((byte)(97)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(35, 36);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tarea";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // procesoImg
            // 
            this.procesoImg.BackColor = System.Drawing.Color.Transparent;
            this.procesoImg.Image = global::Procesos_Hilos.Properties.Resources.proceso;
            this.procesoImg.Location = new System.Drawing.Point(100, 129);
            this.procesoImg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.procesoImg.Name = "procesoImg";
            this.procesoImg.Size = new System.Drawing.Size(101, 96);
            this.procesoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.procesoImg.TabIndex = 3;
            this.procesoImg.TabStop = false;
            // 
            // procesadorImg
            // 
            this.procesadorImg.BackColor = System.Drawing.Color.Transparent;
            this.procesadorImg.Image = global::Procesos_Hilos.Properties.Resources.procesador;
            this.procesadorImg.Location = new System.Drawing.Point(476, 93);
            this.procesadorImg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.procesadorImg.Name = "procesadorImg";
            this.procesadorImg.Size = new System.Drawing.Size(645, 448);
            this.procesadorImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.procesadorImg.TabIndex = 4;
            this.procesadorImg.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Procesos_Hilos.Properties.Resources.proceso;
            this.pictureBox1.Location = new System.Drawing.Point(100, 266);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Procesos_Hilos.Properties.Resources.proceso;
            this.pictureBox2.Location = new System.Drawing.Point(100, 405);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(101, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.procesadorImg);
            this.Controls.Add(this.procesoImg);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.procesoImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procesadorImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox procesoImg;
        private System.Windows.Forms.PictureBox procesadorImg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}