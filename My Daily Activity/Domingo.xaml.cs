using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace My_Daily_Activity
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Domingo : ContentPage
    {
        public Domingo()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            btn_saveChanges_7.Clicked += Btn_saveChanges_7_Clicked;

            if (Application.Current.Properties.ContainsKey("line_43"))
                txt_line_43.Text = Application.Current.Properties["line_43"] as string;

            if (Application.Current.Properties.ContainsKey("line_44"))
                txt_line_44.Text = Application.Current.Properties["line_44"] as string;

            if (Application.Current.Properties.ContainsKey("line_45"))
                txt_line_45.Text = Application.Current.Properties["line_45"] as string;

            if (Application.Current.Properties.ContainsKey("line_46"))
                txt_line_46.Text = Application.Current.Properties["line_46"] as string;

            if (Application.Current.Properties.ContainsKey("line_47"))
                txt_line_47.Text = Application.Current.Properties["line_47"] as string;

            if (Application.Current.Properties.ContainsKey("line_48"))
                txt_line_48.Text = Application.Current.Properties["line_48"] as string;

            if (Application.Current.Properties.ContainsKey("line_49"))
                txt_line_49.Text = Application.Current.Properties["line_49"] as string;
        }

        private async void Btn_saveChanges_7_Clicked(object sender, EventArgs e)
        {
            txt_line_43.IsReadOnly = true; txt_line_44.IsReadOnly = true; txt_line_45.IsReadOnly = true;
            txt_line_46.IsReadOnly = true; txt_line_47.IsReadOnly = true; txt_line_48.IsReadOnly = true;
            txt_line_49.IsReadOnly = true;

            string line_1 = txt_line_43.Text;
            string line_2 = txt_line_44.Text;
            string line_3 = txt_line_45.Text;
            string line_4 = txt_line_46.Text;
            string line_5 = txt_line_47.Text;
            string line_6 = txt_line_48.Text;
            string line_7 = txt_line_49.Text;

            Application.Current.Properties["line_43"] = line_1;
            Application.Current.Properties["line_44"] = line_2;
            Application.Current.Properties["line_45"] = line_3;
            Application.Current.Properties["line_46"] = line_4;
            Application.Current.Properties["line_47"] = line_5;
            Application.Current.Properties["line_48"] = line_6;
            Application.Current.Properties["line_49"] = line_7;

            await Application.Current.SavePropertiesAsync();
            await DisplayAlert(string.Empty, "GUARDADO SATISFACTORIAMENTE", "OK");

            Notificacion();
        }

        private void Notificacion()
        {
            Plugin.LocalNotifications.CrossLocalNotifications.Current.Show(DateTime.Today.DayOfWeek.ToString(), "REGISTRADO A LAS " + DateTime.Now.ToString(), 7);
        }

        private void btn_edit_7_Clicked(object sender, EventArgs e)
        {
            txt_line_43.IsReadOnly = false; txt_line_44.IsReadOnly = false; txt_line_45.IsReadOnly = false;
            txt_line_46.IsReadOnly = false; txt_line_47.IsReadOnly = false; txt_line_48.IsReadOnly = false;
            txt_line_49.IsReadOnly = false;

            Aviso();
        }

        protected async void Aviso()
        {
            await DisplayAlert(string.Empty, "PUEDE EDITAR SU REGISTRO", "ACEPTAR");
        }

        private void btn_borrar_7_Clicked(object sender, EventArgs e)
        {
            txt_line_43.Text = string.Empty; txt_line_44.Text = string.Empty; txt_line_45.Text = string.Empty;
            txt_line_46.Text = string.Empty; txt_line_47.Text = string.Empty; txt_line_48.Text = string.Empty;
            txt_line_49.Text = string.Empty;
        }
    }
}