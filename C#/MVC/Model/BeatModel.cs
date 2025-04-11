using MVC.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Model
{
    internal class BeatModel : IBeatModelInterface
    {
        int bpm = 90;
        bool stop = false;
        List<IBeatObserver> beatObservers = new List<IBeatObserver>();
        List<IBPMObserver> bpmObservers = new List<IBPMObserver>();
        SoundPlayer player;
        Thread thread;

        public void Initialize()
        {
            try
            {

                string wavFilePath = @"C:\Users\hdholakia\Documents\PREP\design_patterns_bootcamp\clap.wav";
                player = new SoundPlayer(wavFilePath);
                player.Load();
            }
            catch (Exception e)
            {
                Console.WriteLine($"BeatModel.Intialize() :: Caught an exception:{e.Message}");
            }
        }
        public void On()
        {
            bpm = 90;
            NotifyBPMObservers();
            stop = false;
            thread = new Thread(Run);
            thread.Start();
        }
        public void Off()
        {
            StopBeat();
            stop = true;
        }
        public void Run()
        {
            while (!stop)
            {
                PlayBeat();
                NotifyBeatObservers();
                try
                {
                    Thread.Sleep(60000 / bpm);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"BeatModel.Run() :: Caught an exception:{e.Message}");
                }
            }
        }

        public void SetBPM(int bpm)
        {
            this.bpm = bpm;
            NotifyBPMObservers();
        }
        public int GetBPM()
        {
            return bpm;
        }
        public void NotifyBeatObservers()
        {
            foreach (IBeatObserver observer in beatObservers)
            {
                observer.UpdateBeat();
            }
        }
        public void NotifyBPMObservers()
        {
            foreach (IBPMObserver observer in bpmObservers)
            {
                observer.UpdateBPM();
            }
        }
        public void RegisterObserver(IBeatObserver o)
        {
            beatObservers.Add(o);
        }

        public void RegisterObserver(IBPMObserver o)
        {
            bpmObservers.Add(o);
        }
        public void RemoveObserver(IBeatObserver o)
        {
            beatObservers.Remove(o);
        }
        public void RemoveObserver(IBPMObserver o)
        {
            bpmObservers.Remove(o);
        }

        void PlayBeat()
        {
            player.PlaySync();
        }
        void StopBeat()
        {
            player.Stop();
        }
    }
}
