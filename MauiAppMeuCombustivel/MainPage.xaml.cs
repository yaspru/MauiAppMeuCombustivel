namespace MauiAppMeuCombustivel
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);

                string msg = "";

                if (etanol <= gasolina * 0.7)
                {
                    msg = "O etano está compensado.";
                } else
                {
                    msg = "A gasolina está compensado.";
                }

                DisplayAlert("Calculado", msg, "OK");

            } //fecha try
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Fechar");
            }
        } // fecha método
    } //fecha class
     //fecha namespace
}
