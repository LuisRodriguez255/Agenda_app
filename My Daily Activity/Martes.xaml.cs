using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace My_Daily_Activity
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Martes : ContentPage
    {
        public Martes()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            btn_saveChanges_2.Clicked += Btn_saveChanges_2_Clicked;

            if (Application.Current.Properties.ContainsKey("line_8"))
                txt_line_8.Text = Application.Current.Properties["line_8"] as string;

            if (Application.Current.Properties.ContainsKey("line_9"))
                txt_line_9.Text = Application.Current.Properties["line_9"] as string;

            if (Application.Current.Properties.ContainsKey("line_10"))
                txt_line_10.Text = Application.Current.Properties["line_10"] as string;

            if (Application.Current.Properties.ContainsKey("line_11"))
                txt_line_11.Text = Application.Current.Properties["line_11"] as string;

            if (Application.Current.Properties.ContainsKey("line_12"))
                txt_line_12.Text = Application.Current.Properties["line_12"] as string;

            if (Application.Current.Properties.ContainsKey("line_13"))
                txt_line_13.Text = Application.Current.Properties["line_13"] as string;

            if (Application.Current.Properties.ContainsKey("line_14"))
                txt_line_14.Text = Application.Current.Properties["line_14"] as string;
        }

        private async void Btn_saveChanges_2_Clicked(object sender, EventArgs e)
        {
            txt_line_8.IsReadOnly = true; txt_line_9.IsReadOnly = true; txt_line_10.IsReadOnly = true;
            txt_line_11.IsReadOnly = true; txt_line_12.IsReadOnly = true; txt_line_13.IsReadOnly = true;
            txt_line_14.IsReadOnly = true;

            string line_1 = txt_line_8.Text;
            string line_2 = txt_line_9.Text;
            string line_3 = txt_line_10.Text;
            string line_4 = txt_line_11.Text;
            string line_5 = txt_line_12.Text;
            string line_6 = txt_line_13.Text;
            string line_7 = txt_line_14.Text;

            Application.Current.Properties["line_8"] = line_1;
            Application.Current.Properties["line_9"] = line_2;
            Application.Current.Properties["line_10"] = line_3;
            Application.Current.Properties["line_11"] = line_4;
            Application.Current.Properties["line_12"] = line_5;
            Application.Current.Properties["line_13"] = line_6;
            Application.Current.Properties["line_14"] = line_7;
            Application.Current.Properties["line_1"] = line_1;

            await Application.Current.SavePropertiesAsync();
            await DisplayAlert(string.Empty, "GUARDADO SATISFACTORIAMENTE", "OK");
            Notificacion();
        }

        private void Notificacion()
        {
            Plugin.LocalNotifications.CrossLocalNotifications.Current.Show(DateTime.Today.DayOfWeek.ToString(), "REGISTRADO A LAS " + DateTime.Now.ToString(), 2);
        }

        private void btn_edit_2_Clicked(object sender, EventArgs e)
        {
            txt_line_8.IsReadOnly = false; txt_line_9.IsReadOnly = false; txt_line_10.IsReadOnly = false;
            txt_line_11.IsReadOnly = false; txt_line_12.IsReadOnly = false; txt_line_13.IsReadOnly = false;
            txt_line_14.IsReadOnly = false;

            Aviso();
        }

        protected async void Aviso()
        {
            await DisplayAlert(string.Empty, "PUEDE EDITAR SU REGISTRO", "ACEPTAR");
        }

        private void btn_borrar_2_Clicked(object sender, EventArgs e)
        {
            txt_line_8.Text = string.Empty; txt_line_9.Text = string.Empty; txt_line_10.Text = string.Empty;
            txt_line_11.Text = string.Empty; txt_line_12.Text = string.Empty; txt_line_13.Text = string.Empty;
            txt_line_14.Text = string.Empty;
        }

        private void btn_next_2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Miercoles());
        }
    }
}