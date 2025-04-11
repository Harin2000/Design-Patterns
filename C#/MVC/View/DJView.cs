using MVC.Controller;
using MVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.View
{
    internal class DJView : IBeatObserver, IBPMObserver
    {
        IBeatModelInterface model;
        IController controller;
        // Frame, Panel, Beatbar, BPMOutputLabel

        public DJView(IController controller, IBeatModelInterface model)
        {
            this.controller = controller;
            this.model = model;
            model.RegisterObserver((IBeatObserver)this);
            model.RegisterObserver((IBPMObserver)this);
        }
        public void CreateView()
        {
            // Create UI components
        }
        public void UpdateBeat()
        {
            int bpm = model.GetBPM();
            if (bpm == 0)
            {
                //Label.setText("Offline");
            }
            else
            {
                //Label.setText("BPM: " + bpm);
            }
        }
        public void UpdateBPM()
        {
            //beatBar.setValue(100);
        }

        // Controls
        public void CreateControlls()
        {
            // Create UI controls
        }
        public void EnableStopMenuItem()
        {
            // stopMenuItem.setEnabled(true);
        }
        public void DisableStopMenuItem()
        {
            // stopMenuItem.setEnabled(false);
        }
        public void EnableStartMenuItem()
        {
            // startMenuItem.setEnabled(true);
        }
        public void DisableStartMenuItem()
        {
            // startMenuItem.setEnabled(false);
        }
        public void ActionPerformed()//(ActionEvent event)
        {
            /*
             * If(event.getSource() == setBPMButton){
             *  int bpm = Integer.parseInt(bpmTextField.getText());
             *  controller.setBPM(bpm);
             * }
             * 
             * else if(event.getSource() == increaseBPMButton){
             *  controller.increaseBPM();
             * }
             * 
             * else if(event.getSource() == decreaseBPMButton){
             *  controller.decreaseBPM();
             * }
             */
        }
    }
}
