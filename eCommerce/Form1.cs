namespace eCommerce
{
    public partial class Form1 : Form
    {
        public prodotto product1;
        public prodotto product2;
        public prodotto product3;
        public prodotto p;
        public prodotto[] prodottiPre = new prodotto[3];
        public prodotto[] Prodotto;
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
            Prodotto = new prodotto[100];
            p = new prodotto();
        }

        public void prodottoPredefiniti(prodotto[] p)
        {
            for(int i = 0; i < 3; i++)
            {
                ListViewItem A = new ListViewItem(p[i].Nome);
               // listViewProdotti.Items.Add(A);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Prodotto = car.GetProdotti();
            if (listViewCarrello.SelectedIndices.Count > 0)
                selezionato = listViewCarrello.SelectedIndices[0];
            //prodottoSelect = listViewCarrello.SelectedItems[0].Text;
            for (int i = 0; i < car.NProdotti; i++)
            {
                if (i == selezionato)
                {
                    car.Rimuovi(Prodotto[i]);
                    listViewCarrello.Items.RemoveAt(selezionato);
                }      
            }
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
                p = alimentari(id, nome, descrizione, prezzo);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void SvuotaCarrello_Click(object sender, EventArgs e)
        {
            listViewCarrello.Clear();
            car.Svuota();
        }

        public void MettiNelCarrello(string s,prodotto[] p)
        {
      
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //prodottoSelect = listViewProdotti.SelectedItems[0].Text;
            //ListViewItem B = new ListViewItem(prodottoSelect);
           //listViewCarrello.Items.Add(B);
            for(int i=0; i < 3; i++)
            {
            //    if (prodottoSelect == prodottiPre[i].Nome)
                    car.Aggiungi(prodottiPre[i]);
            }  
        }
    }
}