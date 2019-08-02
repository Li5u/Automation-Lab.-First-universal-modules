using Aircompany.Models;

namespace Aircompany.Planes
{
    public class MilitaryPlane : Plane
    {
        private MilitaryType _type;

        private string Type
        {
            get{ return _type; }
            set{ _type = value; }
        }

        public MilitaryPlane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity, MilitaryType type)
            : base(model, maxSpeed, maxFlightDistance, maxLoadCapacity)
        {
            Type = type;
            DefaultHashCode = 1701194404;
        }

        public override bool Equals(object obj)
        {
            var plane = obj as MilitaryPlane;
            return plane != null &&
                   base.Equals(obj) &&
                   Type == plane.Type;
        }

        public override int GetHashCode()
        {
            var hashCode = DefaultHashCode;
            hashCode = hashCode * _hashCodeChangeSpeed + base.GetHashCode();
            hashCode = hashCode * _hashCodeChangeSpeed + Type.GetHashCode();
            return hashCode;
        }

        public MilitaryType PlaneTypeIs()
        {
            return Type;
        }

        public override string ToString()
        {
            return base.ToString().Replace("}",
                    ", type=" + Type +
                    '}');
        }        
    }
}
