namespace pryProyecto
{
    partial class frmDocente
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocente));
            lblTitulo = new Label();
            dgvAlumnos = new DataGridView();
            txtMatriculaAlumnos = new TextBox();
            txtNombreCarrera = new TextBox();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            lblUsuario = new Label();
            lblAlumno = new Label();
            panel2 = new Panel();
            cmbPerfil = new ComboBox();
            txtPassword = new TextBox();
            txtUsuario = new TextBox();
            panel1 = new Panel();
            cmbCarrera = new ComboBox();
            cmbTutor = new ComboBox();
            txtPromedioBachillerato = new TextBox();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtAMaterno = new TextBox();
            txtAPaterno = new TextBox();
            txtNombre = new TextBox();
            txtMatricula = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Book Antiqua", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(506, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(262, 67);
            lblTitulo.TabIndex = 30;
            lblTitulo.Text = "Docentes";
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.AllowUserToAddRows = false;
            dgvAlumnos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvAlumnos.DefaultCellStyle = dataGridViewCellStyle4;
            dgvAlumnos.EnableHeadersVisualStyles = false;
            dgvAlumnos.Location = new Point(157, 518);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dgvAlumnos.RowTemplate.Height = 35;
            dgvAlumnos.ScrollBars = ScrollBars.None;
            dgvAlumnos.Size = new Size(961, 222);
            dgvAlumnos.TabIndex = 29;
            // 
            // txtMatriculaAlumnos
            // 
            txtMatriculaAlumnos.Font = new Font("Book Antiqua", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatriculaAlumnos.Location = new Point(828, 476);
            txtMatriculaAlumnos.Name = "txtMatriculaAlumnos";
            txtMatriculaAlumnos.PlaceholderText = "Buscar por matricula";
            txtMatriculaAlumnos.Size = new Size(251, 36);
            txtMatriculaAlumnos.TabIndex = 27;
            // 
            // txtNombreCarrera
            // 
            txtNombreCarrera.Font = new Font("Book Antiqua", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreCarrera.Location = new Point(828, 476);
            txtNombreCarrera.Name = "txtNombreCarrera";
            txtNombreCarrera.PlaceholderText = "Buscar alumno";
            txtNombreCarrera.Size = new Size(251, 36);
            txtNombreCarrera.TabIndex = 28;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.Location = new Point(778, 405);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(147, 65);
            btnEliminar.TabIndex = 26;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.Location = new Point(541, 405);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(147, 65);
            btnGuardar.TabIndex = 25;
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = (Image)resources.GetObject("btnNuevo.BackgroundImage");
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.Location = new Point(301, 405);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(147, 65);
            btnNuevo.TabIndex = 24;
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(810, 125);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(88, 26);
            lblUsuario.TabIndex = 23;
            lblUsuario.Text = "Usuario";
            // 
            // lblAlumno
            // 
            lblAlumno.AutoSize = true;
            lblAlumno.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlumno.Location = new Point(174, 124);
            lblAlumno.Name = "lblAlumno";
            lblAlumno.Size = new Size(93, 26);
            lblAlumno.TabIndex = 22;
            lblAlumno.Text = "Docente";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(cmbPerfil);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(txtUsuario);
            panel2.Location = new Point(795, 154);
            panel2.Name = "panel2";
            panel2.Size = new Size(323, 235);
            panel2.TabIndex = 21;
            // 
            // cmbPerfil
            // 
            cmbPerfil.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbPerfil.FormattingEnabled = true;
            cmbPerfil.Items.AddRange(new object[] { "Administrador", "Alumnos", "Docente", "Tutor" });
            cmbPerfil.Location = new Point(13, 129);
            cmbPerfil.Name = "cmbPerfil";
            cmbPerfil.Size = new Size(297, 34);
            cmbPerfil.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(13, 61);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(297, 33);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(13, 22);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(297, 33);
            txtUsuario.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(cmbCarrera);
            panel1.Controls.Add(cmbTutor);
            panel1.Controls.Add(txtPromedioBachillerato);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(txtDireccion);
            panel1.Controls.Add(txtAMaterno);
            panel1.Controls.Add(txtAPaterno);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(txtMatricula);
            panel1.Location = new Point(157, 153);
            panel1.Name = "panel1";
            panel1.Size = new Size(586, 235);
            panel1.TabIndex = 20;
            // 
            // cmbCarrera
            // 
            cmbCarrera.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold);
            cmbCarrera.FormattingEnabled = true;
            cmbCarrera.Location = new Point(292, 180);
            cmbCarrera.Name = "cmbCarrera";
            cmbCarrera.Size = new Size(271, 34);
            cmbCarrera.TabIndex = 9;
            // 
            // cmbTutor
            // 
            cmbTutor.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold);
            cmbTutor.FormattingEnabled = true;
            cmbTutor.Location = new Point(292, 140);
            cmbTutor.Name = "cmbTutor";
            cmbTutor.Size = new Size(271, 34);
            cmbTutor.TabIndex = 8;
            // 
            // txtPromedioBachillerato
            // 
            txtPromedioBachillerato.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold);
            txtPromedioBachillerato.Location = new Point(292, 101);
            txtPromedioBachillerato.Name = "txtPromedioBachillerato";
            txtPromedioBachillerato.PlaceholderText = "Promedio Bachillerato";
            txtPromedioBachillerato.Size = new Size(271, 33);
            txtPromedioBachillerato.TabIndex = 7;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold);
            txtCorreo.Location = new Point(292, 62);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Correo";
            txtCorreo.Size = new Size(271, 33);
            txtCorreo.TabIndex = 6;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold);
            txtTelefono.Location = new Point(292, 23);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Telefono";
            txtTelefono.Size = new Size(271, 33);
            txtTelefono.TabIndex = 5;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold);
            txtDireccion.Location = new Point(15, 179);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Direccion";
            txtDireccion.Size = new Size(271, 33);
            txtDireccion.TabIndex = 4;
            // 
            // txtAMaterno
            // 
            txtAMaterno.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold);
            txtAMaterno.Location = new Point(15, 140);
            txtAMaterno.Name = "txtAMaterno";
            txtAMaterno.PlaceholderText = "Apellido Materno";
            txtAMaterno.Size = new Size(271, 33);
            txtAMaterno.TabIndex = 3;
            // 
            // txtAPaterno
            // 
            txtAPaterno.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold);
            txtAPaterno.Location = new Point(15, 101);
            txtAPaterno.Name = "txtAPaterno";
            txtAPaterno.PlaceholderText = "Apellido Paterno";
            txtAPaterno.Size = new Size(271, 33);
            txtAPaterno.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold);
            txtNombre.Location = new Point(15, 62);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(271, 33);
            txtNombre.TabIndex = 1;
            // 
            // txtMatricula
            // 
            txtMatricula.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold);
            txtMatricula.Location = new Point(15, 23);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.PlaceholderText = "Matricula";
            txtMatricula.Size = new Size(271, 33);
            txtMatricula.TabIndex = 0;
            // 
            // frmDocente
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1274, 764);
            Controls.Add(lblTitulo);
            Controls.Add(dgvAlumnos);
            Controls.Add(txtMatriculaAlumnos);
            Controls.Add(txtNombreCarrera);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(lblUsuario);
            Controls.Add(lblAlumno);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmDocente";
            Text = "frmDocente";
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private DataGridView dgvAlumnos;
        private TextBox txtMatriculaAlumnos;
        private TextBox txtNombreCarrera;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnNuevo;
        private Label lblUsuario;
        private Label lblAlumno;
        private Panel panel2;
        private ComboBox cmbPerfil;
        private TextBox txtPassword;
        private TextBox txtUsuario;
        private Panel panel1;
        private ComboBox cmbCarrera;
        private ComboBox cmbTutor;
        private TextBox txtPromedioBachillerato;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtAMaterno;
        private TextBox txtAPaterno;
        private TextBox txtNombre;
        private TextBox txtMatricula;
    }
}