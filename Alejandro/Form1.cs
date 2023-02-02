namespace Alejandro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            maskedTextBox3.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ig, eg, mon, util, cuota, plazo, por;
            string es, noes, nombre;


            if (textBox1.Text == "")
            {
                MessageBox.Show("No se permite espacios.");
                textBox1.Focus();

            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("No se permite espacios.");
                comboBox1.Focus();
            }
            else if (maskedTextBox1.Text == "")
            {
                MessageBox.Show("No se permite espacios.");
                maskedTextBox1.Focus();
            }
            else if (maskedTextBox2.Text == "")
            {
                MessageBox.Show("No se permite espacios.");
                maskedTextBox2.Focus();
            }
            else if (maskedTextBox3.Text == "")
            {
                MessageBox.Show("No se permite espacios.");
                maskedTextBox3.Focus();
            }
            else if (comboBox2.Text == "")
            {
                MessageBox.Show("No se permite espacios.");
                comboBox2.Focus();
            }
            else
            {
                nombre = Convert.ToString(textBox1.Text);
                ig = double.Parse(maskedTextBox1.Text);
                eg = double.Parse(maskedTextBox2.Text);
                mon = double.Parse(maskedTextBox3.Text);
                plazo = double.Parse(comboBox2.Text);
                if (ig >= 500 && ig <= 500000)
                {
                    if (eg <= ig)
                    {
                        util = ig - eg;
                        textBox4.Text = util.ToString();



                        cuota = mon / plazo;
                        textBox2.Text = cuota.ToString();
                        por = util * 0.35;
                        if (cuota <= por)
                        {
                            es = " ES SUJETO A CREDITO";
                            textBox3.Text = es.ToString();
                        }
                        else
                        {
                            noes = " NO ES SUJETO A CREDITO";
                            textBox3.Text = noes.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error, El Egreso no debe se mayor que el Ingreso");
                        maskedTextBox2.Text = "";
                        maskedTextBox2.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Error, Rango de ingresos entre 500 y 5000");
                    maskedTextBox1.Text = "";
                    maskedTextBox1.Focus();



                }
                if (mon < 100 || mon > 5000)
                {
                    MessageBox.Show("rango entre 100 y 5000", "Error");
                    maskedTextBox3.Text = "";
                    maskedTextBox3.Focus();
                }



            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double ig, eg, mon, util, cuota, plazo, por;
            string es, noes, nombre, Ting;

            nombre = Convert.ToString(textBox1.Text);
            ig = double.Parse(maskedTextBox1.Text);
            eg = double.Parse(maskedTextBox2.Text);
            mon = double.Parse(maskedTextBox3.Text);
            plazo = double.Parse(comboBox2.Text);
            Ting = Convert.ToString(comboBox1.Text);
            if (ig >= 500 && ig <= 500000)
                if (eg <= ig)
                {
                    util = ig - eg;
                    



                    cuota = mon / plazo;
                    
                    por = util * 0.35;
                    if (cuota <= por)
                    {
                        es = " Es Sujeto a Cr�dito";
                       
                    }
                    else
                    {
                        noes = " No es Sujeto a Cr�dito";
                       
                    }


                }
                else
                {
                    MessageBox.Show("El Egreso no puede ser mayor a Ingreso", "Error");
                    maskedTextBox2.Text = "";
                    maskedTextBox2.Focus();



                }
            else if (mon < 100 || mon > 5000)
            {
                MessageBox.Show("rango entre 100 y 5000", "Error");
                maskedTextBox3.Text = "";
                maskedTextBox3.Focus();
            }

            util = ig - eg;
            cuota = mon / plazo;
            MessageBox.Show("Nombre: " + nombre + "\nTipo de ingreso: " + Ting + "\nPlazo: " + plazo + "\nIngresos: " + ig + "\nEgresos: " + eg + "\nMonto Requerido: " + mon + "\nUtilidad: " + util + "\nCuota: " + cuota);

        }
    }
    }
