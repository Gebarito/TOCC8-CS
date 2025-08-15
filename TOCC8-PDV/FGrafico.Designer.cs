namespace TOCC8_PDV
{
    partial class FGrafico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartProduto = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // chartProduto
            // 
            chartArea1.Name = "ChartArea1";
            this.chartProduto.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartProduto.Legends.Add(legend1);
            this.chartProduto.Location = new System.Drawing.Point(12, 12);
            this.chartProduto.Name = "chartProduto";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartProduto.Series.Add(series1);
            this.chartProduto.Size = new System.Drawing.Size(776, 426);
            this.chartProduto.TabIndex = 0;
            this.chartProduto.Text = "chart1";
            // 
            // FGrafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartProduto);
            this.Name = "FGrafico";
            this.Text = "TOCC8 - Gráfico";
            ((System.ComponentModel.ISupportInitialize)(this.chartProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartProduto;
    }
}