using Abstracts_class.Entities.Enums;

namespace Abstracts_class.Entities
{
    class Rectangle : Shape
    {
        public float Width { get; set; }
        public float Height { get; set; }

        public Rectangle() { }

        public Rectangle(float width, float height, Color color) 
            : base(color)
        {
            Width = width;
            Height = height;
        }

        public override float Area()
        {
            return Width * Height;
        }
    }
}
