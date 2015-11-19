﻿using Pancas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _1.plot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();

            Pancas.Pancas
                .From(new Pancas.DataSource.File("share_prices.csv"))
                .As(new Pancas.DataFormat.Csv())
                .Then(dataFrame =>
                {
                    Plot("Date", "Close", dataFrame);
                });
        }

        /// <summary>
        /// Helper function for plotting.
        /// </summary>
        private void Plot(string yAxisColumnName, string xAxisColumnName, IDataFrame dataFrame)
        {
            var subset = dataFrame.GetColumnsSubset(new string[] { yAxisColumnName, xAxisColumnName });

            var series = new Series(xAxisColumnName);
            foreach (var entry in subset.GetRows<DateTime, float>())
            {
                series.Points.AddXY(entry.Item1, entry.Item2);
            }

            this.chart1.Series.Add(series);
        }
    }
}