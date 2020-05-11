using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Model
    {
        public Tamagochi Pet { get; set; }

        public Model()
        {
            Pet = new Tamagochi();
        }
    }
}
