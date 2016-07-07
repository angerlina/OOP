namespace Task5
{
   public class Ring : Figure
    {
        public Ring(double x, double y, Circle a, Circle b) : base(x, y)
        {

            A = a;
            B = b;
            a.X = x;
            a.Y = y;
            b.X = x;
            b.Y = y;
        }

        public Circle A { get; set; }
        public Circle B  { get; set; }
       public override string ToString()
       {
           return $"Координаты центра кольца - ({X},{Y}), радиус внутренней поверхности = {A.Radius}, радиус внешней поверхности = {B.Radius}";
        }
    }
}
