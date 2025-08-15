using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TOCC8_PDV
{
    public partial class FGrafico : Form
    {
        public FGrafico()
        {
            InitializeComponent();
            displayChart();
        }

        public void displayChart()
        {
            TOCC8Entities contexto;

            try
            {
                contexto = new TOCC8Entities();
                var produtos = from p in contexto.produto select p;

                chartProduto.Series.Clear();

                chartProduto.Series.Add(new Series("Lucro"));
                chartProduto.Series["Lucro"].ChartType = SeriesChartType.Column;
                chartProduto.Series["Lucro"].Color = Color.Blue;

                chartProduto.Series.Add(new Series("PrazoValidade"));
                chartProduto.Series["PrazoValidade"].ChartType = SeriesChartType.Column;
                chartProduto.Series["PrazoValidade"].Color = Color.Orange;


                chartProduto.Titles.Clear();
                chartProduto.Titles.Add("Lucro x Prazo de Validade");

                foreach (var p in produtos)
                {
                    var prazoValidade = (Convert.ToDateTime(p.datavalidade) - DateTime.Now).Days;

                    chartProduto.Series["Lucro"].Points.AddXY(p.descricao, p.taxalucro);
                    chartProduto.Series["PrazoValidade"].Points.AddXY(p.descricao, prazoValidade);
                }


            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
