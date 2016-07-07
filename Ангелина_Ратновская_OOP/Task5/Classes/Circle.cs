namespace Task5
{
   public class Circle : Figure
    {

        public Circle(double x, double y, uint radius) : base(x, y)
        {
            Radius = radius;
        }

       public Circle(uint radius) 
       {
           Radius = radius;
       }
        public override string ToString()
        {
            string what = Colored ? "круга" : "окружности";
            return $"Координаты центра {what} - ({X},{Y}), радиус {what} = {Radius}";
        }

        public uint Radius { get; set; }
    }
}
