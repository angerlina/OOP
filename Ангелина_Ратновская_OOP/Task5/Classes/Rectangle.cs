namespace Task5
{
   public class Rectangle : Figure
    {
       public Rectangle(double x, double y, uint angle, uint a, uint b) : base(x, y, angle)
        {
            A = a;
            B = b;
        }

        public uint A { get; set; }

        public uint B { get; set; }
        public override string ToString()
        {
            return $"Координаты центра прямоугольника ({X},{Y}), длина стороны \"а\" = {A}, длина стороны \"b\" = {B}, угол наклона = {Angle}";
        }
    }
}
