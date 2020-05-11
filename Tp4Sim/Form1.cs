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
        private long cantidadASimular;
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
            if (mostrarDesde.Text == "" || cant_generar.Text =="" || cantAMostrar.Text == "" )
            {
                MessageBox.Show("Faltan datos para generar simulación.");
                return;
            }

            grilla_politica_a.Rows.Clear();
            grilla_politica_b.Rows.Clear();
            cantidadASimular = long.Parse(cant_generar.Text);
            cantDemandadaDiaAnterior = int.Parse(cant_demand.Text);
            cantPerdidaVenderDiaAnterior = int.Parse(cant_perd.Text);
            ko = double.Parse(precio_costo.Text);
            reembolso = double.Parse(precio_reemb.Text);
            ks = double.Parse(prec_uti_perdida.Text);
            filaDesde = int.Parse(mostrarDesde.Text);
            filaHasta = int.Parse(cantAMostrar.Text);
            this.controlInput();
        }

        private void controlInput()
        {
            if (filaDesde > cantidadASimular)
            {
                 MessageBox.Show("'Mostrar Desde' no debe ser mayor a 'Cantidad a generar'. ");
                 return;
            }
            this.politicaA();
            this.politicaB();
            this.compararPoliticas();

        }

        public void compararPoliticas()
        {
            var polA = double.Parse(this.politica_A.Text);
            var polB = double.Parse(this.politica_b.Text);

            resultado_.Text = polB <= polA ? "Política eficiente: B" : "Política eficiente: A";
        }

        public void politicaA()
        {
            double nroAleatorio;
            int demandaDiaActual;
            int cantPedidaDiaActual;
            int cantVendida = 0;
            double costoCompra;
            double costoReembolso;
            double costoUtilidadPerdida;
            double costoTotal;
            double costoTotalAc = 0;
            double costoPromedio = 0;

            for (int i = 1; i <= cantidadASimular; i++)
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

                if (cantPedidaDiaActual > demandaDiaActual)
                {
                    sobrante = cantPedidaDiaActual - demandaDiaActual;
                    cantVendida = demandaDiaActual;
                }


                costoCompra = cantPedidaDiaActual * ko;
                costoReembolso = sobrante * reembolso;
                costoUtilidadPerdida = cantPerdidaDiaActual * ks;
                costoTotal = costoCompra - costoReembolso + costoUtilidadPerdida;
                costoTotalAc += costoTotal;
                costoPromedio = costoTotalAc / i;
                if (((filaDesde <= i) && (filaDesde + filaHasta > i)) || i == cantidadASimular)
                {
                    //Cargar grilla
                    grilla_politica_a.Rows.Add(i, nroAleatorio, demandaDiaActual, cantPedidaDiaActual,
                        cantVendida, cantPerdidaDiaActual, sobrante, costoCompra, costoReembolso, costoUtilidadPerdida, costoTotal, this.TruncateFunction(costoTotalAc,4), this.TruncateFunction(costoPromedio,4));
                }

                if (i == cantidadASimular) {
                    int r = grilla_politica_a.Rows.Count;
                    grilla_politica_a.Rows[r-1].DefaultCellStyle.ForeColor = Color.FromArgb(156, 0, 6);
                    grilla_politica_a.Rows[r-1].DefaultCellStyle.BackColor = Color.Yellow;
                }
                cantDemandadaDiaAnterior = demandaDiaActual;
                cantPerdidaVenderDiaAnterior = cantPerdidaDiaActual;
            }

            this.politica_A.Text = this.TruncateFunction(costoPromedio,2).ToString();

        }

        public void politicaB()
        {
            double nroAleatorio;
            int demandaDiaActual;
            int cantPedidaDiaActual = 23;
            int cantVendida = 0;
            double costoCompra;
            double costoReembolso;
            double costoUtilidadPerdida;
            double costoTotal;
            double costoTotalAc = 0;
            double costoPromedio = 0;

            for (int i = 1; i <= cantidadASimular; i++)
            {

                nroAleatorio = this.TruncateFunction(rnd.NextDouble(), 2);
                demandaDiaActual = valorDelIntervalo.intervalosEjercicio(nroAleatorio);
                int cantPerdidaDiaActual = 0;
                int sobrante = 0;

                if (demandaDiaActual > cantPedidaDiaActual)
                {
                    cantPerdidaDiaActual = demandaDiaActual - cantPedidaDiaActual;
                    cantVendida = cantPedidaDiaActual;
                }

                if (cantPedidaDiaActual > demandaDiaActual)
                {
                    sobrante = cantPedidaDiaActual - demandaDiaActual;
                    cantVendida = demandaDiaActual;
                }


                costoCompra = cantPedidaDiaActual * ko;
                costoReembolso = sobrante * reembolso;
                costoUtilidadPerdida = cantPerdidaDiaActual * ks;
                costoTotal = costoCompra - costoReembolso + costoUtilidadPerdida;
                costoTotalAc += costoTotal;
                costoPromedio = costoTotalAc / i;
                if (((filaDesde <= i) && (filaDesde + filaHasta > i)) || i == cantidadASimular)
                {
                    //Cargar grilla
                    grilla_politica_b.Rows.Add(i, nroAleatorio, demandaDiaActual, cantPedidaDiaActual,
                        cantVendida, cantPerdidaDiaActual, sobrante, costoCompra, costoReembolso, costoUtilidadPerdida, costoTotal, this.TruncateFunction(costoTotalAc, 4), this.TruncateFunction(costoPromedio, 4));
                }

                if (i == cantidadASimular)
                {
                    int r = grilla_politica_b.Rows.Count;
                    grilla_politica_b.Rows[r - 1].DefaultCellStyle.ForeColor = Color.FromArgb(156, 0, 6);
                    grilla_politica_b.Rows[r - 1].DefaultCellStyle.BackColor = Color.Yellow;
                }
                cantDemandadaDiaAnterior = demandaDiaActual;
                cantPerdidaVenderDiaAnterior = cantPerdidaDiaActual;
            }

            this.politica_b.Text = this.TruncateFunction(costoPromedio, 2).ToString();
        }


        public double TruncateFunction(double number, int digit)
        {
            return Math.Truncate((Math.Pow(10.0, (double)digit) * number)) / (Math.Pow(10.0, (double)digit));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cant_demand.Text = "20";
            cant_perd.Text = "3";
            precio_costo.Text = "0,8";
            precio_reemb.Text = "0,2";
            prec_uti_perdida.Text = "0,4";
            cantAMostrar.Clear();
            mostrarDesde.Clear();
            cant_generar.Clear();
            grilla_politica_a.Rows.Clear();
            grilla_politica_b.Rows.Clear();
            politica_A.Clear();
            politica_b.Clear();
            resultado_.Text = "Resultado";
        }
    }
}
