using MVC.Model;
using MVC.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Controller
{
    internal class BeatController : IController
    {
        IBeatModelInterface model;
        DJView view;
        public BeatController(IBeatModelInterface model)
        {
            this.model = model;
            view = new DJView(this, model);
            view.CreateView();
            view.CreateControlls();
            view.DisableStopMenuItem();
            view.EnableStartMenuItem();
            model.Initialize();
        }
        public void DecreaseBPM()
        {
            model.SetBPM(model.GetBPM() - 1);
        }

        public void IncreaseBPM()
        {
            model.SetBPM(model.GetBPM() + 1);
        }

        public void SetBPM(int bpm)
        {
            model.SetBPM(bpm);
        }

        public void Start()
        {
            model.On();
            view.EnableStopMenuItem();
            view.DisableStartMenuItem();
        }

        public void Stop()
        {
            model.Off();
            view.DisableStopMenuItem();
            view.EnableStartMenuItem();
        }
    }
}
