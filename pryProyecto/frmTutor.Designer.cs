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
            btnNuevoTutor = new Button();
            btnAgregarTutor = new Button();
            btnEliminarTutor = new Button();
            dgvTutores = new DataGridView();
            panel1 = new Panel();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtParentesco = new TextBox();
            txtNombreTutor = new TextBox();
            txtBuscarTutor = new TextBox();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTutores).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnNuevoTutor
            // 
            btnNuevoTutor.BackgroundImage = (Image)resources.GetObject("btnNuevoTutor.BackgroundImage");
            btnNuevoTutor.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevoTutor.Location = new Point(164, 287);
            btnNuevoTutor.Name = "btnNuevoTutor";
            btnNuevoTutor.Size = new Size(147, 68);
            btnNuevoTutor.TabIndex = 0;
            btnNuevoTutor.UseVisualStyleBackColor = true;
            // 
            // btnAgregarTutor
            // 
            btnAgregarTutor.BackgroundImage = (Image)resources.GetObject("btnAgregarTutor.BackgroundImage");
            btnAgregarTutor.BackgroundImageLayout = ImageLayout.Stretch;
            btnAgregarTutor.Location = new Point(400, 287);
            btnAgregarTutor.Name = "btnAgregarTutor";
            btnAgregarTutor.Size = new Size(147, 68);
            btnAgregarTutor.TabIndex = 1;
            btnAgregarTutor.UseVisualStyleBackColor = true;
            // 
            // btnEliminarTutor
            // 
            btnEliminarTutor.BackgroundImage = (Image)resources.GetObject("btnEliminarTutor.BackgroundImage");
            btnEliminarTutor.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminarTutor.Location = new Point(646, 287);
            btnEliminarTutor.Name = "btnEliminarTutor";
            btnEliminarTutor.Size = new Size(147, 68);
            btnEliminarTutor.TabIndex = 2;
            btnEliminarTutor.UseVisualStyleBackColor = true;
            // 
            // dgvTutores
            // 
            dgvTutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTutores.Location = new Point(160, 563);
            dgvTutores.Name = "dgvTutores";
            dgvTutores.RowHeadersWidth = 51;
            dgvTutores.Size = new Size(957, 188);
            dgvTutores.TabIndex = 3;
            // 
            // panel1
            // 
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
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(164, 204);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Ingrese su Telefono";
            txtTelefono.Size = new Size(629, 36);
            txtTelefono.TabIndex = 6;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDireccion.Location = new Point(164, 152);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Ingrese su Dirección";
            txtDireccion.Size = new Size(629, 36);
            txtDireccion.TabIndex = 5;
            // 
            // txtParentesco
            // 
            txtParentesco.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtParentesco.Location = new Point(164, 89);
            txtParentesco.Name = "txtParentesco";
            txtParentesco.PlaceholderText = "Ingrese su Parentesco";
            txtParentesco.Size = new Size(629, 36);
            txtParentesco.TabIndex = 4;
            // 
            // txtNombreTutor
            // 
            txtNombreTutor.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreTutor.Location = new Point(164, 30);
            txtNombreTutor.Name = "txtNombreTutor";
            txtNombreTutor.PlaceholderText = "Ingrese el nombre completo del tutor";
            txtNombreTutor.Size = new Size(629, 36);
            txtNombreTutor.TabIndex = 3;
            // 
            // txtBuscarTutor
            // 
            txtBuscarTutor.Font = new Font("Book Antiqua", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarTutor.Location = new Point(866, 518);
            txtBuscarTutor.Name = "txtBuscarTutor";
            txtBuscarTutor.PlaceholderText = "Buscar Tutor";
            txtBuscarTutor.Size = new Size(251, 39);
            txtBuscarTutor.TabIndex = 5;
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
            Controls.Add(dgvTutores);
            DoubleBuffered = true;
            Name = "frmTutor";
            Text = "Tutores";
            ((System.ComponentModel.ISupportInitialize)dgvTutores).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevoTutor;
        private Button btnAgregarTutor;
        private Button btnEliminarTutor;
        private DataGridView dgvTutores;
        private Panel panel1;
        private TextBox txtBuscarTutor;
        private Label lblTitulo;
        private TextBox txtNombreTutor;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtParentesco;
    }
}