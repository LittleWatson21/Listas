using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//El System IO nos permite trabajar con archivos
//

namespace Archivos_de_texto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           


        }

        private void guardar_Datos_Click(object sender, EventArgs e)
        {
            string nombre;
            int edad;
            float altura;
            float peso;
            DateTime fecha_Nacimiento;
            nombre = text_Nombre.Text;
            edad = Convert.ToInt32(numeric_Edad.Value);
            altura = float.Parse(text_Altura.Text);
            peso = float.Parse(text_Peso.Text);
            fecha_Nacimiento = dateTimePicker1.Value;

            saveFileDialog1.ShowDialog();
            string rutaArchivo;
            rutaArchivo = saveFileDialog1.FileName;
            FileStream fs = new FileStream(rutaArchivo, FileMode.Create);
            StreamWriter escritor = new StreamWriter(fs);

            escritor.WriteLine(nombre);
            escritor.WriteLine(edad);
            escritor.WriteLine();
            escritor.WriteLine(altura);
            escritor.WriteLine("peso" + peso.ToString());
            escritor.WriteLine("Nacimiento) " + fecha_Nacimiento.ToString());
            //escritor.Flush();
            //Lo abre, escribe en la variable y guarda.
            escritor.Close();
            fs.Close();
        }

        private void btnArchivoBinario_Click(object sender, EventArgs e)
        {
            int i1 = 100; //Número Entero Positivo
            int i2 = -100; //Número Entero Negativo

            Int64 i64 = 1000; //

            double pi = 3.141592; //Valor de Pi
            string cad = "Mi mensaje"; // Mensaje

            //primero ocupamos guardar los dialogos antes de salvarlos en una string.
            saveFileDialog1.ShowDialog(); 
            string ruta = saveFileDialog1.FileName;
         
            FileStream fs = new FileStream(ruta, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(i1);
            bw.Write(i2);
            bw.Write(i64);
            bw.Write(pi);
            bw.Write(cad);
            bw.Close();
            fs.Close();


        }

        private void Prueba2_Click(object sender, EventArgs e)
        {
            Persona individuo1 = new Persona("Pancho", 30, 76);
            Persona[] personas = new Persona[10];
            personas[0] = new Persona("Juanito", 20, 55);

            List < Persona > miLista = new List<Persona>();
            miLista.Add(new Persona("Pedro", 10, 50));
            miLista.Add(new Persona("b", 2, 2));
            miLista.Add(new Persona("c", 3, 3));
            miLista.Add(new Persona("d", 4, 4));
            miLista.Add(new Persona("e", 5, 5));

            //miLista[0].Nombre;
            string s = "";
            foreach (Persona p in miLista)
            {
                s += p.Nombre + ":::";
            }

            miLista.RemoveAt(3);

            for(int i=0; i<miLista.Count; i++)
            {
                if (miLista[i].Nombre == "c")
                    miLista.RemoveAt(i);
            }
        }
    }
}
