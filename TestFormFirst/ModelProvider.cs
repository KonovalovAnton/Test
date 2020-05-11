using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestFormFirst
{
    public class ModelProvider
    {
        public Model.Model Model { get; }

        public ModelProvider()
        {
            Model = new Model.Model();
        }
    }
}
