﻿namespace ConverterNumeros
{
    partial class Form1
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
            this.btnConverterNumeros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConverterNumeros
            // 
            this.btnConverterNumeros.Location = new System.Drawing.Point(60, 68);
            this.btnConverterNumeros.Name = "btnConverterNumeros";
            this.btnConverterNumeros.Size = new System.Drawing.Size(141, 46);
            this.btnConverterNumeros.TabIndex = 4;
            this.btnConverterNumeros.Text = "Converter Numeros";
            this.btnConverterNumeros.UseVisualStyleBackColor = true;
            this.btnConverterNumeros.Click += new System.EventHandler(this.btnConverterNumeros_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 194);
            this.Controls.Add(this.btnConverterNumeros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnConverterNumeros;
    }
}