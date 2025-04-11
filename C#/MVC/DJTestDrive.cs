using MVC.Controller;
using MVC.Model;

namespace MVC
{
    internal class DJTestDrive
    {
        static void Main(string[] args)
        {
            IBeatModelInterface model = new BeatModel();
            IController controller = new BeatController(model);
        }
    }
}
