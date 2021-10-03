using System.Collections.Generic;

namespace ParadiseVille.Handler
{
    internal class QuartierData : Hierarcy
    {
        const int SOCIAL_STATE = 4;
        const int MAX_ETAGES = 7;
        const int APPARTAMENT_HABITANS = 2;
        const int EMPLOYER_GROUPS = 10;
        const float EMPLOYERS_PER_UNIT = 5.95f;
        const float DEPUTE_DISTRICT_HABITANS = 500f;
        const string VILL_NAME = "PARADISE";

        const int NO_INIT_INT = -1;
        const float NO_INIT_FLOAT = -1f;

        int[] quartiers;
        int[] totalHabitans;
        int[] totalEmployers;
        float[] squares;
        int[,] socialStateCounts;
        int[,] appartamentsData;
        int[,] employersData;

        int length;
        int added = 0;
        int level = NO_INIT_INT;

        int countResidents = NO_INIT_INT;
        int countEmployers = NO_INIT_INT;
        string[] names;
        string[] empGroups;
        int[] empCount;
        int[] empPart;
        float square = NO_INIT_FLOAT;
        int depute = NO_INIT_INT;
        string[] espacePublic;
        int[] socialGroup;
        int[] socialGroupParts;
        int[] etages;
        int[] etagesParts;

        public int founded = 0;

        public int CountResidents
        {
            get
            {
                if (countResidents == NO_INIT_INT)
                {
                    countResidents = TotalHabitans();
                }

                return countResidents;
            }
        }

        public string[] Names
        {
            get
            {
                if (names == null)
                {
                    names = GetNames();
                }

                return names;
            }
        }

        public float Square
        {
            get
            {
                if (square == NO_INIT_FLOAT)
                {
                    square = TotalSqaure();
                }

                return square;
            }
        }

        public int CountEmployers
        {
            get
            {
                if (countEmployers == NO_INIT_INT)
                {
                    countEmployers = TotalEmployers();
                }

                return countEmployers;
            }
        }

        public int Depute
        {
            get
            {
                if (depute == NO_INIT_INT)
                {
                    depute = TotalDepute();
                }

                return depute;
            }
        }

        public string[] EmployerGroupNames
        {
            get
            {
                if (empGroups == null)
                {
                    empGroups = EmployerGroupList();
                }

                return empGroups;
            }
        }

        public int[] EmployerGroupCount
        {
            get
            {
                if (empCount == null)
                {
                    empCount = EmployerGroupWorkers();
                }

                return empCount;
            }
        }

        public int[] EmployerGroupParts
        {
            get
            {
                if (empPart == null)
                {
                    empPart = PartEmployers();
                }

                return empPart;
            }
        }

        public string[] EspacePublic
        {
            get
            {
                if (level == 1)
                {
                    if (espacePublic == null)
                    {
                        espacePublic = AllPublic();
                    }

                    return espacePublic;
                }

                return new string[1] { "Error" };
            }
        }

        public int[] SocialGroups
        {
            get
            {
                if (socialGroup == null)
                {
                    socialGroup = AllSocial();
                }

                return socialGroup;
            }
        }

        public int[] SocialGroupsPercent
        {
            get
            {
                if (socialGroupParts == null)
                {
                    socialGroupParts = PartSocial();
                }

                return socialGroupParts;
            }
        }

        public int[] Etages
        {
            get
            {
                if (etages == null)
                {
                    etages = HabitansOnEtages();
                }

                return etages;
            }
        }

        public int[] EtagesPercent
        {
            get
            {
                if (etagesParts == null)
                {
                    etagesParts = PartEtages();
                }

                return etagesParts;
            }
        }

        public QuartierData(Quartier quartier) : base(quartier)
        {
            Init(1);
        }

        public QuartierData(Canton canton) : base(canton)
        {
            Init(2);
        }

        public QuartierData(Villette villette) : base(villette)
        {
            Init(3);
        }

        public QuartierData() : base()
        {
            Init(4);
        }

        void Init(int level)
        {
            this.level = level;
            length = quartierList.Count;

            quartiers = new int[length];
            totalHabitans = new int[length];
            totalEmployers = new int[length];
            squares = new float[length];
            socialStateCounts = new int[length, SOCIAL_STATE];
            appartamentsData = new int[length, MAX_ETAGES];
            employersData = new int[length, EMPLOYER_GROUPS];

            if (level == 1)
            {
                Quartier quartier = quartierList[0];
                DistrictData data = DataVille.Information(quartierList[0]);
                AddData(quartier, data.homeDataList, data.employersDataDictionary);
                squares[0] = data.square;
                founded = data.founded;
                added = 1;
            }
            else
            {
                foreach (Quartier quartier in quartierList)
                {
                    DistrictData data = DataVille.Information(quartier);
                    AddData(quartier, data.homeDataList, data.employersDataDictionary);
                    squares[added] = data.square;
                    added++;
                }
            }
        }

        void AddData(Quartier quartier, List<HomeData> home, Dictionary<EmployerType, int> work)
        {
            int quartierId = (int)quartier;
            int count = 0;
            int worker = 0;
            int[] social = new int[SOCIAL_STATE];
            int[] appart = new int[MAX_ETAGES];
            int[] employ = new int[EMPLOYER_GROUPS];

            for (int i = 0; i < added; i++)
            {
                if (quartiers[i] == quartierId)
                {
                    return;
                }
            }

            foreach (HomeData homeData in home)
            {
                int etages = homeData.appartaments.Length;
                int total = 0;

                for (int i = 0; i < etages; i++)
                {
                    int etage_count = homeData.appartaments[i] * homeData.count * APPARTAMENT_HABITANS;
                    appart[i] += etage_count;
                    total += etage_count;
                }

                count += total;
                social[(int)homeData.social] += total;
            }

            foreach (EmployerType empData in work.Keys)
            {
                int emp_count = UnityEngine.Mathf.RoundToInt(work[empData] * EMPLOYERS_PER_UNIT);
                employ[(int)empData] = emp_count;
                worker += emp_count;
            }

            quartiers[added] = quartierId;
            totalHabitans[added] = count;
            totalEmployers[added] = worker;

            for (int i = 0; i < SOCIAL_STATE; i++)
            {
                socialStateCounts[added, i] = social[i];
            }

            for (int i = 0; i < MAX_ETAGES; i++)
            {
                appartamentsData[added, i] = appart[i];
            }

            for (int i = 0; i < EMPLOYER_GROUPS; i++)
            {
                employersData[added, i] = employ[i];
            }
        }

        int TotalHabitans()
        {
            int count = 0;

            for (int i = 0; i < added; i++)
            {
                count += totalHabitans[i];
            }

            return count;
        }

        float TotalSqaure()
        {
            float count = 0f;

            for (int i = 0; i < added; i++)
            {
                count += squares[i];
            }

            return count;
        }

        int TotalEmployers()
        {
            int count = 0;

            for (int i = 0; i < added; i++)
            {
                count += totalEmployers[i];
            }

            return count;
        }

        string[] GetNames()
        {
            DistrictData data = DataVille.Information((Quartier)quartiers[0]);
            string[] names;

            switch (level)
            {
                case 1:
                    names = new string[3]
                    {
                        data.quartier,
                        data.canton,
                        data.villette
                    };
                    return names;

                case 2:
                    names = new string[2]
                    {
                        data.canton,
                        data.villette
                    };
                    return names;

                case 3:
                    names = new string[1]
                    {
                        data.villette
                    };
                    return names;

                default:
                    return new string[1] { VILL_NAME };
            }
        }

        int TotalDepute()
        {
            int count = 0;

            for (int i = 0; i < added; i++)
            {
                count += UnityEngine.Mathf.RoundToInt((totalHabitans[i] + totalEmployers[i]) / DEPUTE_DISTRICT_HABITANS);
            }

            return count;
        }

        string[] EmployerGroupList()
        {
            return new string[EMPLOYER_GROUPS]
            {
                "Industrie",
                "Bureaux",
                "Commerce",
                "Culture",
                "Hôtels",
                "Éducation",
                "Santé",
                "Services de la Ville",
                "Sport",
                "Administration"
            };
        }

        int[] EmployerGroupWorkers()
        {
            int[] count = new int[EMPLOYER_GROUPS];

            for (int i = 0; i < added; i++)
            {
                for (int j = 0; j < EMPLOYER_GROUPS; j++)
                {
                    count[j] += employersData[i, j];
                }
            }

            return count;
        }

        int[] PartEmployers()
        {
            if (empCount == null)
            {
                empCount = EmployerGroupWorkers();
            }

            return PercentValuesGet(empCount);
        }

        string[] AllPublic()
        {
            DistrictData data = DataVille.Information(quartierList[0]);
            int length = data.placeDataList.Count;
            int count = 0;
            string[] espaces = new string[length];

            foreach (string info in data.placeDataList)
            {
                espaces[count] = info;
                count++;
            }

            return espaces;
        }

        int[] AllSocial()
        {
            int[] count = new int[SOCIAL_STATE];

            for (int i = 0; i < added; i++)
            {
                for (int j = 0; j < SOCIAL_STATE; j++)
                {
                    count[j] += socialStateCounts[i, j];
                }
            }

            return count;
        }

        int[] PartSocial()
        {
            if (socialGroup == null)
            {
                socialGroup = AllSocial();
            }

            return PercentValuesGet(socialGroup);
        }

        int[] HabitansOnEtages()
        {
            int[] count = new int[MAX_ETAGES];

            for (int i = 0; i < added; i++)
            {
                for (int j = 0; j < MAX_ETAGES; j++)
                {
                    count[j] += appartamentsData[i, j];
                }
            }

            return count;
        }

        int[] PartEtages()
        {
            if (etages == null)
            {
                etages = HabitansOnEtages();
            }

            return PercentValuesGet(etages);
        }

        int[] PercentValuesGet(int[] dataArray)
        {
            int arrLength = dataArray.Length;
            int percentTotal = 100;
            int total = 0;

            for (int i = 0; i < arrLength; i++)
            {
                total += dataArray[i];
            }

            if (arrLength > 0)
            {
                int[] arrPercents = new int[arrLength];

                if (total == 0)
                {
                    for (int i = 0; i < arrLength; i++)
                    {
                        arrPercents[i] = 0;
                    }
                }
                else
                {
                    int currentPercentCount = 0;

                    for (int i = 0; i < arrLength; i++)
                    {
                        arrPercents[i] = UnityEngine.Mathf.RoundToInt(dataArray[i] / (float)total * percentTotal);
                        currentPercentCount += arrPercents[i];
                    }

                    int loop = 0;

                    while (currentPercentCount != percentTotal)
                    {
                        int changeIndex = 0;
                        float changeGap = 0f;

                        loop++;

                        if (currentPercentCount < percentTotal)
                        {
                            for (int i = 0; i < arrLength; i++)
                            {
                                float fValue = dataArray[i] / (float)total * percentTotal;
                                float changed = fValue - arrPercents[i];

                                if (changed > changeGap)
                                {
                                    changeGap = changed;
                                    changeIndex = i;
                                }
                            }

                            arrPercents[changeIndex] += 1;
                            currentPercentCount += 1;
                        }
                        else
                        {
                            for (int i = 0; i < arrLength; i++)
                            {
                                float fValue = dataArray[i] / (float)total * percentTotal;
                                float changed = fValue - arrPercents[i];

                                if (changed < changeGap)
                                {
                                    changeGap = changed;
                                    changeIndex = i;
                                }
                            }

                            arrPercents[changeIndex] -= 1;
                            currentPercentCount -= 1;
                        }

                        if (loop >= 10)
                        {
                            UnityEngine.Debug.Log("error cycle while");
                            return arrPercents;
                        }
                    }
                }

                return arrPercents;
            }
            else
                return new int[0];
        }

        public void CalcEmployersPerUnit()
        {
            int employersCount = 0;
            int employersUnit = 0;
            int workPlaceUnit = 0;

            foreach (Quartier quartier in quartierList)
            {
                DistrictData dat = DataVille.Information(quartier);

                foreach (HomeData home in dat.homeDataList)
                {
                    int homeSize = 0;
                    int homeCount = home.appartaments.Length;

                    for (int i = 0; i < homeCount; i++)
                    {
                        homeSize += home.appartaments[i];
                    }

                    employersCount += home.count * homeSize;
                    employersUnit += home.count * home.size;
                }

                foreach (EmployerType employers in dat.employersDataDictionary.Keys)
                {
                    workPlaceUnit += dat.employersDataDictionary[employers];
                }
            }

            UnityEngine.Debug.Log("count = " + employersCount.ToString()
                + " unit = " + employersUnit.ToString()
                + " work unit = " + workPlaceUnit.ToString()
                + " work places = " + (workPlaceUnit / (float)employersUnit).ToString()
                + " employers per unit = " + (employersCount / (float)employersUnit).ToString());
        }
    }
}
