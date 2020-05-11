using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestFormFirst
{
    class Pet
    {
        public Dictionary<ParameterType, int> Parameters = new Dictionary<ParameterType, int>();
        public Status Status;

        public Pet()
        {
            Status = Status.Idle;
            foreach (ParameterType item in Enum.GetValues(typeof(ParameterType)))
            {
                Parameters[item] = 50;               
            }
        }
    }
}
