using System;
using System.Linq;
using System.Collections.Generic;

namespace ParadiseVille
{
    /// <summary>
    /// Struct for general data of disctrict
    /// </summary>
    public struct DistrictData
    {
        public string quartier { private set; get; }
        public string canton { private set; get; }
        public string villette { private set; get; }
        public float square { private set; get; }

        public List<HomeData> homeDataList { private set; get; }
        public Dictionary<EmployerType, int> employersDataDictionary { private set; get; }
        public List<string> placeDataList { private set; get; }

        public DistrictData(string quartier, string canton, string villette, float square)
        {
            this.quartier = quartier;
            this.canton = canton;
            this.villette = villette;
            this.square = square;

            homeDataList = new List<HomeData>();

            employersDataDictionary = new Dictionary<EmployerType, int>();
            List<EmployerType> allEmployerTypes = Enum.GetValues(typeof(EmployerType)).Cast<EmployerType>().ToList();

            foreach (EmployerType employerType in allEmployerTypes)
            {
                employersDataDictionary.Add(employerType, 0);
            }

            placeDataList = new List<string>();
        }

        public void HomeDataAdd(string facade, SocialState social, int size, int count, int[] appartaments)
        {
            homeDataList.Add(new HomeData(facade, social, size, count, appartaments));
        }

        public void EmployersDataAdd(EmployerType employerType, int count)
        {
            employersDataDictionary[employerType] += count;
        }

        public void PlaceDataAdd(params string[] placeArray)
        {
            foreach (string place in placeArray)
            {
                placeDataList.Add(place);
            }
        }
    }
}
