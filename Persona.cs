using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos_de_texto
{
    class Persona
    {
        /*
        private string _nombre;
        private int _edad;
        private float _altura, _peso;

        public void introducirNombre(string nombre)
        {
            _nombre = nombre;
        }

        public void introducirEdad(int edad)
        {
            _edad = edad;
        }

        public void introducirAltura(float altura)
        {
            _altura = altura;
        }

        public void introducirPeso(float peso)
        {
            _peso = peso;
        }
        */

        private string _nombre;
        private int _edad;
        private int _peso;

        public string Nombre

        {
            set { _nombre = value; }
            get { return _nombre; }
        }

        public int Edad
        {
            set { _edad = value; }
            get { return _edad; }
        }


        public int Peso

        {
            set { _peso = value; }
            get { return _peso; }
        }
        public Persona(string nombre, int edad, int peso)
        {
            _nombre = nombre;
            _edad = edad;
            _peso = peso;
            
        }

    }
}
