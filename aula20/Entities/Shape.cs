using aula20.Entities.Enums;

namespace aula20.Entities{
    abstract class Shape{
        public Color Color { get; set; }
    }

    public Shape(Color color){
        Color = color;
    }

    public abstract double Area();

    
}