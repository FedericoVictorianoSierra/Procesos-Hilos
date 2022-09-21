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
            this.proceso1 = new System.Windows.Forms.PictureBox();
            this.procesadorImg = new System.Windows.Forms.PictureBox();
            this.proceso2 = new System.Windows.Forms.PictureBox();
            this.proceso3 = new System.Windows.Forms.PictureBox();
            this.proceso4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.proceso1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procesadorImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proceso2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proceso3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proceso4)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(96)))), ((int)(((byte)(97)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(26, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tarea";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // proceso1
            // 
            this.proceso1.BackColor = System.Drawing.Color.Transparent;
            this.proceso1.Image = global::Procesos_Hilos.Properties.Resources.proceso;
            this.proceso1.Location = new System.Drawing.Point(75, 76);
            this.proceso1.Name = "proceso1";
            this.proceso1.Size = new System.Drawing.Size(76, 78);
            this.proceso1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.proceso1.TabIndex = 3;
            this.proceso1.TabStop = false;
            // 
            // procesadorImg
            // 
            this.procesadorImg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.procesadorImg.BackColor = System.Drawing.Color.Transparent;
            this.procesadorImg.Image = global::Procesos_Hilos.Properties.Resources.procesador;
            this.procesadorImg.Location = new System.Drawing.Point(402, 76);
            this.procesadorImg.Margin = new System.Windows.Forms.Padding(0);
            this.procesadorImg.Name = "procesadorImg";
            this.procesadorImg.Size = new System.Drawing.Size(358, 328);
            this.procesadorImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.procesadorImg.TabIndex = 4;
            this.procesadorImg.TabStop = false;
            // 
            // proceso2
            // 
            this.proceso2.BackColor = System.Drawing.Color.Transparent;
            this.proceso2.Image = global::Procesos_Hilos.Properties.Resources.proceso;
            this.proceso2.Location = new System.Drawing.Point(75, 174);
            this.proceso2.Name = "proceso2";
            this.proceso2.Size = new System.Drawing.Size(76, 78);
            this.proceso2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.proceso2.TabIndex = 5;
            this.proceso2.TabStop = false;
            // 
            // proceso3
            // 
            this.proceso3.BackColor = System.Drawing.Color.Transparent;
            this.proceso3.Image = global::Procesos_Hilos.Properties.Resources.proceso;
            this.proceso3.Location = new System.Drawing.Point(75, 270);
            this.proceso3.Name = "proceso3";
            this.proceso3.Size = new System.Drawing.Size(76, 78);
            this.proceso3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.proceso3.TabIndex = 6;
            this.proceso3.TabStop = false;
            this.proceso3.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // proceso4
            // 
            this.proceso4.BackColor = System.Drawing.Color.Transparent;
            this.proceso4.Image = global::Procesos_Hilos.Properties.Resources.proceso;
            this.proceso4.Location = new System.Drawing.Point(75, 362);
            this.proceso4.Name = "proceso4";
            this.proceso4.Size = new System.Drawing.Size(76, 78);
            this.proceso4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.proceso4.TabIndex = 7;
            this.proceso4.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(854, 487);
            this.Controls.Add(this.proceso4);
            this.Controls.Add(this.proceso3);
            this.Controls.Add(this.proceso2);
            this.Controls.Add(this.proceso1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.procesadorImg);
            this.Name = "Form3";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proceso1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procesadorImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proceso2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proceso3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proceso4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox proceso1;
        private System.Windows.Forms.PictureBox procesadorImg;
        private System.Windows.Forms.PictureBox proceso2;
        private System.Windows.Forms.PictureBox proceso3;
        private System.Windows.Forms.PictureBox proceso4;
    }
}