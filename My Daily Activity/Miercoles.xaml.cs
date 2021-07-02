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
    public partial class Miercoles : ContentPage
    {
        public Miercoles()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            btn_saveChanges_3.Clicked += Btn_saveChanges_3_Clicked;

            if (Application.Current.Properties.ContainsKey("line_15"))
                txt_line_15.Text = Application.Current.Properties["line_15"] as string;

            if (Application.Current.Properties.ContainsKey("line_16"))
                txt_line_16.Text = Application.Current.Properties["line_16"] as string;

            if (Application.Current.Properties.ContainsKey("line_17"))
                txt_line_17.Text = Application.Current.Properties["line_17"] as string;

            if (Application.Current.Properties.ContainsKey("line_18"))
                txt_line_18.Text = Application.Current.Properties["line_18"] as string;

            if (Application.Current.Properties.ContainsKey("line_19"))
                txt_line_19.Text = Application.Current.Properties["line_19"] as string;

            if (Application.Current.Properties.ContainsKey("line_20"))
                txt_line_20.Text = Application.Current.Properties["line_20"] as string;

            if (Application.Current.Properties.ContainsKey("line_21"))
                txt_line_21.Text = Application.Current.Properties["line_21"] as string;
        }

        private async void Btn_saveChanges_3_Clicked(object sender, EventArgs e)
        {
            txt_line_15.IsReadOnly = true; txt_line_16.IsReadOnly = true; txt_line_17.IsReadOnly = true;
            txt_line_18.IsReadOnly = true; txt_line_19.IsReadOnly = true; txt_line_20.IsReadOnly = true;
            txt_line_21.IsReadOnly = true;

            string line_1 = txt_line_15.Text;
            string line_2 = txt_line_16.Text;
            string line_3 = txt_line_17.Text;
            string line_4 = txt_line_18.Text;
            string line_5 = txt_line_19.Text;
            string line_6 = txt_line_20.Text;
            string line_7 = txt_line_21.Text;

            Application.Current.Properties["line_15"] = line_1;
            Application.Current.Properties["line_16"] = line_2;
            Application.Current.Properties["line_17"] = line_3;
            Application.Current.Properties["line_18"] = line_4;
            Application.Current.Properties["line_19"] = line_5;
            Application.Current.Properties["line_20"] = line_6;
            Application.Current.Properties["line_21"] = line_7;

            await Application.Current.SavePropertiesAsync();
            await DisplayAlert(string.Empty, "GUARDADO SATISFACTORIAMENTE", "OK");
            Notificacion();
        }

        private void Notificacion()
        {
            Plugin.LocalNotifications.CrossLocalNotifications.Current.Show(DateTime.Today.DayOfWeek.ToString(), "REGISTRADO A LAS " + DateTime.Now.ToString(), 3);
        }

        private void btn_edit_3_Clicked(object sender, EventArgs e)
        {
            txt_line_15.IsReadOnly = false; txt_line_16.IsReadOnly = false; txt_line_17.IsReadOnly = false;
            txt_line_18.IsReadOnly = false; txt_line_19.IsReadOnly = false; txt_line_20.IsReadOnly = false;
            txt_line_21.IsReadOnly = false;

            Aviso();
        }

        protected async void Aviso()
        {
            await DisplayAlert(string.Empty, "PUEDE EDITAR SU REGISTRO", "ACEPTAR");
        }

        private void btn_borrar_3_Clicked(object sender, EventArgs e)
        {
            txt_line_15.Text = string.Empty; txt_line_16.Text = string.Empty; txt_line_17.Text = string.Empty;
            txt_line_18.Text = string.Empty; txt_line_19.Text = string.Empty; txt_line_20.Text = string.Empty;
            txt_line_21.Text = string.Empty;
        }

        private void btn_next_3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Jueves());
        }
    }
}