using Xamarin.Forms;

namespace practiceapp
{
    public partial class practiceappPage : ContentPage
    {
        private   info Info;
        public practiceappPage()
        {
            InitializeComponent();
            Info = new info();
            entry.BindingContext = Info;
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Info.Name = "fdsfasdfasd1111" + entry.Text.ToString();
           // DisplayAlert(string.Empty, Info.Name.ToString(),"ok");
   
        }

       
    }
}
