using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            ProjectManager pm = new ProjectManager();

            //Create web application
            WebProgrammer webProgrammer = new WebProgrammer();
            Project webApplication = pm.CreateProject(webProgrammer);
            Console.WriteLine(webApplication.ToString());

            //Create calculator
            DesktopProgrammer desktopProgrammer = new DesktopProgrammer();
            Project calculator = pm.CreateProject(desktopProgrammer);
            Console.WriteLine(calculator.ToString());

            Console.ReadKey();

        }
    }
}
