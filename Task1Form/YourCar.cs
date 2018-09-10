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
using System.Media;

namespace Task1Form
{
    public partial class YourCar : Form
    {
        public YourCar()
        {
            InitializeComponent();
            Engine_box.Text = "Выключен";
            Wheel_box.Text = "Не двигаются";
            Engine_box.ReadOnly = true;
            Wheel_box.ReadOnly = true;
            Info_box.ReadOnly = true;
            Model_box.ReadOnly = true;
        }
        public static void ClearBox(TextBox Info_box)
        {
            Info_box.Clear();
        }
        public static void StartCar(Car car,TextBox Engine_box,TextBox Wheel_box)
        {
            if (car.engine.EngineStatus == false) {
                car.engine.StartEngine();
                car.StartMoveWheels();
                Engine_box.Text = "Включен";
                Wheel_box.Text = "Приведены в движение";
                SoundPlayer startsoundcar = new SoundPlayer(@"C:\Users\bakul\OneDrive\Рабочий стол\АТТЕСТАЦИЯ ПО ПРОГАММИРОВАНИЮ\3 семестр\1 аттестация\Task1Console\car.wav");
                startsoundcar.Play();
            }
        }
        public static void StopCar(Car car, TextBox Engine_box, TextBox Wheel_box)
        {
            if (car.engine.EngineStatus == true)
            {
                car.StopMoveWheels();
                car.engine.OffEngine();
                Engine_box.Text = "Выключен";
                Wheel_box.Text = "Не двигаются";
                SoundPlayer stopsoundcar = new SoundPlayer(@"C:\Users\bakul\OneDrive\Рабочий стол\АТТЕСТАЦИЯ ПО ПРОГАММИРОВАНИЮ\3 семестр\1 аттестация\Task1Console\Stopcar.wav");
                stopsoundcar.Play();
            }
        }
        Car car = new Car();
        private void Btn_move_Click(object sender, EventArgs e)
        {
            ClearBox(Info_box);
            StartCar(car,Engine_box,Wheel_box);
        }

        private void Btn_refuel_Click(object sender, EventArgs e)
        {
            ClearBox(Info_box);
            StopCar(car, Engine_box, Wheel_box);
            Info_box.Text = "Идёт заправка...";
            System.Threading.Thread.Sleep(1500);
            Info_box.Text = "Бак, полон";
        }

        private void Btn_changeWheel_Click(object sender, EventArgs e)
        {
            ClearBox(Info_box);
            StopCar(car, Engine_box, Wheel_box);
            Random rnd = new Random();
            int randomNumber = rnd.Next(0, 3);
            car.wheels.RemoveAt(randomNumber);
            Wheel_box.Text = "Заменено, готово в к движению";
            Info_box.Text = "Колесо заменено";
        }

        private void Btn_showModel_Click(object sender, EventArgs e)
        {
            ClearBox(Info_box);
            Model_box.Text = car.Models;
            Btn_showModel.Enabled = false;
        }
    }
}
