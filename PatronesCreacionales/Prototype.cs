using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesCreacionales
{
    interface IClonable<T> where T : class
    {
        public T ShallowCopy();
        public T DeepCopy();
    }

    public class Persona: IClonable<Persona>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Persona(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Persona ShallowCopy()
        {
            return (Persona)this.MemberwiseClone();
        }

        public Persona DeepCopy()
        {
            Persona clon = (Persona)this.MemberwiseClone();
            clon.Name = this.Name;
            clon.Age = this.Age;

            return clon;
        }
    }
}
