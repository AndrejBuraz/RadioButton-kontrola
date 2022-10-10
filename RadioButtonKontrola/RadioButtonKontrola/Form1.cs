namespace RadioButtonKontrola
{
    public partial class Form1 : Form
    {
        string izbor;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButtonAvion_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonAvion.Checked)
            {
                izbor = "prijevoz avionom.";
            }
        }

        private void radioButtonAutobus_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAutobus.Checked)
            {
                izbor = "prijevoz autobusom.";
            }
        }

        private void radioButtonVlastiti_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonVlastiti.Checked)
            {
                izbor = "vlastiti prijevoz.";
            }
        }

        private void buttonRezerviraj_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Odabrali ste " + izbor;
        }
    }
}