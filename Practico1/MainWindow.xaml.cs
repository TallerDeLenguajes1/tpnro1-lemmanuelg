using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practico1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Alumno> ListaFutbol = new List<Alumno>();
        List<Alumno> ListaVoley = new List<Alumno>();
        List<Alumno> ListaAtletismo = new List<Alumno>();
        public int contador = 0;
        //Funcion para crear los Archivos CSV
        void CrearAchivo(List<Alumno> lista, string curso)
        {
            using (StreamWriter csvCurso = new StreamWriter(curso + ".csv"))
            {
                foreach (Alumno alumno in lista)
                {
                    csvCurso.WriteLine(alumno);
                }

            }
        }
        public MainWindow()
        {

            InitializeComponent();
            
        }

        public class Alumno
        {
            public Alumno()
            {
            }

            //public Alumno(string id, string apellido, string nombre, string curso)
            //{
            //    Id = id;
            //    Apellido = apellido;
            //    Nombre = nombre;
            //    Curso = curso;
            //}

            public string Id { get; set; }
            public string Apellido { get; set; }
            public string Nombre { get; set; }
            public string Curso { get; set; }
            public override string ToString()
            {
                return Id + " - " + Apellido + " " + Nombre + " - Curso: " + Curso;
            }


        }
        private void Cmb_cursos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Btn_agregar_Click(object sender, RoutedEventArgs e)
        {
            txt_id.Text = contador.ToString();
            if (txt_apellido.Text == "")
            {
                MessageBox.Show("Debe Ingresar el Apellido");
            } else if (txt_nombre.Text == "")
            {
                MessageBox.Show("Debe Ingresar el Nombre");
            } else if (txt_id.Text == "")
            {
                MessageBox.Show("El campo ID no puede estar vacio");
            } else if (cmb_cursos.Text == "")
            {
                MessageBox.Show("Debe Elegir un Curso");
            }
            else {

                if (cmb_cursos.Text == "Futbol") {
                    var MiAlumno = new Alumno();
                    MiAlumno.Apellido = txt_apellido.Text;
                    MiAlumno.Nombre = txt_nombre.Text;
                    MiAlumno.Id = txt_id.Text;
                    MiAlumno.Curso = cmb_cursos.Text;

                    ListaFutbol.Add(item: MiAlumno);
                    lst_alumnos.Items.Add(MiAlumno);
                }
                if (cmb_cursos.Text == "Voley")
                {
                    var MiAlumno = new Alumno();
                    MiAlumno.Apellido = txt_apellido.Text;
                    MiAlumno.Nombre = txt_nombre.Text;
                    MiAlumno.Id = txt_id.Text;
                    MiAlumno.Curso = cmb_cursos.Text;

                    ListaVoley.Add(item: MiAlumno);
                    lst_alumnos.Items.Add(MiAlumno);
                }
                if (cmb_cursos.Text == "Atletismo") {
                    var MiAlumno = new Alumno();
                    MiAlumno.Apellido = txt_apellido.Text;
                    MiAlumno.Nombre = txt_nombre.Text;
                    MiAlumno.Id = txt_id.Text;
                    MiAlumno.Curso = cmb_cursos.Text;

                    ListaAtletismo.Add(item: MiAlumno);
                    lst_alumnos.Items.Add(MiAlumno);
                }
                contador = contador + 1;
                txt_id.Text = contador.ToString();
                
            }



        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Btn_exportar_Click(object sender, RoutedEventArgs e)
        {
            //StringBuilder archivocsv = new StringBuilder();
            //archivocsv.AppendLine("Hola");
            //archivocsv.AppendLine("Hola");
            //archivocsv.AppendLine("Hola");
            //string ubicacion = "E:\\hola";
            //File.AppendAllText(ubicacion, archivocsv.ToString());

            //Creo el archivo Futbol.csv

            CrearAchivo(ListaVoley, "Voley");
            CrearAchivo(ListaVoley, "Futbol");
            CrearAchivo(ListaVoley, "Atletismo");

            //    using (StreamWriter csvFubol = new StreamWriter("Futbol.csv"))
            //    {
            //        foreach(Alumno alumno in ListaFutbol){
            //            csvFubol.WriteLine(alumno);
            //        } 

            //    }
            //    //Creo el archivo Voley.csv
            //    using (StreamWriter csvVoley = new StreamWriter("Voley.csv"))
            //    {
            //        foreach (Alumno alumno in ListaVoley)
            //        {
            //            csvVoley.WriteLine(alumno);
            //        }

            //    }
            //    //Creo el archivo Atletismo.csv
            //    using (StreamWriter csvAtletismo = new StreamWriter("Atletismo.csv"))
            //    {
            //        foreach (Alumno alumno in ListaAtletismo)
            //        {
            //            csvAtletismo.WriteLine(alumno);
            //        }

            //    }
        }
    }
}
