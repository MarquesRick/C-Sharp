using ClasseAbstrata.Enum;

namespace ClasseAbstrata.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        /*public Shape()
        {
            forma 1 de evitar erro na classe abstrata;
        }*/
        
        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
