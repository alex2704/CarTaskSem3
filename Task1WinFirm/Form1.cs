using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace Task1WinFirm
{
    public partial class YourCar : Form
    {
        Car car = new Car();
        string carmodel = car.Models;
        public YourCar()
        {
            InitializeComponent();
        }
        public static void StartEngine()
        {
            
        }

        private void Car_Load(object sender, EventArgs e)
        {
        }

        private void Btn_move_Click(object sender, EventArgs e)
        {

        }
    }
}
