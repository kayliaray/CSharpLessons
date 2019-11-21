using System;

namespace Csharp_Dog
{
    public class Pet
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public bool Fixed { get; set; }
        public string Breed { get; set; }
        public string Species { get; set; }

        public Pet(string petName)
        {
            this.Name = petName;
        }
    }
}