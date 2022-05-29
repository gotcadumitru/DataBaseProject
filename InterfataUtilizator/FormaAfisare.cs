using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using NivelAccesDate;
using LibrarieModele;
using System.Collections.Generic;
using System.Drawing;

namespace InterfataUtilizator
{
    public partial class FormaAfisare : Form
    {
        private const int PRIMA_COLOANA = 0;
        private const bool SUCCES = true;

        //initializare obiecte utilizate pentru salvarea datelor in baza de date (sau alte medii de stocare...daca exista implementare corespunzatoare)
        IStocareFirme stocareFirme = (IStocareFirme)new StocareFactory().GetTipStocare(typeof(Firma));
        IStocareMasini stocareMasini = (IStocareMasini)new StocareFactory().GetTipStocare(typeof(Masina));
        IStocareLivratori stocareLivratori = (IStocareLivratori)new StocareFactory().GetTipStocare(typeof(Livrator));

        public FormaAfisare()
        {
            InitializeComponent();
            if (stocareMasini == null || stocareFirme == null || stocareLivratori == null)
            {
                MessageBox.Show("Eroare la initializare");
            }
        }

        #region handlere ale evenimentelor formei
        private void FormaAfisare_Load(object sender, EventArgs e)
        {
            AfiseazaFirme();
            stocareMasini.GetMasini();
            AfiseazaMasini();
            Image myimage = new Bitmap(@"../../../delivery.jpg");
            this.BackgroundImage = myimage;
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


        /// <summary>
        /// afiseaza informatiile complete despre masini 
        /// </summary>
        private void AfiseazaFirme()
        {
            try
            {
                lstFirme.Items.Clear();
                var antetTabel = String.Format("{0,-5}{1,-35}{2,20}\n", "Id", "Nume Firma", "Logo");
                lstFirme.Items.Add(antetTabel);

                var firme = stocareFirme.GetFirme();

                foreach (var f in firme)
                {
                    var linieTabel = String.Format("{0,-5}{1,-35}{2,20}\n", f.Id, f.Name, f.LogoUrl);
                    lstFirme.Items.Add(linieTabel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void AfiseazaLivratori()
        {
            try
            {

                string curItem = lstFirme.SelectedItem.ToString();
                Int32.TryParse(curItem.Split(' ')[0], out int id);

                if (id != 0)
                {
                    lstLivratori.Items.Clear();
                    var antetTabel = String.Format("{0,0}{1,10}{2,20}{3,20}{4,10}\n", "Id", "Nume", "Prenume", "Data angajarii", "Comenzie");
                    lstLivratori.Items.Add(antetTabel);

                    var livratori = stocareLivratori.GetLivatori(id);

                    foreach (var l in livratori)
                    {
                        var linieTabel = String.Format("{0,0}{1,10}{2,20}{3,20}{4,10}\n", l.Id, l.FirstName, l.LastName, l.HireDate.ToString("d"), l.NumberOfDeliveries);
                        lstLivratori.Items.Add(linieTabel);
                    }

                }
                else
                {
                    clearFirmaInputs();
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void AfiseazaMasini()
        {
            try
            {
                lstMasine.Items.Clear();
                var antetTabel = String.Format("{0,-5}{1,-10}{2,20}\n", "Id", "Model", "Marca");
                lstMasine.Items.Add(antetTabel);

                var masini = stocareMasini.GetMasini();

                foreach (var m in masini)
                {
                    var linieTabel = String.Format("{0,-5}{1,-10}{2,20}\n", m.Id, m.Model, m.Mark);
                    lstMasine.Items.Add(linieTabel);
                }
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

            txtFirmaError.Text = "";
            return true;
        }
        private TipVehicol? GetVehicolSelectat()
        {
            if (rdbAutomobil.Checked)
                return TipVehicol.Automobil;
            if (rdbBicicleta.Checked)
                return TipVehicol.Bicicleta;
            if (rdbMotocicleta.Checked)
                return TipVehicol.Motocicleta;
            if (rdbTrotineta.Checked)
                return TipVehicol.Trotineta;

            return null;
        }
        private bool ValidareDateIntrareLivrator()
        {
            if (txtNumeLivrator.Text.Length == 0)
            {
                eroareLivratorLbl.Text = "Te rog introdu numele livratorului";
                return false;
            }
            if (txtPrenumeLivrator.Text.Length == 0)
            {
                eroareLivratorLbl.Text = "Te rog introdu prenumele livratorului";
                return false;
            }
            if (emailValue.Text.Length == 0)
            {
                eroareLivratorLbl.Text = "Te rog introdu prenumele livratorului";
                return false;
            }

            eroareLivratorLbl.Text = "";
            return true;
        }

        private bool ValidareDateIntrareAutomobil()
        {
            if (textModelCar.Text.Length == 0)
            {
                eroareMasinaLbl.Text = "Te rog selecteaza modelul vehicolului";
                return false;
            }
            if (textMarkValue.Text.Length == 0)
            {
                eroareMasinaLbl.Text = "Te rog selecteaza marca vehicolului";
                return false;
            }
           

            if (!GetVehicolSelectat().HasValue)
            {
                eroareMasinaLbl.Text = "Te rog selecteaza tipul vehicolului";
                return false;
            }

            eroareLivratorLbl.Text = "";
            return true;
        }

        private void btnAdaugaFirma_Click(object sender, EventArgs e)
        {

            if (ValidareDateIntrare())
            {
          
                    stocareFirme.AddFirma(new Firma(txtNumeFirma.Text, txtLogoUrl.Text));
                clearFirmaInputs();
                AfiseazaFirme();
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
                        if (stocareFirme.UpdateFirma(firma))
                        {

                        clearFirmaInputs();
                            AfiseazaFirme();
                        }
                        else
                        {
                            txtFirmaError.Text = "Ceva nu a mers bine la update";
                        }
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
            AfiseazaFirme();
        }
        private void clearFirmaInputs()
        {
            txtNumeFirma.Text = "";
            txtLogoUrl.Text = "";
            txtFirmaError.Text = "";
        }


        private void lstFirme_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFirmaError.Text = "";
            // Get the currently selected item in the ListBox.
            try
            {
                if (lstFirme.SelectedItem != null)
                {
                    resetLivratorData();
                    string currentFirma = lstFirme.SelectedItem.ToString();
                    Int32.TryParse(currentFirma.Split(' ')[0], out int idFirma);

                    var firma = stocareFirme.GetFirma(idFirma);

                    txtNumeFirma.Text = firma.Name;
                    txtLogoUrl.Text = firma.LogoUrl;

                    AfiseazaLivratori();
                }
            }catch (Exception ex)
            {

            }
        }

        private void lblPrenumeLivrator_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addLivBtn_Click(object sender, EventArgs e)
        {
            if (ValidareDateIntrareLivrator())
            {
                if (lstFirme.SelectedItem != null)
                {
                    string currentFirma = lstFirme.SelectedItem.ToString();

                    Int32.TryParse(currentFirma.Split(' ')[0], out int idFirma);

                    string currentAuto = lstMasine.SelectedItem.ToString();

                    Int32.TryParse(currentAuto.Split(' ')[0], out int idAuto);
                    if (idFirma != 0)
                    {
                        var firma = stocareFirme.GetFirma(idFirma);

                            var newLivrator = new Livrator(0, txtNumeLivrator.Text, txtPrenumeLivrator.Text, dataNasteriiPicker.Value.Date, dataAngPicker.Value.Date, emailValue.Text, firma.Id, 0, idAuto);
                            stocareLivratori.AddLivrator(newLivrator);
                        resetLivratorData();
                        lstMasine.ClearSelected();
                        AfiseazaLivratori();

                    }
                    else
                    {
                        eroareLivratorLbl.Text = "Selecteaza o firma din lista";
                    }

                }
                else
                {
                    eroareLivratorLbl.Text = "Selecteaza o firma din lista";
                }
            }
        }

        private void rdbAutomobil_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void resetLivratorData()
        {
            dataNasteriiPicker.ResetText();
            dataAngPicker.ResetText();
            txtNumeLivrator.Text = "";
            emailValue.Text = "";
            txtPrenumeLivrator.Text = "";
            lstMasine.ClearSelected();
            eroareLivratorLbl.Text = "";
        }

        private void eroareLivratorLbl_Click(object sender, EventArgs e)
        {

        }

        private void lstLivratori_SelectedIndexChanged(object sender, EventArgs e)
        {
           try{
                if (lstLivratori.SelectedItem != null)
                {
                    string selectedLivrator = lstLivratori.SelectedItem.ToString();

                    Int32.TryParse(selectedLivrator.Split(' ')[0], out int idLivrator);

                    Livrator selectedEmployee = stocareLivratori.GetLivrator(idLivrator);
                    if (selectedEmployee != null)
                    {

                    dataNasteriiPicker.Value = selectedEmployee.BirthDate;
                    dataAngPicker.Value = selectedEmployee.HireDate;
                    txtNumeLivrator.Text = selectedEmployee.FirstName;
                    emailValue.Text = selectedEmployee.Email;
                    txtPrenumeLivrator.Text = selectedEmployee.LastName;
                        lstMasine.ClearSelected();
                        var masini = stocareMasini.GetMasini();
                        for (int i= 0;i < masini.Count;i++)
                        {

                            if (masini[i].Id == selectedEmployee.VehicleId)
                            {

                                lstMasine.SetSelected(i+1, true);
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidareDateIntrareAutomobil())
            {
                int vehicol = (int)GetVehicolSelectat();
                stocareMasini.AddMasina(new Masina(0, textModelCar.Text, textMarkValue.Text, vehicol));
                textModelCar.Text = "";
                textMarkValue.Text = "";
                rdbBicicleta.Checked = false;
                rdbAutomobil.Checked = false;
                rdbMotocicleta.Checked = false;
                rdbTrotineta.Checked = false;
                eroareMasinaLbl.Text = "";
                AfiseazaMasini();
            }
        }

        private void lstMasine_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void editLivBtn_Click(object sender, EventArgs e)
        {
            if (ValidareDateIntrareLivrator())
            {
                if (lstFirme.SelectedItem != null)
                {
                    string currentFirma = lstFirme.SelectedItem.ToString();

                    Int32.TryParse(currentFirma.Split(' ')[0], out int idFirma);


                    string currentAuto = lstMasine.SelectedItem.ToString();

                    Int32.TryParse(currentAuto.Split(' ')[0], out int idAuto);


                    string currentLivrator= lstLivratori.SelectedItem.ToString();

                    Int32.TryParse(currentLivrator.Split(' ')[0], out int idLivrator);



                    if (idFirma != 0)
                    {
                        var firma = stocareFirme.GetFirma(idFirma);

                        Livrator livratorForEdit = stocareLivratori.GetLivrator(idLivrator);
                        livratorForEdit.FirstName = txtNumeLivrator.Text;
                        livratorForEdit.LastName = txtPrenumeLivrator.Text;
                        livratorForEdit.HireDate = dataAngPicker.Value.Date;
                        livratorForEdit.BirthDate = dataNasteriiPicker.Value.Date;
                        livratorForEdit.Email = emailValue.Text;
                        livratorForEdit.VehicleId = idAuto;
                        stocareLivratori.UpdateLivrator(livratorForEdit);
                        resetLivratorData();
                        lstMasine.ClearSelected();
                        AfiseazaLivratori();

                    }
                    else
                    {
                        eroareLivratorLbl.Text = "Selecteaza o firma din lista";
                    }

                }
                else
                {
                    eroareLivratorLbl.Text = "Selecteaza o firma din lista";
                }
            }
        }

        private void btnStergeFirma_Click(object sender, EventArgs e)
        {
            if (lstFirme.SelectedItem != null)
            {
                string curItem = lstFirme.SelectedItem.ToString();

                Int32.TryParse(curItem.Split(' ')[0], out int id);
                if (id != 0)
                {
                    stocareFirme.DeleteFirma(id);
                    clearFirmaInputs();
                    AfiseazaFirme();
                    lstLivratori.Items.Clear();
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

        private void deleteLivBtn_Click(object sender, EventArgs e)
        {
            if (lstFirme.SelectedItem != null)
            {
                string currentFirma = lstFirme.SelectedItem.ToString();

                Int32.TryParse(currentFirma.Split(' ')[0], out int idFirma);

                string currentLivrator = lstLivratori.SelectedItem.ToString();

                Int32.TryParse(currentLivrator.Split(' ')[0], out int idLivrator);


                if (idFirma != 0)
                {
                    stocareLivratori.DeleteLivrator(idLivrator);
                    resetLivratorData();
                    lstMasine.ClearSelected();
                    AfiseazaLivratori();

                }
                else
                {
                    eroareLivratorLbl.Text = "Selecteaza o firma din lista";
                }

            }
            else
            {
                eroareLivratorLbl.Text = "Selecteaza o firma din lista";
            }
        }
    }
}
