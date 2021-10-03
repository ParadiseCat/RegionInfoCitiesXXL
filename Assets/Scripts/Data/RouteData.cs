using System.Collections.Generic;

namespace ParadiseVille
{
    public struct RouteData
    {
        public Routier route { private set; get; }
        public string name { private set; get; }
        public string number { private set; get; }

        Queue<StationData> routeQueue;

        public RouteData(Routier route, int number, string name)
        {
            this.route = route;
            this.name = name;
            this.number = "Route " + number.ToString();

            routeQueue = new Queue<StationData>();
        }

        public Queue<StationData> GetPathStations()
        {
            return routeQueue;
        }

        public void AddStations(params StationData[] stations)
        {
            int length = stations.Length;

            for (int i = 0; i < length; i++)
            {
                routeQueue.Enqueue(stations[i]);
            }
        }
    }
}
