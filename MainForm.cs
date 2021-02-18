using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTask.RacingLogic;
using static TestTask.RacingLogic.Colors;
using static TestTask.RacingLogic.Racing;

namespace TestTask
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var venicleColorsDictionary = GetVehicleColors();
            //TODO Доделать (?)
            //cbVehicleColors.DrawMode = DrawMode.OwnerDrawFixed;
            //cbVehicleColors.DrawItem += (_sender, _e) => {
            //    _e.DrawBackground();
            //    var graphics = _e.Graphics;

            //    var индекс = (int)cbVehicleColors.Items[_e.Index];

            //    graphics.FillRectangle(new SolidBrush(venicleColorsDictionary[ColorEnumeration.Blue]), _e.Bounds);
            //    _e.DrawFocusRectangle();
            //};
            foreach (var venicleColor in venicleColorsDictionary)
            {
                cbVehicleColors.Items.Add(venicleColor.Key);
            }
            cbVehicleColors.SelectedIndex = 0;



            cbVehicleTypes.SelectedIndex = 0;
            lbVehicles.DataSource = new BindingSource().DataSource = vehicles;
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
            var vehicle = new Vehicle(vehicleType, Convert.ToInt32(nudVehicleSpeed.Value), Convert.ToDouble(nudWheelPunctureProbability.Value),
                (ColorEnumeration)Enum.Parse(typeof(ColorEnumeration), cbVehicleColors.SelectedItem.ToString()));
            vehicles.Add(vehicle);
            VehicleCollectionIsChanged();
        }

        private void VehicleCollectionIsChanged()
        {
            btnRemoveVehicle.Enabled = vehicles.Count > 0;
            btnAddVehicle.Enabled = vehicles.Count < 12;
        }
    }
}
