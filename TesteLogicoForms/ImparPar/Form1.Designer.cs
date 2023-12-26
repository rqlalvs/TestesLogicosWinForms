namespace ImparPar
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
            this.txtString = new System.Windows.Forms.TextBox();
            this.btnImparPar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(99, 80);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(100, 23);
            this.txtString.TabIndex = 7;
            this.txtString.TextChanged += new System.EventHandler(this.txtString_TextChanged);
            // 
            // btnImparPar
            // 
            this.btnImparPar.Location = new System.Drawing.Point(81, 109);
            this.btnImparPar.Name = "btnImparPar";
            this.btnImparPar.Size = new System.Drawing.Size(140, 41);
            this.btnImparPar.TabIndex = 6;
            this.btnImparPar.Text = "Impar ou Par";
            this.btnImparPar.UseVisualStyleBackColor = true;
            this.btnImparPar.Click += new System.EventHandler(this.btnImparPar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 230);
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.btnImparPar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtString;
        private Button btnImparPar;
    }
}