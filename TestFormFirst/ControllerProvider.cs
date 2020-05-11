using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestFormFirst
{
    public class ControllerProvider
    {
        public TamagochiController TamagochiController { get; }

        public ControllerProvider(ModelProvider modelProvider)
        {
            TamagochiController = new TamagochiController(modelProvider.Model.Pet);
        }
    }
}
