using System.Collections.Generic;

namespace Aircompany.Planes
{
    public abstract class Plane
    {
        internal readonly int _hashCodeChangeSpeed = -1521134295;
        private int _defaultHashCode;
        private string _model;
        private int _maxSpeed;
        private int _maxFlightDistance;
        private int _maxLoadCapacity;

        public string Model
        {
            get{ return _model; }
            set{ _model = value; }
        }

        public string MaxSpeed
        {
            get{ return _maxSpeed; }
            set{ _maxSpeed = value; }
        }

        public string MaxFlightDistance
        {
            get{ return _maxFlightDistance; }
            set{ _maxFlightDistance = value; }
        }

        public string MaxLoadCapacity
        {
            get{ return _maxLoadCapacity; }
            set{ _maxLoadCapacity = value; }
        }

        public string DefaultHashCode
        {
            get{ return _defaultHashCode; }
            set{ _defaultHashCode = value; }
        }

        public Plane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity)
        {
            Model = model;
            MaxSpeed = maxSpeed;
            MaxFlightDistance = maxFlightDistance;
            MAXLoadCapacity = maxLoadCapacity;
            DefaultHashCode = 1043886837;
        }

        public string GetModel()
        {
            return Model;
        }

        public int GetMS()
        {
            return MaxSpeed;
        }

        public int MAXFlightDistance()
        {
            return MaxFlightDistance;
        } 

        public int MAXLoadCapacity()
        {
            return MaxLoadCapacity;
        }

        public override string ToString()
        {
            return "Plane{" +
                "model='" + Model + '\'' +
                ", maxSpeed=" + MaxSpeed +
                ", maxFlightDistance=" + MaxFlightDistance +
                ", maxLoadCapacity=" + MaxLoadCapacity +
                '}';
        }

        public override bool Equals(object obj)
        {
            var plane = obj as Plane;
            return plane != null &&
                   Model == plane.Model &&
                   MaxSpeed == plane.MaxSpeed &&
                   MaxFlightDistance == plane.MaxFlightDistance &&
                   MaxLoadCapacity == plane.MaxLoadCapacity;
        }

        public override int GetHashCode()
        {
            var hashCode = DefaultHashCode;
            hashCode = hashCode * _hashCodeChangeSpeed + EqualityComparer<string>.Default.GetHashCode(_model);
            hashCode = hashCode * _hashCodeChangeSpeed + MaxSpeed.GetHashCode();
            hashCode = hashCode * _hashCodeChangeSpeed + MaxFlightDistance.GetHashCode();
            hashCode = hashCode * _hashCodeChangeSpeed + MaxLoadCapacity.GetHashCode();
            return hashCode;
        }        
    }
}
