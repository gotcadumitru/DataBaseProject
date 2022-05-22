using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using NivelAccesDate;
using LibrarieModele;

namespace InterfataUtilizator
{
    public partial class FormaAfisare : Form
    {
        private const int PRIMA_COLOANA = 0;
        private const bool SUCCES = true;

        //initializare obiecte utilizate pentru salvarea datelor in baza de date (sau alte medii de stocare...daca exista implementare corespunzatoare)
        IStocareFirme stocareFirme = (IStocareFirme)new StocareFactory().GetTipStocare(typeof(Firma));
        IStocareMasini stocareMasini = (IStocareMasini)new StocareFactory().GetTipStocare(typeof(Masina));

        public FormaAfisare()
        {
            InitializeComponent();
            if (stocareMasini == null || stocareFirme == null)
            {
                MessageBox.Show("Eroare la initializare");
            }
        }

        #region handlere ale evenimentelor formei
        private void FormaAfisare_Load(object sender, EventArgs e)
        {
            AfiseazaCatalog();
            IncarcaFirme();
        }
        private void FormaAfisare_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion


        #region handlere ale evenimentelor controalelor de pe forma (butoane, dataGrid)

        /// <summary>
        /// afiseaza informatiile despre masina selectata in controale ce permit editarea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        /// <summary>
        /// Actualizeaza inregistrarea afisata spre editare din tabelul masini_DEV
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizeaza_Click(object sender, EventArgs e)
        {

        }

        private void btnAfiseazaFormaAdaugare_Click(object sender, EventArgs e)
        {
         
        }

        #endregion

        #region metode helper

        private void IncarcaFirme()
        {
            try
            {
                //se elimina itemii deja adaugati
                lstFirme.Items.Clear();

                var firme = stocareFirme.GetFirme();
                if (firme != null && firme.Any())
                {
                    foreach (var firma in firme)
                    {
                        lstFirme.Items.Add(new ComboItem(firma.Name, (Int32)firma.Id));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        /// <summary>
        /// afiseaza informatiile complete despre masini 
        /// </summary>
        private void AfiseazaCatalog()
        {
            try
            {
                var masini = stocareMasini.GetMasini();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        #endregion

        private void txtNumeFirma_TextChanged(object sender, EventArgs e)
        {

        }
        private bool ValidareDateIntrare()
        {
            if (txtNumeFirma.Text.Length == 0)
            {
                txtFirmaError.Text = "Te rog introdu numele firmei";
                return false;
            }
            if (txtLogoUrl.Text.Length == 0)
            {
                txtFirmaError.Text = "Te rog introdu linkul catre logo";
                return false;
            }

            if (!float.TryParse(txtRaiting.Text, out float raiting) && (txtRaiting.Text.Length != 0))
            {
                txtFirmaError.Text = "Te rog introdu o valoare valida a raitingului (number)";
                return false;
            }
            txtFirmaError.Text = "";
            return true;
        }


        private void btnAdaugaFirma_Click(object sender, EventArgs e)
        {

            if (ValidareDateIntrare())
            {
                if (txtRaiting.Text.Length != 0)
                {
                    stocareFirme.AddFirma(new Firma(txtNumeFirma.Text, txtLogoUrl.Text));
                }
                else
                {
                    stocareFirme.AddFirma(new Firma(txtNumeFirma.Text, txtLogoUrl.Text));
                }
            }
        }

        private void btnUpdateFirma_Click(object sender, EventArgs e)
        {
            if (lstFirme.SelectedItem != null)
            {
                string curItem = lstFirme.SelectedItem.ToString();

                Int32.TryParse(curItem.Split(' ')[0], out int id);
                if (id != 0)
                {
                    if (ValidareDateIntrare())
                    {

                        var firma = stocareFirme.GetFirma(id);
                        firma.Name = txtNumeFirma.Text;
                        firma.LogoUrl = txtLogoUrl.Text;
                        stocareFirme.UpdateFirma(firma);
                        clearFirmaInputs();
                    }

                }
                else
                {
                    txtFirmaError.Text = "Selecteaza o firma din lista";
                }

            }
            else
            {
                txtFirmaError.Text = "Selecteaza o firma din lista";
            }
        }

        private void btnAfisareFirme_Click(object sender, EventArgs e)
        {
            lstFirme.Items.Clear();
            var antetTabel = String.Format("{0,-5}{1,-35}{2,20}\n", "Id", "Nume Firma", "Logo");
            lstFirme.Items.Add(antetTabel);

            var firme = stocareFirme.GetFirme();

            foreach (var f in firme)
            {
                var linieTabel = String.Format("{0,-5}{1,-35}{2,20}\n", f.Id, f.Name,f.LogoUrl);
                lstFirme.Items.Add(linieTabel);
            }
        }
        private void clearFirmaInputs()
        {
            txtNumeFirma.Text = "";
            txtRaiting.Text = "";
            txtLogoUrl.Text = "";
        }


        private void lstFirme_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFirmaError.Text = "";
            // Get the currently selected item in the ListBox.
            string curItem = lstFirme.SelectedItem.ToString();
            Int32.TryParse(curItem.Split(' ')[0], out int id);

            if (id != 0)
            {
                var firma = stocareFirme.GetFirma(id);
                txtNumeFirma.Text = firma.Name;
                txtLogoUrl.Text = firma.LogoUrl;
            }
            else
            {
                clearFirmaInputs();
            }
        }
    }
}
