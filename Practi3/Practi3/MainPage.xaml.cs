using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Practi3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Datos Ingresados", Nombre.Text + " " + Apellido.Text + "\n " + Direccion.Text + " \n " + TEL.Text + " \n" + Carrera.Text + " \n" + Semestre.Text + "\n " + Matricula.Text + "\n " + Correo.Text + "\n " + GitHub.Text, "OK");
        }
    }
}
