namespace WarmUp
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
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnValudar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(104, 42);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(292, 22);
            this.txtPwd.TabIndex = 0;
            // 
            // btnValudar
            // 
            this.btnValudar.Location = new System.Drawing.Point(167, 108);
            this.btnValudar.Name = "btnValudar";
            this.btnValudar.Size = new System.Drawing.Size(140, 23);
            this.btnValudar.TabIndex = 1;
            this.btnValudar.Text = "Ok";
            this.btnValudar.UseVisualStyleBackColor = true;
            this.btnValudar.Click += new System.EventHandler(this.ok);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contraseña";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 206);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnValudar);
            this.Controls.Add(this.txtPwd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btnValudar;
        private System.Windows.Forms.Label label1;
    }
}

