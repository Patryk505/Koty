namespace Koty
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnKotClicked(object sender, EventArgs e)
        {
            string url = "https://cataas.com/cat";
            int nr = (int)picker.SelectedIndex;
            if (nr > 0)
                url += "/" + (string)picker.SelectedItem;
            if (! string.IsNullOrEmpty(entSays.Text))
            {
                url += "/says/" + entSays.Text;
            }
            imgCat.Source = url;
        }
    }

}
