using System;
using System.Collections.ObjectModel;

namespace learningProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Collection<Subject> english = new();
            Collection<Subject> maths = new();

            Subject s1 = new();
            Subject s2 = new();
            Subject s3 = new();
            Subject s4 = new();

            s1.Id = 1;
            s1.Name = "Prakash";
            s1.Mark = 53;

            s2.Id = 2;
            s2.Name = "Subash";
            s2.Mark = 55; 
            
            s3.Id = 3;
            s3.Name = "Prakash";
            s3.Mark = 60;

            s4.Id = 4;
            s4.Name = "Malinga";
            s4.Mark = 59;

            english.Add(s1);
            english.Add(s2);

            maths.Add(s3);
            maths.Add(s4);

            foreach (var s in english)
            {
                foreach (var ms in maths)
                {
                    if (s.Name == ms.Name)
                    {
                        if (s.Mark > 50 && ms.Mark > 50)
                        {
                            Console.WriteLine(s.Name);
                        }
                    }
                }
            }
        }

        public class Subject
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Mark { get; set; }
        }

    }
}