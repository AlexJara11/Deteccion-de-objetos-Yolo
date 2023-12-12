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

namespace WebCamYolo
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }
        ApplicationDbContext _dbContext = new ApplicationDbContext();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Por favor ingrese un nombre.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("Por favor ingrese un apellido.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(textBox3.Text))
                {
                    MessageBox.Show("Por favor ingrese un curso.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox3.Focus();
                    return;
                }
                Student student = new Student();
                student.FirstName = textBox1.Text;
                student.LastName = textBox2.Text;
                student.Escuela = textEscuela.Text;
                student.UserName = textBox4.Text;
                student.PasswordHash = textBox5.Text;
                student.course = textBox3.Text;
                _dbContext.Students.Add(student);
                if (_dbContext.SaveChanges() > 0)
                {
                    MessageBox.Show("Registrado con exito.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registrado fallido.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario que deseas mostrar
            Form2 sesion = new Form2();

            // Mostrar el formulario
            sesion.Show();
            this.Close();
        }
    }
}
