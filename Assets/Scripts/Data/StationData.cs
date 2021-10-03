using System.Collections.Generic;
using UnityEngine;

namespace ParadiseVille
{
    public struct StationData
    {
        public Station station { private set; get; }
        public string name { private set; get; }
        public Vector2 pos { private set; get; }

        Dictionary<Station, Vector2[]> pathDict;

        public StationData(Station station, string name, Vector2 pos)
        {
            this.station = station;
            this.name = name;
            this.pos = pos;

            pathDict = new Dictionary<Station, Vector2[]>();
        }

        public void AddPath (Station station, params Vector2[] interPoints)
        {
            pathDict.Add(station, interPoints);
        }

        public Vector2[] GetPath (Station station)
        {
            if (pathDict.ContainsKey(station))
            {
                return pathDict[station];
            }
            else
            {
                return null;
            }
        }
    }
}
