namespace pryProyecto
{
    partial class frmAlumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlumnos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            txtMatricula = new TextBox();
            txtNombre = new TextBox();
            txtAPaterno = new TextBox();
            txtAMaterno = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            txtPromedioBachillerato = new TextBox();
            cmbTutor = new ComboBox();
            cmbCarrera = new ComboBox();
            panel1 = new Panel();
            panel2 = new Panel();
            cmbPerfil = new ComboBox();
            txtPassword = new TextBox();
            txtUsuario = new TextBox();
            lblAlumno = new Label();
            lblUsuario = new Label();
            btnGuardar = new Button();
            btnNuevo = new Button();
            btnEliminar = new Button();
            txtMatriculaAlumnos = new TextBox();
            dgvAlumnos = new DataGridView();
            lblTitulo = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // txtMatricula
            // 
            txtMatricula.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold);
            txtMatricula.Location = new Point(15, 24);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.PlaceholderText = "Matricula";
            txtMatricula.Size = new Size(271, 35);
            txtMatricula.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold);
            txtNombre.Location = new Point(15, 65);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(271, 35);
            txtNombre.TabIndex = 1;
            // 
            // txtAPaterno
            // 
            txtAPaterno.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold);
            txtAPaterno.Location = new Point(15, 106);
            txtAPaterno.Name = "txtAPaterno";
            txtAPaterno.PlaceholderText = "Apellido Paterno";
            txtAPaterno.Size = new Size(271, 35);
            txtAPaterno.TabIndex = 2;
            // 
            // txtAMaterno
            // 
            txtAMaterno.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold);
            txtAMaterno.Location = new Point(15, 147);
            txtAMaterno.Name = "txtAMaterno";
            txtAMaterno.PlaceholderText = "Apellido Materno";
            txtAMaterno.Size = new Size(271, 35);
            txtAMaterno.TabIndex = 3;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold);
            txtDireccion.Location = new Point(15, 188);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Direccion";
            txtDireccion.Size = new Size(271, 35);
            txtDireccion.TabIndex = 4;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold);
            txtTelefono.Location = new Point(292, 24);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Telefono";
            txtTelefono.Size = new Size(271, 35);
            txtTelefono.TabIndex = 5;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold);
            txtCorreo.Location = new Point(292, 65);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Correo";
            txtCorreo.Size = new Size(271, 35);
            txtCorreo.TabIndex = 6;
            // 
            // txtPromedioBachillerato
            // 
            txtPromedioBachillerato.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold);
            txtPromedioBachillerato.Location = new Point(292, 106);
            txtPromedioBachillerato.Name = "txtPromedioBachillerato";
            txtPromedioBachillerato.PlaceholderText = "Promedio Bachillerato";
            txtPromedioBachillerato.Size = new Size(271, 35);
            txtPromedioBachillerato.TabIndex = 7;
            // 
            // cmbTutor
            // 
            cmbTutor.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold);
            cmbTutor.FormattingEnabled = true;
            cmbTutor.Location = new Point(292, 147);
            cmbTutor.Name = "cmbTutor";
            cmbTutor.Size = new Size(271, 36);
            cmbTutor.TabIndex = 8;
            // 
            // cmbCarrera
            // 
            cmbCarrera.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold);
            cmbCarrera.FormattingEnabled = true;
            cmbCarrera.Location = new Point(292, 189);
            cmbCarrera.Name = "cmbCarrera";
            cmbCarrera.Size = new Size(271, 36);
            cmbCarrera.TabIndex = 9;
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
            panel1.Location = new Point(146, 173);
            panel1.Name = "panel1";
            panel1.Size = new Size(586, 247);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(cmbPerfil);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(txtUsuario);
            panel2.Location = new Point(784, 174);
            panel2.Name = "panel2";
            panel2.Size = new Size(323, 247);
            panel2.TabIndex = 11;
            // 
            // cmbPerfil
            // 
            cmbPerfil.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbPerfil.FormattingEnabled = true;
            cmbPerfil.Items.AddRange(new object[] { "Administrador", "Alumnos", "Docente", "Tutor" });
            cmbPerfil.Location = new Point(13, 136);
            cmbPerfil.Name = "cmbPerfil";
            cmbPerfil.Size = new Size(297, 36);
            cmbPerfil.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(13, 64);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(297, 35);
            txtPassword.TabIndex = 1;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(13, 23);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(297, 35);
            txtUsuario.TabIndex = 0;
            // 
            // lblAlumno
            // 
            lblAlumno.AutoSize = true;
            lblAlumno.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlumno.Location = new Point(163, 142);
            lblAlumno.Name = "lblAlumno";
            lblAlumno.Size = new Size(99, 28);
            lblAlumno.TabIndex = 12;
            lblAlumno.Text = "Alumno";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(799, 143);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(96, 28);
            lblUsuario.TabIndex = 13;
            lblUsuario.Text = "Usuario";
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.Location = new Point(530, 438);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(147, 68);
            btnGuardar.TabIndex = 15;
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = (Image)resources.GetObject("btnNuevo.BackgroundImage");
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.Location = new Point(290, 438);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(147, 68);
            btnNuevo.TabIndex = 14;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.Location = new Point(767, 438);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(147, 68);
            btnEliminar.TabIndex = 16;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtMatriculaAlumnos
            // 
            txtMatriculaAlumnos.Font = new Font("Book Antiqua", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatriculaAlumnos.Location = new Point(817, 513);
            txtMatriculaAlumnos.Name = "txtMatriculaAlumnos";
            txtMatriculaAlumnos.PlaceholderText = "Buscar por matricula";
            txtMatriculaAlumnos.Size = new Size(251, 39);
            txtMatriculaAlumnos.TabIndex = 17;
            txtMatriculaAlumnos.TextChanged += txtNombreCarrera_TextChanged;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAlumnos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAlumnos.EnableHeadersVisualStyles = false;
            dgvAlumnos.Location = new Point(146, 557);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.RowHeadersWidth = 51;
            dgvAlumnos.RowTemplate.Height = 35;
            dgvAlumnos.Size = new Size(961, 234);
            dgvAlumnos.TabIndex = 18;
            dgvAlumnos.SelectionChanged += dgvAlumnos_SelectionChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Book Antiqua", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(400, 51);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(286, 73);
            lblTitulo.TabIndex = 19;
            lblTitulo.Text = "Alumnos";
            // 
            // frmAlumnos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1274, 803);
            Controls.Add(lblTitulo);
            Controls.Add(dgvAlumnos);
            Controls.Add(txtMatriculaAlumnos);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(lblUsuario);
            Controls.Add(lblAlumno);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmAlumnos";
            Text = "Registro de Alumnos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMatricula;
        private TextBox txtNombre;
        private TextBox txtAPaterno;
        private TextBox txtAMaterno;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtPromedioBachillerato;
        private ComboBox cmbTutor;
        private ComboBox cmbCarrera;
        private Panel panel1;
        private Panel panel2;
        private ComboBox cmbPerfil;
        private TextBox txtPassword;
        private TextBox txtUsuario;
        private Label lblAlumno;
        private Label lblUsuario;
        private Button btnGuardar;
        private Button btnNuevo;
        private Button btnEliminar;
        private TextBox txtMatriculaAlumnos;
        private DataGridView dgvAlumnos;
        private Label lblTitulo;
    }
}