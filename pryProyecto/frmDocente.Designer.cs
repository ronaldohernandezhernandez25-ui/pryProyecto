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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocente));
            lblTitulo = new Label();
            dgvDocentes = new DataGridView();
            txtClaveDocente = new TextBox();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            lblUsuario = new Label();
            lblAlumno = new Label();
            pnlUsuario = new Panel();
            cmbPerfil = new ComboBox();
            txtPassword = new TextBox();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            txtNombreDocente = new TextBox();
            txtPuesto = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            pnlDocente = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvDocentes).BeginInit();
            pnlUsuario.SuspendLayout();
            pnlDocente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Book Antiqua", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(402, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(286, 73);
            lblTitulo.TabIndex = 30;
            lblTitulo.Text = "Docentes";
            // 
            // dgvDocentes
            // 
            dgvDocentes.AllowUserToAddRows = false;
            dgvDocentes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvDocentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvDocentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvDocentes.DefaultCellStyle = dataGridViewCellStyle6;
            dgvDocentes.EnableHeadersVisualStyles = false;
            dgvDocentes.Location = new Point(166, 545);
            dgvDocentes.Name = "dgvDocentes";
            dgvDocentes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dgvDocentes.RowTemplate.Height = 35;
            dgvDocentes.ScrollBars = ScrollBars.None;
            dgvDocentes.Size = new Size(939, 234);
            dgvDocentes.TabIndex = 29;
            dgvDocentes.SelectionChanged += dgvDocentes_SelectionChanged_1;
            // 
            // txtClaveDocente
            // 
            txtClaveDocente.Font = new Font("Book Antiqua", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClaveDocente.Location = new Point(854, 501);
            txtClaveDocente.Name = "txtClaveDocente";
            txtClaveDocente.PlaceholderText = "Buscar por Clave";
            txtClaveDocente.Size = new Size(251, 39);
            txtClaveDocente.TabIndex = 27;
            txtClaveDocente.TextChanged += txtClaveDocente_TextChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.Location = new Point(778, 426);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(147, 68);
            btnEliminar.TabIndex = 26;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.Location = new Point(541, 426);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(147, 68);
            btnGuardar.TabIndex = 25;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = (Image)resources.GetObject("btnNuevo.BackgroundImage");
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.Location = new Point(301, 426);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(147, 68);
            btnNuevo.TabIndex = 24;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(756, 131);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(96, 28);
            lblUsuario.TabIndex = 23;
            lblUsuario.Text = "Usuario";
            // 
            // lblAlumno
            // 
            lblAlumno.AutoSize = true;
            lblAlumno.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlumno.Location = new Point(249, 131);
            lblAlumno.Name = "lblAlumno";
            lblAlumno.Size = new Size(100, 28);
            lblAlumno.TabIndex = 22;
            lblAlumno.Text = "Docente";
            // 
            // pnlUsuario
            // 
            pnlUsuario.BackColor = SystemColors.ActiveCaption;
            pnlUsuario.BorderStyle = BorderStyle.Fixed3D;
            pnlUsuario.Controls.Add(cmbPerfil);
            pnlUsuario.Controls.Add(txtPassword);
            pnlUsuario.Controls.Add(txtUsuario);
            pnlUsuario.Location = new Point(756, 162);
            pnlUsuario.Name = "pnlUsuario";
            pnlUsuario.Size = new Size(323, 247);
            pnlUsuario.TabIndex = 21;
            // 
            // cmbPerfil
            // 
            cmbPerfil.Font = new Font("Book Antiqua", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbPerfil.FormattingEnabled = true;
            cmbPerfil.Items.AddRange(new object[] { "Docente\t\t\t\t" });
            cmbPerfil.Location = new Point(13, 125);
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
            txtPassword.UseSystemPasswordChar = true;
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
            // txtClave
            // 
            txtClave.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtClave.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold);
            txtClave.Location = new Point(15, 24);
            txtClave.Name = "txtClave";
            txtClave.PlaceholderText = "Clave";
            txtClave.Size = new Size(397, 35);
            txtClave.TabIndex = 0;
            // 
            // txtNombreDocente
            // 
            txtNombreDocente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombreDocente.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold);
            txtNombreDocente.Location = new Point(15, 65);
            txtNombreDocente.Name = "txtNombreDocente";
            txtNombreDocente.PlaceholderText = "Nombre del Docente";
            txtNombreDocente.Size = new Size(397, 35);
            txtNombreDocente.TabIndex = 1;
            // 
            // txtPuesto
            // 
            txtPuesto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPuesto.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold);
            txtPuesto.Location = new Point(15, 106);
            txtPuesto.Name = "txtPuesto";
            txtPuesto.PlaceholderText = "Pueso";
            txtPuesto.Size = new Size(397, 35);
            txtPuesto.TabIndex = 2;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTelefono.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold);
            txtTelefono.Location = new Point(15, 147);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Telefono";
            txtTelefono.Size = new Size(397, 35);
            txtTelefono.TabIndex = 3;
            // 
            // txtCorreo
            // 
            txtCorreo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCorreo.Font = new Font("Book Antiqua", 13.7454548F, FontStyle.Bold);
            txtCorreo.Location = new Point(15, 188);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Correo";
            txtCorreo.Size = new Size(397, 35);
            txtCorreo.TabIndex = 4;
            // 
            // pnlDocente
            // 
            pnlDocente.BackColor = SystemColors.ActiveCaption;
            pnlDocente.BorderStyle = BorderStyle.Fixed3D;
            pnlDocente.Controls.Add(txtCorreo);
            pnlDocente.Controls.Add(txtTelefono);
            pnlDocente.Controls.Add(txtPuesto);
            pnlDocente.Controls.Add(txtNombreDocente);
            pnlDocente.Controls.Add(txtClave);
            pnlDocente.Location = new Point(249, 161);
            pnlDocente.Name = "pnlDocente";
            pnlDocente.Size = new Size(439, 247);
            pnlDocente.TabIndex = 20;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(713, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // frmDocente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1274, 804);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitulo);
            Controls.Add(dgvDocentes);
            Controls.Add(txtClaveDocente);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(lblUsuario);
            Controls.Add(lblAlumno);
            Controls.Add(pnlUsuario);
            Controls.Add(pnlDocente);
            Name = "frmDocente";
            Text = "frmDocente";
            ((System.ComponentModel.ISupportInitialize)dgvDocentes).EndInit();
            pnlUsuario.ResumeLayout(false);
            pnlUsuario.PerformLayout();
            pnlDocente.ResumeLayout(false);
            pnlDocente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Panel pnlUsuario;
        private TextBox txtPassword;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private TextBox txtNombreDocente;
        private TextBox txtPuesto;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private Panel pnlDocente;
        private ComboBox cmbPerfil;
        private PictureBox pictureBox1;
    }
}