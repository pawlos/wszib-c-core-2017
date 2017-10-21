using System;
using System.Collections.Generic;
using System.Text;

namespace Interfejsy
{
    public class FullTimeStudent : Human
    {
        public FullTimeStudent(string firstName)
        {
            FirstName = firstName;
        }

        //private string _firstName;
        public string FirstName { get; private set; }

        public void DoWork()
        {
            throw new NotImplementedException();
        }

        //public override string ToString()
        //{
        //    return $"{FirstName}";
        //}
    }
}
