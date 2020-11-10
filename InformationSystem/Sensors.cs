using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationSystem
{
    public partial class Sensors : Form
    {
        private readonly MySqlConnection conn;
        public Sensors()
        {
            InitializeComponent();
            conn = DatabaseConnect.Connect();
        }
        private void Sensors_Load(object sender, EventArgs e)
        {
            
        }

        private int _sensors = 0;
        private int _sensorPosition = 0;
        private void AddSensor_Click(object sender, EventArgs e)
        {
            _sensors++;

            FontFamily ff = new FontFamily("Roboto Medium");
            int fz = 14;
            FontStyle fs = FontStyle.Regular;
            GraphicsUnit ft = GraphicsUnit.Pixel;
            Color fc = Color.Black;
            ContentAlignment ta = ContentAlignment.MiddleCenter;
            Color bc = Color.FromArgb(196, 196, 196); // 196, 196, 196
            Size bz = new Size(1, 18);

            int _locationY = 20;

            // Label Sensor ~ Узел 12
            Label Sensor = new Label
            {
                AutoSize = false,
                Font = new Font(ff, fz, fs, ft),
                ForeColor = fc,
                Location = new Point(1, _locationY * _sensorPosition),
                Parent = PanelSensors,
                Name = "Sensor_" + _sensors.ToString(),
                Text = "Узел " + _sensors.ToString(),
                TextAlign = ContentAlignment.MiddleRight,
                Size = new Size(84, 17)
            };
            Sensor.BringToFront();

            // Border 1
            Panel Border = new Panel
            {
                Location = new Point(84, _locationY * _sensorPosition),
                Name = "Border_1_" + _sensors.ToString(),
                Parent = PanelSensors,
                Size = bz,
                BackColor = bc
            };
            Border.BringToFront();

            // Temperature
            Label Temperature = new Label
            {
                AutoSize = false,
                Font = new Font(ff, fz, fs, ft),
                ForeColor = fc,
                Location = new Point(85, _locationY * _sensorPosition),
                Parent = PanelSensors,
                Name = "Temperature_" + _sensors.ToString(),
                Text = "8",
                TextAlign = ta,
                Size = new Size(24, 17)
            };
            Temperature.BringToFront();

            // Border 2
            Panel Border2 = new Panel
            {
                Location = new Point(109, _locationY * _sensorPosition),
                Name = "Border_2_" + _sensors.ToString(),
                Parent = PanelSensors,
                Size = bz,
                BackColor = bc
            };
            Border2.BringToFront();

            // ph
            Label ph = new Label
            {
                AutoSize = false,
                Font = new Font(ff, fz, fs, ft),
                ForeColor = fc,
                Location = new Point(110, _locationY * _sensorPosition),
                Parent = PanelSensors,
                Name = "Ph_" + _sensors.ToString(),
                Text = "Edit",
                TextAlign = ta,
                Size = new Size(50, 17)
            };
            ph.BringToFront();

            // Border 3
            Panel Border3 = new Panel
            {
                Location = new Point(160, _locationY * _sensorPosition),
                Name = "Border_3_" + _sensors.ToString(),
                Parent = PanelSensors,
                Size = bz,
                BackColor = bc
            };
            Border3.BringToFront();

            // Humidity
            Label humidity = new Label
            {
                AutoSize = false,
                Font = new Font(ff, fz, fs, ft),
                ForeColor = fc,
                Location = new Point(161, _locationY * _sensorPosition),
                Parent = PanelSensors,
                Name = "Humidity_" + _sensors.ToString(),
                Text = "Edit",
                TextAlign = ta,
                Size = new Size(90, 17)
            };
            humidity.BringToFront();

            // Border 4
            Panel Border4 = new Panel
            {
                Location = new Point(251, _locationY * _sensorPosition),
                Name = "Border_4_" + _sensors.ToString(),
                Parent = PanelSensors,
                Size = bz,
                BackColor = bc
            };
            Border4.BringToFront();

            // Phosphorus
            Label phosphorus = new Label
            {
                AutoSize = false,
                Font = new Font(ff, fz, fs, ft),
                ForeColor = fc,
                Location = new Point(252, _locationY * _sensorPosition),
                Parent = PanelSensors,
                Name = "Phosphorus_" + _sensors.ToString(),
                Text = "Edit",
                TextAlign = ta,
                Size = new Size(45, 17)
            };
            ph.BringToFront();

            // Border 5
            Panel Border5 = new Panel
            {
                Location = new Point(297, _locationY * _sensorPosition),
                Name = "Border_5_" + _sensors.ToString(),
                Parent = PanelSensors,
                Size = bz,
                BackColor = bc
            };
            Border5.BringToFront();

            // Potassium
            Label potassium = new Label
            {
                AutoSize = false,
                Font = new Font(ff, fz, fs, ft),
                ForeColor = fc,
                Location = new Point(298, _locationY * _sensorPosition),
                Parent = PanelSensors,
                Name = "Potassium_" + _sensors.ToString(),
                Text = "Edit",
                TextAlign = ta,
                Size = new Size(45, 17)
            };
            potassium.BringToFront();

            // Border 6
            Panel Border6 = new Panel
            {
                Location = new Point(343, _locationY * _sensorPosition),
                Name = "Border_6_" + _sensors.ToString(),
                Parent = PanelSensors,
                Size = bz,
                BackColor = bc
            };
            Border6.BringToFront();

            // Magnesium
            Label magnesium = new Label
            {
                AutoSize = false,
                Font = new Font(ff, fz, fs, ft),
                ForeColor = fc,
                Location = new Point(344, _locationY * _sensorPosition),
                Parent = PanelSensors,
                Name = "Magnesium_" + _sensors.ToString(),
                Text = "Edit",
                TextAlign = ta,
                Size = new Size(60, 17)
            };
            magnesium.BringToFront();

            // Border 7
            Panel Border7 = new Panel
            {
                Location = new Point(404, _locationY * _sensorPosition),
                Name = "Border_7_" + _sensors.ToString(),
                Parent = PanelSensors,
                Size = bz,
                BackColor = bc
            };
            Border7.BringToFront();

            // Calcium
            Label calcium = new Label
            {
                AutoSize = false,
                Font = new Font(ff, fz, fs, ft),
                ForeColor = fc,
                Location = new Point(405, _locationY * _sensorPosition),
                Parent = PanelSensors,
                Name = "Calcium_" + _sensors.ToString(),
                Text = "Edit",
                TextAlign = ta,
                Size = new Size(60, 17)
            };
            calcium.BringToFront();

            // Border 8
            Panel Border8 = new Panel
            {
                Location = new Point(465, _locationY * _sensorPosition),
                Name = "Border_8_" + _sensors.ToString(),
                Parent = PanelSensors,
                Size = bz,
                BackColor = bc
            };
            Border8.BringToFront();

            // Nitrogen
            Label nitrogen = new Label
            {
                AutoSize = false,
                Font = new Font(ff, fz, fs, ft),
                ForeColor = fc,
                Location = new Point(466, _locationY * _sensorPosition),
                Parent = PanelSensors,
                Name = "Nitrogen_" + _sensors.ToString(),
                Text = "Edit",
                TextAlign = ta,
                Size = new Size(56, 17)
            };
            nitrogen.BringToFront();
            // Border 9
            Panel Border9 = new Panel
            {
                Location = new Point(522, _locationY * _sensorPosition),
                Name = "Border_9_" + _sensors.ToString(),
                Parent = PanelSensors,
                Size = bz,
                BackColor = bc
            };
            Border9.BringToFront();

            // Recomendation
            Label recomendation = new Label
            {
                AutoSize = false,
                Font = new Font(ff, fz, fs, ft),
                ForeColor = fc,
                Location = new Point(466, _locationY * _sensorPosition),
                Parent = PanelSensors,
                Name = "Recomendation_" + _sensors.ToString(),
                Text = "Edit",
                TextAlign = ta,
                Size = new Size(200, 17)
            };
            nitrogen.BringToFront();

            _sensorPosition++;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var _culture = comboBox1.SelectedItem;
            for(int _i = 1; _i <= _sensors; _i++)
            {
                var _temperature = "Temperature_" + _i.ToString();
                var _ph = "" + _i.ToString();
                var _phoshor = "" + _i.ToString();

                var _recomendation = "Recomendation_" + _i.ToString();

                var _cultures = DatabaseConnect.GetTableCultures("where `name` = '" + _culture + "'", conn);

                var Temperature = Controls[_temperature];
                var Recomendation = Controls[_recomendation];

                var _tempDb = double.Parse(_cultures[9]);
                var _tempNum = double.Parse(Temperature.Name);

                if (_tempNum >= _tempDb)
                    Recomendation.Text += " Необходимо снизить температуру на " + (_tempNum - _tempDb).ToString();
                else if (_tempNum <= _tempDb)
                    Recomendation.Text += " Необходимо повысить температуру на " + (_tempDb - _tempNum).ToString();
            }
        }
    }
}
