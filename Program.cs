using System;
using System.Collections.Generic;
using System.Linq;

namespace linq_study
{
    class Program
    {
        const int LIMIT_UP = 17;
        const int LIMIT_DOWN = 0;
        static void Main(string[] args)
        {
            #region MENU
            int choose = 1;
            do
            {
                Console.Clear();
                Console.WriteLine("-------------LINQ STUDY-------------");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Foreach");
                Console.WriteLine("2. Exists");
                Console.WriteLine("3. Find");
                Console.WriteLine("4. FindAll");
                Console.WriteLine("5. FindIndex");
                Console.WriteLine("6. FindLast");
                Console.WriteLine("7. FindLastIndex");
                Console.WriteLine("8. RemoveAll");
                Console.WriteLine("9. TrueForAll");
                Console.WriteLine("10. Select");
                Console.WriteLine("11. Where");
                Console.WriteLine("12. OrderBy");
                Console.WriteLine("13. All");
                Console.WriteLine("14. Any");
                Console.WriteLine("15. Max,min");
                Console.WriteLine("16. OfType");
                Console.WriteLine("17. FirstOrDefault");
                Console.WriteLine("------------------------------------");

                #region INPUT
                bool checkInput = false;
                do
                {
                    Console.Write("\n\nPlease input your choose: ");
                    string dataInput = Console.ReadLine();
                    if (int.TryParse(dataInput, out choose) && choose >= LIMIT_DOWN && choose <= LIMIT_UP)
                    {
                        checkInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Nhap sai roi con duy~, nhap lai di.");
                    }
                } while (!checkInput);
                #endregion

                if(choose == 1)
                {
                    Console.Clear();
                    LinqForeach();
                    Console.ReadKey();
                }

                if(choose == 2)
                {
                    Console.Clear();
                    LinqExists();
                    Console.ReadKey();
                }

                if (choose == 3)
                {
                    Console.Clear();
                    LinqFind();
                    Console.ReadKey();
                }

                if (choose == 4)
                {
                    Console.Clear();
                    LinqFindAll();
                    Console.ReadKey();
                }

                if (choose == 5)
                {
                    Console.Clear();
                    LinqFindIndex();
                    Console.ReadKey();
                }

                if (choose == 6)
                {
                    Console.Clear();
                    LinqFindLast();
                    Console.ReadKey();
                }

                if (choose == 7)
                {
                    Console.Clear();
                    LinqFindLastIndex();
                    Console.ReadKey();
                }

                if (choose == 8)
                {
                    Console.Clear();
                    LinqRemoveAll();
                    Console.ReadKey();
                }

                if (choose == 9)
                {
                    Console.Clear();
                    LinqTrueForAll();
                    Console.ReadKey();
                }

                if (choose == 10)
                {
                    Console.Clear();
                    LinqSelect();
                    Console.ReadKey();
                }

                if (choose == 11)
                {
                    Console.Clear();
                    LinqWhere();
                    Console.ReadKey();
                }

                if (choose == 12)
                {
                    Console.Clear();
                    LinqOrderBy();
                    Console.ReadKey();
                }

                if (choose == 13)
                {
                    Console.Clear();
                    LinqAll();
                    Console.ReadKey();
                }

                if (choose == 14)
                {
                    Console.Clear();
                    LinqAny();
                    Console.ReadKey();
                }

                if (choose == 15)
                {
                    Console.Clear();
                    LinqMinMax();
                    Console.ReadKey();
                }

                if (choose == 16)
                {
                    Console.Clear();
                    LinqOfType();
                    Console.ReadKey();
                }

                if (choose == 17)
                {
                    Console.Clear();
                    LinqFirstOrDefault();
                    Console.ReadKey();
                }
            } while (choose != 0);
            #endregion
        }

        #region DATA
        static List<Student> LoadData()
        {
            List<Student> studentList = new List<Student>();
            studentList.Add(new Student("Alice", 18, 9.5));
            studentList.Add(new Student("Bell", 18, 8.5));
            studentList.Add(new Student("Colin", 22, 7.0));
            studentList.Add(new Student("Dik", 20, 9.8));
            studentList.Add(new Student("Elenon", 19, 10));
            studentList.Add(new Student("Fazy", 14, 6.0));
            studentList.Add(new Student("Jun", 15, 4.0));
            return studentList;
        }
        #endregion

        #region LINQ_METHOD
        static void LinqForeach()
        {
            Console.WriteLine("+++Foreach+++");
            Console.WriteLine("- Browse each element in the array from head to tail.");
            Console.WriteLine("- At a time, it only excutes one element.");
            Console.WriteLine("- It's not possible to change the value of the element because its value has been copied to temporary variable.");
            Console.WriteLine("- Example: Use exits to check student list has student reached 10 point or not.");
            Console.WriteLine("- Output example:");
            List<Student> studentList = new List<Student>(LoadData());
            //foreach (Student student in studentList)
            //{
            //    student.StudentInfo();
            //}
            studentList.ForEach(student => student.StudentInfo());
        }

        static void LinqExists()
        {
            Console.WriteLine("+++Foreach+++");
            Console.WriteLine("- Check the existence of the object to look for.");
            Console.WriteLine("- Example: Use exits to check student list has student reached 10 point or not.");
            Console.WriteLine("- Output example:");
            List<Student> studentList = new List<Student>(LoadData());
            bool result = studentList.Exists(student => student.Point == 10);
            if (result)
            {
                Console.WriteLine(">> The student list has exited the student reached 10 point.");
            }
            else
            {
                Console.WriteLine(">> The student list has NOT exited the student reached 10 point.");
            }
        }

        static void LinqFind()
        {
            Console.WriteLine("+++Find+++");
            Console.WriteLine("- Find and return the element in list.");
            Console.WriteLine("- Example: Use find to find the student reached 10 point.");
            Console.WriteLine("- Output example:");
            List<Student> studentList = new List<Student>(LoadData());
            var result = studentList.Find(student => student.Point == 10);
            result.StudentInfo();
        }

        static void LinqFindAll()
        {
            Console.WriteLine("+++FindAll+++");
            Console.WriteLine("- Find and return all the elements satisfy the condition.");
            Console.WriteLine("- Example: Use FindAll to find all the student under 18 years old.");
            Console.WriteLine("- Output example:");
            List<Student> studentList = new List<Student>(LoadData());
            var result = studentList.FindAll(student => student.Age < 18).ToArray();
            foreach (Student temp in result)
            {
                temp.StudentInfo();
            }
        }

        static void LinqFindIndex()
        {
            Console.WriteLine("+++FindIndex+++");
            Console.WriteLine("- Search and return the index of the element satified the condition.");
            Console.WriteLine("- Example: Use FindIndex to find the index of student reached 10 point.");
            Console.WriteLine("- Output example:");
            List<Student> studentList = new List<Student>(LoadData());
            int result = studentList.FindIndex(student => student.Point == 10);
            Console.WriteLine(result);
        }

        static void LinqFindLast()
        {
            Console.WriteLine("+++FindLast+++");
            Console.WriteLine("- Search and return the last element matched the condition.");
            Console.WriteLine("- Example: Use FindLast to find the student which equals 18 years old.");
            Console.WriteLine("- Output example:");
            List<Student> studentList = new List<Student>(LoadData());
            Student result = studentList.FindLast(student => student.Age == 18);
            result.StudentInfo();
        }

        static void LinqFindLastIndex()
        {
            Console.WriteLine("+++FindLastIndex+++");
            Console.WriteLine("- Search and return the index of the last element matched the condition.");
            Console.WriteLine("- Example: Use FindLastIndex to find the index of the student which equals 18 years old.");
            Console.WriteLine("- Output example:");
            List<Student> studentList = new List<Student>(LoadData());
            int result = studentList.FindLastIndex(student => student.Age == 18);
            Console.WriteLine(result);
        }

        static void LinqRemoveAll()
        {
            Console.WriteLine("+++RemoveAll+++");
            Console.WriteLine("- Remove all elements matched the condition.");
            Console.WriteLine("- Example: Use RemoveAll to remove the student which equals 18 years old.");
            Console.WriteLine("- Output example:");
            List<Student> studentList = new List<Student>(LoadData());
            studentList.RemoveAll(student => student.Age == 18);
            studentList.ForEach(student => student.StudentInfo());
        }

        static void LinqTrueForAll()
        {
            Console.WriteLine("+++TrueForAll+++");
            Console.WriteLine("- Check all the elements matched the condition or not.");
            Console.WriteLine("- Example: Use TrueForAll to check the student list with condition that point is bigger than 5.");
            Console.WriteLine("- Output example:");
            List<Student> studentList = new List<Student>(LoadData());
            bool result = studentList.TrueForAll(student => student.Point > 5);
            Console.WriteLine(result);
        }

        static void LinqSelect()
        {
            Console.WriteLine("+++Select+++");
            Console.WriteLine("- Output is value of the query clause.");
            Console.WriteLine("- Example: Use select to create new list.");
            Console.WriteLine("- Output example:");
            List<Student> studentList = new List<Student>(LoadData());
            var results = studentList.Select(student => new Student(student.Name, student.Age, student.Point)).ToList();
            results.ForEach(student => student.StudentInfo());
        }

        static void LinqWhere()
        {
            Console.WriteLine("+++Where+++");
            Console.WriteLine("- Use to filter the list.");
            Console.WriteLine("- Example: Use where to show the sutdent whose point is smaller than 8.");
            Console.WriteLine("- Output example:");
            List<Student> studentList = new List<Student>(LoadData());
            var results = studentList.Where(student => student.Point < 8).ToList();
            results.ForEach(student => student.StudentInfo());
        }

        static void LinqOrderBy()
        {
            Console.WriteLine("+++OrderBy+++");
            Console.WriteLine("- Sort the list.");
            Console.WriteLine("- Example: Use OrderBy to sort the list by point.");
            Console.WriteLine("- Output example:");
            List<Student> studentList = new List<Student>(LoadData());
            var results = studentList.OrderBy(student => student.Point).ToList();
            results.ForEach(student => student.StudentInfo());
        }

        static void LinqAll()
        {
            Console.WriteLine("+++All+++");
            Console.WriteLine("- Check all the elements matched the condition or not.");
            Console.WriteLine("- Example: Use All to check the list which students's point is bigger than 5 or not.");
            Console.WriteLine("- Output example:");
            List<Student> studentList = new List<Student>(LoadData());
            bool result = studentList.All(student => student.Point > 5);
            Console.WriteLine(result);
        }

        static void LinqAny()
        {
            Console.WriteLine("+++All+++");
            Console.WriteLine("- Return true if any element meet the condition.");
            Console.WriteLine("- Example: Use Any to check the list if any student's point is smaller than 5.");
            Console.WriteLine("- Output example:");
            List<Student> studentList = new List<Student>(LoadData());
            bool result = studentList.Any(student => student.Point < 5);
            Console.WriteLine(result);
        }

        static void LinqMinMax()
        {
            Console.WriteLine("+++Min/Max+++");
            Console.WriteLine("- Return the min/max of value as the condition.");
            Console.WriteLine("- Example: Use Min/Max to find the age of the youngest student.");
            Console.WriteLine("- Output example:");
            List<Student> studentList = new List<Student>(LoadData());
            var result = studentList.Min(Student => Student.Age);
            Console.WriteLine(result);
        }

        static void LinqOfType()
        {
            Console.WriteLine("+++OfType+++");
            Console.WriteLine("- Return the element base on the datatype.");
            Console.WriteLine("- Example: Use OfType to return the student list.");
            Console.WriteLine("- Output example:");
            List<Student> studentList = new List<Student>(LoadData());
            var results = studentList.OfType<Student>().ToList();
            results.ForEach(student => student.StudentInfo());
        }

        static void LinqFirstOrDefault()
        {
            Console.WriteLine("+++FirstOrDefault+++");
            Console.WriteLine("- Return the first element met the condition.");
            Console.WriteLine("- Example: Use FirstOrDefault to return the first student whose age bigger than 18.");
            Console.WriteLine("- Output example:");
            List<Student> studentList = new List<Student>(LoadData());
            var result = studentList.FirstOrDefault(student => student.Age > 18);
            result.StudentInfo();
        }
        #endregion
    }

    #region Class_Demo
    public class Student
    {
        private string name;
        private int age;
        private double point;
        
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public double Point { get => point; set => point = value; }

        public Student() { }

        public Student(string name, int age, double point)
        {
            this.name = name;
            this.age = age;
            this.point = point;
        }

        public void StudentInfo()
        {
            Console.WriteLine("\t- Name: {0}\tAge: {1}\tPoint: {2}", this.name, this.age, this.point);
        }
    }
    #endregion
}
