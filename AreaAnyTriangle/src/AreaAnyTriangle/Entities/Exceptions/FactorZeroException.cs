using System;
using System.Collections.Generic;
using System.Text;

namespace AreaAnyTriangle.Entities.Exceptions
{
    class FactorZeroException : ApplicationException
    {
        public FactorZeroException(string message) : base(message)
        {

        }
    }
}
