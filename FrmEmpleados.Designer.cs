
namespace Empleados
{
    partial class FrmEmpleados
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
            this.LblDepartamento = new System.Windows.Forms.Label();
            this.LblLocalizacion = new System.Windows.Forms.Label();
            this.LblApellidos = new System.Windows.Forms.Label();
            this.LblComision = new System.Windows.Forms.Label();
            this.LblFechaAlta = new System.Windows.Forms.Label();
            this.LblSalario = new System.Windows.Forms.Label();
            this.LblOficio = new System.Windows.Forms.Label();
            this.LblBuscarPor = new System.Windows.Forms.Label();
            this.LblIgual = new System.Windows.Forms.Label();
            this.LstDepartamento = new System.Windows.Forms.ListBox();
            this.LstLocalizacion = new System.Windows.Forms.ListBox();
            this.LstApellidos = new System.Windows.Forms.ListBox();
            this.LstOficio = new System.Windows.Forms.ListBox();
            this.LstSalario = new System.Windows.Forms.ListBox();
            this.LstFechaAlta = new System.Windows.Forms.ListBox();
            this.LstComision = new System.Windows.Forms.ListBox();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.TxtOficio = new System.Windows.Forms.TextBox();
            this.TxtSalario = new System.Windows.Forms.TextBox();
            this.TxtFechaAlta = new System.Windows.Forms.TextBox();
            this.TxtComision = new System.Windows.Forms.TextBox();
            this.LstCampos = new System.Windows.Forms.ListBox();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnArriba = new System.Windows.Forms.Button();
            this.BtnAbajo = new System.Windows.Forms.Button();
            this.LstPKDepartamentos = new System.Windows.Forms.ListBox();
            this.LstPKEmpleados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LblDepartamento
            // 
            this.LblDepartamento.AutoSize = true;
            this.LblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDepartamento.Location = new System.Drawing.Point(122, 52);
            this.LblDepartamento.Name = "LblDepartamento";
            this.LblDepartamento.Size = new System.Drawing.Size(140, 24);
            this.LblDepartamento.TabIndex = 0;
            this.LblDepartamento.Text = "Departamento";
            // 
            // LblLocalizacion
            // 
            this.LblLocalizacion.AutoSize = true;
            this.LblLocalizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLocalizacion.Location = new System.Drawing.Point(435, 52);
            this.LblLocalizacion.Name = "LblLocalizacion";
            this.LblLocalizacion.Size = new System.Drawing.Size(126, 24);
            this.LblLocalizacion.TabIndex = 1;
            this.LblLocalizacion.Text = "Localización";
            // 
            // LblApellidos
            // 
            this.LblApellidos.AutoSize = true;
            this.LblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellidos.Location = new System.Drawing.Point(12, 225);
            this.LblApellidos.Name = "LblApellidos";
            this.LblApellidos.Size = new System.Drawing.Size(82, 20);
            this.LblApellidos.TabIndex = 2;
            this.LblApellidos.Text = "Apellidos";
            // 
            // LblComision
            // 
            this.LblComision.AutoSize = true;
            this.LblComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblComision.Location = new System.Drawing.Point(536, 225);
            this.LblComision.Name = "LblComision";
            this.LblComision.Size = new System.Drawing.Size(82, 20);
            this.LblComision.TabIndex = 3;
            this.LblComision.Text = "Comisión";
            // 
            // LblFechaAlta
            // 
            this.LblFechaAlta.AutoSize = true;
            this.LblFechaAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaAlta.Location = new System.Drawing.Point(395, 225);
            this.LblFechaAlta.Name = "LblFechaAlta";
            this.LblFechaAlta.Size = new System.Drawing.Size(96, 20);
            this.LblFechaAlta.TabIndex = 4;
            this.LblFechaAlta.Text = "Fecha Alta";
            // 
            // LblSalario
            // 
            this.LblSalario.AutoSize = true;
            this.LblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSalario.Location = new System.Drawing.Point(258, 225);
            this.LblSalario.Name = "LblSalario";
            this.LblSalario.Size = new System.Drawing.Size(65, 20);
            this.LblSalario.TabIndex = 5;
            this.LblSalario.Text = "Salario";
            // 
            // LblOficio
            // 
            this.LblOficio.AutoSize = true;
            this.LblOficio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOficio.Location = new System.Drawing.Point(131, 225);
            this.LblOficio.Name = "LblOficio";
            this.LblOficio.Size = new System.Drawing.Size(55, 20);
            this.LblOficio.TabIndex = 6;
            this.LblOficio.Text = "Oficio";
            // 
            // LblBuscarPor
            // 
            this.LblBuscarPor.AutoSize = true;
            this.LblBuscarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuscarPor.Location = new System.Drawing.Point(8, 523);
            this.LblBuscarPor.Name = "LblBuscarPor";
            this.LblBuscarPor.Size = new System.Drawing.Size(96, 20);
            this.LblBuscarPor.TabIndex = 7;
            this.LblBuscarPor.Text = "Buscar por";
            // 
            // LblIgual
            // 
            this.LblIgual.AutoSize = true;
            this.LblIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIgual.Location = new System.Drawing.Point(263, 523);
            this.LblIgual.Name = "LblIgual";
            this.LblIgual.Size = new System.Drawing.Size(25, 25);
            this.LblIgual.TabIndex = 8;
            this.LblIgual.Text = "=";
            // 
            // LstDepartamento
            // 
            this.LstDepartamento.FormattingEnabled = true;
            this.LstDepartamento.Location = new System.Drawing.Point(55, 79);
            this.LstDepartamento.Name = "LstDepartamento";
            this.LstDepartamento.Size = new System.Drawing.Size(277, 121);
            this.LstDepartamento.TabIndex = 9;
            this.LstDepartamento.SelectedIndexChanged += new System.EventHandler(this.LstDepartamento_SelectedIndexChanged);
            // 
            // LstLocalizacion
            // 
            this.LstLocalizacion.FormattingEnabled = true;
            this.LstLocalizacion.Location = new System.Drawing.Point(358, 79);
            this.LstLocalizacion.Name = "LstLocalizacion";
            this.LstLocalizacion.Size = new System.Drawing.Size(277, 121);
            this.LstLocalizacion.TabIndex = 10;
            this.LstLocalizacion.SelectedIndexChanged += new System.EventHandler(this.LstLocalizacion_SelectedIndexChanged);
            // 
            // LstApellidos
            // 
            this.LstApellidos.FormattingEnabled = true;
            this.LstApellidos.Location = new System.Drawing.Point(12, 248);
            this.LstApellidos.Name = "LstApellidos";
            this.LstApellidos.Size = new System.Drawing.Size(96, 147);
            this.LstApellidos.TabIndex = 11;
            this.LstApellidos.SelectedIndexChanged += new System.EventHandler(this.LstApellidos_SelectedIndexChanged);
            // 
            // LstOficio
            // 
            this.LstOficio.FormattingEnabled = true;
            this.LstOficio.Location = new System.Drawing.Point(135, 248);
            this.LstOficio.Name = "LstOficio";
            this.LstOficio.Size = new System.Drawing.Size(96, 147);
            this.LstOficio.TabIndex = 12;
            this.LstOficio.SelectedIndexChanged += new System.EventHandler(this.LstOficio_SelectedIndexChanged);
            // 
            // LstSalario
            // 
            this.LstSalario.FormattingEnabled = true;
            this.LstSalario.Location = new System.Drawing.Point(262, 248);
            this.LstSalario.Name = "LstSalario";
            this.LstSalario.Size = new System.Drawing.Size(96, 147);
            this.LstSalario.TabIndex = 13;
            this.LstSalario.SelectedIndexChanged += new System.EventHandler(this.LstSalario_SelectedIndexChanged);
            // 
            // LstFechaAlta
            // 
            this.LstFechaAlta.FormattingEnabled = true;
            this.LstFechaAlta.Location = new System.Drawing.Point(399, 248);
            this.LstFechaAlta.Name = "LstFechaAlta";
            this.LstFechaAlta.Size = new System.Drawing.Size(96, 147);
            this.LstFechaAlta.TabIndex = 14;
            this.LstFechaAlta.SelectedIndexChanged += new System.EventHandler(this.LstFechaAlta_SelectedIndexChanged);
            // 
            // LstComision
            // 
            this.LstComision.FormattingEnabled = true;
            this.LstComision.Location = new System.Drawing.Point(540, 248);
            this.LstComision.Name = "LstComision";
            this.LstComision.Size = new System.Drawing.Size(96, 147);
            this.LstComision.TabIndex = 15;
            this.LstComision.SelectedIndexChanged += new System.EventHandler(this.LstComision_SelectedIndexChanged);
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Location = new System.Drawing.Point(12, 432);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(96, 20);
            this.TxtApellidos.TabIndex = 16;
            // 
            // TxtOficio
            // 
            this.TxtOficio.Location = new System.Drawing.Point(135, 432);
            this.TxtOficio.Name = "TxtOficio";
            this.TxtOficio.Size = new System.Drawing.Size(96, 20);
            this.TxtOficio.TabIndex = 17;
            // 
            // TxtSalario
            // 
            this.TxtSalario.Location = new System.Drawing.Point(262, 432);
            this.TxtSalario.Name = "TxtSalario";
            this.TxtSalario.Size = new System.Drawing.Size(96, 20);
            this.TxtSalario.TabIndex = 18;
            // 
            // TxtFechaAlta
            // 
            this.TxtFechaAlta.Location = new System.Drawing.Point(399, 432);
            this.TxtFechaAlta.Name = "TxtFechaAlta";
            this.TxtFechaAlta.ReadOnly = true;
            this.TxtFechaAlta.Size = new System.Drawing.Size(96, 20);
            this.TxtFechaAlta.TabIndex = 19;
            // 
            // TxtComision
            // 
            this.TxtComision.Location = new System.Drawing.Point(540, 432);
            this.TxtComision.Name = "TxtComision";
            this.TxtComision.Size = new System.Drawing.Size(96, 20);
            this.TxtComision.TabIndex = 20;
            // 
            // LstCampos
            // 
            this.LstCampos.FormattingEnabled = true;
            this.LstCampos.Items.AddRange(new object[] {
            "Apellidos",
            "Oficio",
            "Salario",
            "Fecha Alta",
            "Comision"});
            this.LstCampos.Location = new System.Drawing.Point(126, 502);
            this.LstCampos.Name = "LstCampos";
            this.LstCampos.Size = new System.Drawing.Size(120, 69);
            this.LstCampos.TabIndex = 21;
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(294, 525);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(96, 20);
            this.TxtBusqueda.TabIndex = 22;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Image = global::Empleados.Properties.Resources.lupa1;
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBuscar.Location = new System.Drawing.Point(421, 504);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(91, 69);
            this.BtnBuscar.TabIndex = 23;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.Image = global::Empleados.Properties.Resources.star;
            this.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnNuevo.Location = new System.Drawing.Point(725, 552);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(91, 69);
            this.BtnNuevo.TabIndex = 24;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrar.Image = global::Empleados.Properties.Resources.borrar;
            this.BtnBorrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBorrar.Location = new System.Drawing.Point(725, 477);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(91, 69);
            this.BtnBorrar.TabIndex = 25;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBorrar.UseVisualStyleBackColor = true;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Image = global::Empleados.Properties.Resources.save;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnGuardar.Location = new System.Drawing.Point(725, 402);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(91, 69);
            this.BtnGuardar.TabIndex = 26;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Image = global::Empleados.Properties.Resources.exit;
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSalir.Location = new System.Drawing.Point(725, 79);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(91, 69);
            this.BtnSalir.TabIndex = 27;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnArriba
            // 
            this.BtnArriba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnArriba.Image = global::Empleados.Properties.Resources.uparrow;
            this.BtnArriba.Location = new System.Drawing.Point(642, 275);
            this.BtnArriba.Name = "BtnArriba";
            this.BtnArriba.Size = new System.Drawing.Size(48, 46);
            this.BtnArriba.TabIndex = 29;
            this.BtnArriba.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnArriba.UseVisualStyleBackColor = true;
            this.BtnArriba.Click += new System.EventHandler(this.BtnArriba_Click);
            // 
            // BtnAbajo
            // 
            this.BtnAbajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbajo.Image = global::Empleados.Properties.Resources.downarrow;
            this.BtnAbajo.Location = new System.Drawing.Point(642, 327);
            this.BtnAbajo.Name = "BtnAbajo";
            this.BtnAbajo.Size = new System.Drawing.Size(48, 46);
            this.BtnAbajo.TabIndex = 30;
            this.BtnAbajo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAbajo.UseVisualStyleBackColor = true;
            this.BtnAbajo.Click += new System.EventHandler(this.BtnAbajo_Click);
            // 
            // LstPKDepartamentos
            // 
            this.LstPKDepartamentos.FormattingEnabled = true;
            this.LstPKDepartamentos.Location = new System.Drawing.Point(641, 79);
            this.LstPKDepartamentos.Name = "LstPKDepartamentos";
            this.LstPKDepartamentos.Size = new System.Drawing.Size(120, 95);
            this.LstPKDepartamentos.TabIndex = 31;
            this.LstPKDepartamentos.Visible = false;
            // 
            // LstPKEmpleados
            // 
            this.LstPKEmpleados.FormattingEnabled = true;
            this.LstPKEmpleados.Location = new System.Drawing.Point(696, 237);
            this.LstPKEmpleados.Name = "LstPKEmpleados";
            this.LstPKEmpleados.Size = new System.Drawing.Size(120, 95);
            this.LstPKEmpleados.TabIndex = 32;
            this.LstPKEmpleados.Visible = false;
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 633);
            this.Controls.Add(this.LstPKEmpleados);
            this.Controls.Add(this.LstPKDepartamentos);
            this.Controls.Add(this.BtnAbajo);
            this.Controls.Add(this.BtnArriba);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtBusqueda);
            this.Controls.Add(this.LstCampos);
            this.Controls.Add(this.TxtComision);
            this.Controls.Add(this.TxtFechaAlta);
            this.Controls.Add(this.TxtSalario);
            this.Controls.Add(this.TxtOficio);
            this.Controls.Add(this.TxtApellidos);
            this.Controls.Add(this.LstComision);
            this.Controls.Add(this.LstFechaAlta);
            this.Controls.Add(this.LstSalario);
            this.Controls.Add(this.LstOficio);
            this.Controls.Add(this.LstApellidos);
            this.Controls.Add(this.LstLocalizacion);
            this.Controls.Add(this.LstDepartamento);
            this.Controls.Add(this.LblIgual);
            this.Controls.Add(this.LblBuscarPor);
            this.Controls.Add(this.LblOficio);
            this.Controls.Add(this.LblSalario);
            this.Controls.Add(this.LblFechaAlta);
            this.Controls.Add(this.LblComision);
            this.Controls.Add(this.LblApellidos);
            this.Controls.Add(this.LblLocalizacion);
            this.Controls.Add(this.LblDepartamento);
            this.Name = "FrmEmpleados";
            this.Text = "Gestión Empleados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Desconexion);
            this.Load += new System.EventHandler(this.Conexion);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDepartamento;
        private System.Windows.Forms.Label LblLocalizacion;
        private System.Windows.Forms.Label LblApellidos;
        private System.Windows.Forms.Label LblComision;
        private System.Windows.Forms.Label LblFechaAlta;
        private System.Windows.Forms.Label LblSalario;
        private System.Windows.Forms.Label LblOficio;
        private System.Windows.Forms.Label LblBuscarPor;
        private System.Windows.Forms.Label LblIgual;
        private System.Windows.Forms.ListBox LstDepartamento;
        private System.Windows.Forms.ListBox LstLocalizacion;
        private System.Windows.Forms.ListBox LstApellidos;
        private System.Windows.Forms.ListBox LstOficio;
        private System.Windows.Forms.ListBox LstSalario;
        private System.Windows.Forms.ListBox LstFechaAlta;
        private System.Windows.Forms.ListBox LstComision;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.TextBox TxtOficio;
        private System.Windows.Forms.TextBox TxtSalario;
        private System.Windows.Forms.TextBox TxtFechaAlta;
        private System.Windows.Forms.TextBox TxtComision;
        private System.Windows.Forms.ListBox LstCampos;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnArriba;
        private System.Windows.Forms.Button BtnAbajo;
        private System.Windows.Forms.ListBox LstPKDepartamentos;
        private System.Windows.Forms.ListBox LstPKEmpleados;
    }
}

