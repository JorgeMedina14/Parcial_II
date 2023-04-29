using System;
using System.Collections.Generic;
using System.Windows;

namespace Agenda
{
    public partial class MainWindow : Window
    {
        List<Task> tareas = new List<Task>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            DateTime fecha = dpFecha.SelectedDate.Value;

            Task tarea = new Task(nombre, descripcion, fecha);
            tareas.Add(tarea);

            lstTareas.Items.Add(tarea);
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            int index = lstTareas.SelectedIndex;
            if (index >= 0)
            {
                tareas.RemoveAt(index);
                lstTareas.Items.RemoveAt(index);
            }
        }
    }

    public class Task
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }

        public Task(string nombre, string descripcion, DateTime fecha)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Fecha = fecha;
        }

        public override string ToString()
        {
            return $"{Nombre} - {Fecha.ToString("dd/MM/yyyy")} - {Descripcion}";
        }
    }
}

