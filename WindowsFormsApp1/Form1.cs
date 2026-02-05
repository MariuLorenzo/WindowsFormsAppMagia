using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int numero; // Número random para adivinar
        private int intentos; // Contador intentos

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReiniciarJuego(); 
        }

        // Genera número aleatorio & Reinicia juego
        private void ReiniciarJuego()
        {
            Random random = new Random();
            numero = random.Next(1, 101); // Número aleatorio entre 1 y 100
        
            intentos = 0; // Contador intentos
            Intento.Text = intentos.ToString();
            
            respuesta.Text = ""; // Limpia respuesta
            txtNum.Text = ""; // Limpia cuadro de entrada

            btnAdivinar.Enabled = true; // Habilita botón adivinar
        }

        // Botón "Adivinar"
        private async void btnAdivinar_Click(object sender, EventArgs e)
        {
            int num;
            //respuesta.Text = "";

            // Aumenta Intentos
            intentos++;
            Intento.Text = intentos.ToString();

            // Validar que ingrese un número
            if (!int.TryParse(this.txtNum.Text, out num))
            {
                MessageBox.Show("Por favor, ingresa un número válido.");
                return;
            }
                       
            // Compara número ingresado con número a adivinar
            if (num < numero)
            {
                respuesta.Text = "Estoy pensando en\n un número mayor...";
            
                txtNum.Clear();
                
            }
            else if (num > numero)
            {
                respuesta.Text = "Estoy pensando en\n un número menor...";
                txtNum.Clear();                
            }
            else
            {
                // Si Adivina el user
                MessageBox.Show($"¡Acertaste!\n Adivinaste en {intentos} intentos.");
                btnAdivinar.Enabled = false; // Desactiva el botón 


                // Llama switch con mensaje x intentos
                MostrarMensajePorIntentos(intentos);


                // Pregunta si quiere jugar otra vez
                var result = MessageBox.Show("¿Quieres jugar otra vez?", "Nuevo juego", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ReiniciarJuego(); // Reinicia el juego si el user quiere jugar de nuevo
                }
            }
        }

        
        // Mensajes según número de intentos
        private void MostrarMensajePorIntentos(int intentos)
        {
            string mensaje = "";

           
            switch (intentos)
            {
                case 1:
                    mensaje = "¡Increíble!\n Adivinaste en el primer intento!!\n ¡Eres VIDENTE NATURAL!";
                    break;
                case 2:
                case 3:
                    mensaje = "¡Excelente!\n Adivinaste en pocos intentos!\n ¡Sigue activando tu PODER VIDENTE!";
                    break;
                case 4:
                case 5:
                case 6:
                case 7: 
                case 8:
                case 9:
                case 10:
                    mensaje = "¡Bien hecho!\n Adivinaste después de algunos intentos.\n Practica más tu Magia y tu Poder Vidente...";
                    break;
                default:
                    mensaje = "¡Lo lograste! Finalmente encontraste el número,\n aunque tomó varios intentos...\n sigue practicando, tienes magia...";
                    break;
            }

            // Mostrar mensaje de Nivel
            MessageBox.Show(mensaje, "Tu Nivel de Magia");

        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            respuesta.Text = "";
        }
    }
}
