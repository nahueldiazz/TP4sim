using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp4Sim
{
    public partial class Form1 : Form
    {

        public ControlIntervalo valorDelIntervalo = new ControlIntervalo();
        Random rnd = new Random();
        private int cantidadAgenerar;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Generar_Click(object sender, EventArgs e)
        {
            cantidadAgenerar = int.Parse(cant_generar.Text);
            this.politicaA();
            this.politicaB();

        }

        public void politicaA()
        {
            var demanda = valorDelIntervalo.intervalosEjercicio(this.TruncateFunction(rnd.NextDouble(),2));
        }
    
        public void politicaB()
        {
            var demanda = valorDelIntervalo.intervalosEjercicio(this.TruncateFunction(rnd.NextDouble(), 2));
        }

        public double TruncateFunction(double number, int digit)
        {
            return Math.Truncate((Math.Pow(10.0, (double)digit) * number)) / (Math.Pow(10.0, (double)digit));
        }

    }
}
