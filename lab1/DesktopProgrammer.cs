using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class DesktopProgrammer : Programmer
    {
        public DesktopProgrammer()
        {
            project = new Project("Calculator");
        }

        public override void Develop()
        {
            project.Development("Calculator has been developed");
        }

        public override void Test()
        {
            project.Test("Tested");
        }

        public override void Fix()
        {
            project.Fix("Fixed");
        }

        public override void Support()
        {
            project.Support("Start supporting...");
        }
    }
}
