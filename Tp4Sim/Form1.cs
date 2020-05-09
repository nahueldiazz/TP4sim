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
        private int cantidadASimular;
        int cantDemandadaDiaAnterior;
        int cantPerdidaVenderDiaAnterior;
        double ko;
        double reembolso;
        double ks;
        int filaDesde;
        int filaHasta;
        public Form1()
        {
            InitializeComponent();
            cant_demand.Text = @"20";
            cant_perd.Text = @"3";
            precio_costo.Text = @"0,8";
            precio_reemb.Text = @"0,2";
            prec_uti_perdida.Text = @"0,4";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Generar_Click(object sender, EventArgs e)
        {

            cantidadASimular = int.Parse(cant_generar.Text);
            cantDemandadaDiaAnterior = int.Parse(cant_demand.Text);
            cantPerdidaVenderDiaAnterior = int.Parse(cant_perd.Text);
            ko = double.Parse(precio_costo.Text);
            reembolso = double.Parse(precio_reemb.Text);
            ks = double.Parse(prec_uti_perdida.Text);
            filaDesde= int.Parse(mostrarDesde.Text);
            filaHasta = int.Parse(cantAMostrar.Text);
            this.politicaA();
            this.politicaB();

        }

        public void politicaA()
        {
            double nroAleatorio;
            int demandaDiaActual;
            int cantPedidaDiaActual;
            int cantVendida=0;
            double costoCompra;
            double costoReembolso;
            double costoUtilidadPerdida;
            double costoTotal;
            double costoTotalAc=0;

            for (int i = 1; i < cantidadASimular; i++)
            {
                
                nroAleatorio = this.TruncateFunction(rnd.NextDouble(), 2);
                demandaDiaActual = valorDelIntervalo.intervalosEjercicio(nroAleatorio);
                cantPedidaDiaActual = cantDemandadaDiaAnterior + cantPerdidaVenderDiaAnterior;
                int cantPerdidaDiaActual = 0;
                int sobrante = 0;

                if (demandaDiaActual > cantPedidaDiaActual)
                {
                    cantPerdidaDiaActual = demandaDiaActual - cantPedidaDiaActual;
                    cantVendida = cantPedidaDiaActual;
                }
                
                if (cantPedidaDiaActual > demandaDiaActual) {
                    sobrante = cantPedidaDiaActual - demandaDiaActual;
                    cantVendida = demandaDiaActual;
                }


                costoCompra = cantPedidaDiaActual * ko;
                costoReembolso = sobrante * reembolso;
                costoUtilidadPerdida = cantPerdidaDiaActual * ks;
                costoTotal = costoCompra - costoReembolso + costoUtilidadPerdida;
                costoTotalAc += costoTotal;
                if ((filaDesde <= i) && (filaDesde + filaHasta > i))
                {
                    //Cargar grilla
                    grilla_politica_a.Rows.Add(i, nroAleatorio, demandaDiaActual, cantPedidaDiaActual, cantVendida,cantPerdidaDiaActual,sobrante, costoCompra, costoReembolso, costoUtilidadPerdida, costoTotal, costoTotalAc);
                }
                cantDemandadaDiaAnterior = demandaDiaActual;
                cantPerdidaVenderDiaAnterior =cantPerdidaDiaActual;
            }

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
