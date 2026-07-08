using System;
using System.Collections.Generic;
using System.Text;

namespace Uni_course_track
{
    internal class Module
    {
        public string ModuleName { get; }
        public enum Year
        {
            FirstYear = 1,
            SecondYear = 2,
            ThirdYear = 3
        }
        public Year ModuleYear { get; }

        public Module(string name, Year year)
        {
            ModuleName = name;
            ModuleYear = year;
        }

    }
}
