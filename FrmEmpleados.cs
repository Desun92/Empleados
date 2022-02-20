using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleados
{
    //LA BASE DE DATOS NO CONTIENE REGISTROS ÚNICOS A EXCEPCIÓN DE LA CLAVE PRIMARIA, ESTO QUIERE DECIR QUE PODEMOS TENER DOS REGISTROS EXACTAMENTE IGUALES A EXCEPCIÓN DE SU CLAVE
    //POR LO QUE PODEMOS TENER UN EMPLEADO CON LOS MISMOS DATOS EXACTOS A OTRO A EXCEPCIÓN DE SU CLAVE. ESTE PROGRAMA ESTÁ HECHO PARA QUE, EN CASO DE CAMBIAR DICHA ESTRUCTURA EN LA BASE DE DATOS
    //E INTENTAR INSERTAR UN CAMPO QUE ANTES PODÍA REPETIRSE Y AHORA NO, SALTE UN ERROR Y NO PERMITA SU ALTA. POR EJEMPLO, SI EL CAMPO APELLIDO EN LA BASE DE DATOS FUESE ÚNICO E INTENTÁSEMOS
    //CREAR UN REGISTRO CON UN APELLIDO IGUAL AL DE OTRO EMPLEADO, NOS SALTARÍA UN ERROR QUE NO NOS DEJARÍA HACERLO. AHORA SÍ, PUESTO QUE EL CAMPO DE APELLIDO EN LA ESTRUCTURA DE LA BASE NO ES ÚNICO.
    public partial class FrmEmpleados : Form
    {
        IDbConnection IdbConnection;
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void Conexion(object sender, EventArgs e) //MÉTODO PARA CONECTAR A LA BASE DE DATOS
        {
            IdbConnection = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\\temp\\Emple.mdb");
            IdbConnection.Open();
            MessageBox.Show("Conexión establecida","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
            MostrarInfo();
        }

        private void Desconexion(object sender, FormClosingEventArgs e) //MÉTODO PARA DESCONECTAR LA BASE DE DATOS
        {
            if (IdbConnection.State == ConnectionState.Open)
            {
                IdbConnection.Close();
                MessageBox.Show("Conexión cerrada","Info", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void MostrarInfo() //MÉTODO PARA MOSTRAR LA LISTA DE DEPARTAMENTOS Y LOCALIZACIONES
        {
            try
            {
                IDbCommand command = IdbConnection.CreateCommand();
                command.CommandText = "Select * from DEPART";
                IDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    LstPKDepartamentos.Items.Add(Convert.ToInt32(reader.GetValue(0)));
                    LstDepartamento.Items.Add(reader.GetValue(1).ToString());
                    LstLocalizacion.Items.Add(reader.GetValue(2).ToString());
                }

                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e) //MÉTODO PARA SALIR
        {
            this.Close();
        }

        private void LstDepartamento_SelectedIndexChanged(object sender, EventArgs e) //MÉTODO PARA MOSTRAR LOS DATOS DE LOS EMPLEADOS PERTENECIENTES A UN DEPARTAMENTO
        {
            //Cuando hagamos click en algún componente del Listbox de departamento, se seleccionará el mismo índice
            //en la Listbox de claves primarias de los departamentos, de manera que así siempre tendremos la PK de dicho departamento para facilitar operaciones
            LstPKDepartamentos.SelectedIndex = LstDepartamento.SelectedIndex;
            LimpiarListasEmpleados();

            if(LstDepartamento.SelectedIndex>-1)
                MostrarDatosEmpleadosDepartamento();
        }

        private void LstLocalizacion_SelectedIndexChanged(object sender, EventArgs e) //MÉTODO PARA MOSTRAR LOS DATOS DE LOS EMPLEADOS QUE PERTENECEN A LOS DEPARTAMENTOS UBICADOS EN UNA LOCALIZACIÓN CONCRETA (POR ESO NO HE HECHO QUE SI CLICAS EN UN DEPARTAMENTO, AUTOMÁTICAMENTE SE SELECCIONE TAMBIÉN SU LOCALIZACIÓN, PARA ASÍ PODER HACER UNA CONSULTA ALGO MÁS COMPLEJA)
        {
            LimpiarListasEmpleados();
            if (LstLocalizacion.SelectedIndex > -1)
                MostrarDatosEmpleadosLocalizacion();
        }

        private void LimpiarListasDepartamentos() //MÉTODO PARA LIMPIAR LAS LISTAS CON INFORMACIÓN PERTENECIENTE A LOS DEPARTAMENTOS
        {
            LstPKDepartamentos.Items.Clear();
            LstDepartamento.Items.Clear();
            LstLocalizacion.Items.Clear();
        }

        private void LimpiarListasEmpleados() //MÉTODO PARA LIMPIAR LAS LISTAS CON INFORMACIÓN PERTENECIENTE A LOS EMPLEADOS
        {
            LstPKEmpleados.Items.Clear();
            LstApellidos.Items.Clear();
            LstOficio.Items.Clear();
            LstSalario.Items.Clear();
            LstFechaAlta.Items.Clear();
            LstComision.Items.Clear();
        }

        private void LimpiarTXT() //MÉTODO PARA LIMPIAR TODAS LAS TEXTBOX DEL FORMULARIO
        {
            foreach(TextBox text in this.Controls.OfType<TextBox>())
            {
                text.Clear();
            }
        }

        private void MostrarDatosEmpleadosDepartamento() //MÉTODO PARA MOSTRAR TODOS LOS DATOS DE LOS EMPLEADOS ASOCIADOS A UN DEPARTAMENTO
        {
            try
            {
                IDbCommand command = IdbConnection.CreateCommand();
                command.CommandText = "select * from emple where dept_no = " + LstPKDepartamentos.SelectedItem.ToString();
                IDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    LstPKEmpleados.Items.Add(reader.GetValue(0).ToString());
                    LstApellidos.Items.Add(reader.GetValue(1).ToString());
                    LstOficio.Items.Add(reader.GetValue(2).ToString());
                    LstSalario.Items.Add(reader.GetValue(5).ToString());
                    LstFechaAlta.Items.Add(reader.GetValue(4).ToString());
                    LstComision.Items.Add(reader.GetValue(6).ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarDatosEmpleadosLocalizacion() //MÉTODO PARA MOSTRAR TODOS LOS DATOS DE LOS EMPLEADOS QUE PERTENECEN A DEPARTAMENTOS DE UNA LOCALIZACIÓN CONCRETA
        {
            try
            {
                IDbCommand command = IdbConnection.CreateCommand();
                command.CommandText = "select e.* from emple e, depart d where e.dept_no = d.dept_no and loc = '"+LstLocalizacion.SelectedItem.ToString()+"'";
                IDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    LstPKEmpleados.Items.Add(reader.GetValue(0).ToString());
                    LstApellidos.Items.Add(reader.GetValue(1).ToString());
                    LstOficio.Items.Add(reader.GetValue(2).ToString());
                    LstSalario.Items.Add(reader.GetValue(5).ToString());
                    LstFechaAlta.Items.Add(reader.GetValue(4).ToString());
                    LstComision.Items.Add(reader.GetValue(6).ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LstApellidos_SelectedIndexChanged(object sender, EventArgs e) //MÉTODO PARA QUE, AL SELECCIONAR UN ITEM EN UNA LISTA PERTENECIENTE A LA INFORMACIÓN DE EMPLEADOS, TAMBIÉN LO HAGAN LAS OTRAS LISTAS
        {
            LstPKEmpleados.SelectedIndex = LstApellidos.SelectedIndex;
            LstOficio.SelectedIndex = LstApellidos.SelectedIndex;
            LstSalario.SelectedIndex = LstApellidos.SelectedIndex;
            LstFechaAlta.SelectedIndex = LstApellidos.SelectedIndex;
            LstComision.SelectedIndex = LstApellidos.SelectedIndex;
            MostrarCamposEditables();
        }

        private void LstOficio_SelectedIndexChanged(object sender, EventArgs e) //MÉTODO PARA QUE, AL SELECCIONAR UN ITEM EN UNA LISTA PERTENECIENTE A LA INFORMACIÓN DE EMPLEADOS, TAMBIÉN LO HAGAN LAS OTRAS LISTAS
        {
            LstPKEmpleados.SelectedIndex = LstOficio.SelectedIndex;
            LstApellidos.SelectedIndex = LstOficio.SelectedIndex;
            LstSalario.SelectedIndex = LstOficio.SelectedIndex;
            LstFechaAlta.SelectedIndex = LstOficio.SelectedIndex;
            LstComision.SelectedIndex = LstOficio.SelectedIndex;
            MostrarCamposEditables();
        }

        private void LstSalario_SelectedIndexChanged(object sender, EventArgs e) //MÉTODO PARA QUE, AL SELECCIONAR UN ITEM EN UNA LISTA PERTENECIENTE A LA INFORMACIÓN DE EMPLEADOS, TAMBIÉN LO HAGAN LAS OTRAS LISTAS
        {
            LstPKEmpleados.SelectedIndex = LstSalario.SelectedIndex;
            LstApellidos.SelectedIndex = LstSalario.SelectedIndex;
            LstOficio.SelectedIndex = LstSalario.SelectedIndex;
            LstFechaAlta.SelectedIndex = LstSalario.SelectedIndex;
            LstComision.SelectedIndex = LstSalario.SelectedIndex;
            MostrarCamposEditables();
        }

        private void LstFechaAlta_SelectedIndexChanged(object sender, EventArgs e) //MÉTODO PARA QUE, AL SELECCIONAR UN ITEM EN UNA LISTA PERTENECIENTE A LA INFORMACIÓN DE EMPLEADOS, TAMBIÉN LO HAGAN LAS OTRAS LISTAS
        {
            LstPKEmpleados.SelectedIndex = LstFechaAlta.SelectedIndex;
            LstApellidos.SelectedIndex = LstFechaAlta.SelectedIndex;
            LstOficio.SelectedIndex = LstFechaAlta.SelectedIndex;
            LstSalario.SelectedIndex = LstFechaAlta.SelectedIndex;
            LstComision.SelectedIndex = LstFechaAlta.SelectedIndex;
            MostrarCamposEditables();
        }

        private void LstComision_SelectedIndexChanged(object sender, EventArgs e) //MÉTODO PARA QUE, AL SELECCIONAR UN ITEM EN UNA LISTA PERTENECIENTE A LA INFORMACIÓN DE EMPLEADOS, TAMBIÉN LO HAGAN LAS OTRAS LISTAS
        {
            LstPKEmpleados.SelectedIndex = LstComision.SelectedIndex;
            LstApellidos.SelectedIndex = LstComision.SelectedIndex;
            LstOficio.SelectedIndex = LstComision.SelectedIndex;
            LstSalario.SelectedIndex = LstComision.SelectedIndex;
            LstFechaAlta.SelectedIndex = LstComision.SelectedIndex;
            MostrarCamposEditables();
        }

        private void MostrarCamposEditables() //MÉTODO PARA PONER EN LOS TEXTBOX EDITABLES, LA INFORMACIÓN DE LA LISTBOX DE EMPLEADOS
        {
            TxtApellidos.Text = LstApellidos.SelectedItem.ToString();
            TxtOficio.Text = LstOficio.SelectedItem.ToString();
            TxtSalario.Text = LstSalario.SelectedItem.ToString();
            TxtFechaAlta.Text = LstFechaAlta.SelectedItem.ToString();
            TxtComision.Text = LstComision.SelectedItem.ToString();
        }

        private void BtnArriba_Click(object sender, EventArgs e) //MÉTODO PARA SUBIR EN LA LISTA DE EMPLEADOS
        {
            if (LstApellidos.SelectedIndex > 0)
            {
                LstApellidos.SelectedIndex = LstApellidos.SelectedIndex - 1;
            }
        }

        private void BtnAbajo_Click(object sender, EventArgs e) //MÉTODO PARA BAJAR EN LA LISTA DE EMPLEADOS
        {
            if(LstApellidos.SelectedIndex < LstApellidos.Items.Count-1)
            {
                LstApellidos.SelectedIndex = LstApellidos.SelectedIndex + 1;
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e) //MÉTODO QUE GESTIONA LAS BÚSQUEDAS PARA LA BASE DE DATOS
        {
            //Si el cuadro de búsqueda tiene algo escrito, y hemos seleccionado un criterio de búsqueda, actuamos
            if (TxtBusqueda.Text != "" && LstCampos.SelectedItem!=null) 
            {
                //Nos volcamos lo que haya en el cuadro de búsqueda en la variable criterio
                string criterio = TxtBusqueda.Text;

                //En función de qué campo esté seleccionado en la listbox de "Buscar por" haremos sentencias SQL distintas
                switch (LstCampos.SelectedItem.ToString())
                {
                    case "Apellidos":
                        BuscarPorApellido(criterio);
                        break;

                    case "Oficio":
                        BuscarPorOficio(criterio);
                        break;

                    case "Salario":
                        try
                        {
                            BuscarPorSalario(Convert.ToDouble(criterio));
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;

                    case "Fecha Alta":
                        try
                        {
                            BuscarPorFechaAlta(Convert.ToDateTime(criterio));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;

                    case "Comision":
                        try
                        {
                            BuscarPorComision(Convert.ToDouble(criterio));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;

                    default:
                        break;
                }
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e) //MÉTODO PARA EL BOTÓN DE DAR DE ALTA A UN EMPLEADO
        {
            if (Alta())
            {
                LimpiarTXT();
                LimpiarListasEmpleados();
                LimpiarListasDepartamentos();
                MostrarInfo();
                MessageBox.Show("Alta con éxito", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e) //MÉTODO PARA EL BOTÓN DE DAR DE BAJA A UN EMPLEADO
        {
            if (Baja())
            {
                LimpiarListasEmpleados();
                LimpiarListasDepartamentos();
                MostrarInfo();
                MessageBox.Show("Borrado con éxito", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e) //MÉTODO PARA EL BOTÓN DE GUARDAR UN EMPLEADO
        {
            if (Actualizacion())
            {
                LimpiarTXT();
                LimpiarListasEmpleados();
                LimpiarListasDepartamentos();
                MostrarInfo();
                MessageBox.Show("Actualización con éxito", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool Baja() //MÉTODO QUE GESTIONA LAS BAJAS DE LOS EMPLEADOS
        {
            bool baja = false;

            if (LstApellidos.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona un empleado de la lista para borrarlo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string pk = LstPKEmpleados.SelectedItem.ToString();
                    IDbCommand command = IdbConnection.CreateCommand();
                    command.CommandText = "Delete from emple where emp_no = "+pk;
                    command.ExecuteNonQuery();
                    baja = true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return baja;
        }

        private bool Alta() //MÉTODO QUE GESTIONA LAS ALTAS DE LOS EMPLEADOS
        {
            bool alta = false;
            if (ComprobarCampos())
            {
                try
                {
                    //Volcamos los contenidos de los txt en variables
                    string apellido = TxtApellidos.Text;
                    string oficio = TxtOficio.Text;
                    string salario = TxtSalario.Text;

                    //Generamos la fecha de hoy y la convertimos en formato corto para su inserción
                    DateTime dt = DateTime.Today;
                    string fecha = dt.ToShortDateString();

                    string comision = TxtComision.Text;
                    string departamento = LstPKDepartamentos.SelectedItem.ToString();

                    //Generamos una consulta que nos devuelve el valor máximo de las claves primarias de la tabla, para así generar un valor máximo nuevo de uno más
                    IDbCommand commandPK = IdbConnection.CreateCommand();
                    commandPK.CommandText = "select max(emp_no) from emple";
                    int pk = Convert.ToInt32(commandPK.ExecuteScalar());
                    pk++;

                    IDbCommand command = IdbConnection.CreateCommand();
                    command.CommandText = "insert into emple (emp_no,apellido,oficio,fecha_alt,salario,comision,dept_no) values ("+pk+",'"+apellido+"','"+oficio+"','"+fecha+"',"+salario+","+comision+","+departamento+")";
                    command.ExecuteNonQuery();
                    alta = true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Faltan campos por rellenar, o bien, seleccionar un departamento", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return alta;
        }

        public bool Actualizacion() //MÉTODO QUE GESTIONA LA ACTUALIZACIÓN DE LOS EMPLEADOS
        {
            bool actualizado = false;

            if (ComprobarCampos() && LstPKEmpleados.SelectedIndex>-1)
            {
                try
                {
                    string pk = LstPKEmpleados.SelectedItem.ToString();
                    string apellido = TxtApellidos.Text;
                    string oficio = TxtOficio.Text;
                    string salario = TxtSalario.Text;
                    string comision = TxtComision.Text;
                    string departamento = LstPKDepartamentos.SelectedItem.ToString();

                    IDbCommand command = IdbConnection.CreateCommand();
                    command.CommandText = "update emple set apellido = '"+apellido+"', oficio = '"+oficio+"', salario = "+salario+", comision = "+comision+", dept_no = "+departamento+" where emp_no = "+pk;
                    command.ExecuteNonQuery();
                    actualizado = true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Faltan campos por rellenar, o bien, seleccionar un departamento o empleado a actualizar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return actualizado;
        }

        private void BuscarPorApellido(string apellido) //MÉTODO QUE GESTIONA LAS BÚSQUEDAS POR APELLIDO
        {
            //Variable booleana para ver si el reader tiene al menos un registro, ya que si no es asi, no pasa por el while
            bool pasa = false;
            try
            {
                IDbCommand command = IdbConnection.CreateCommand();
                command.CommandText = "select * from emple where apellido = '"+apellido+"'";
                IDataReader reader = command.ExecuteReader();
                LimpiarListasEmpleados();

                while (reader.Read())
                {
                    LstPKEmpleados.Items.Add(reader.GetValue(0).ToString());
                    LstApellidos.Items.Add(reader.GetValue(1).ToString());
                    LstOficio.Items.Add(reader.GetValue(2).ToString());
                    LstSalario.Items.Add(reader.GetValue(5).ToString());
                    LstFechaAlta.Items.Add(reader.GetValue(4).ToString());
                    LstComision.Items.Add(reader.GetValue(6).ToString());
                    pasa = true;
                }

                if (!pasa)
                {
                    MessageBox.Show("No existen registros para ese apellido","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarPorOficio(string oficio) //MÉTODO QUE GESTIONA LAS BÚSQUEDAS POR OFICIO
        {
            bool pasa = false;
            try
            {
                IDbCommand command = IdbConnection.CreateCommand();
                command.CommandText = "select * from emple where oficio = '" + oficio + "'";
                IDataReader reader = command.ExecuteReader();
                LimpiarListasEmpleados();

                while (reader.Read())
                {
                    LstPKEmpleados.Items.Add(reader.GetValue(0).ToString());
                    LstApellidos.Items.Add(reader.GetValue(1).ToString());
                    LstOficio.Items.Add(reader.GetValue(2).ToString());
                    LstSalario.Items.Add(reader.GetValue(5).ToString());
                    LstFechaAlta.Items.Add(reader.GetValue(4).ToString());
                    LstComision.Items.Add(reader.GetValue(6).ToString());
                    pasa = true;
                }

                if (!pasa)
                {
                    MessageBox.Show("No existen registros para ese oficio","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarPorSalario(double salario) //MÉTODO QUE GESTIONA LAS BÚSQUEDAS POR SALARIO
        {
            bool pasa = false;
            try
            {
                string salar = Convert.ToString(salario);
                IDbCommand command = IdbConnection.CreateCommand();
                command.CommandText = "select * from emple where salario = " + salar;
                IDataReader reader = command.ExecuteReader();
                LimpiarListasEmpleados();

                while (reader.Read())
                {
                    LstPKEmpleados.Items.Add(reader.GetValue(0).ToString());
                    LstApellidos.Items.Add(reader.GetValue(1).ToString());
                    LstOficio.Items.Add(reader.GetValue(2).ToString());
                    LstSalario.Items.Add(reader.GetValue(5).ToString());
                    LstFechaAlta.Items.Add(reader.GetValue(4).ToString());
                    LstComision.Items.Add(reader.GetValue(6).ToString());
                    pasa = true;
                }

                if (!pasa)
                {
                    MessageBox.Show("No existen registros para ese salario","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarPorFechaAlta(DateTime fecha) //MÉTODO QUE GESTIONA LAS BÚSQUEDAS POR FECHA DE ALTA
        {
            bool pasa = false;
            try
            {
                string fecha2 = fecha.ToShortDateString();
                IDbCommand command = IdbConnection.CreateCommand();
                command.CommandText = "select * from emple where fecha_alt like ('" + fecha2 + "')";
                IDataReader reader = command.ExecuteReader();
                LimpiarListasEmpleados();

                while (reader.Read())
                {
                    LstPKEmpleados.Items.Add(reader.GetValue(0).ToString());
                    LstApellidos.Items.Add(reader.GetValue(1).ToString());
                    LstOficio.Items.Add(reader.GetValue(2).ToString());
                    LstSalario.Items.Add(reader.GetValue(5).ToString());
                    LstFechaAlta.Items.Add(reader.GetValue(4).ToString());
                    LstComision.Items.Add(reader.GetValue(6).ToString());
                    pasa = true;
                }

                if (!pasa)
                {
                    MessageBox.Show("No existen registros para esa fecha","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarPorComision(double comision) //MÉTODO QUE GESTIONA LAS BÚSQUEDAS POR COMISIÓN
        {
            bool pasa = false;
            try
            {
                string comis = Convert.ToString(comision);
                IDbCommand command = IdbConnection.CreateCommand();
                command.CommandText = "select * from emple where comision = " + comision;
                IDataReader reader = command.ExecuteReader();
                LimpiarListasEmpleados();

                while (reader.Read())
                {
                    LstPKEmpleados.Items.Add(reader.GetValue(0).ToString());
                    LstApellidos.Items.Add(reader.GetValue(1).ToString());
                    LstOficio.Items.Add(reader.GetValue(2).ToString());
                    LstSalario.Items.Add(reader.GetValue(5).ToString());
                    LstFechaAlta.Items.Add(reader.GetValue(4).ToString());
                    LstComision.Items.Add(reader.GetValue(6).ToString());
                    pasa = true;
                }

                if (!pasa)
                {
                    MessageBox.Show("No existen registros para esa comisión","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ComprobarCampos() //MÉTODO PARA COMPROBAR LOS DATOS ASOCIADOS A LOS TEXTBOX ANTES DE SU TRATAMIENTO
        {
            return TxtApellidos.Text != "" && TxtOficio.Text != "" && TxtSalario.Text != "" && TxtComision.Text != "" && LstDepartamento.SelectedIndex>-1;
        }
    }
}
