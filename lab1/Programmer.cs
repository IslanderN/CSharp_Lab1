using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum ProgrammerLevel
{
    Junior,
    Middle,
    Senior
}


namespace lab1
{
    abstract class Programmer
    {
        protected Project project;
        public ProgrammerLevel level;

        public abstract void Develop();
        public abstract void Test();
        public abstract void Fix();
        public abstract void Support();

        public virtual Project GetProject()
        {
            return project;
        }
   

    }
}
