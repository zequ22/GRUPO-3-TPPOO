namespace VISTA
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.btnSALIR = new System.Windows.Forms.Button();
            this.btnINGRESAR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCONTRASEÑA = new System.Windows.Forms.TextBox();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSALIR
            // 
            this.btnSALIR.Location = new System.Drawing.Point(126, 90);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(100, 23);
            this.btnSALIR.TabIndex = 11;
            this.btnSALIR.Text = "Salir";
            this.btnSALIR.UseVisualStyleBackColor = true;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // btnINGRESAR
            // 
            this.btnINGRESAR.Location = new System.Drawing.Point(17, 90);
            this.btnINGRESAR.Name = "btnINGRESAR";
            this.btnINGRESAR.Size = new System.Drawing.Size(100, 23);
            this.btnINGRESAR.TabIndex = 10;
            this.btnINGRESAR.Text = "Ingresar";
            this.btnINGRESAR.UseVisualStyleBackColor = true;
            this.btnINGRESAR.Click += new System.EventHandler(this.btnINGRESAR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre:";
            // 
            // txtCONTRASEÑA
            // 
            this.txtCONTRASEÑA.Location = new System.Drawing.Point(84, 55);
            this.txtCONTRASEÑA.Name = "txtCONTRASEÑA";
            this.txtCONTRASEÑA.PasswordChar = '*';
            this.txtCONTRASEÑA.Size = new System.Drawing.Size(142, 20);
            this.txtCONTRASEÑA.TabIndex = 7;
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.Location = new System.Drawing.Point(84, 12);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.Size = new System.Drawing.Size(142, 20);
            this.txtNOMBRE.TabIndex = 6;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(246, 128);
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.btnINGRESAR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCONTRASEÑA);
            this.Controls.Add(this.txtNOMBRE);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.Text = "Inicio de Sesion";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSALIR;
        private System.Windows.Forms.Button btnINGRESAR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCONTRASEÑA;
        private System.Windows.Forms.TextBox txtNOMBRE;
    }
}