using System;
using System.Collections.Generic;
using System.Text;

namespace Interfejsy
{
    public interface IStudent
    {
        void DoWork();

        string FirstName { get; }
    }
}
