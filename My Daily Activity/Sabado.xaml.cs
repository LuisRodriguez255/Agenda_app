using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace My_Daily_Activity
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Sabado : ContentPage
    {
        public Sabado()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            btn_saveChanges_6.Clicked += Btn_saveChanges_6_Clicked;

            if (Application.Current.Properties.ContainsKey("line_36"))
                txt_line_36.Text = Application.Current.Properties["line_36"] as string;

            if (Application.Current.Properties.ContainsKey("line_37"))
                txt_line_37.Text = Application.Current.Properties["line_37"] as string;

            if (Application.Current.Properties.ContainsKey("line_38"))
                txt_line_38.Text = Application.Current.Properties["line_38"] as string;

            if (Application.Current.Properties.ContainsKey("line_39"))
                txt_line_39.Text = Application.Current.Properties["line_39"] as string;

            if (Application.Current.Properties.ContainsKey("line_40"))
                txt_line_40.Text = Application.Current.Properties["line_40"] as string;

            if (Application.Current.Properties.ContainsKey("line_41"))
                txt_line_41.Text = Application.Current.Properties["line_41"] as string;

            if (Application.Current.Properties.ContainsKey("line_42"))
                txt_line_42.Text = Application.Current.Properties["line_42"] as string;
        }

        private async void Btn_saveChanges_6_Clicked(object sender, EventArgs e)
        {
            txt_line_36.IsReadOnly = true; txt_line_37.IsReadOnly = true; txt_line_38.IsReadOnly = true;
            txt_line_39.IsReadOnly = true; txt_line_40.IsReadOnly = true; txt_line_41.IsReadOnly = true;
            txt_line_42.IsReadOnly = true;

            string line_1 = txt_line_36.Text;
            string line_2 = txt_line_37.Text;
            string line_3 = txt_line_38.Text;
            string line_4 = txt_line_39.Text;
            string line_5 = txt_line_40.Text;
            string line_6 = txt_line_41.Text;
            string line_7 = txt_line_42.Text;

            Application.Current.Properties["line_36"] = line_1;
            Application.Current.Properties["line_37"] = line_2;
            Application.Current.Properties["line_38"] = line_3;
            Application.Current.Properties["line_39"] = line_4;
            Application.Current.Properties["line_40"] = line_5;
            Application.Current.Properties["line_41"] = line_6;
            Application.Current.Properties["line_42"] = line_7;

            await Application.Current.SavePropertiesAsync();
            await DisplayAlert(string.Empty, "GUARDADO SATISFACTORIAMENTE", "OK");
            Notificacion();
        }

        private void Notificacion()
        {
            Plugin.LocalNotifications.CrossLocalNotifications.Current.Show(DateTime.Today.DayOfWeek.ToString(), "REGISTRADO A LAS " + DateTime.Now.ToString(), 6);
        }

        private void btn_edit_6_Clicked(object sender, EventArgs e)
        {
            txt_line_36.IsReadOnly = false; txt_line_37.IsReadOnly = false; txt_line_38.IsReadOnly = false;
            txt_line_39.IsReadOnly = false; txt_line_40.IsReadOnly = false; txt_line_41.IsReadOnly = false;
            txt_line_42.IsReadOnly = false;

            Aviso();
        }

        protected async void Aviso()
        {
            await DisplayAlert(string.Empty, "PUEDE EDITAR SU REGISTRO", "ACEPTAR");
        }

        private void btn_borrar_6_Clicked(object sender, EventArgs e)
        {

            txt_line_36.Text = string.Empty; txt_line_37.Text = string.Empty; txt_line_38.Text = string.Empty;
            txt_line_39.Text = string.Empty; txt_line_40.Text = string.Empty; txt_line_41.Text = string.Empty;
            txt_line_42.Text = string.Empty;
        }

        private void btn_next_6_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Domingo());
        }
    }
}