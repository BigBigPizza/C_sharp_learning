using System;
using System.Collections.Generic;
using System.Text;

namespace Uni_course_track
{
    internal class Student
    {
        public string StudentName { get; }
        public int StudentCurrentYear { get; set; }
        public Course StudentCourse { get; }
        public Student(string studentName, int studentYear, Course studentCourse)
        {
            StudentName = studentName;
            StudentCurrentYear = studentYear;
            StudentCourse = studentCourse;
        }

        List<Module> StudentModules = new List<Module>();
        public void AddModule(Module module)
        {
            string NameOfModule = module.ModuleName;
            if (!StudentCourse.Contains(module))
            {
                Console.WriteLine($"{StudentName}'s course of {StudentCourse.CourseName} does not contain the module {NameOfModule} and could not be enrolled");
            }
            else if (StudentModules.Contains(module))
            {
                Console.WriteLine($"{StudentName} is already enrolled in the {NameOfModule} module and could not be enrolled.");
            }
            else if ((int)module.ModuleYear != StudentCurrentYear)
            {
                Console.WriteLine($"{StudentName} could not be enrolled in the {NameOfModule} module as this is a year {(int)module.ModuleYear} module and {StudentName} is in year {StudentCurrentYear}");
            }
            else
            {
                Console.WriteLine($"{StudentName} was enrolled on the {module.ModuleName} module under their {StudentCourse.CourseName} course.");
                StudentModules.Add(module);
            }
        }
        public void RemoveModule(Module module)
        {
            if (StudentModules.Contains(module))
            {
                StudentModules.Remove(module);
            }
            else
            {
                Console.WriteLine($"{StudentName} is not current enrolled in {module.ModuleName} and can not be removed from it.");
            }
        }
        public void ProgressOneYear()
        {
            if (StudentCurrentYear < 3)
            {
                StudentCurrentYear++;
                Console.WriteLine($"{StudentName} is now in year {StudentCurrentYear}");
            }
            else
            {
                Console.WriteLine($"{StudentName} is in year {StudentCurrentYear} and can not progress to modules beyond {StudentCurrentYear}");
            }
        }
    }
}
