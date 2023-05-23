using Herencia;

namespace Encapsulamiento
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                PointEncapsulado pointEnc = new PointEncapsulado();
                pointEnc.SetX(120);
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
			}
            Point3D point = new Point3D();
            point.X = 30;
        }
        
    }
}