using System;
using System.Collections.Generic;
using System.Text;

namespace AreaAnyTriangle.Entities.Exceptions
{
    class TriangleMeasureException : ApplicationException
    {
        public TriangleMeasureException(string message) : base(message)
        {

        }
    }
}
