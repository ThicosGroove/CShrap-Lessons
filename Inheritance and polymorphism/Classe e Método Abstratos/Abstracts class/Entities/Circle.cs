using Abstracts_class.Entities.Enums;

namespace Abstracts_class.Entities
{
    class Circle : Shape
    {
        public float Radius { get; set; }

        public Circle() { }

        public Circle(float radius, Color color) 
            : base(color)
        {
            Radius = radius;
        }

        public override float Area()
        {
            return Radius * Radius * 3.14f; 
        }
    }
}
