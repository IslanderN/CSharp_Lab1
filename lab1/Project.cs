using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Project
    {
        private string name;

        private string development;
        private string test;
        private string fix;
        private string support;

        public Project(string name)
        {
            this.name = name;
        }

        public void Development(string development)
        {
            this.development = development;
        }

        public void Test(string test)
        {
            this.test = test;
        }

        public void Fix(string fix)
        {
            this.fix = fix;
        }

        public void Support(string support)
        {
            this.support = support;
        }

        public override string ToString()
        {
            string result = "Project: " + name + "\nDevelopment: " + development + "\nTest: " + test + "\nFix: " + fix + "\nSupport: " + support + "\n";
            return result;
        }
    }
}
