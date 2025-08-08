
using System.Windows.Forms;

namespace Aguinaldo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void lblSal_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {






        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        /* private void textBox1_TextChanged(object sender, EventArgs e)
         {

         }*/

        private void btnAguinaldo_Click(object sender, EventArgs e)

        {
            // String op = combselec.SelectedItem.ToString();
            try
            {
                decimal salv;
                decimal salario = 0;
                decimal salday = 0;
                decimal aguinaldo = 0;


                if (decimal.TryParse(txtsalary.Text, out salario))
                {
                    salday = salario / 30;
                    //lblresultado.Text = "Tu salario diario es"+ salday;

                    if (rdbmas.Checked)

                    {
                        timeact.Enabled = false;
                        timeini.Enabled = false;
                        String op = combselec.SelectedItem.ToString();

                        switch (op)
                        {

                            case "De 1 a 3 años":
                                aguinaldo = 15 * salday;
                                aguinaldo = Math.Round(aguinaldo, 2);
                                aguinaldo = aguinaldo + salario;
                                lblresultado.Text = "Su aguinaldo a recibir es de: $ " + aguinaldo;
                                break;
                            case "De 3 a 10 años":
                                aguinaldo = 19 * salday;
                                aguinaldo = Math.Round(aguinaldo, 2);
                                aguinaldo = aguinaldo + salario;
                                lblresultado.Text = "Su aguinaldo a recibir es de: $ " + aguinaldo; ;
                                break;

                            case "De 10 años en adelante":
                                aguinaldo = 21 * salday;
                                aguinaldo = Math.Round(aguinaldo, 2);
                                aguinaldo = aguinaldo + salario;
                                lblresultado.Text = "Su aguinaldo a recibir es de: $ " + aguinaldo;
                                break;

                        }

                    }

                    if (rdbmenos.Checked)
                    {

                        DateTime fechain = timeini.Value;
                        DateTime fechaact = timeact.Value;

                        TimeSpan diastraba = fechaact - fechain;
                        int enterosdias = diastraba.Days;
                        MessageBox.Show("Dias trabajados: " + enterosdias);
                        aguinaldo = (salday * 15) * ((decimal)enterosdias / 365);
                        aguinaldo = aguinaldo + salario;
                        lblresultado.Text = "Su aguinaldo a recibir es de: $ " + Math.Round(aguinaldo, 2);


                    }


                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }













        }

        private void rdbdiastrab_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbmas.Checked)
            {




                timeini.Enabled = false;
                timeact.Enabled = false;
                combselec.Enabled = true;
                combselec.Items.Clear();
                combselec.Items.Add("De 1 a 3 años");
                combselec.Items.Add("De 3 a 10 años");
                combselec.Items.Add("De 10 años en adelante");
                //txtfechai.Enabled = false;
                //  txtfechaact.Enabled = false;
            }
            if (!rdbmas.Checked)
            {
                timeini.Enabled = true;
                timeact.Enabled = true;
                combselec.Enabled = false;
                combselec.Items.Clear();
            }
        }

        private void lbldias_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            combselec.Enabled = true;
            combselec.Items.Clear();
        }

        private void rdbmenos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbmenos.Checked)
            {
                combselec.Enabled = false;
                combselec.Items.Clear();
                //txtfechaact;
                // txtfechaact.Enabled = true;
            }


        }

        private void lblresultado_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timeini_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
