using System;

namespace Aircompany.Planes
{
    public class PassengerPlane : Plane
    {
        public int _passengersCapacity;

        private string PassengerCapacity
        {
            get{ return _passengersCapacity; }
            set{ _passengersCapacity = value; }
        }

        public PassengerPlane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity, int passengersCapacity)
            :base(model, maxSpeed, maxFlightDistance, maxLoadCapacity)
        {
            PassengersCapacity = passengersCapacity;
            DefaultHashCode = 751774561;
        }

        public override bool Equals(object obj)
        {
            var plane = obj as PassengerPlane;
            return plane != null &&
                   base.Equals(obj) &&
                   PassengersCapacity == plane.PassengersCapacity;
        }

        public override int GetHashCode()
        {
            var hashCode = DefaultHashCode;
            hashCode = hashCode *  + base.GetHashCode();
            hashCode = hashCode * _hashCodeChangeSpeed + PassengersCapacity.GetHashCode();
            return hashCode;
        }

        public int PassengersCapacityIs()
        {
            return PassengersCapacity;
        }

        public override string ToString()
        {
            return base.ToString().Replace("}",
                    ", passengersCapacity=" + PassengersCapacity +
                    '}');
        }         
    }
}
