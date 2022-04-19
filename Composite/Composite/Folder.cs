using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Folder : BrandSystemComponent
    {
        private List<BrandSystemComponent> _components = new List<BrandSystemComponent>();

        public Folder(string name) : base(name)
        {

        }

        public override void Display(int level = 0)
        {
            string spaces = new string(' ', level);

            Console.WriteLine(spaces + "└ " + Name);
            foreach (var component in _components)
                component.Display(level + 1);
        }

        public void AddComponent(BrandSystemComponent component)
        {
            _components.Add(component);
        }

        public void RemoveComponent(BrandSystemComponent component)
        {
            _components.Remove(component);
        }
    }
}
