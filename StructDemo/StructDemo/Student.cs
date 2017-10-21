using System;
using System.Collections.Generic;
using System.Text;

namespace StructDemo
{
    struct Student
    {
        public Student(int no)
        {
            No = no;
            Index = "";
        }
        public int No { get; set; } 
        public string Index { get; set; }
    }
}
