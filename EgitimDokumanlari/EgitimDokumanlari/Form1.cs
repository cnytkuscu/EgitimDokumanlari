namespace EgitimDokumanlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private AsenkronikMimari.AsenkronikMimari asenkronikMimari = new AsenkronikMimari.AsenkronikMimari();
        private void btnTopla_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asenkronikMimari.Topla(10, 20).ToString());
        }

        private async void btnCarp_Click(object sender, EventArgs e)
        {
            var gelenSayi = await asenkronikMimari.CarpAsync(10, 20);
            MessageBox.Show(gelenSayi.ToString());
        }
    }
}