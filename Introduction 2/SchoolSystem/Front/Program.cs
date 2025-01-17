using static System.Console;
using Model;
using System.Text;
using DataBase;


IRepository<Student> studentsRepo = null;
IRepository<Teacher> teachersRepo = null;
IRepository<Subject> subjectsRepo = null;
IRepository<Class> classesRepo = null;

studentsRepo = new StudentRepository();
teachersRepo = new TeacherRepository();
subjectsRepo = new SubjectRepository();
classesRepo = new ClassRepository(subjectsRepo, studentsRepo);

while (true)
{
    try
    {
        Clear();
        WriteLine("""
        1 - Cadastrar Professor
        2 - Cadastrar Aluno
        3 - Cadastrar Disciplina
        4 - Cadastrar Turma
        5 - Ver Professores
        6 - Ver Alunos
        7 - Ver Disciplinas
        8 - Ver Turmas
        9 - Sair
        """);

        int option = int.Parse(ReadLine());

        switch (option)
        {
            case 1:
                Teacher newTeacher = new();
                WriteLine("Insert the name of the Teacher:  ");
                newTeacher.Name = ReadLine();
                WriteLine("Insert the graduation of the Teacher:  ");
                newTeacher.Graduated = ReadLine();
                teachersRepo.Add(newTeacher);
                break;
            case 2:
                Student newStudent = new();
                WriteLine("Insert the name of the Student:  ");
                newStudent.Name = ReadLine();
                WriteLine("Insert the age of the Student:  ");
                newStudent.Age = int.Parse(ReadLine());
                studentsRepo.Add(newStudent);
                break;
            case 3:
                Subject newSubject = new();
                WriteLine("Insert the name of the Subject:  ");
                newSubject.Name = ReadLine();
                WriteLine("Insert the name of the Teacher Responsable:  ");
                string teacherName = ReadLine();
                foreach (Teacher teacher in teachersRepo.All)
                {
                    if (teacher.Name == teacherName)
                        newSubject.teacher_id = teacher.UUID;
                }
                subjectsRepo.Add(newSubject);
                break;

            case 4:
                Class newClass = new();
                List<string> classSub = new List<string>();
                List<string> classStu = new List<string>();
               
                    Clear();
                    WriteLine("Insert the name of this class:  ");
                    newClass.Name = ReadLine();

                    WriteLine("Insert the number of the Subject this class have:  ");
                    int numSubject = int.Parse(ReadLine());

                    for (int i = 0; i < numSubject; i++)
                    {
                        WriteLine("Insert the name of the Subject associated with this class:  ");
                        string subjectName = ReadLine();
                        foreach (var subject in subjectsRepo.All)
                        {
                            if (subject.Name == subjectName)
                            {
                                classSub.Add(subject.UUID);
                            }
                        }
                    }

                    WriteLine("Insert the number of the Students this class have:  ");
                    int numStudents = int.Parse(ReadLine());
                    for (int i = 0; i < numStudents; i++)
                    {
                        WriteLine("Insert the name of the Student associated with this class:  ");
                        string studentName = ReadLine();
                        foreach (var student in studentsRepo.All)
                        {
                            if (student.Name == studentName)
                            {
                                classStu.Add(student.UUID);
                            }
                        }
                    }

                        System.Console.WriteLine(classSub);
                        System.Console.WriteLine(classStu);
                        newClass.subjects_id = classSub;
                        newClass.students_id = classStu;
                         System.Console.WriteLine("È o save");
                        classesRepo.Add(newClass);
                 
                   

                

                break;
            case 5:
                var teachers = teachersRepo.All;
                foreach (var teacher in teachers)
                {
                    WriteLine($"""
                {teacher.Graduated} - {teacher.Name}
                ----------------------------------
                """);
                }
                break;
            case 6:
                var students = studentsRepo.All;
                foreach (var student in students)
                {
                    WriteLine($"""
                {student.Age} - {student.Name}
                ----------------------------------
                """);
                }
                break;
            case 7:
                var subjects = subjectsRepo.All;
                var teachersSubject = teachersRepo.All;
                foreach (var subject in subjects)
                {
                    WriteLine($"Subject: {subject.Name}");
                    foreach (var teacher in teachersSubject)
                    {
                        if (subject.teacher_id == teacher.UUID)
                        {
                            WriteLine($"""
                 Teacher: {teacher.Name} 
                 Graduation: {teacher.Graduated} 
                ----------------------------------
                """);
                        }
                    }
                }
                break;

            case 8:


                // var subjectsClass = subjectsRepo.All.ToArray();
                // var studentsClass = studentsRepo.All.ToArray();
                // var teacherClass = teachersRepo.All.ToArray();
                // var classes = classesRepo.All;


                // foreach (var Class in classes)
                // {
                //     WriteLine(Class.Name);
                //     var studentsArray = Class.students_id.ToArray();
                //     var subjectsArray = Class.subjects_id.ToArray();

                //     List<string> studentsPrint = [];
                //     List<string> subjectPrint = [];
                //     List<string> teacherPrint = [];

                //     for (int i = 0; i < studentsClass.Length; i++)
                //     {
                //         for (int j = 0; j < studentsArray.Length; j++)
                //         {
                //             if (studentsClass[i].UUID == studentsArray[j])
                //             {
                //                 studentsPrint.Add(studentsClass[i].Name);
                //             }
                //         }
                //     }

                //     for (int i = 0; i < subjectsClass.Length; i++)
                //     {
                //         for (int j = 0; j < subjectsArray.Length; j++)
                //         {
                //             if (subjectsClass[i].UUID == subjectsArray[j])
                //             {
                //                 subjectPrint.Add(subjectsClass[i].Name);
                //                 foreach (var teacher in teacherClass)
                //                 {
                //                     if (subjectsClass[i].teacher_id == teacher.UUID)
                //                     {
                //                         teacherPrint.Add(teacher.Name);
                //                     }
                //                 }
                //             }
                //         }
                //     }



                //     Clear();
                //     int maxLines = Math.Max(subjectPrint.Count, studentsPrint.Count);
                //     Console.WriteLine("Students".PadRight(20) + "Subjects");
                //     Console.WriteLine(new string('-', 40));

                //     for (int i = 0; i < maxLines; i++)
                //     {
                //         string SubjectsTer = i < subjectPrint.Count ? subjectPrint[i] : "";
                //         string StudentTer = i < studentsPrint.Count ? studentsPrint[i] : "";
                //         string TeacherTer = i < teacherPrint.Count ? teacherPrint[i] : "";
                //         Console.WriteLine(SubjectsTer.PadRight(20) + StudentTer.PadRight(20) + TeacherTer);
                //     }
                // }
                break;
        }



    }
    catch
    {
        WriteLine("Tu fez merda te vira");
    }

    WriteLine("\nAperte qualquer tecla para continuar... ");
    ReadKey(true);
}