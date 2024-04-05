namespace MauiBitMono
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Protected by BitMono. Clicked {count} time";
            else
                CounterBtn.Text = $"Protected by BitMono. Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
