using System;
using System.Collections.Generic;
using System.Text;

namespace Interfejsy
{
    public class Student : Human
    {
        public Student(string firstName)
        {
            FirstName = firstName;
            StudentLib.StudentLogic.EnrolStudent();
        }

        //private string _firstName;
        public string FirstName { get; private set; }

        public void DoWork()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{FirstName}";
        }
    }
}
