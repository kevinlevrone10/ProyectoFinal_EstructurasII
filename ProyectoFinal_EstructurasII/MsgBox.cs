using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Msg
{
    public partial class MsgBox : Form
    {
        public DialogResult DialogResultCustom { get; private set; }
        private Panel panel1;
        private Label lblMsg;
        private FontAwesome.Sharp.IconSplitButton iconSplitButton1;
        private Label lblTitulo;
        private PictureBox ok;
        private Button button1;
        private PictureBox error;
        private Button btnCancelar;
        private PictureBox pregunta;
        private Panel panel2;

        public MsgBox()
        {
            InitializeComponent();
        }


        //Sobrecargamos el constructor con parametros
        public MsgBox(string pTipo, string pMensaje)
        {
            InitializeComponent();
            lblMsg.Text = pMensaje;//cambiamos el text del label por el string que recibimos
            //Condición para mostrar imagen y cambiar color
            switch (pTipo)
            {
                case "ok":
                    lblTitulo.Text = "Exito";//Cambiamos el label titulo  
                    lblTitulo.ForeColor = Color.FromArgb(0, 128, 0); // RGB para verde oscuro

                    // Establecer color de fondo en el Panel (verde)
                    panel1.BackColor = Color.FromArgb(0, 128, 0); // RGB para verde oscuro

                    panel2.BackColor = Color.FromArgb(0, 128, 0); // RGB para verde oscuro
                    ok.Visible = true;//mostramos la imagen
                    break;
                case "error":
                    lblTitulo.Text = "Error";//Cambiamos el label titulo
                    lblTitulo.ForeColor = Color.FromArgb(255, 0, 0);//color de letra
                    panel1.BackColor = Color.FromArgb(255, 0, 0);//panel la primera línea
                    panel2.BackColor = Color.FromArgb(255, 0, 0);//panel la segunda línea
                    error.Visible = true;//mostramos la imagen
                    break;
                case "pregunta":
                    lblTitulo.Text = "Pregunta";//Cambiamos el label titulo
                    lblTitulo.ForeColor = Color.FromArgb(0, 0, 0);//color de letra
                    panel1.BackColor = Color.FromArgb(33, 150, 243);//panel la primera línea
                    panel2.BackColor = Color.FromArgb(33, 150, 243);//panel la segunda línea
                    pregunta.Visible = true;//mostramos la imagen
                    btnCancelar.Visible = true;
                    break;

            }
        }
        //Evento para los botones, cuando el mouse entre en el bóton
        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Button b = sender as Button;
            b.BackColor = Color.Transparent;
            b.ForeColor = Color.FromArgb(0, 111, 230);
        }
        //Evento cuando el mouse sale del bóton
        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button b = sender as Button;
            b.BackColor = Color.FromArgb(0, 111, 230);
            b.ForeColor = Color.White;
        }
        //Evento click del bóton aceptar
        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;//enviamos OK
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;//enviamos cancel.
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgBox));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMsg = new System.Windows.Forms.Label();
            this.iconSplitButton1 = new FontAwesome.Sharp.IconSplitButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pregunta = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregunta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(2, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 4);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Location = new System.Drawing.Point(2, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 4);
            this.panel2.TabIndex = 1;
            // 
            // lblMsg
            // 
            this.lblMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.Black;
            this.lblMsg.Location = new System.Drawing.Point(-1, 78);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(48, 15);
            this.lblMsg.TabIndex = 86;
            this.lblMsg.Text = "label1";
            // 
            // iconSplitButton1
            // 
            this.iconSplitButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconSplitButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconSplitButton1.IconColor = System.Drawing.Color.Black;
            this.iconSplitButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSplitButton1.IconSize = 48;
            this.iconSplitButton1.Name = "iconSplitButton1";
            this.iconSplitButton1.Rotation = 0D;
            this.iconSplitButton1.Size = new System.Drawing.Size(23, 23);
            this.iconSplitButton1.Text = "iconSplitButton1";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(-1, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(48, 15);
            this.lblTitulo.TabIndex = 87;
            this.lblTitulo.Text = "label2";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // ok
            // 
            this.ok.ErrorImage = null;
            this.ok.Image = ((System.Drawing.Image)(resources.GetObject("ok.Image")));
            this.ok.Location = new System.Drawing.Point(242, 1);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(100, 50);
            this.ok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ok.TabIndex = 88;
            this.ok.TabStop = false;
            this.ok.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(30)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(120, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 30);
            this.button1.TabIndex = 89;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // error
            // 
            this.error.ErrorImage = null;
            this.error.Image = ((System.Drawing.Image)(resources.GetObject("error.Image")));
            this.error.Location = new System.Drawing.Point(242, 1);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(100, 50);
            this.error.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.error.TabIndex = 90;
            this.error.TabStop = false;
            this.error.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(30)))));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(227, 118);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 30);
            this.btnCancelar.TabIndex = 91;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pregunta
            // 
            this.pregunta.ErrorImage = null;
            this.pregunta.Image = ((System.Drawing.Image)(resources.GetObject("pregunta.Image")));
            this.pregunta.Location = new System.Drawing.Point(242, 1);
            this.pregunta.Name = "pregunta";
            this.pregunta.Size = new System.Drawing.Size(100, 50);
            this.pregunta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pregunta.TabIndex = 92;
            this.pregunta.TabStop = false;
            this.pregunta.Visible = false;
            this.pregunta.Click += new System.EventHandler(this.pregunta_Click);
            // 
            // MsgBox
            // 
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(341, 154);
            this.Controls.Add(this.pregunta);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.error);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MsgBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MsgBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregunta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MsgBox_Load(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResultCustom = DialogResult.Yes;
            Close();
        }

        private void pregunta_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResultCustom = DialogResult.No;
            Close();
        }
    }
}