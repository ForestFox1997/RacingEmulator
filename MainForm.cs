using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using TestTask.RacingLogic;
using static TestTask.RacingLogic.Colors;
using static TestTask.RacingLogic.Racing;
using static TestTask.RacingLogic.Service;

namespace TestTask
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Picture picture = new Picture();

        private void MainForm_Load(object sender, EventArgs e)
        {
            var venicleColorsDictionary = GetVehicleColors();
            foreach (var venicleColor in venicleColorsDictionary)
                cbVehicleColors.Items.Add(venicleColor.Key);
            cbVehicleColors.SelectedIndex = 0;
            cbVehicleTypes.SelectedIndex = 0;
            lbVehicles.DataSource = new BindingSource().DataSource = vehicles;
            Parameters.DistanceUnits = (int)nudDistance.Value;
            Parameters.MinimumTimeToChangeWheel = (int)nudMinTimeToChangeWheel.Value;
            Parameters.MaximumTimeToChangeWheel = (int)nudMaxTimeToChangeWheel.Value;
            Parameters.SimulationSpeed = (int)nudSimulationSpeed.Value;
        }

        private void btnRemoveVehicle_Click(object sender, EventArgs e)
        {
            var vehicle = (Vehicle)lbVehicles.SelectedItem;
            vehicles.Remove(vehicle);
            VehicleCollectionIsChanged();
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            var vehicleType = Vehicle.VehicleType.Truck;
            if (cbVehicleTypes.SelectedItem.ToString() == "Легковое авто")
                vehicleType = Vehicle.VehicleType.PassengerCar;
            else if (cbVehicleTypes.SelectedItem.ToString() == "Мотоцикл")
                vehicleType = Vehicle.VehicleType.Motorcycle;
            string additionalParameter = "";
            if (vehicleType == Vehicle.VehicleType.Truck)
                additionalParameter = nudCargoWeight.Value.ToString();
            else if (vehicleType == Vehicle.VehicleType.Motorcycle)
                additionalParameter = cbSidecarAvailability.Checked.ToString();
            else if (vehicleType == Vehicle.VehicleType.PassengerCar)
                additionalParameter = nudPeopleCount.Value.ToString();
            var vehicle = new Vehicle(vehicleType, Convert.ToInt32(nudVehicleSpeed.Value), Convert.ToDouble(nudWheelPunctureProbability.Value),
                (ColorEnumeration)Enum.Parse(typeof(ColorEnumeration), cbVehicleColors.SelectedItem.ToString()), additionalParameter);
            vehicles.Add(vehicle);
            VehicleCollectionIsChanged();
        }

        private void VehicleCollectionIsChanged()
        {
            btnRemoveVehicle.Enabled = vehicles.Count > 0;
            btnAddVehicle.Enabled = vehicles.Count < 12;
        }

        private async void btnGo_Click(object sender, EventArgs e)
        {
            tbVehiclesStats.Text = Statistics.GetResult(Statistics.RaceCondition.start);
            await Task.Run(() => {
                if (vehicles.Count != 0)
                {
                    Invoke((MethodInvoker)delegate {
                        nudDistance.Enabled = false;
                        btnGo.Enabled = false;
                        btnRemoveVehicle.Enabled = false;
                        btnAddVehicle.Enabled = false;
                    });
                    var raceCondition = new RaceCondition();
                    raceCondition.RaceConditionIsChanged += DisplayChangedRaceCondition;
                    raceCondition.StartRace();
                    tbRacingStats.Invoke((MethodInvoker)delegate { tbRacingStats.Text += "Гонка завершена!"; });
                    Invoke((MethodInvoker)delegate {
                        nudDistance.Enabled = true;
                        btnGo.Enabled = true;
                        btnRemoveVehicle.Enabled = true;
                        btnAddVehicle.Enabled = true;
                    });
                }
            });
            DisplayReport();
        }

        private void DisplayChangedRaceCondition()
        {
            var currentCondition = vehicles;
            tbRacingStats.Invoke((MethodInvoker)delegate {
                string condition = Statistics.GetResult(Statistics.RaceCondition.continues);
                tbRacingStats.Text = condition + Environment.NewLine;
                pictureBox.Invoke((MethodInvoker)delegate { picture.DrawPicture(pictureBox); });
            });
        }
        
        private void TimeToChangeWheel_ValueChanged(object sender, EventArgs e)
        {
            if (nudMinTimeToChangeWheel.Value > nudMaxTimeToChangeWheel.Value)
                if (((NumericUpDown)sender).Name == "nudMinTimeToChangeWheel")
                    nudMaxTimeToChangeWheel.Value = nudMinTimeToChangeWheel.Value;
                else
                    nudMinTimeToChangeWheel.Value = nudMaxTimeToChangeWheel.Value;
            Parameters.MinimumTimeToChangeWheel = (int)nudMinTimeToChangeWheel.Value;
            Parameters.MaximumTimeToChangeWheel = (int)nudMaxTimeToChangeWheel.Value;
        }

        private void nudSimulationSpeed_ValueChanged(object sender, EventArgs e)
        {
            Parameters.SimulationSpeed = (int)nudSimulationSpeed.Value;
        }

        private void nudDistance_ValueChanged(object sender, EventArgs e)
        {
            Parameters.DistanceUnits = (int)nudDistance.Value;
        }

        private void cbVehicleTypes_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbVehicleTypes.SelectedItem.ToString() == "Грузовик")
            {
                label9.Text = "Вес груза";
                nudCargoWeight.Visible = true;
                nudPeopleCount.Visible = false;
                cbSidecarAvailability.Visible = false;
            }
            else if (cbVehicleTypes.SelectedItem.ToString() == "Легковое авто")
            {
                label9.Text = "Количество людей";
                nudCargoWeight.Visible = false;
                nudPeopleCount.Visible = true;
                cbSidecarAvailability.Visible = false;
            }
            else if (cbVehicleTypes.SelectedItem.ToString() == "Мотоцикл")
            {
                label9.Text = "";
                nudCargoWeight.Visible = false;
                nudPeopleCount.Visible = false;
                cbSidecarAvailability.Visible = true;
            }
        }

        private void DisplayReport()
        {
            if (vehicles.Count == 0)
                return;
            var formReport = new FormReport();
            if (formReport.ShowDialog() == DialogResult.OK)
                btnGo_Click(formReport, new EventArgs());
        }
    }
}
