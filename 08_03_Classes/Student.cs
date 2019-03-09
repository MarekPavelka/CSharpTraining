using System;

namespace _08_03_Classes
{
    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        int year;

        public Student(string name, string surname, int year)
        {
            Name = name;
            Surname = surname;
            this.year = year;
        }

        public void SayHi()
        {
            Console.WriteLine("Som {0} {1} a studujem v {2}. rocniku", Name, Surname, year);
        }

        public string GetRating(int rating)
        {
            if (rating < 1 || rating > 5)
            {
                return "Tuto znamku nepoznam";
            }

            if (year > 1)
            {
                if (rating < 5)
                {
                    return "Hlavne ze to neni patorka!";
                }
                else
                {
                    return "Nic moc, ale snad to bude lepsie";
                }
            }
            else
            {
                return "Zatial som prvak, este sa rozkukavam";
            }
        }
    }
}
