using System;
using System.Linq;
using System.Collections.Generic;

namespace ParadiseVille
{
    /// <summary>
    /// Struct for home data in dicticts
    /// </summary>
    public struct HomeData
    {
        public string facade;
        public SocialState social;
        public int size;
        public int count;
        public int[] appartaments;

        public HomeData(string _facade, SocialState _social, int _size, int _count, int[] _appartaments)
        {
            facade = _facade;
            social = _social;
            size = _size;
            count = _count;
            appartaments = _appartaments;
        }
    }

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

        public DistrictData(string _quartier, string _canton, string _villette, float _square)
        {
            quartier = _quartier;
            canton = _canton;
            villette = _villette;
            square = _square;

            homeDataList = new List<HomeData>();

            employersDataDictionary = new Dictionary<EmployerType, int>();
            List<EmployerType> allEmployerTypes = Enum.GetValues(typeof(EmployerType)).Cast<EmployerType>().ToList();

            foreach (EmployerType employerType in allEmployerTypes)
            {
                employersDataDictionary.Add(employerType, 0);
            }

            placeDataList = new List<string>();
        }

        public void HomeDataAdd(string _facade, SocialState _social, int _size, int _count, int[] _appartaments)
        {
            homeDataList.Add(new HomeData(_facade, _social, _size, _count, _appartaments));
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
