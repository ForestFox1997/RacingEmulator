using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TestTask.RacingLogic.Racing;
using static TestTask.RacingLogic.Statistics;
using static TestTask.RacingLogic.Service;

namespace TestTask
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            var reports = new List<ReportRow>();
            dgvReport.RowCount = vehicles.Count;
            for (int i = 0; i < vehicles.Count; i++)
                reports.Add(new ReportRow {
                    Participant = vehicles[i].ToString(),
                    FinishPosition = finishers.IndexOf(vehicles[i]),
                    SpentTimeRacing = (int)vehicles[i].CountOfTimeUnits,
                    CountOfWheelPunctures = vehicles[i].CountOfTirePunctures,
                    TimeToChangeWheel = Math.Round(((vehicles[i].CountOfTimeUnits - Parameters.DistanceUnits) / Parameters.DistanceUnits), 3)
                });
            for (var i = 0; i < reports.Count; i++)
            {
                dgvReport[0, i].Value = reports[i].Participant;
                dgvReport[1, i].Value = reports[i].FinishPosition + 1;
                dgvReport[2, i].Value = reports[i].SpentTimeRacing;
                dgvReport[3, i].Value = reports[i].CountOfWheelPunctures;
                dgvReport[4, i].Value = reports[i].TimeToChangeWheel * 100;
            }
        }

        private class ReportRow
        {
            public string Participant { get; set; }

            public int FinishPosition { get; set; }

            public int SpentTimeRacing { get; set; }

            public int CountOfWheelPunctures { get; set; }

            public double TimeToChangeWheel { get; set; }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
