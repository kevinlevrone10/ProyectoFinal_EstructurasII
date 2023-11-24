namespace ProyectoFinal_EstructurasII
{
    partial class Pedir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedir));
            this.button1 = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.PictureBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtpedir = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ok)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(30)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(141, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 30);
            this.button1.TabIndex = 98;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ok
            // 
            this.ok.ErrorImage = null;
            this.ok.Image = ((System.Drawing.Image)(resources.GetObject("ok.Image")));
            this.ok.Location = new System.Drawing.Point(317, 2);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(50, 33);
            this.ok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ok.TabIndex = 97;
            this.ok.TabStop = false;
            this.ok.Visible = false;
            // 
            // lblMsg
            // 
            this.lblMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.Black;
            this.lblMsg.Location = new System.Drawing.Point(1, 20);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(48, 15);
            this.lblMsg.TabIndex = 95;
            this.lblMsg.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Location = new System.Drawing.Point(-52, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 4);
            this.panel2.TabIndex = 94;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(-52, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 4);
            this.panel1.TabIndex = 93;
            // 
            // txtpedir
            // 
            this.txtpedir.Location = new System.Drawing.Point(141, 66);
            this.txtpedir.Name = "txtpedir";
            this.txtpedir.Size = new System.Drawing.Size(100, 20);
            this.txtpedir.TabIndex = 99;
            // 
            // Pedir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 147);
            this.Controls.Add(this.txtpedir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pedir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedir";
            this.Load += new System.EventHandler(this.Pedir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox ok;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtpedir;
    }
}