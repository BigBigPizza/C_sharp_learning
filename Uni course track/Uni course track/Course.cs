using System;
using System.Collections.Generic;
using System.Text;

namespace Uni_course_track
{
    internal class Course
    {
        public string CourseName { get; }
        public Course(string courseName)
        {
            CourseName = courseName;

            Module Orientation = new Module("Student orientations", Module.Year.FirstYear); // All courses have student orientation module by default
            AddModule(Orientation);
        }

        public Dictionary<string, int> ModuleList = new Dictionary<string, int>();
        public void AddModule(Module module)
        {
            if (!Contains(module))
            {
                string ModuleName = module.ModuleName;
                int ModuleYear = (int)module.ModuleYear;
                ModuleList.Add(ModuleName, ModuleYear);
            }
        }

        public bool Contains(Module module)
        {
            if (ModuleList.ContainsKey(module.ModuleName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void RemoveModule(Module module)
        {
            if (Contains(module))
            {
                ModuleList.Remove(module.ModuleName);
            }
        }
        public void ListModules()
        {
            Console.WriteLine($"{CourseName} contains these modules:\n");
            foreach(var pair in ModuleList)
            {
                Console.WriteLine("- Name: " + pair.Key + "\t Year: " + pair.Value);
            }
        }
    }
}
