using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Final_Project
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GroupId { get; set; }
        public List<LevelMark> EnglishLevels { get; set; }
        public double LastestMark { get; set; }

    }


}
