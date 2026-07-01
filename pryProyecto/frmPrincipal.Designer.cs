namespace pryProyecto
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            pcbMenu = new PictureBox();
            pcbTitulo = new PictureBox();
            pcbAlumnos = new PictureBox();
            pcbCarreras = new PictureBox();
            pcbUsuario = new PictureBox();
            pcbDocente = new PictureBox();
            pnlContenedor = new Panel();
            pcbTutores = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbTitulo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbAlumnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbCarreras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbDocente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbTutores).BeginInit();
            SuspendLayout();
            // 
            // pcbMenu
            // 
            pcbMenu.AccessibleRole = AccessibleRole.None;
            pcbMenu.BackColor = Color.Transparent;
            pcbMenu.Image = (Image)resources.GetObject("pcbMenu.Image");
            pcbMenu.Location = new Point(12, 11);
            pcbMenu.Name = "pcbMenu";
            pcbMenu.Size = new Size(405, 948);
            pcbMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbMenu.TabIndex = 0;
            pcbMenu.TabStop = false;
            // 
            // pcbTitulo
            // 
            pcbTitulo.BackColor = Color.Transparent;
            pcbTitulo.Image = (Image)resources.GetObject("pcbTitulo.Image");
            pcbTitulo.Location = new Point(532, 11);
            pcbTitulo.Name = "pcbTitulo";
            pcbTitulo.Size = new Size(1292, 149);
            pcbTitulo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbTitulo.TabIndex = 1;
            pcbTitulo.TabStop = false;
            // 
            // pcbAlumnos
            // 
            pcbAlumnos.BackColor = Color.Transparent;
            pcbAlumnos.Image = (Image)resources.GetObject("pcbAlumnos.Image");
            pcbAlumnos.Location = new Point(31, 124);
            pcbAlumnos.Name = "pcbAlumnos";
            pcbAlumnos.Size = new Size(363, 116);
            pcbAlumnos.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbAlumnos.TabIndex = 2;
            pcbAlumnos.TabStop = false;
            pcbAlumnos.Click += pcbAlumnos_Click;
            pcbAlumnos.MouseDown += pcbGeneral_MouseDown;
            pcbAlumnos.MouseUp += pcbGeneral_MouseUp;
            // 
            // pcbCarreras
            // 
            pcbCarreras.Image = (Image)resources.GetObject("pcbCarreras.Image");
            pcbCarreras.Location = new Point(31, 291);
            pcbCarreras.Name = "pcbCarreras";
            pcbCarreras.Size = new Size(363, 116);
            pcbCarreras.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbCarreras.TabIndex = 3;
            pcbCarreras.TabStop = false;
            pcbCarreras.Click += pcbCarreras_Click;
            pcbCarreras.MouseDown += pcbGeneral_MouseDown;
            pcbCarreras.MouseUp += pcbGeneral_MouseUp;
            // 
            // pcbUsuario
            // 
            pcbUsuario.BackColor = Color.Transparent;
            pcbUsuario.Image = (Image)resources.GetObject("pcbUsuario.Image");
            pcbUsuario.Location = new Point(31, 806);
            pcbUsuario.Name = "pcbUsuario";
            pcbUsuario.Size = new Size(363, 116);
            pcbUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbUsuario.TabIndex = 4;
            pcbUsuario.TabStop = false;
            pcbUsuario.MouseDown += pcbGeneral_MouseDown;
            pcbUsuario.MouseUp += pcbGeneral_MouseUp;
            // 
            // pcbDocente
            // 
            pcbDocente.Image = (Image)resources.GetObject("pcbDocente.Image");
            pcbDocente.Location = new Point(31, 633);
            pcbDocente.Name = "pcbDocente";
            pcbDocente.Size = new Size(363, 116);
            pcbDocente.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbDocente.TabIndex = 5;
            pcbDocente.TabStop = false;
            pcbDocente.MouseDown += pcbGeneral_MouseDown;
            pcbDocente.MouseUp += pcbGeneral_MouseUp;
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.White;
            pnlContenedor.Location = new Point(532, 152);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1292, 808);
            pnlContenedor.TabIndex = 6;
            // 
            // pcbTutores
            // 
            pcbTutores.Image = (Image)resources.GetObject("pcbTutores.Image");
            pcbTutores.Location = new Point(31, 466);
            pcbTutores.Name = "pcbTutores";
            pcbTutores.Size = new Size(363, 116);
            pcbTutores.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbTutores.TabIndex = 7;
            pcbTutores.TabStop = false;
            pcbTutores.Click += pcbTutores_Click;
            pcbTutores.MouseDown += pcbGeneral_MouseDown;
            pcbTutores.MouseUp += pcbGeneral_MouseUp;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1920, 998);
            Controls.Add(pcbTutores);
            Controls.Add(pnlContenedor);
            Controls.Add(pcbDocente);
            Controls.Add(pcbUsuario);
            Controls.Add(pcbCarreras);
            Controls.Add(pcbAlumnos);
            Controls.Add(pcbTitulo);
            Controls.Add(pcbMenu);
            Name = "frmPrincipal";
            Text = "Sistema Escolar";
            WindowState = FormWindowState.Maximized;
            Load += frmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pcbMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbTitulo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbAlumnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbCarreras).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbDocente).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbTutores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pcbMenu;
        private PictureBox pcbTitulo;
        private PictureBox pcbAlumnos;
        private PictureBox pcbCarreras;
        private PictureBox pcbUsuario;
        private PictureBox pcbDocente;
        private Panel pnlContenedor;
        private PictureBox pcbTutores;
    }
}