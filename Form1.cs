
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
            try
{
    decimal salario;
    if (decimal.TryParse(txtsalary.Text, out salario))
    {
        decimal salday = salario / 30;
        decimal aguinaldo = 0;

        // Fecha actual fija: 12 de diciembre del año actual
        DateTime fechaact = new DateTime(DateTime.Now.Year, 12, 12);
        timeact.Value = fechaact; 
        timeact.Enabled = false; // Desactivar edición

        // Fecha de inicio ingresada por el usuario
        DateTime fechain = timeini.Value;

        // Calcular días trabajados
        int diasTrabajados = (fechaact.Date - fechain.Date).Days+1;
        MessageBox.Show("Días trabajados: " + diasTrabajados);

        // Calcular años trabajados
        decimal aniosTrabajados = diasTrabajados / 365;

        // Determinar categoría
        if (aniosTrabajados >= 1 && aniosTrabajados < 3)
        {
            aguinaldo = 15 * salday;
        }
        else if (aniosTrabajados >= 3 && aniosTrabajados < 10)
        {
            aguinaldo = 19 * salday;
        }
        else if (aniosTrabajados >= 10)
        {
            aguinaldo = 21 * salday;
        }
        else
        {
            // Menos de 1 año → proporcional
            aguinaldo = (salday * 15) * (diasTrabajados / 365m);
        }

        // Mostrar resultado
        aguinaldo = Math.Round(aguinaldo, 2);
        lblresultado.Text = "Su aguinaldo a recibir es de: $ " + aguinaldo;
    }
    else
    {
        MessageBox.Show("Ingrese un salario válido.");
    }
}
catch (Exception ex)
{
    MessageBox.Show("Ocurrió un error: " + ex.Message);
}













        }

        private void rdbdiastrab_CheckedChanged(object sender, EventArgs e)
        {
          //  if (rdbmas.Checked)
           // {




                timeini.Enabled = false;
                timeact.Enabled = false;
                //combselec.Enabled = true;
               // combselec.Items.Clear();
               // combselec.Items.Add("De 1 a 3 años");
               // combselec.Items.Add("De 3 a 10 años");
               // combselec.Items.Add("De 10 años en adelante");
                //txtfechai.Enabled = false;
                //  txtfechaact.Enabled = false;
           // }
            //if (!rdbmas.Checked)
           // {
                timeini.Enabled = true;
                timeact.Enabled = true;
               // combselec.Enabled = false;
               // combselec.Items.Clear();
           // }
        }

        private void lbldias_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // combselec.Enabled = true;
            // combselec.Items.Clear();
            timeact.Enabled = false;
            DateTime fechaact = new DateTime(DateTime.Now.Year, 12, 12);
            timeact.Value = fechaact;
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
