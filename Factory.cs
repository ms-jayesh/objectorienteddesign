using System;
namespace OOD
{
    public interface IVehicle
    {
        void some();
        
    }
    public interface ICar
    {
        void somex();
    }
    public class Vehicle : IVehicle
    {
        public readonly int x;
        public readonly int y;
        private Vehicle(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void some()
        {
            Console.WriteLine("print");
        }
    }
    public class Car : IVehicle
    {
        public readonly int stand;
        public readonly int doors;
        private Car(int stand, int doors)
        {
            this.stand = stand;
        }
        public void some()
        {
        }
    }

    public interface IVehicleFactory
    {
        IVehicle GetVehicle(int x, int y);
    }

    public class NameFactory : IVehicleFactory
    {
        // it may use singleton to restrict to one object or to restrict to create 'X' number of objects.
        // Dependency Inversion (SOLID pricinciples)
        public IVehicle nameobj;

        public IVehicle GetVehicle(int x, int y)
        {
            return new Car(x, y);
        }


    }

    public class client
    { 
        //create more decoupled application.
        public void clientcaller()
        {
            var vehicleFactory = new NameFactory();
            var vehicle = vehicleFactory.GetVehicle(5,6);

        }
    }
}
