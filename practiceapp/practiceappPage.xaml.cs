using Xamarin.Forms;

namespace practiceapp
{
    public partial class practiceappPage : ContentPage
    {
        private   InfoViewModel Info;
        public practiceappPage()
        {
            InitializeComponent();
            Info = new InfoViewModel();
            this.BindingContext = Info;

        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Info.Name = "fdsfasdfasd1111" + entry.Text.ToString();
           // DisplayAlert(string.Empty, Info.Name.ToString(),"ok");
   
        }

       
    }
}
