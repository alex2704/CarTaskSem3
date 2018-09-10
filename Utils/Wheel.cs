using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class Wheel
    {
        public bool StatusWheel { get; set; } = false;
        public void StartMove()
        {
            StatusWheel = true;
        }
    }
}
