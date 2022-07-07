namespace Homework_22_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parallelepiped p1 = new Parallelepiped("Parralelepiped", 7, 8, 9);
            Console.WriteLine("Volume is: " + p1.name +" = " + p1.GetVolume());
            Console.WriteLine("Total area is:" + p1.name + " = " + p1.GetTotalSurfaceArea());
            Console.WriteLine();

            Pyramid p2 = new Pyramid("Piramida", 10, 10, 15);
            Console.WriteLine("Volume is: " + p2.name + " = " + p2.GetVolume());
            Console.WriteLine("Total area is:" + p1.name + " = " + p2.GetTotalSurfaceArea());
            Console.WriteLine();

            Sphere p3 = new Sphere("Sphere", 21);
            Console.WriteLine("Volume is: " + p3.name + " = " + p3.GetVolume());
            Console.WriteLine("Total area is:" + p3.name + " = " + p3.GetTotalSurfaceArea());
            Console.WriteLine();

            Cylinder p4 = new Cylinder("Cylinder", 12, 10);
            Console.WriteLine("Volume is: " + p4.name + " = " + p4.GetVolume());
            Console.WriteLine("Total area is:" + p4.name + " = " + p4.GetTotalSurfaceArea());
            Console.WriteLine();

            Cone p5 = new Cone("Cone", 10, 12);
            Console.WriteLine("Volume is: " + p5.name + " = " + p5.GetVolume());
            Console.WriteLine("Total area is:" + p5.name + " = " + p5.GetTotalSurfaceArea());
            Console.WriteLine();

            IFigure[] figures = { p1, p2, p3, p4, p5 };

                if (p1.GetVolume() > p2.GetVolume() && p1.GetVolume() > p3.GetVolume() && p1.GetVolume() > p4.GetVolume() && p1.GetVolume() > p5.GetVolume())
                {
                    Console.WriteLine("The largest volume of figures is: " +p1.name + " = " + p1.GetVolume());
                }
                else if (p2.GetVolume() > p1.GetVolume() && p2.GetVolume() > p3.GetVolume() && p2.GetVolume() > p4.GetVolume() && p2.GetVolume() > p5.GetVolume())
                {
                    Console.WriteLine("The largest volume of figures is: " + p2.name + " = " + p2.GetVolume());
                }
                else if (p3.GetVolume() > p1.GetVolume() && p3.GetVolume() > p2.GetVolume() && p3.GetVolume() > p4.GetVolume() && p3.GetVolume() > p5.GetVolume())
                {
                    Console.WriteLine("The largest volume of figures is: " + p3.name + " = " + p3.GetVolume());
                }
                else if (p4.GetVolume() > p1.GetVolume() && p4.GetVolume() > p3.GetVolume() && p4.GetVolume() > p3.GetVolume() & p4.GetVolume() > p5.GetVolume())
                {
                    Console.WriteLine("The largest volume of figures is: " + p4.name + " = " + p4.GetVolume());
                }
                else if (p5.GetVolume() > p1.GetVolume() && p5.GetVolume() > p2.GetVolume() && p5.GetVolume() > p3.GetVolume() & p5.GetVolume() > p4.GetVolume())
                {
                    Console.WriteLine("The largest volume of figures is: " + p5.name + " = " + p5.GetVolume());
                }

            
            



        }
    }

    struct Parallelepiped : IFigure
    {
        public string name;
        public double lengthOfPar;
        public double widthOfPar;
        public double heightOfPar;

        public Parallelepiped(string Name, double LengthOfPar, double WidthOfPar, double HeightOfPar)
        {
            this.name = Name;
            this.lengthOfPar = LengthOfPar;
            this.widthOfPar = WidthOfPar;
            this.heightOfPar = HeightOfPar;
        }

        public double GetVolume()
        {
            return this.widthOfPar * this.heightOfPar * this.lengthOfPar;
        }
        public double GetTotalSurfaceArea()
        {
            return 2 * ((this.lengthOfPar * this.widthOfPar) + (this.lengthOfPar * this.heightOfPar) + (this.widthOfPar * this.heightOfPar));
        }

    }
    struct Pyramid : IFigure
    {
        public string name;
        public double lengthOfPir;
        public double widthOfPar;
        public double heightOfPir;

        public Pyramid(string Name, double LengthOfPir,  double HeightOfPir, double WidthOfPar)
        {
            this.name = Name;
            this.lengthOfPir = LengthOfPir;
            this.widthOfPar = WidthOfPar;
            this.heightOfPir = HeightOfPir;
        }

        public double GetVolume()
        {
            double BaseAreaOfPyramid = (Math.Pow(this.lengthOfPir, 2) * 0.33) / 4;
            return 0.33 * BaseAreaOfPyramid * this.heightOfPir;
        }
        public double GetTotalSurfaceArea()
        {
            double BaseAreaOfPyramid = (Math.Pow(this.lengthOfPir, 2) * 0.33) / 4;
            double LateralAreaOfPyramid = 0.50 * (this.lengthOfPir + this.widthOfPar) * this.heightOfPir; 
            return BaseAreaOfPyramid + LateralAreaOfPyramid;
        }
    }
    struct Sphere : IFigure
    {
        public string name;
        public double radiusOfSphere;
        public Sphere(string Name, double RadiusOfSphere)
        {
            this.name = Name;
            this.radiusOfSphere = RadiusOfSphere;
        }
        public double GetVolume()
        {
            return 1.33 * Math.PI * Math.Pow(this.radiusOfSphere, 3);
        }
        public double GetTotalSurfaceArea()
        {
            return 4 * Math.PI * Math.Pow(this.radiusOfSphere, 2);
            
        }

    }
    struct Cylinder : IFigure
    {
        public string name;
        public double radiusOfCylinder;
        public double heightOfCylinder;
        
        public Cylinder(string Name, double radiusOfCylinder, double HeightOfCylinder)
        {
            this.name = Name;
            this.radiusOfCylinder = radiusOfCylinder;
            this.heightOfCylinder = HeightOfCylinder;
        }
        public double GetVolume()
        {
            return this.heightOfCylinder * Math.PI * Math.Pow(this.radiusOfCylinder, 2);
        }
        public double GetTotalSurfaceArea()
        {
            return 2 * Math.PI * this.radiusOfCylinder * this.heightOfCylinder;
        }
    }

    struct Cone : IFigure
    {
        public string name;
        public double radiusOfCone;
        public double heightOfCone;

        public Cone(string Name, double RadiusOfCone, double HeightOfCone)
        {
            this.name = Name;
            this.radiusOfCone = RadiusOfCone;
            this.heightOfCone = HeightOfCone;
        }
        public double GetVolume()
        {
            return (this.heightOfCone * Math.PI * Math.Pow(this.radiusOfCone, 2)) / 3;
        }
        public double GetTotalSurfaceArea()
        {
            double LengthOfcone = Math.Sqrt( Math.Pow(this.radiusOfCone, 2) + Math.Pow(this.heightOfCone, 2) );
            return Math.PI * this.radiusOfCone * LengthOfcone;
        }


    }

     public interface IFigure
     {
        double GetVolume();
        double GetTotalSurfaceArea();
     }


}
