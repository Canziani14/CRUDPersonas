namespace WinUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgPersonas = new System.Windows.Forms.DataGridView();
            this.btnListarPersonas = new System.Windows.Forms.Button();
            this.btnAgregarPersona = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnBusquedaPorID = new System.Windows.Forms.Button();
            this.IDaBuscar = new System.Windows.Forms.Label();
            this.txtBuscarPorID = new System.Windows.Forms.TextBox();
            this.txtIDaEliminar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizarPersona = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgPersonas
            // 
            this.dgPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPersonas.Location = new System.Drawing.Point(16, 31);
            this.dgPersonas.Margin = new System.Windows.Forms.Padding(4);
            this.dgPersonas.Name = "dgPersonas";
            this.dgPersonas.Size = new System.Drawing.Size(429, 272);
            this.dgPersonas.TabIndex = 0;
            // 
            // btnListarPersonas
            // 
            this.btnListarPersonas.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnListarPersonas.Location = new System.Drawing.Point(16, 311);
            this.btnListarPersonas.Margin = new System.Windows.Forms.Padding(4);
            this.btnListarPersonas.Name = "btnListarPersonas";
            this.btnListarPersonas.Size = new System.Drawing.Size(159, 28);
            this.btnListarPersonas.TabIndex = 1;
            this.btnListarPersonas.Text = "Listar Personas";
            this.btnListarPersonas.UseVisualStyleBackColor = false;
            this.btnListarPersonas.Click += new System.EventHandler(this.btnListarPersonas_Click);
            // 
            // btnAgregarPersona
            // 
            this.btnAgregarPersona.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAgregarPersona.Location = new System.Drawing.Point(-3, 202);
            this.btnAgregarPersona.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarPersona.Name = "btnAgregarPersona";
            this.btnAgregarPersona.Size = new System.Drawing.Size(151, 28);
            this.btnAgregarPersona.TabIndex = 3;
            this.btnAgregarPersona.Text = "Agregar Persona";
            this.btnAgregarPersona.UseVisualStyleBackColor = false;
            this.btnAgregarPersona.Click += new System.EventHandler(this.btnAgregarPersona_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(45, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Edad";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(118, 49);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(44, 22);
            this.txtID.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(118, 86);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(169, 22);
            this.txtNombre.TabIndex = 9;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(118, 172);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(4);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(52, 22);
            this.txtEdad.TabIndex = 11;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(118, 128);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(169, 22);
            this.txtApellido.TabIndex = 10;
            // 
            // btnBusquedaPorID
            // 
            this.btnBusquedaPorID.Location = new System.Drawing.Point(42, 58);
            this.btnBusquedaPorID.Name = "btnBusquedaPorID";
            this.btnBusquedaPorID.Size = new System.Drawing.Size(73, 23);
            this.btnBusquedaPorID.TabIndex = 12;
            this.btnBusquedaPorID.Text = "Buscar";
            this.btnBusquedaPorID.UseVisualStyleBackColor = true;
            this.btnBusquedaPorID.Click += new System.EventHandler(this.btnBusquedaPorID_Click);
            // 
            // IDaBuscar
            // 
            this.IDaBuscar.AutoSize = true;
            this.IDaBuscar.Location = new System.Drawing.Point(46, 30);
            this.IDaBuscar.Name = "IDaBuscar";
            this.IDaBuscar.Size = new System.Drawing.Size(20, 16);
            this.IDaBuscar.TabIndex = 13;
            this.IDaBuscar.Text = "ID";
            // 
            // txtBuscarPorID
            // 
            this.txtBuscarPorID.Location = new System.Drawing.Point(72, 27);
            this.txtBuscarPorID.Name = "txtBuscarPorID";
            this.txtBuscarPorID.Size = new System.Drawing.Size(43, 22);
            this.txtBuscarPorID.TabIndex = 14;
            // 
            // txtIDaEliminar
            // 
            this.txtIDaEliminar.Location = new System.Drawing.Point(79, 21);
            this.txtIDaEliminar.Name = "txtIDaEliminar";
            this.txtIDaEliminar.Size = new System.Drawing.Size(43, 22);
            this.txtIDaEliminar.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "ID";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(49, 52);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(73, 23);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizarPersona
            // 
            this.btnActualizarPersona.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnActualizarPersona.Location = new System.Drawing.Point(156, 202);
            this.btnActualizarPersona.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizarPersona.Name = "btnActualizarPersona";
            this.btnActualizarPersona.Size = new System.Drawing.Size(151, 28);
            this.btnActualizarPersona.TabIndex = 18;
            this.btnActualizarPersona.Text = "Actualizar Persona";
            this.btnActualizarPersona.UseVisualStyleBackColor = false;
            this.btnActualizarPersona.Click += new System.EventHandler(this.btnActualizarPersona_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBusquedaPorID);
            this.groupBox1.Controls.Add(this.IDaBuscar);
            this.groupBox1.Controls.Add(this.txtBuscarPorID);
            this.groupBox1.Location = new System.Drawing.Point(31, 352);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Por ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtIDaEliminar);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(536, 352);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eliminar Por ID";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtApellido);
            this.groupBox3.Controls.Add(this.btnAgregarPersona);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnActualizarPersona);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtEdad);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtNombre);
            this.groupBox3.Controls.Add(this.txtID);
            this.groupBox3.Location = new System.Drawing.Point(452, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(320, 263);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alta y Modificacion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(813, 464);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnListarPersonas);
            this.Controls.Add(this.dgPersonas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.IndianRed;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "CRUD";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPersonas;
        private System.Windows.Forms.Button btnListarPersonas;
        private System.Windows.Forms.Button btnAgregarPersona;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnBusquedaPorID;
        private System.Windows.Forms.Label IDaBuscar;
        private System.Windows.Forms.TextBox txtBuscarPorID;
        private System.Windows.Forms.TextBox txtIDaEliminar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizarPersona;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

