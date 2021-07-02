using System;
using Plugin.LocalNotifications;
using Xamarin.Forms;

namespace My_Daily_Activity
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            CrossLocalNotifications.Current.Show("BIENVENIDO!", "HORA DE COMENZAR A ORGANIZARSE", 0, DateTime.Today);
        }

        private void btn_salir_Clicked(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_info_Clicked(object sender, EventArgs e)
        {
            btn_empezar.IsVisible = false;
            btn_info.IsVisible = false;
            btn_salir.IsVisible = false;
            btn_atras.IsVisible = true;
            lbl_info.IsVisible = true;
            lbl_info.Text = "ÉSTA ES UNA APP DESARROLLADA CON EL OBJETIVO DE AYUDARTE PARA QUE MANTENGAS UNA SEMANA ORDENADA, CONTIENE UNA INTERFAZ INTUITIVA.\n" +
                              "\nCOMO SIEMPRE, AQUÍ LES DEJO MI CORREO:" + "\nluisrodriguezbobadilla01@gmail.com";
        }

        private void btn_atras_Clicked(object sender, EventArgs e)
        {
            btn_empezar.IsVisible = true;
            btn_info.IsVisible = true;
            btn_salir.IsVisible = true;
            btn_atras.IsVisible = false;
            lbl_info.Text = string.Empty;
            lbl_info.IsVisible = false;
        }

        private void btn_empezar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SchedulePage());
        }
    }
}
