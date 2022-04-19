using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    abstract class BrandSystemComponent
    {
        public string Name { get; }

        public BrandSystemComponent(string name)
        {
            Name = name;
        }

        public abstract void Display(int level = 0);
    }
}
