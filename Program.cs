using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C__List
{
    internal class Program
    {
        struct Person
        {
            public string Name;
            public int Age;
            public float Grade;

            public Person(string name, int age,float grade)
            {
                this.Name = name;
                this.Age = age;
                this.Grade = grade;
                
            }
        }

        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public double Grade { get; set; }
            public string Department { get; set; }

            //public Student(int id,string name,int age ,double grade ,string department)
            //{
            //    this.Id = id;
            //    this.Name= name;
            //    this.Age = age;
            //    this.Grade = grade;
            //    this.Department = department;


            //}


            public override string ToString()
            {
                return $"Name :{this.Name} ,Age :{this.Age} ,Grade :{this.Grade}, Department :{this.Department}";
            }
        }

        static void Main(string[] args)
        {
            //int[] numbersArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            //List<int> numbersList= numbersArray.ToList();
            //Console.WriteLine("An List From An Array");
            //numbersList.ForEach(S => { Console.WriteLine(S.ToString()); });





            var departments = new List<(string Dept, string Head)>
             {
                 ("CS", "Dr. Ahmed"),
                 ("Math", "Dr. Samir")
             };

            List<Student> Students = new List<Student>
                                    {
                                     new Student { Id = 1, Name = "Ali", Age = 20, Grade = 88.5, Department = "CS" },
                                     new Student { Id = 2, Name = "Sara", Age = 22, Grade = 91.2, Department = "Math" },
                                     new Student { Id = 3, Name = "John", Age = 19, Grade = 73.4, Department = "CS" },
                                     new Student { Id = 4, Name = "Mary", Age = 21, Grade = 85.0, Department = "Physics" },
                                     new Student { Id = 5, Name = "Omar", Age = 20, Grade = 95.2, Department = "Math" },
                                     new Student { Id = 6, Name = "Lina", Age = 23, Grade = 68.3, Department = "CS" },
                                     new Student { Id = 7, Name = "Adam", Age = 22, Grade = 79.9, Department = "Math" },
                                     new Student { Id = 8, Name = "Zain", Age = 18, Grade = 92.1, Department = "CS" },
                                    };








           Hashtable hashtable = new Hashtable();

            hashtable.Add("Key1", Students.Find(n=>n.Name==  "Adam"));//Here We Are Boxing Student Adam 'Value' And Giving It A Unique Key 'Adam';
            hashtable.Add("Key2", Students.Find(n => n.Name == "Sara"));//Here We Are Boxing Student Adam 'Value' And Giving It A Unique Key 'Adam';
            hashtable.Add("Key3", Students.Find(n => n.Name == "Ali"));

            Console.WriteLine($"Accesing Key2 Element :{hashtable["Key2"].ToString()}");

            hashtable.Remove("Key2");
            bool DoesKey2Exists = hashtable.Contains("Key2");

            if (DoesKey2Exists)
                Console.WriteLine("Yes Key2 Is Exists");

            Console.WriteLine("Sara Is Removed And Adam's Grade Updated\n Print All Elemnts With There Keys");
            Students.Find(n => n.Name == "Adam").Grade = 100;
            //hashtable["Key1"] = (Students.Find(n => n.Name == "Adam"));

            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine($"Key :{entry.Key} ,Value :{entry.Value.ToString()}");
            }




            //var IsThereAnyHighestGradeInHisDepartemnt = Students.GroupBy(s=>s.Department);



            //Student student = Students.Find(S=>S.Name.StartsWith("S"));

            //if(student != null)
            //{
            //    Console.WriteLine($"Person Is Found \n{student.ToString()}");
            //}

            //Students.Remove(student);

            //Students.ForEach(s=>Console.WriteLine(s.ToString()));




            //Student[] MyStudents=Students.ToArray();


            //Console.WriteLine("Printed With Array");

            //foreach(var v in MyStudents)
            //{
            //    if (v == null)
            //        return;

            //    Console.WriteLine(v.ToString());
            //}


            //List<Student> MyNewsStudents = MyStudents.ToList();

            //Console.WriteLine("After An Array Converted To List");
            //MyNewsStudents.ForEach(S => { Console.WriteLine(S.ToString()); });




            //var IsThereAStudent=Students.Any(S=> (S.Name[0] == S.Name[S.Name.Length-1])&&S.Grade>90&&departments.Exists(d=>d.Dept==S.Department));

            //Console.WriteLine("Is There  Students \n" +
            //    "Their name starts and ends with the same letter\n" +
            //    "Their grade is above 90\n" +
            //    "Their department exists in departments list \n" +
            //    $"Result :{IsThereAStudent}");


            //var MyStudent = Students.Find(n=>n.Age<22 && n.Grade>Students.Average(k=>k.Grade) && n.Department=="CS");

            //Console.WriteLine($"Students Avg Grade :{Students.Average(k=>k.Grade)}");
            //Console.WriteLine($"Name :{MyStudent.Name} ,Age :{MyStudent.Age} ,Dep :{MyStudent.Department},Grade :{MyStudent.Grade}");




            // var Deps = Students.FindAll(n=>n.Department);


            //Console.WriteLine("unique departments that have at least two students aged 20 or older :");

            //foreach (var i in Deps)
            //{
            //    Console.WriteLine($"Department Name :{i.Key}");
            //}









            //List<string> words = new List<string> { "apple", "banana", "cherry", "date", "elderberry", "fig", "grape", "honeydew" };

            //Console.WriteLine($"Words List : {string.Join(", ", words)}");


            //bool ContainsApple = words.Contains("apple");
            //Console.WriteLine($"List contains 'apple': {ContainsApple}" );

            //bool ContainsLength5 = words.Exists(W=>W.Length==5);
            //Console.WriteLine($"List contains Word Of Length 5: {ContainsLength5}");


            //Console.WriteLine($"First Word Longer Than Five Charecters : {words.Find(w=>w.Length>5)}");
            //Console.WriteLine($"Words Longer Than Five Charecters : {string.Join(",", words.FindAll(w => w.Length > 5))}");


            //Console.WriteLine($"Any Word Starting With 'a' : {words.Any(w => w.StartsWith("a"))}");
            //Console.WriteLine($"Any Word Ending With 'z' : {words.Any(w => w.EndsWith("z"))}");

























            //var GroupedByDep = Students.GroupBy(n => n.Department);


            //Console.WriteLine("Students Info By Departments:");

            //foreach (var groupe in GroupedByDep)
            //{
            //    Console.WriteLine("______________________________________________________________");
            //    Console.WriteLine($"{groupe.Key} --> Count :{groupe.Count()},Avg :{groupe.Average(n=>n.Grade)},Max :{groupe.Max(n=>n.Grade)},Min :{groupe.Min(n=>n.Grade)}");
            //    Console.WriteLine("______________________________________________________________\n");
            //}


            //var groupedByAgeRanges = Students.GroupBy(n=>n.Age>=18 && n.Age<=20 );


            //Console.WriteLine("Students Info By Age Range 18-20:");

            //foreach (var groupe in groupedByAgeRanges)
            //{
            //    Console.WriteLine("______________________________________________________________");
            //    groupe.ToList().ForEach(n => { Console.WriteLine($"Name : {n.Name} ,Age : {n.Age}"); });
            //    Console.WriteLine("______________________________________________________________\n");
            //}





























            //var csStudents = Students.Where(n=>n.Department=="CS").ToList();

            //Console.WriteLine("Computer Science Students:");
            //csStudents.ForEach(n => { Console.WriteLine($"Name : {n.Name} ,Dep : {n.Department}"); });


            //var sortedByGrade = Students.OrderByDescending(s => s.Grade).ToList();

            //Console.WriteLine("Students Sorted By Grades Desc:");
            //sortedByGrade.ForEach(n => { Console.WriteLine($"Name : {n.Name} ,Dep : {n.Department}, Grade :{n.Grade}"); });


            //var names = Students.Select(s=>s.Department);

            //Console.WriteLine("Selected Names :");

            //foreach (var name in names)
            //{
            //    Console.WriteLine("Name :"+name);
            //}


            //var avgGrade=Students.Average(s => s.Grade);

            //Console.WriteLine($"Average Grade :{avgGrade}");

            //var sumGrades = Students.Sum(s => s.Grade);

            //Console.WriteLine($"Grades Sum :{sumGrades}");

            //var MinGrade = Students.Min(s => s.Grade);

            //Console.WriteLine($"Min Grade :{MinGrade}");

            //var MaxGrade = Students.Max(s => s.Grade);

            //Console.WriteLine($"Max Grade :{MaxGrade}");


            //var firstMathStudent=Students.FirstOrDefault(n=>n.Department=="Math");

            //Console.WriteLine("First Math Student:");
            //Console.WriteLine($"Name : {firstMathStudent.Name} ,Dep : {firstMathStudent.Department}, Grade :{firstMathStudent.Grade}");




            //var SomeSortedStudents = Students.OrderByDescending(s => s.Grade).Take(3).ToList();

            //Console.WriteLine("Some Students Sorted By Grades Desc:");
            //SomeSortedStudents.ForEach(n => { Console.WriteLine($"Name : {n.Name} ,Dep : {n.Department}, Grade :{n.Grade}"); });


            //var SomeSortedStudents2 = Students.OrderByDescending(s => s.Grade).Skip(3).ToList();

            //Console.WriteLine("Some Students Sorted By Grades Desc:");
            //SomeSortedStudents2.ForEach(n => { Console.WriteLine($"Name : {n.Name} ,Dep : {n.Department}, Grade :{n.Grade}"); });



            //var HasLowGrade = Students.Any(n => n.Grade<=80);

            //Console.WriteLine($"Is There Any Student Of Grade Less Then Or Equals To 80:{HasLowGrade}");

            //var UniqueDepartments = Students.Select(p=>p.Department).Distinct();


            //Console.WriteLine("Unique Departments :");

            //foreach (var DepName in UniqueDepartments)
            //{
            //    Console.WriteLine("Dep Name :" + DepName);
            //}



            //var joined = Students.Join(departments, s => s.Department, d => d.Dept, (student, Dep) => new { student.Department, Dep.Head });

            //foreach (var item in joined)
            //{
            //    Console.WriteLine($"Dep Name: {item.Department} ,Dep Head: {item.Head}");
            //}





















            //List<int> Numbers = new List<int> { 44, 22, -55, 666, 9, -6, 345, 11, 3, 3 };

            ////FindAll,Find,Any,Exists,Contains

            //Console.WriteLine($"List Items :{string.Join(",",Numbers)}");
            //Console.WriteLine($"Does List Contains 9 :{Numbers.Contains(9)}");
            //Console.WriteLine($"Does List Contains 100 :{Numbers.Contains(100)}");
            //Console.WriteLine($"Does Negative Numbers Exists In The List :{Numbers.Exists(n=>n<0)}");
            //Console.WriteLine($"Does Positive Numbers Exists In The List :{Numbers.Exists(n => n > 0)}");
            //Console.WriteLine($"First Negative Number :{Numbers.Find(n => n < 0)}");
            //Console.WriteLine($"First Positive Number :{Numbers.Find(n => n > 0)}");
            //Console.WriteLine($"Find All Negative Numbers :{string.Join(", ", Numbers.FindAll(n => n < 0))}");
            //Console.WriteLine($"Find All Positive Numbers :{string.Join(", ", Numbers.FindAll(n => n > 0))}");
            //Console.WriteLine($"Is There Any Zero :{Numbers.Any(n=>n==0)}");
            //Console.WriteLine($"Is There Any Negative Number :{Numbers.Any(n => n < 0)}");
            //Console.WriteLine($"Is There Any Positive Number :{Numbers.Any(n => n > 0)}");



























            //Console.WriteLine($"Even Numbers :{string.Join(", ", Numbers.Where(n => n % 2 == 0))}");
            //Console.WriteLine($"Odd Numbers :{string.Join(", ", Numbers.Where(n => n % 2 != 0))}");
            //Console.WriteLine($"Numbers Greater Than 5 :{string.Join(", ", Numbers.Where(n => n > 5 ))}");
            //Console.WriteLine($"Every Second Number :{string.Join(", ", Numbers.Where((n, index) => index%2==1))}");
            //Console.WriteLine($"Numbers Between 3 And 8 :{string.Join(", ", Numbers.Where(n => n > 3 && n<8))}");


            //Numbers.Sort();
            //Console.WriteLine("Sort Numbers Asc");
            //Numbers.ForEach((n) => { Console.WriteLine($"{n}"); });

            //Numbers.Reverse();
            //Console.WriteLine("Sort Numbers Desc");
            //Numbers.ForEach((n) => { Console.WriteLine($"{n}"); });


            //Console.WriteLine($"Sorted Ascending  With Linq : {string.Join("\n",Numbers.OrderBy(n=>n))}");
            //Console.WriteLine($"Sorted Descending With Linq : {string.Join("\n", Numbers.OrderByDescending(n => n))}");

            //Numbers.Sort((a, b) => Math.Abs(a).CompareTo(Math.Abs(b)));
            //Console.WriteLine("Sorted by Absolute Values: " + string.Join(", ", Numbers));



            //Numbers.Remove(5);
            //Console.WriteLine("After Removing 5 : "+string.Join(", ",Numbers));



            //Numbers.RemoveAt(0);
            //Console.WriteLine("After Removing First Item :" + string.Join(", ", Numbers));



            //Numbers.RemoveAll(n=>n%2==0);
            //Console.WriteLine("After Removing Even Numbers :" + string.Join(", ", Numbers));



            //Numbers.RemoveRange(0,2);
            //Console.WriteLine("After Removing Item 1 To 2 :" + string.Join(", ", Numbers));


            //Numbers.Clear();
            //Console.WriteLine("Numbers Count After Clearing :" +Numbers.Count);





            //Numbers.Add(1);
            //Numbers.Add(2);
            //Numbers.Add(3);
            //Numbers.Add(4);
            //Numbers.Add(5);

            //Console.WriteLine("Number Of Items In The List :"+Numbers.Count);

            //Console.WriteLine(Numbers[0]);
            //Console.WriteLine(Numbers[1]);
            //Console.WriteLine(Numbers[2]);
            //Console.WriteLine(Numbers[3]);
            //Console.WriteLine(Numbers[4]);

            //Numbers[1] = 500;

            //Console.WriteLine("Changing The Value Of Item 2 Of The List To 500");
            //Console.WriteLine(Numbers[1]);

            //Random rnd = new Random();

            //for(int i=0;i<=10;i++)
            //{
            //    Numbers.Add(rnd.Next(1,100));
            //}


            //Numbers.ForEach
            //    (
            //    i=>
            //    {
            //        if (i % 2 == 0)
            //            Console.WriteLine(i + " Is An Even Number");
            //        else
            //            Console.WriteLine(i + "Is An Odd Number");
            //    }
            //    );





        }
    }
}
