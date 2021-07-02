using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace My_Daily_Activity
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Jueves : ContentPage
    {
        public Jueves()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            btn_saveChanges_4.Clicked += Btn_saveChanges_4_Clicked;

            if (Application.Current.Properties.ContainsKey("line_22"))
                txt_line_22.Text = Application.Current.Properties["line_22"] as string;

            if (Application.Current.Properties.ContainsKey("line_23"))
                txt_line_23.Text = Application.Current.Properties["line_23"] as string;

            if (Application.Current.Properties.ContainsKey("line_24"))
                txt_line_24.Text = Application.Current.Properties["line_24"] as string;

            if (Application.Current.Properties.ContainsKey("line_25"))
                txt_line_25.Text = Application.Current.Properties["line_25"] as string;

            if (Application.Current.Properties.ContainsKey("line_26"))
                txt_line_26.Text = Application.Current.Properties["line_26"] as string;

            if (Application.Current.Properties.ContainsKey("line_27"))
                txt_line_27.Text = Application.Current.Properties["line_27"] as string;

            if (Application.Current.Properties.ContainsKey("line_28"))
                txt_line_28.Text = Application.Current.Properties["line_28"] as string;
        }

        private async void Btn_saveChanges_4_Clicked(object sender, EventArgs e)
        {
            txt_line_22.IsReadOnly = true; txt_line_23.IsReadOnly = true; txt_line_24.IsReadOnly = true;
            txt_line_25.IsReadOnly = true; txt_line_26.IsReadOnly = true; txt_line_27.IsReadOnly = true;
            txt_line_28.IsReadOnly = true;

            string line_1 = txt_line_22.Text;
            string line_2 = txt_line_23.Text;
            string line_3 = txt_line_24.Text;
            string line_4 = txt_line_25.Text;
            string line_5 = txt_line_26.Text;
            string line_6 = txt_line_27.Text;
            string line_7 = txt_line_28.Text;

            Application.Current.Properties["line_22"] = line_1;
            Application.Current.Properties["line_23"] = line_2;
            Application.Current.Properties["line_24"] = line_3;
            Application.Current.Properties["line_25"] = line_4;
            Application.Current.Properties["line_26"] = line_5;
            Application.Current.Properties["line_27"] = line_6;
            Application.Current.Properties["line_28"] = line_7;

            await Application.Current.SavePropertiesAsync();
            await DisplayAlert(string.Empty, "GUARDADO SATISFACTORIAMENTE", "OK");
            Notificacion();
        }

        private void Notificacion()
        {
            Plugin.LocalNotifications.CrossLocalNotifications.Current.Show(DateTime.Today.DayOfWeek.ToString(), "REGISTRADO A LAS " + DateTime.Now.ToString(), 4);
        }

        private void btn_edit_4_Clicked(object sender, EventArgs e)
        {
            txt_line_22.IsReadOnly = false; txt_line_23.IsReadOnly = false; txt_line_24.IsReadOnly = false;
            txt_line_25.IsReadOnly = false; txt_line_26.IsReadOnly = false; txt_line_27.IsReadOnly = false;
            txt_line_28.IsReadOnly = false;

            Aviso();
        }

        protected async void Aviso()
        {
            await DisplayAlert(string.Empty, "PUEDE EDITAR SU REGISTRO", "ACEPTAR");
        }

        private void btn_borrar_4_Clicked(object sender, EventArgs e)
        {
            txt_line_22.Text = string.Empty; txt_line_23.Text = string.Empty; txt_line_24.Text = string.Empty;
            txt_line_25.Text = string.Empty; txt_line_26.Text = string.Empty; txt_line_27.Text = string.Empty;
            txt_line_28.Text = string.Empty;
        }

        private void btn_next_4_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Viernes());
        }
    }
}