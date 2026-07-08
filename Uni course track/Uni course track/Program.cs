using Uni_course_track;

public class Program
{
    static void Main()
    {
        Course MathematicsCourse = new Course("Mathematics");
        Course EnglishLitCourse = new Course("English Literature");

        Module Algebra = new Module("Algebra 1", Module.Year.FirstYear);
        Module Calculus = new Module("Calculus", Module.Year.SecondYear);
        Module Complex_nums = new Module("Lincear Algebra and Complex Numbers", Module.Year.ThirdYear);
        MathematicsCourse.AddModule(Algebra);
        MathematicsCourse.AddModule(Calculus);
        MathematicsCourse.AddModule(Complex_nums);

        Module ARH5009MX = new Module("Politics of Renaissance Art", Module.Year.SecondYear);
        Module ENG5005 = new Module("Professional Writing for Different Media", Module.Year.SecondYear);
        EnglishLitCourse.AddModule(ENG5005);
        EnglishLitCourse.AddModule(ARH5009MX);


        Student Maths_student = new Student("Bob", 1, MathematicsCourse);
        Student English_student = new Student("Dave", 2, EnglishLitCourse);

        Maths_student.AddModule(ENG5005);
        Maths_student.AddModule(Algebra);
        Maths_student.AddModule(Calculus);

        English_student.AddModule(ENG5005);
        English_student.AddModule(ARH5009MX);

        MathematicsCourse.ListModules();
        EnglishLitCourse.ListModules();

    }
}
