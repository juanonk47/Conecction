using conecction.BEANS;
using conecction.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conecction.vista
{
    public partial class Alumno1 : Form
    {
        Alumno alumnos = new Alumno();
        AlumnosBeans alumnos_bean = new AlumnosBeans();
        public Alumno1()
        {

            InitializeComponent();
            
        }
        public void registrar()
        {
            carga_reg();
            alumnos_bean.registrar();
            //limpiar();
            // listar_todos();
        }
        public void modificar()
        {

        }
        public void carga_reg()
        {
            this.alumnos_bean.Alumno.Nombre = txtNombre.Text;
            this.alumnos_bean.Alumno.Apaterno = txtApaterno.Text;
            this.alumnos_bean.Alumno.Amaterno = txtAmaterno.Text;
            this.alumnos_bean.Alumno.Direccion = txtDireccion.Text;
            this.alumnos_bean.Alumno.Telefono = txtTelefono.Text;
            this.alumnos_bean.Alumno.Sexo = txtSexo.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            registrar();
        }
    }
}
