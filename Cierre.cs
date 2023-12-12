using iText.Kernel.Events;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Newtonsoft.Json;
using WebCamYolo.Model;
using WinFormsApp3;

namespace WebCamYolo
{
    public partial class Cierre : Form
    {
        private readonly Student student;
        private List<string> uniqueObjectNames;
        private DateTime fechaInicio;
        private DateTime fechaCierre;
        private string tiempoFormateado = "";
        string objetosJson = "";
        public Cierre(Student student, List<string> uniqueObjectNames, DateTime fechaInicio, DateTime fechaCierre)
        {
            InitializeComponent();
            this.student = student;
            this.uniqueObjectNames = uniqueObjectNames;
            this.fechaInicio = fechaInicio;
            this.fechaCierre = fechaCierre;
            // Obtener los Id de los objetos coincidentes
            // Crear una cadena JSON a partir de la lista de objetos
            objetosJson = JsonConvert.SerializeObject(uniqueObjectNames);
            var objectIds = GetObjectIdsByNames(uniqueObjectNames);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Llamamos al método para insertar en StudentObjectHistories
            InsertarEnStudentObjectHistories();
            // Llamamos al método para generar el PDF
            GenerarPDF();
        }
        private void GenerarPDF()
        {
            // Calcula la diferencia en horas
            TimeSpan diferencia = fechaCierre - fechaInicio;

            // Obtiene el resultado en formato hh:mm:ss
            tiempoFormateado = FormatearTiempo(diferencia);

            // Crear un nombre de archivo único para el PDF
            string pdfFileName = $"Informe_{DateTime.Now:yyyyMMddHHmmss}.pdf";

            // Ruta completa del archivo PDF
            string pdfPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), pdfFileName);
            // Creamos un documento PDF
            using (PdfWriter writer = new PdfWriter(pdfPath))
            {
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    Document document = new Document(pdf);

                    // Encabezado
                    document.Add(new Paragraph("Informe del Estudiante").SetTextAlignment(TextAlignment.CENTER));

                    // Datos del Estudiante
                    document.Add(new Paragraph($"ID: {student.Id}").SetBold());
                    document.Add(new Paragraph($"Nombre: {student.FirstName} {student.LastName}"));
                    document.Add(new Paragraph($"Unidad Educativa: {student.Escuela}"));
                    document.Add(new Paragraph($"Curso: {student.course}"));
                    document.Add(new Paragraph($"Fecha de Inicio: {fechaInicio.ToString("dd/MM/yyyy")}"));

                    // Sección de Tiempo
                    if (fechaCierre != DateTime.MinValue)
                    {
                        document.Add(new Paragraph($"Fecha de Cierre: {fechaCierre.ToString("dd/MM/yyyy")}"));
                    }
                    document.Add(new Paragraph($"Tiempo de uso del Aplicativo: {tiempoFormateado}"));

                    // Sección de Objetos Aprendidos
                    if (uniqueObjectNames != null && uniqueObjectNames.Count > 0)
                    {
                        document.Add(new Paragraph("Nombres de Objetos Aprendidos:"));
                        foreach (var nombre in uniqueObjectNames)
                        {
                            document.Add(new Paragraph(nombre));
                        }
                    }
                    // Pie de Página
                    document.Add(new Paragraph($"Generado el {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}").SetFontColor(iText.Kernel.Colors.Color.ConvertRgbToCmyk(new iText.Kernel.Colors.DeviceRgb(128, 128, 128)))
                                                              .SetTextAlignment(TextAlignment.CENTER)
                                                              .SetFontSize(8));
                }
            }

            MessageBox.Show("Reporte generado con éxito.");
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }
        private List<int> GetObjectIdsByNames(List<string> objectNames)
        {
            using (var context = new ApplicationDbContext())
            {
                // Consulta LINQ para obtener los Id de los objetos coincidentes
                return context.Objects
                    .Where(obj => objectNames.Contains(obj.ObjectName))
                    .Select(obj => obj.Id)
                    .ToList();
            }
        }
        private void InsertarEnStudentObjectHistories()
        {
            using (var context = new ApplicationDbContext())
            {
                // Obtenemos los Id de los objetos coincidentes
                var objectIds = GetObjectIdsByNames(uniqueObjectNames);

                // Insertamos registros en StudentObjectHistories

                var history = new StudentObjectHistory
                {
                    StudentId = student.Id,
                    FechaInicio = fechaInicio,
                    FechaFin = fechaCierre,
                    TiempoUso = tiempoFormateado,
                    Objetos = objetosJson
                };

                context.StudentObjectHistories.Add(history);

                // Guardamos todos los cambios en la base de datos
                context.SaveChanges();
            }
        }
        static string FormatearTiempo(TimeSpan tiempo)
        {
            // Utiliza el formato hh:mm:ss para mostrar la diferencia en horas, minutos y segundos
            return $"{tiempo.Hours:D2}:{tiempo.Minutes:D2}:{tiempo.Seconds:D2}";
        }
       
        private void Cierre_Load(object sender, EventArgs e)
        {
            label2.Text = $"{student.FirstName} {student.LastName}";
        }
    }
}
