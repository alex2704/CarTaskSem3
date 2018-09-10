using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class Car
    {
        public Car()
        {
            for(int i = 0; i < 4; i++)
            {
                AddWheel();
            }
             this.engine = new Engine();
        }
        public List<Wheel> wheels = new List<Wheel>();
        public Engine engine = null;
        public string Models
        {
            get
            {
                string getModel="";
                getModel = GetModels();
                return getModel;
            }
        }
        private int RandomNumber()
        {
            Random rnd = new Random();
            int k = rnd.Next(0, 9);
            return k;
        }
        private string GetModels()
        {
            string[] mas = new string[] {"Lada","Mercedez","BMW","Audi","Ferrari","Bentley","Reno","Citroen","Nissan","Peugeot" };
            string i = mas[RandomNumber()];
            return i;
        }
        public void AddWheel()
        {
            Wheel wheel = new Wheel();
            wheels.Add(wheel);
        }
        public void StartMoveWheels()
        {
            foreach(var wheel in wheels)
            {
                wheel.StatusWheel = true;
            }
        }
        public void StopMoveWheels()
        {
            foreach(var wheel in wheels)
            {
                wheel.StatusWheel = false;
            }
        }
        public void Refuel()
        {

        }
    }
}
