using MVC.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Model
{
    internal interface IBeatModelInterface
    {
        void Initialize();
        void On();
        void Off();
        void SetBPM(int bpm);
        int GetBPM();
        void RegisterObserver(IBeatObserver o);
        void RemoveObserver(IBeatObserver o);
        void RegisterObserver(IBPMObserver o);
        void RemoveObserver(IBPMObserver o);
    }
}
