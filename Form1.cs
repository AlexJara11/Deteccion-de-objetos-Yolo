using AForge.Video.DirectShow;
using Alturos.Yolo;
using Alturos.Yolo.Model;
using OpenAI_API;
using OpenAI_API.Completions;
using System.Speech.Synthesis;
using WebCamYolo;
using WebCamYolo.Model;
//using System;
//using System.Speech.Synthesis;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        private readonly Student _student;
        private readonly SpeechSynthesizer speechSynthesizer;

        public Form1(Student student)
        {
            InitializeComponent();
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            //InitializeDataGridView();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            _student = student;
            // Captura la fecha y hora de inicio al abrir el formulario
            fechaInicio = DateTime.Now;
            // Inicializa la instancia de SpeechSynthesizer
            speechSynthesizer = new SpeechSynthesizer();
        }

        private FilterInfoCollection CaptureDevices;
        private VideoCaptureDevice videoSource;
        private YoloWrapper yolo;
        int frameCount = 0;
        int count = 0;
        int countX;
        string pathNet;
        List<YoloItem> _items;
        private DateTime fechaInicio;
        private DateTime fechaCierre;
        private List<string> detectedObjectNamesList = new List<string>();
        List<string> uniqueObjectNames = new List<string>();
        private bool objectPresented = false;
        string vozHablar = "";
        // Inicializa la instancia de SpeechSynthesizer

        string objetoNombre = "";

        private async void button1_Click(object sender, EventArgs e)
        {
            objectPresented = false;  // Habilita la presentación de objetos
            videoSource = new VideoCaptureDevice(CaptureDevices[comboBox1.SelectedIndex].MonikerString);
            videoSource.NewFrame += videoSource_NewFrame;
            await Task.Run(() => videoSource.Start());
            //videoSource.Start();
        }
        private void videoSource_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap img = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = img;
            if (frameCount == count)
            {
                count += countX;
                Task.Run(() => CNN_detection(img));

            }
            frameCount++;
        }
        private async void CNN_detection(Image img)
        {
            var configurationDetector = new YoloConfigurationDetector();
            var config = configurationDetector.Detect(pathNet);
            yolo = new YoloWrapper(config);
            var memoryStream = new MemoryStream();
            img.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
            _items = yolo.Detect(memoryStream.ToArray()).ToList();

            if (_items.Count != 0 && !objectPresented)
            {
                objectPresented = true;

                var detectedObject = _items[0];
                string detectedObjectName = detectedObject.Type.ToUpper();
                label4.Invoke((MethodInvoker)delegate
                {
                    label4.Text = $"OBJECT: {detectedObjectName}";
                });

                // Muestra un mensaje emergente
                MessageBox.Show("Detected object", "Object Detection", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // Muestra la imagen correspondiente


                objetoNombre = detectedObjectName;
                MostrarImagen(objetoNombre);
                // Establece la variable de estado para indicar que se ha presentado un objeto
                //Genera oraciones con ChatGPT
                string chatGPTResponse = await GenerateSentencesWithChatGPT(detectedObjectName);
                vozHablar = chatGPTResponse;
                // Muestra la respuesta de ChatGPT en el label
                label6.Invoke((MethodInvoker)delegate
                {
                    label6.Text = $"{chatGPTResponse}";
                });
                string traduccion = await GenerateSentencesWithTraduccionChatGPT();
                label8.Invoke((MethodInvoker)delegate
                {
                    label8.Text = $"{traduccion}";
                });

            }
            else if (!objectPresented)
            {
                label4.Invoke((MethodInvoker)delegate
                {
                    label4.Text = "No object detected";
                });
                //ResetSource();
            }
            if (objectPresented)
            {

            }


        }
        private void HablarOracion(string oracion)
        {
            try
            {
                // Habla la oración usando SpeechSynthesizer
                speechSynthesizer.Speak(oracion);
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que pueda ocurrir durante la síntesis de voz
                MessageBox.Show($"Error al hablar la oración: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task<string> GenerateSentencesWithChatGPT(string detectedObjectName)
        {
            // Reemplaza 'YOUR_API_KEY' con tu clave de API de OpenAI
            string apiKey = "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";
            string answer = string.Empty;
            OpenAIAPI api = new OpenAIAPI(apiKey);

            CompletionRequest completion = new CompletionRequest
            {
                Prompt = $"Generate a short and simple English sentence for children (ages 7-12) using the object: {detectedObjectName}.",
                //Prompt = $"Generate a short and simple English sentence for children (ages 7-12) using the object: {detectedObjectName}. Then, provide its translation in Spanish: ",
                MaxTokens = 20 // Ajusta este valor según sea necesario para oraciones cortas y simples
            };

            var result = await api.Completions.CreateCompletionAsync(completion);

            if (result != null && result.Completions.Count > 0)
            {
                // Solo asigna el valor del primer elemento si hay completaciones disponibles
                answer = result.Completions[0].Text;
            }

            return answer;
        }

        public async Task<string> GenerateSentencesWithTraduccionChatGPT()
        {
            // Reemplaza 'YOUR_API_KEY' con tu clave de API de OpenAI
            string apiKey = "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";
            string answer = string.Empty;
            OpenAIAPI api = new OpenAIAPI(apiKey);
            // Obtén la oración en inglés del label6
            string englishSentence = label6.Text;
            CompletionRequest completion = new CompletionRequest
            {
                Prompt = $"Translate the following English sentence to Spanish: {englishSentence}",
                //Prompt = $"Generate a short and simple English sentence for children (ages 7-12) using the object: {detectedObjectName}. Then, provide its translation in Spanish: ",
                MaxTokens = 40 // Ajusta este valor según sea necesario para oraciones cortas y simples
            };

            var result = await api.Completions.CreateCompletionAsync(completion);

            if (result != null && result.Completions.Count > 0)
            {
                // Solo asigna el valor del primer elemento si hay completaciones disponibles
                answer = result.Completions[0].Text;
            }

            return answer;
        }
        private void MostrarImagen(string objectName)
        {
            using (ApplicationDbContext dbContext = new ApplicationDbContext())
            {
                // Busca el objeto en la base de datos
                WebCamYolo.Model.Object objeto = dbContext.Objects.FirstOrDefault(o => o.ObjectName == objectName);

                if (objeto != null && objeto.Imagenes != null)
                {
                    // Convierte los bytes a una imagen y muestra en el PictureBox
                    using (MemoryStream ms = new MemoryStream(objeto.Imagenes))
                    {
                        pictureBox2.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    // Si no se encuentra la imagen, muestra un mensaje o toma alguna acción apropiada
                    MessageBox.Show("La imagen no pudo ser encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            label5.Text = $"Name: {_student.FirstName} {_student.LastName}";
            foreach (FilterInfo Device in CaptureDevices)
            {
                comboBox1.Items.Add(Device.Name);
            }
            comboBox1.SelectedIndex = 0;
            videoSource = new VideoCaptureDevice();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (videoSource.IsRunning)
                {
                    //videoSource.Stop();
                    videoSource.SignalToStop();  // Indica al hilo que debe detenerse
                    videoSource.WaitForStop();   // Espera a que el hilo se detenga correctamente
                    // Deja en blanco el pictureBox1
                    pictureBox1.Image = null;
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción aquí o mostrar un mensaje al usuario
                MessageBox.Show($"Error al detener el video: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            pathNet = Directory.GetCurrentDirectory() + "\\networks\\" + comboBox2.Text + "\\";
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCount = comboBox3.SelectedItem.ToString();
            countX = Convert.ToInt32(selectedCount);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Captura la fecha y hora de cierre
            fechaCierre = DateTime.Now;
            // Abrir Form2 y pasar el estudiante
            Cierre cierre = new Cierre(_student, uniqueObjectNames, fechaInicio, fechaCierre);
            cierre.Show();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(vozHablar))
            {
                HablarOracion(vozHablar);

            }
        }
    }
}
