using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class ProjectManager
    {
 
        public Project CreateProject(Programmer programmer)
        {
            programmer.Develop();
            programmer.Test();
            programmer.Fix();
            programmer.Support();

            return programmer.GetProject() ;
        }
    }
}
