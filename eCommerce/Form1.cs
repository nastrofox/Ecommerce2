namespace eCommerce
{
    public partial class Form1 : Form
    {
        public prodotto product1;
        public prodotto product2;
        public prodotto product3;
        public prodotto p;
        public prodotto[] prodottiPre = new prodotto[3];
        public List<prodotto> Prodotto = new List<prodotto>();
        public carrello car = new carrello("ytd");
        public string prodottoselez,sss;
        public int nP = 0, npC,selezionato = 0;
        public Form1()
        {
            InitializeComponent();
            product1 = new prodotto("sadw", "AIA", "cotoletta");
            prodottiPre[0] = product1;
            product2 = new prodotto("sfjf", "logitech", "mouse wireless");
            prodottiPre[1] = product2;
            product3 = new prodotto("ciao", "porcoDURO", "carne di maiale");
            prodottiPre[2] = product3;
            prodottoPredefiniti(prodottiPre);
            p = new prodotto();
        }

        public void prodottoPredefiniti(prodotto[] p)
        {
           
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string id, nome, produttore, descrizione, ingredienti;
            double prezzo;
            id = textBox1.Text;
            nome = textBox2.Text;
            produttore = textBox3.Text;
            descrizione = textBox4.Text;
            prezzo = Convert.ToDouble(textBox5.Text);
            ingredienti = textBox6.Text;
            string[] ing = ingredienti.Split(',');                                                                      
            if (comboBox1.Text == "ALIMENTARI")
            {
               // p = alimentari(id, nome, descrizione, prezzo);
               
            }
            ListViewItem newItem1 = new ListViewItem(p.Id);
            newItem1.SubItems.Add(p.Nome);
            newItem1.SubItems.Add(p.Produttore);
            newItem1.SubItems.Add(p.Descrizione);
            newItem1.SubItems.Add($"{p.Prezzo}");

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void listViewCarrello_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SvuotaCarrello_Click(object sender, EventArgs e)
        {
            listViewCarrello.Items.Clear();
            car.Svuota();
        }

        public void MettiNelCarrello(string s,prodotto[] p)
        {
      
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }
    }
}