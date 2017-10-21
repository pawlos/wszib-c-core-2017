using System;
using System.Collections.Generic;
using System.Text;

namespace Interfejsy
{
    class Student : IStudent, IHuman
    {
        public Student(string firstName)
        {
            FirstName = firstName;
        }

        //private string _firstName;
        public string FirstName { get; private set; }

        public void DoWork()
        {
            throw new NotImplementedException();
        }

        void IHuman.Breath()
        {
            throw new NotImplementedException();
        }
    }
}
