using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebCamYolo.Model;
using WinFormsApp3;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WebCamYolo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            string password = textBox2.Text;
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Por favor ingrese un usuario.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Por favor ingrese una contraseña.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }
            using (var context = new ApplicationDbContext())
            {
                var student = context.Students
                    .FirstOrDefault(s => s.UserName == userName && s.PasswordHash == GetHashedPassword(password));

                if (student != null)
                {
                    MessageBox.Show("Estudiante encontrado");
                    // Abrir Form2 y pasar el estudiante
                    Form1 form1 = new Form1(student);
                    form1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Estudiante no encontrado");
                }
            }
        }
        // Método para hashear la contraseña (deberías usar un método más seguro en un entorno de producción)
        private string GetHashedPassword(string password)
        {
            // Implementa la lógica para hashear la contraseña (por ejemplo, usando BCrypt, Argon2, etc.)
            // Este ejemplo es solo para propósitos ilustrativos y no es seguro para uso en producción.
            return password;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    // Crear una instancia del formulario que deseas mostrar
        //    Registro registro = new Registro();

        //    // Mostrar el formulario
        //    registro.Show();
        //    this.Hide();

        //}

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Crear una instancia del formulario que deseas mostrar
            Registro registro = new Registro();

            // Mostrar el formulario
            registro.Show();
            this.Hide();
        }
    }
}
