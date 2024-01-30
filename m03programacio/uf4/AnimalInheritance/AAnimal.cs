using System;

namespace oopsecond
{
    public abstract class AAnimal
    {
        public float Weight { get; set; }
        public string? Name { get; set; }
        public abstract void Eat();
        public abstract void Move();
    }
}
