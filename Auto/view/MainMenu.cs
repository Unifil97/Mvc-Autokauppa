using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Autokauppa.controller;
using Autokauppa.model;


namespace Autokauppa.view
{
   
    public partial class MainMenu : Form
    {
        Auto nyky = new Auto();
       
        SqlConnection dbYhteys = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Autot;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        KaupanLogiikka registerHandler;
       

        public MainMenu()
        {
            
            registerHandler = new KaupanLogiikka();
            InitializeComponent();
           
        }


        private void MainMenu_Load(object sender, EventArgs e)
        {
           
        
            
            cbmerkki.ValueMember = "ID";
            cbmerkki.DisplayMember = "Merkkinimi";
            cbmerkki.DataSource = registerHandler.getAllAutoMakers();

            
            //cbmalli.SelectedValue = MerkkiId;
            //cbmalli.ValueMember = "ID";
            //cbmalli.DisplayMember = "Mallinimi";
            //cbmalli.DataSource = registerHandler.getAutoModels(MerkkiId);
            //cbmalli.Text = MerkkiId + cbmerkki.SelectedItem.ToString();

        }
        private void LisaaMallit(object sender, EventArgs e)
        {
            try
            {
                if(cbmerkki.SelectedValue is int)
                {
                    int MerkkiId = (int)cbmerkki.SelectedValue;
                    var mallit = registerHandler.getAutoModels(MerkkiId);
                    cbmalli.DataSource = mallit;
                    cbmalli.ValueMember = "ID";
                    cbmalli.DisplayMember = "Mallinimi";
                   
                    cbpolttoaine.DataSource = registerHandler.GetFuel();
                    cbpolttoaine.ValueMember = "Id";
                    cbpolttoaine.DisplayMember = "Polttoaineennimi";

                    cbvari.DataSource = registerHandler.GetColor();
                    cbvari.ValueMember = "Id";
                    cbvari.DisplayMember = "Varinnimi";
                    
                    
                }
                
            }
            catch
            {

            }
        }
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cbmalli_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void tbmittarilukema_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbtilavuus_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbhinta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btuusitietue_Click(object sender, EventArgs e)
        {
            ClearBoxes(this);
        }
       

        void ClearBoxes(Control control)
        {

            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }

                if (c is ComboBox)
                {
                    ((ComboBox)c).ResetText();
                }

                else
                {
                    ClearBoxes(c);
                }
            }

        }
        private void bttallenna_Click(object sender, EventArgs e)
        {
            Auto biili = new Auto();
            
            biili.AutonMerkkiID1= (int)cbmerkki.SelectedValue;
            biili.AutonMalliID1 = (int)cbmalli.SelectedValue;
            biili.PolttoaineID1 = (int)cbpolttoaine.SelectedValue;
            biili.VaritID1 = (int)cbvari.SelectedValue;
            biili.Mittarilukema1 =int.Parse (tbmittarilukema.Text);
            biili.Moottorin_tilavuus1 = decimal.Parse(tbtilavuus.Text);
            biili.Hinta1 = decimal.Parse(tbhinta.Text);
            biili.Rekisteri_paivamaara1 = Dtp.Value;

            registerHandler.saveAuto(biili);
        }
        private void tulosta(Auto uusi)
        {          
            cbmerkki.SelectedValue = uusi.AutonMerkkiID1;
            cbmalli.SelectedValue = uusi.AutonMalliID1;
            cbpolttoaine.SelectedValue = uusi.PolttoaineID1;
            cbvari.SelectedValue = uusi.VaritID1;
            tbmittarilukema.Text = uusi.Mittarilukema1.ToString();
            tbhinta.Text = uusi.Hinta1.ToString();
            Dtp.Text = uusi.Rekisteri_paivamaara1.ToString();
            tbtilavuus.Text = uusi.Moottorin_tilavuus1.ToString();
        }

        private void btpoista_Click(object sender, EventArgs e)
        {

        }

        private void btedellinen_Click(object sender, EventArgs e)
        {
            nyky = registerHandler.edellcar(nyky.ID1);
            tulosta(nyky);

        }

        private void btseuraava_Click(object sender, EventArgs e)
        {
                                
           nyky = registerHandler.seurcar(nyky.ID1);
           tulosta(nyky);           
        }

      

        private void testaaYhteysToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if(registerHandler.TestDatabaseConnection())
            {
                MessageBox.Show("jee");
            }
            else
            {
                MessageBox.Show("nöy");
            }
        }

        private void cbmerkki_Click(object sender, EventArgs e)
        {
           

        }

        private void Dtp_ValueChanged(object sender, EventArgs e)
        {

        }
      
    }
}
