using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class Engine
    {
        //private bool engineStatus = false;
        public bool EngineStatus { get; set; } = false;
        public void StartEngine()
        {
            EngineStatus = true;
        }
        public void OffEngine()
        {
            EngineStatus = false;
        }

    }
}
