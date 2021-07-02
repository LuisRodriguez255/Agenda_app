using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.LocalNotifications;

namespace My_Daily_Activity
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SchedulePage : ContentPage
    {
        public SchedulePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            btn_saveChanges_1.Clicked += Btn_saveChanges_1_Clicked;

            if (Application.Current.Properties.ContainsKey("line_1"))
                txt_line_1.Text = Application.Current.Properties["line_1"] as string;

            if (Application.Current.Properties.ContainsKey("line_2"))
                txt_line_2.Text = Application.Current.Properties["line_2"] as string;

            if (Application.Current.Properties.ContainsKey("line_3"))
                txt_line_3.Text = Application.Current.Properties["line_3"] as string;

            if (Application.Current.Properties.ContainsKey("line_4"))
                txt_line_4.Text = Application.Current.Properties["line_4"] as string;

            if (Application.Current.Properties.ContainsKey("line_5"))
                txt_line_5.Text = Application.Current.Properties["line_5"] as string;

            if (Application.Current.Properties.ContainsKey("line_6"))
                txt_line_6.Text = Application.Current.Properties["line_6"] as string;

            if (Application.Current.Properties.ContainsKey("line_7"))
                txt_line_7.Text = Application.Current.Properties["line_7"] as string;
        }

        private async void Btn_saveChanges_1_Clicked(object sender, EventArgs e)
        {
            txt_line_1.IsReadOnly = true;txt_line_2.IsReadOnly = true;txt_line_3.IsReadOnly = true;
            txt_line_4.IsReadOnly = true;txt_line_5.IsReadOnly = true;txt_line_6.IsReadOnly = true;
            txt_line_7.IsReadOnly = true;

            string line_1 = txt_line_1.Text;
            string line_2 = txt_line_2.Text;
            string line_3 = txt_line_3.Text;
            string line_4 = txt_line_4.Text;
            string line_5 = txt_line_5.Text;
            string line_6 = txt_line_6.Text;
            string line_7 = txt_line_7.Text;

            Application.Current.Properties["line_1"] = line_1;
            Application.Current.Properties["line_2"] = line_2;
            Application.Current.Properties["line_3"] = line_3;
            Application.Current.Properties["line_4"] = line_4;
            Application.Current.Properties["line_5"] = line_5;
            Application.Current.Properties["line_6"] = line_6;
            Application.Current.Properties["line_7"] = line_7;

            await Application.Current.SavePropertiesAsync();
            await DisplayAlert(string.Empty, "GUARDADO SATISFACTORIAMENTE", "OK");
            Notificacion();
        }

        private void Notificacion()
        {
            CrossLocalNotifications.Current.Show(DateTime.Today.DayOfWeek.ToString(), "REGISTRADO A LAS " + DateTime.Now.ToString(), 1);
        }

        private void btn_edit_1_Clicked(object sender, EventArgs e)
        {
            txt_line_1.IsReadOnly = false; txt_line_2.IsReadOnly = false; txt_line_3.IsReadOnly = false;
            txt_line_4.IsReadOnly = false; txt_line_5.IsReadOnly = false; txt_line_6.IsReadOnly = false;
            txt_line_7.IsReadOnly = false;

            Aviso();
        }

        protected async void Aviso()
        {
            await DisplayAlert(string.Empty, "PUEDE EDITAR SU REGISTRO","OK");
        }

        private void btn_borrar_1_Clicked(object sender, EventArgs e)
        {
            txt_line_1.Text = string.Empty;txt_line_2.Text = string.Empty;txt_line_3.Text = string.Empty;
            txt_line_4.Text = string.Empty;txt_line_5.Text = string.Empty;txt_line_6.Text = string.Empty;
            txt_line_7.Text = string.Empty;
        }

        private void btn_next_1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Martes());
        }
    }
}