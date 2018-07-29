using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstacionamentoDesafio.Carro;


namespace EstacionamentoDesafio
{
    public partial class Form1 : Form
    {
        private List<Carro.Carro> carros = new List<Carro.Carro>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Carro.Carro c= new Carro.Carro();
            c.Marca = "";
        }
    }
}
