using System;

namespace BusFleet
{
    public struct Bus
    {
        private string busNumber;
        private string name;
        private int routeNumber;

        public string BusNumber
        {
            get { return busNumber; }
            set { busNumber = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int RouteNumber
        {
            get { return routeNumber; }
            set { routeNumber = value; }
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2}", busNumber, name, routeNumber);
        }

    }
}
