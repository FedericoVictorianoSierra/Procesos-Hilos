﻿
namespace Procesos_Hilos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.procesadorImg = new System.Windows.Forms.PictureBox();
            this.procesoImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.procesadorImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procesoImg)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(96)))), ((int)(((byte)(97)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tarea";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // procesadorImg
            // 
            this.procesadorImg.BackColor = System.Drawing.Color.Transparent;
            this.procesadorImg.Image = global::Procesos_Hilos.Properties.Resources.procesador;
            this.procesadorImg.Location = new System.Drawing.Point(453, 121);
            this.procesadorImg.Name = "procesadorImg";
            this.procesadorImg.Size = new System.Drawing.Size(309, 182);
            this.procesadorImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.procesadorImg.TabIndex = 1;
            this.procesadorImg.TabStop = false;
            // 
            // procesoImg
            // 
            this.procesoImg.BackColor = System.Drawing.Color.Transparent;
            this.procesoImg.Image = global::Procesos_Hilos.Properties.Resources.proceso;
            this.procesoImg.Location = new System.Drawing.Point(109, 121);
            this.procesoImg.Name = "procesoImg";
            this.procesoImg.Size = new System.Drawing.Size(114, 115);
            this.procesoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.procesoImg.TabIndex = 2;
            this.procesoImg.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.procesoImg);
            this.Controls.Add(this.procesadorImg);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.procesadorImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procesoImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox procesadorImg;
        private System.Windows.Forms.PictureBox procesoImg;
    }
}

