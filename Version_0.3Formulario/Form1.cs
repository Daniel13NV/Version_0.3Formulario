using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO.Ports;
using MySql.Data.MySqlClient; //Referencias necesarias para trabar con localhost y xampp

namespace Version_0._3Formulario
{
    public partial class Form1 : Form
    {
        //Datos de conexion a MYSQL (XAMPP)
        string conexionSQL = "Server=localhost;Port=3306;Database=programacionavanzada;Uid=root;Pwd=;";
        //Metodo de insertar registros 
        public Form1()
        {
            InitializeComponent();

            //Agregar controladores de eventos TextChanged a los campos 
            tbEdad.TextChanged += ValidarEdad;
            tbEstatura.TextChanged += ValidarEstatura;
            tbTelefono.TextChanged += ValidarTelefono;
            tbNombre.TextChanged += ValidarNombre;
            tbApellidos.TextChanged += ValidarApellidos;
        }

        private void InsertarRegistro(string nombre, string apellidos, int edad, decimal estatura, string telefono, string genero)
        {
            using (MySqlConnection conection = new MySqlConnection(conexionSQL))
            {
                conection.Open();
                string insertQuery = "INSERT INTO registros (Nombre , Apellido, Edad, Estatura, Telefono,Genero)" +
                                       "VALUES (@Nombre, @Apellido,@Edad,@Estatura,@Telefono,@Genero)";
                using (MySqlCommand command = new MySqlCommand(insertQuery, conection))
                {
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellido", apellidos);
                    command.Parameters.AddWithValue("@Edad", edad);
                    command.Parameters.AddWithValue("@Estatura", estatura);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.Parameters.AddWithValue("@Genero", genero);

                    command.ExecuteNonQuery();

                }
                conection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Ontener los datos ingresados por el texbOx
            string nombres = tbNombre.Text;
            string apellidos = tbApellidos.Text;
            string edad = tbEdad.Text;
            string estatura = tbEstatura.Text;
            string telefono = tbTelefono.Text;

            //Obtener el genero seleccionado
            string genero = "";
            if (rbHombre.Checked)
            {
                genero = "Hombre";
            }
            else if (rbMujer.Checked)
            {
                genero = "Mujer";
            }

            //Validar que los compos tengas el formato correcto
            if (EsEnteroValido(edad) && EsDecimalValido(estatura) && EsEnteroValidoDe10Digitos(telefono) &&
                EsTextoValido(nombres) && EsTextoValido(apellidos))
            {
                //Crear una cadena de datos 
                string datos = $"Nombres:{nombres}\r\nApellido:{apellidos}\r\nTelefono:{telefono}\r\nEstatura:{estatura}cm\r\nEdad:{edad}años\r\nGenero:{genero}\r\n";

                //Guardar los datos en un achivo de texto
                string rutaArchivo = "C:/Users/theha/Downloads/PrubaFormulario1.txt";
                bool archivoExiste = File.Exists(rutaArchivo);
                if (archivoExiste == false)
                {
                    File.WriteAllText(rutaArchivo, datos);

                }
                else
                {
                    //Verificar si el dato ya existe
                    using (StreamWriter write = new StreamWriter(rutaArchivo, true))
                    {
                        if (archivoExiste)
                        {
                            //Siel archivo existe, añadir un separador antes del ruevo registro
                            write.WriteLine();
                            write.WriteLine(datos);
                            //Programacion de funcionalidad de inser SQL
                            InsertarRegistro(nombres, apellidos, int.Parse(edad), decimal.Parse(estatura), telefono, genero);
                            MessageBox.Show("Datos ingresados corrctamente.");
                        }
                        else
                        {
                            write.WriteLine(datos);
                            //Programacion de funcionalidad de inser SQL
                            InsertarRegistro(nombres, apellidos, int.Parse(edad), decimal.Parse(estatura), telefono, genero);
                            MessageBox.Show("Datos ingresados corrctamente.");
                        }
                    }
                }
                //Montrar un mensaje con los datos capturados 
                MessageBox.Show("Datos Guardados con exito: \n\n" + datos, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por Favor, ingrese datos validos en los coampos.:", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private bool EsEnteroValido(string valor)
        {
            int resultado;
            return int.TryParse(valor, out resultado);

        }
        private bool EsDecimalValido(string valor)
        {
            decimal resultado;
            return decimal.TryParse(valor, out resultado);
        }

        private bool EsEnteroValidoDe10Digitos(string input)
        {
            if(input.Length != 10)
            {
                return false;
            }

            if (!input.All(char.IsDigit))
            {
                return false;
            }
            return true;
        }

        private bool EsTextoValido(string valor)
        {
            return Regex.IsMatch(valor, @"[a-zA-Z\s]+$"); //Solo lestras y Espacios
        }

        private void ValidarEdad(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsEnteroValido(textBox.Text))
            {
                MessageBox.Show("Profavor, ingrese una edad valida,", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }
        private void ValidarEstatura(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsDecimalValido(textBox.Text))
            {
                MessageBox.Show("Por favor, ingrese una estatura valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ValidarTelefono(object sender, EventArgs e)
        {
            TextBox textBox=(TextBox)sender;
            string input = textBox.Text;
            //Eliminar espacios en blanco guiones si es necesario
            //input = input.Repalce("","").Replace("-","");
            if(input.Length < 10)
            {
                return;
            }

            if (!EsEnteroValidoDe10Digitos(input))
            {
                MessageBox.Show("Por favor, ingrese un numero de telefono valido de 10 digitos.", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void ValidarNombre(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsTextoValido(textBox.Text))
            {
                MessageBox.Show("Por favor, ingrese un nomre valido ( solo letras t espacios).", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }

        }
        private void ValidarApellidos(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsTextoValido(textBox.Text))
            {
                MessageBox.Show("Por favor, ingrese un nomre valido ( solo letras t espacios).", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }

        }
    }
}