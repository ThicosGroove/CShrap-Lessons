using Abstracts_class.Entities.Enums;

namespace Abstracts_class.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape() { }

        protected Shape(Color color)
        {
            Color = color;
        }

        public abstract float Area();
    }
}
