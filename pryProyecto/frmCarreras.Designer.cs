namespace pryProyecto
{
    partial class frmCarreras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarreras));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pcbLogo = new PictureBox();
            lblTitulo = new Label();
            pnlAgrupaControles = new Panel();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            dgvCarreras = new DataGridView();
            txtNombreCarrera = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            pnlAgrupaControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarreras).BeginInit();
            SuspendLayout();
            // 
            // pcbLogo
            // 
            pcbLogo.Image = (Image)resources.GetObject("pcbLogo.Image");
            pcbLogo.Location = new Point(709, 49);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(168, 179);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 0;
            pcbLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Book Antiqua", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(453, 141);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(261, 73);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Carreras";
            // 
            // pnlAgrupaControles
            // 
            pnlAgrupaControles.Controls.Add(btnEliminar);
            pnlAgrupaControles.Controls.Add(btnGuardar);
            pnlAgrupaControles.Controls.Add(btnNuevo);
            pnlAgrupaControles.Controls.Add(txtDescripcion);
            pnlAgrupaControles.Controls.Add(txtNombre);
            pnlAgrupaControles.Location = new Point(246, 248);
            pnlAgrupaControles.Name = "pnlAgrupaControles";
            pnlAgrupaControles.Size = new Size(798, 268);
            pnlAgrupaControles.TabIndex = 2;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.Location = new Point(496, 183);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(147, 68);
            btnEliminar.TabIndex = 4;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.Location = new Point(343, 183);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(147, 68);
            btnGuardar.TabIndex = 3;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = (Image)resources.GetObject("btnNuevo.BackgroundImage");
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.Location = new Point(179, 183);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(147, 68);
            btnNuevo.TabIndex = 2;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(179, 119);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Escriba una descripcion de la carrera";
            txtDescripcion.Size = new Size(463, 36);
            txtDescripcion.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(180, 44);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Escriba el nombre de la carrera";
            txtNombre.Size = new Size(463, 36);
            txtNombre.TabIndex = 0;
            // 
            // dgvCarreras
            // 
            dgvCarreras.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCarreras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCarreras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCarreras.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCarreras.EnableHeadersVisualStyles = false;
            dgvCarreras.Location = new Point(164, 567);
            dgvCarreras.Name = "dgvCarreras";
            dgvCarreras.RowHeadersWidth = 51;
            dgvCarreras.RowTemplate.Height = 35;
            dgvCarreras.Size = new Size(961, 192);
            dgvCarreras.TabIndex = 3;
            dgvCarreras.SelectionChanged += dgvCarreras_SelectionChanged;
            // 
            // txtNombreCarrera
            // 
            txtNombreCarrera.Font = new Font("Book Antiqua", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreCarrera.Location = new Point(793, 522);
            txtNombreCarrera.Name = "txtNombreCarrera";
            txtNombreCarrera.PlaceholderText = "Buscar carrera";
            txtNombreCarrera.Size = new Size(251, 39);
            txtNombreCarrera.TabIndex = 4;
            txtNombreCarrera.TextChanged += txtNombreCarrera_TextChanged;
            // 
            // frmCarreras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1274, 803);
            Controls.Add(txtNombreCarrera);
            Controls.Add(dgvCarreras);
            Controls.Add(pnlAgrupaControles);
            Controls.Add(lblTitulo);
            Controls.Add(pcbLogo);
            DoubleBuffered = true;
            Name = "frmCarreras";
            Text = "Registro de Carreras";
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            pnlAgrupaControles.ResumeLayout(false);
            pnlAgrupaControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarreras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbLogo;
        private Label lblTitulo;
        private Panel pnlAgrupaControles;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnNuevo;
        private DataGridView dgvCarreras;
        private TextBox txtNombreCarrera;
    }
}