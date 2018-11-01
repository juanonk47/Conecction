using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conecction.modelo
{
    class Alumno
    {
        private int idalumno;
        private string nombre;
        private string apaterno;
        private string amaterno;
        private string direccion;
        private string telefono;
        private string correo;
        private string sexo;

        public int Idalumno { get => idalumno; set => idalumno = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apaterno { get => apaterno; set => apaterno = value; }
        public string Amaterno { get => amaterno; set => amaterno = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Sexo { get => sexo; set => sexo = value; }
    }
}
