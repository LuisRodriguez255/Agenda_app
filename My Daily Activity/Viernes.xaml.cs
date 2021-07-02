using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace My_Daily_Activity
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Viernes : ContentPage
    {
        public Viernes()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            btn_saveChanges_5.Clicked += Btn_saveChanges_5_Clicked;

            if (Application.Current.Properties.ContainsKey("line_29"))
                txt_line_29.Text = Application.Current.Properties["line_29"] as string;

            if (Application.Current.Properties.ContainsKey("line_30"))
                txt_line_30.Text = Application.Current.Properties["line_30"] as string;

            if (Application.Current.Properties.ContainsKey("line_31"))
                txt_line_31.Text = Application.Current.Properties["line_31"] as string;

            if (Application.Current.Properties.ContainsKey("line_32"))
                txt_line_32.Text = Application.Current.Properties["line_32"] as string;

            if (Application.Current.Properties.ContainsKey("line_33"))
                txt_line_33.Text = Application.Current.Properties["line_33"] as string;

            if (Application.Current.Properties.ContainsKey("line_34"))
                txt_line_34.Text = Application.Current.Properties["line_34"] as string;

            if (Application.Current.Properties.ContainsKey("line_35"))
                txt_line_35.Text = Application.Current.Properties["line_35"] as string;
        }

        private async void Btn_saveChanges_5_Clicked(object sender, EventArgs e)
        {
            txt_line_29.IsReadOnly = true; txt_line_30.IsReadOnly = true; txt_line_31.IsReadOnly = true;
            txt_line_32.IsReadOnly = true; txt_line_33.IsReadOnly = true; txt_line_34.IsReadOnly = true;
            txt_line_35.IsReadOnly = true;

            string line_1 = txt_line_29.Text;
            string line_2 = txt_line_30.Text;
            string line_3 = txt_line_31.Text;
            string line_4 = txt_line_32.Text;
            string line_5 = txt_line_33.Text;
            string line_6 = txt_line_34.Text;
            string line_7 = txt_line_35.Text;

            Application.Current.Properties["line_29"] = line_1;
            Application.Current.Properties["line_30"] = line_2;
            Application.Current.Properties["line_31"] = line_3;
            Application.Current.Properties["line_32"] = line_4;
            Application.Current.Properties["line_33"] = line_5;
            Application.Current.Properties["line_34"] = line_6;
            Application.Current.Properties["line_35"] = line_7;

            await Application.Current.SavePropertiesAsync();
            await DisplayAlert(string.Empty, "GUARDADO SATISFACTORIAMENTE", "OK");
            Notificacion();
        }

        private void Notificacion()
        {
            Plugin.LocalNotifications.CrossLocalNotifications.Current.Show(DateTime.Today.DayOfWeek.ToString(), "REGISTRADO A LAS " + DateTime.Now.ToString(), 5);
        }

        private void btn_edit_5_Clicked(object sender, EventArgs e)
        {
            txt_line_29.IsReadOnly = false; txt_line_30.IsReadOnly = false; txt_line_31.IsReadOnly = false;
            txt_line_32.IsReadOnly = false; txt_line_33.IsReadOnly = false; txt_line_34.IsReadOnly = false;
            txt_line_35.IsReadOnly = false;

            Aviso();
        }

        protected async void Aviso()
        {
            await DisplayAlert(string.Empty, "PUEDE EDITAR SU REGISTRO", "ACEPTAR");
        }

        private void btn_borrar_5_Clicked(object sender, EventArgs e)
        {
            txt_line_29.Text = string.Empty; txt_line_30.Text = string.Empty; txt_line_31.Text = string.Empty;
            txt_line_32.Text = string.Empty; txt_line_33.Text = string.Empty; txt_line_34.Text = string.Empty;
            txt_line_35.Text = string.Empty;
        }

        private void btn_next_5_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Sabado());
        }
    }
}