namespace Task5
{
   public class Line : Figure
    {
       public Line(double x, double y, uint angle, uint lenght) : base(x, y, angle)
        {            
                Lenght = lenght;                      
        }

       public uint Lenght { get; set; }
       public override string ToString()
       {
           return $"Координаты центра линии ({X},{Y}), длина линии = {Lenght}, угол наклона = {Angle}";
       }
    }

}
