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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocente));
            lblTitulo = new Label();
            dgvDocentes = new DataGridView();
            txtClaveDocente = new TextBox();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            lblUsuario = new Label();
            lblAlumno = new Label();
            panel2 = new Panel();
            cmbPerfil = new ComboBox();
            txtPassword = new TextBox();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            txtNombreDocente = new TextBox();
            txtPuesto = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvDocentes).BeginInit();
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
            // dgvDocentes
            // 
            dgvDocentes.AllowUserToAddRows = false;
            dgvDocentes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDocentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDocentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDocentes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDocentes.EnableHeadersVisualStyles = false;
            dgvDocentes.Location = new Point(166, 518);
            dgvDocentes.Name = "dgvDocentes";
            dgvDocentes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dgvDocentes.RowTemplate.Height = 35;
            dgvDocentes.ScrollBars = ScrollBars.None;
            dgvDocentes.Size = new Size(939, 222);
            dgvDocentes.TabIndex = 29;
            dgvDocentes.SelectionChanged += dgvDocentes_SelectionChanged_1;
            // 
            // txtClaveDocente
            // 
            txtClaveDocente.Font = new Font("Book Antiqua", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClaveDocente.Location = new Point(854, 476);
            txtClaveDocente.Name = "txtClaveDocente";
            txtClaveDocente.PlaceholderText = "Buscar por Clave";
            txtClaveDocente.Size = new Size(251, 36);
            txtClaveDocente.TabIndex = 27;
            txtClaveDocente.TextChanged += txtClaveDocente_TextChanged;
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
            lblUsuario.Location = new Point(756, 124);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(88, 26);
            lblUsuario.TabIndex = 23;
            lblUsuario.Text = "Usuario";
            // 
            // lblAlumno
            // 
            lblAlumno.AutoSize = true;
            lblAlumno.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlumno.Location = new Point(249, 124);
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
            panel2.Location = new Point(756, 154);
            panel2.Name = "panel2";
            panel2.Size = new Size(323, 235);
            panel2.TabIndex = 21;
            // 
            // cmbPerfil
            // 
            cmbPerfil.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbPerfil.FormattingEnabled = true;
            cmbPerfil.Location = new Point(13, 106);
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
            // txtClave
            // 
            txtClave.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtClave.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold);
            txtClave.Location = new Point(15, 23);
            txtClave.Name = "txtClave";
            txtClave.PlaceholderText = "Clave";
            txtClave.Size = new Size(397, 33);
            txtClave.TabIndex = 0;
            // 
            // txtNombreDocente
            // 
            txtNombreDocente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombreDocente.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold);
            txtNombreDocente.Location = new Point(15, 62);
            txtNombreDocente.Name = "txtNombreDocente";
            txtNombreDocente.PlaceholderText = "Nombre del Docente";
            txtNombreDocente.Size = new Size(397, 33);
            txtNombreDocente.TabIndex = 1;
            // 
            // txtPuesto
            // 
            txtPuesto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPuesto.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold);
            txtPuesto.Location = new Point(15, 101);
            txtPuesto.Name = "txtPuesto";
            txtPuesto.PlaceholderText = "Pueso";
            txtPuesto.Size = new Size(397, 33);
            txtPuesto.TabIndex = 2;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTelefono.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold);
            txtTelefono.Location = new Point(15, 140);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Telefono";
            txtTelefono.Size = new Size(397, 33);
            txtTelefono.TabIndex = 3;
            // 
            // txtCorreo
            // 
            txtCorreo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCorreo.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold);
            txtCorreo.Location = new Point(15, 179);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Correo";
            txtCorreo.Size = new Size(397, 33);
            txtCorreo.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(txtPuesto);
            panel1.Controls.Add(txtNombreDocente);
            panel1.Controls.Add(txtClave);
            panel1.Location = new Point(249, 153);
            panel1.Name = "panel1";
            panel1.Size = new Size(439, 235);
            panel1.TabIndex = 20;
            // 
            // frmDocente
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1274, 764);
            Controls.Add(lblTitulo);
            Controls.Add(dgvDocentes);
            Controls.Add(txtClaveDocente);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(lblUsuario);
            Controls.Add(lblAlumno);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmDocente";
            Text = "frmDocente";
            ((System.ComponentModel.ISupportInitialize)dgvDocentes).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private DataGridView dgvDocentes;
        private TextBox txtClaveDocente;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnNuevo;
        private Label lblUsuario;
        private Label lblAlumno;
        private Panel panel2;
        private TextBox txtPassword;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private TextBox txtNombreDocente;
        private TextBox txtPuesto;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private Panel panel1;
        private ComboBox cmbPerfil;
    }
}