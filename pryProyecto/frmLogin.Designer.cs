namespace pryProyecto
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            pcbImagenLogin = new PictureBox();
            btnAcceder = new Button();
            btnSalir = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbImagenLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 13.8F);
            txtUsuario.Location = new Point(150, 305);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Ingrese el Usuario";
            txtUsuario.Size = new Size(279, 38);
            txtUsuario.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 13.8F);
            txtPassword.Location = new Point(150, 368);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Ingrese la Contraseña";
            txtPassword.Size = new Size(279, 38);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // pcbImagenLogin
            // 
            pcbImagenLogin.Image = Properties.Resources.usuario_icono;
            pcbImagenLogin.Location = new Point(215, 84);
            pcbImagenLogin.Name = "pcbImagenLogin";
            pcbImagenLogin.Size = new Size(166, 193);
            pcbImagenLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbImagenLogin.TabIndex = 2;
            pcbImagenLogin.TabStop = false;
            // 
            // btnAcceder
            // 
            btnAcceder.Font = new Font("Segoe UI", 13.8F);
            btnAcceder.Location = new Point(150, 430);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(118, 42);
            btnAcceder.TabIndex = 3;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = true;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 13.8F);
            btnSalir.Location = new Point(311, 430);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(118, 42);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(124, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(364, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(205, 205, 205);
            ClientSize = new Size(598, 539);
            Controls.Add(pictureBox1);
            Controls.Add(btnSalir);
            Controls.Add(btnAcceder);
            Controls.Add(pcbImagenLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Name = "frmLogin";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pcbImagenLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtPassword;
        private PictureBox pcbImagenLogin;
        private Button btnAcceder;
        private Button btnSalir;
        private PictureBox pictureBox1;
    }
}
