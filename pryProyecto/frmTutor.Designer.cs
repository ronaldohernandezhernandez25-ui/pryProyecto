namespace pryProyecto
{
    partial class frmTutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTutor));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnNuevoTutor = new Button();
            btnAgregarTutor = new Button();
            btnEliminarTutor = new Button();
            dgvTutor = new DataGridView();
            panel1 = new Panel();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtParentesco = new TextBox();
            txtNombreTutor = new TextBox();
            txtBuscarTutor = new TextBox();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTutor).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnNuevoTutor
            // 
            btnNuevoTutor.BackgroundImage = (Image)resources.GetObject("btnNuevoTutor.BackgroundImage");
            btnNuevoTutor.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevoTutor.Location = new Point(165, 296);
            btnNuevoTutor.Name = "btnNuevoTutor";
            btnNuevoTutor.Size = new Size(147, 68);
            btnNuevoTutor.TabIndex = 0;
            btnNuevoTutor.UseVisualStyleBackColor = true;
            btnNuevoTutor.Click += btnNuevoTutor_Click;
            // 
            // btnAgregarTutor
            // 
            btnAgregarTutor.BackgroundImage = (Image)resources.GetObject("btnAgregarTutor.BackgroundImage");
            btnAgregarTutor.BackgroundImageLayout = ImageLayout.Stretch;
            btnAgregarTutor.Location = new Point(394, 296);
            btnAgregarTutor.Name = "btnAgregarTutor";
            btnAgregarTutor.Size = new Size(147, 68);
            btnAgregarTutor.TabIndex = 1;
            btnAgregarTutor.UseVisualStyleBackColor = true;
            btnAgregarTutor.Click += btnAgregarTutor_Click;
            // 
            // btnEliminarTutor
            // 
            btnEliminarTutor.BackgroundImage = (Image)resources.GetObject("btnEliminarTutor.BackgroundImage");
            btnEliminarTutor.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminarTutor.Location = new Point(646, 296);
            btnEliminarTutor.Name = "btnEliminarTutor";
            btnEliminarTutor.Size = new Size(147, 68);
            btnEliminarTutor.TabIndex = 2;
            btnEliminarTutor.UseVisualStyleBackColor = true;
            btnEliminarTutor.Click += btnEliminarTutor_Click;
            // 
            // dgvTutor
            // 
            dgvTutor.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLightLight;
            dgvTutor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DarkSalmon;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvTutor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvTutor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvTutor.DefaultCellStyle = dataGridViewCellStyle3;
            dgvTutor.EnableHeadersVisualStyles = false;
            dgvTutor.Location = new Point(160, 563);
            dgvTutor.Name = "dgvTutor";
            dgvTutor.RowHeadersWidth = 51;
            dgvTutor.Size = new Size(957, 197);
            dgvTutor.TabIndex = 3;
            dgvTutor.SelectionChanged += dgvTutor_SelectionChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(txtDireccion);
            panel1.Controls.Add(txtParentesco);
            panel1.Controls.Add(txtNombreTutor);
            panel1.Controls.Add(btnNuevoTutor);
            panel1.Controls.Add(btnAgregarTutor);
            panel1.Controls.Add(btnEliminarTutor);
            panel1.Location = new Point(160, 136);
            panel1.Name = "panel1";
            panel1.Size = new Size(957, 372);
            panel1.TabIndex = 4;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(165, 253);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Ingrese Su correo Electronico";
            txtCorreo.Size = new Size(629, 36);
            txtCorreo.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(165, 204);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Ingrese su Telefono";
            txtTelefono.Size = new Size(629, 36);
            txtTelefono.TabIndex = 6;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDireccion.Location = new Point(165, 152);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Ingrese su Dirección";
            txtDireccion.Size = new Size(629, 36);
            txtDireccion.TabIndex = 5;
            // 
            // txtParentesco
            // 
            txtParentesco.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtParentesco.Location = new Point(165, 89);
            txtParentesco.Name = "txtParentesco";
            txtParentesco.PlaceholderText = "Ingrese su Parentesco";
            txtParentesco.Size = new Size(629, 36);
            txtParentesco.TabIndex = 4;
            // 
            // txtNombreTutor
            // 
            txtNombreTutor.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreTutor.Location = new Point(165, 29);
            txtNombreTutor.Name = "txtNombreTutor";
            txtNombreTutor.PlaceholderText = "Ingrese el nombre completo del tutor";
            txtNombreTutor.Size = new Size(629, 36);
            txtNombreTutor.TabIndex = 3;
            // 
            // txtBuscarTutor
            // 
            txtBuscarTutor.Font = new Font("Book Antiqua", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarTutor.Location = new Point(866, 517);
            txtBuscarTutor.Name = "txtBuscarTutor";
            txtBuscarTutor.PlaceholderText = "Buscar Tutor";
            txtBuscarTutor.Size = new Size(251, 39);
            txtBuscarTutor.TabIndex = 5;
            txtBuscarTutor.TextChanged += txtBuscarTutor_TextChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Book Antiqua", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(523, 51);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(242, 73);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "Tutores";
            // 
            // frmTutor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1274, 803);
            Controls.Add(lblTitulo);
            Controls.Add(txtBuscarTutor);
            Controls.Add(panel1);
            Controls.Add(dgvTutor);
            DoubleBuffered = true;
            Name = "frmTutor";
            Text = "Tutores";
            ((System.ComponentModel.ISupportInitialize)dgvTutor).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevoTutor;
        private Button btnAgregarTutor;
        private Button btnEliminarTutor;
        private DataGridView dgvTutor;
        private Panel panel1;
        private TextBox txtBuscarTutor;
        private Label lblTitulo;
        private TextBox txtNombreTutor;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtParentesco;
        private TextBox txtCorreo;
    }
}