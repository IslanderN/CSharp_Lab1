using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class WebProgrammer : Programmer
    {
        public WebProgrammer()
        {
            project = new Project("Web Application");
        }

        public override void Develop()
        {
            project.Development("Web application has been developed");
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
