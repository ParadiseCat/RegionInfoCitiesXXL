using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

namespace ParadiseVille
{
    /// <summary>
    /// List of cities dicticts
    /// </summary>
    public enum Ville
    {
        v_Fleurville = 100,
            c_MontFleur = 110,
                q_Jardinfleuri = 111,
                q_Ilechateau = 112,
                q_Roifrenaie = 113,
                q_Cotelevant = 114,
            c_Coeurville = 120,
                q_Hotel = 121,
                q_Riveciel = 122,
                q_Eclaires = 123,
            c_Gloir = 130,
                q_Hallesluxe = 131,
                q_Aquarelle = 132,
                q_Promenade = 133,
            c_Imperial = 140,
                q_Idylle = 141,
                q_Anthese = 142,
            c_Promission = 150,
                q_Perpetuel = 151,
                q_Sabbat = 152,
            c_Palefroi = 160,
                q_Victoire = 161,
                q_Lumiere = 162,
                q_Iris = 163,
                q_Sophora = 164,
        v_Cotierville = 200,
            c_Soleil = 210,
                q_Charme = 211,
                q_Cotecorail = 212,
                q_Artisan = 213,
            c_Couleur = 220,
                q_Chandelle = 221,
                q_Parfumeur = 222,
                q_Gremil = 223,
                q_Hulotte = 224,
            c_Castel = 230,
                q_Prosperite = 231,
                q_Pastel = 232,
                q_Sansonnet = 233,
            c_Chaleur = 240,
                q_Cotepalmier = 241,
                q_Cotecafe = 242,
                q_Brise =243,
            c_Tropique = 250,
                q_Tadorne = 251,
                q_Cocotier = 252,
                q_Montfee = 253,
        v_Montville = 300,
            c_Roquerie = 310,
                q_Nichoir = 311,
                q_Trefleblue = 312,
            c_Ravinlis = 320,
                q_Paysage = 321,
                q_Croissance = 322,
                q_Tilleul = 323,
            c_Liberte = 330,
                q_Enchanteur = 331,
                q_Sublimite = 332,
            c_Brume = 340,
                q_Tulipier = 341,
                q_Montpistache = 342,
                q_Accalmie =343,
        v_Rivierville = 400,
            c_Promontoire = 410,
                q_Mielfaine = 411,
                q_Boishetre = 412,
                q_Blancheur = 413,
            c_Oiselle = 420,
                q_Cheveche = 421,
                q_Perroquet = 422,
            c_Grace = 430,
                q_Charite = 431,
                q_Aronde = 432,
                q_Palaisreine = 433,
            c_Parcville = 440,
                q_Parcoiseau = 441,
        v_Boisville = 600,
            c_Conte = 610,
                q_Nectar = 611,
                q_Lambruche = 612,
            c_Serein = 620,
                q_Accord = 621,
            c_Versantvert = 630,
                q_Pivoine = 631,
                q_Peinardise = 632,
            c_Clemence = 640,
                q_Purete = 641,
                q_Renardeau = 642,
                q_Ormaie = 643,
            c_Prestige = 650,
                q_Comtefleur = 651,
                q_Licorne = 652,
                q_Gare = 653,
            c_Occidental = 660,
                q_Bruyere = 661,
        v_Merville = 700,
            c_Lotus = 710,
                q_Interfluve = 711,
                q_Orchidee = 712,
                q_Cygneblanch = 713,
            c_Zenith = 720,
                q_Aber = 721,
                q_Suavite = 722,
                q_Suffle = 723,
                q_Harmonie = 724,
            c_Vanille = 730,
                q_Cedres = 731,
                q_Gattilier = 732,
            c_Maritime = 740,
                q_Littoral = 741,
                q_Coquille = 742,
                q_Goeland = 743,
            c_Phare = 750,
                q_Tissage = 751,
                q_Port = 752
    }

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

    /// <summary>
    /// Handler data info for it input in Game as text
    /// </summary>
    public class DataHandler
    {
        TextDraw objTextDraw;

        const int appartamentHabitans = 2;
        const int deputeDictictHabitans = 500;
        const float employersPerUnit = 5.5f;

        string hexColor = "";
        Mode mapMode;

        List<EmployerType> allEmployerTypes;
        List<SocialState> allSocialStates;
        List<Ville> allQuarties;
        Dictionary<EmployerType, string> allEmployerNames;

        public DataHandler(Mode modeDefault)
        {
            objTextDraw = new TextDraw();
            allEmployerTypes = Enum.GetValues(typeof(EmployerType)).Cast<EmployerType>().ToList();
            allSocialStates = Enum.GetValues(typeof(SocialState)).Cast<SocialState>().ToList();
            allQuarties = Enum.GetValues(typeof(Ville)).Cast<Ville>().ToList();
            allEmployerNames = new Dictionary<EmployerType, string>();

            mapMode = modeDefault;

            string[] nameEmployersGroup = new string[10]
            {
                "Production", 
                "Office", 
                "Trade", 
                "Culture", 
                "Hotel", 
                "Education", 
                "Medicine", 
                "Services", 
                "Sport", 
                "Administration"
            };

            int index = 0;

            foreach (EmployerType employerGroup in allEmployerTypes)
            {
                allEmployerNames.Add(employerGroup, nameEmployersGroup[index]);
                index++;
            }
        }

        public void ShowData(Mode mode, string hexCode)
        {
            if (hexColor != hexCode || mapMode != mode)
            {
                hexColor = hexCode;
                mapMode = mode;

                objTextDraw.TextClean();

                switch (mode)
                {
                    case Mode.Quartier: {
                        switch (hexCode)
                        {
                            // *** FLEURVILLE *** //
                            // --- Montfleur --- //
                            case "B5FF00": QuartierHandler(Ville.q_Jardinfleuri); break;
                            case "00FF31": QuartierHandler(Ville.q_Ilechateau); break;
                            case "0BC373": QuartierHandler(Ville.q_Roifrenaie); break;
                            case "47FF00": QuartierHandler(Ville.q_Cotelevant); break;
                            // --- Coeurville --- //
                            case "FF0000": QuartierHandler(Ville.q_Hotel); break;
                            case "FF7F91": QuartierHandler(Ville.q_Riveciel); break;
                            case "EC2745": QuartierHandler(Ville.q_Eclaires); break;
                            // --- Gloir --- //
                            case "6028E7": QuartierHandler(Ville.q_Hallesluxe); break;
                            case "9A82F4": QuartierHandler(Ville.q_Aquarelle); break;
                            case "AA0CF4": QuartierHandler(Ville.q_Promenade); break;
                            // --- Imperial --- //
                            case "70FA1E": QuartierHandler(Ville.q_Idylle); break;
                            case "CBFE39": QuartierHandler(Ville.q_Anthese); break;
                            // --- Promission --- //
                            case "EA9B39": QuartierHandler(Ville.q_Perpetuel); break;
                            case "F7C326": QuartierHandler(Ville.q_Sabbat); break;
                            // --- Palefroi --- //
                            case "89FFFF": QuartierHandler(Ville.q_Victoire); break;
                            case "7E96FF": QuartierHandler(Ville.q_Lumiere); break;
                            case "3CAEFF": QuartierHandler(Ville.q_Iris); break;
                            case "1562C0": QuartierHandler(Ville.q_Sophora); break;

                            // *** COTIERVILLE *** //
                            // --- Soleil --- //
                            case "0BEBA2": QuartierHandler(Ville.q_Charme); break;
                            case "9CEF13": QuartierHandler(Ville.q_Cotecorail); break;
                            case "00A600": QuartierHandler(Ville.q_Artisan); break;
                            // --- Couleur --- //
                            case "F40DB8": QuartierHandler(Ville.q_Chandelle); break;
                            case "D60CC6": QuartierHandler(Ville.q_Parfumeur); break;
                            case "F44173": QuartierHandler(Ville.q_Gremil); break;
                            case "E4421E": QuartierHandler(Ville.q_Hulotte); break;
                            // --- Castel --- //
                            case "18A7CE": QuartierHandler(Ville.q_Prosperite); break;
                            case "1837F7": QuartierHandler(Ville.q_Pastel); break;
                            case "843EEF": QuartierHandler(Ville.q_Sansonnet); break;
                            // --- Chaleur --- //
                            case "F22F63": QuartierHandler(Ville.q_Cotepalmier); break;
                            case "F48F6E": QuartierHandler(Ville.q_Cotecafe); break;
                            case "F7DF31": QuartierHandler(Ville.q_Brise); break;
                            // --- Tropique --- //
                            case "7BF008": QuartierHandler(Ville.q_Tadorne); break;
                            case "21FA0B": QuartierHandler(Ville.q_Cocotier); break;
                            case "08B67B": QuartierHandler(Ville.q_Montfee); break;

                            // *** MONTVILLE *** //
                            // --- Roquerie --- //
                            case "84C78F": QuartierHandler(Ville.q_Nichoir); break;
                            case "1EF018": QuartierHandler(Ville.q_Trefleblue); break;
                            // --- Ravinlis --- //
                            case "6674BA": QuartierHandler(Ville.q_Paysage); break;
                            case "1037EC": QuartierHandler(Ville.q_Croissance); break;
                            case "398DFF": QuartierHandler(Ville.q_Tilleul); break;
                            // --- Liberte --- //
                            case "DE664A": QuartierHandler(Ville.q_Enchanteur); break;
                            case "E11468": QuartierHandler(Ville.q_Sublimite); break;
                            // --- Brume --- //
                            case "6071C9": QuartierHandler(Ville.q_Tulipier); break;
                            case "81F4FF": QuartierHandler(Ville.q_Montpistache); break;
                            case "39B6EC": QuartierHandler(Ville.q_Accalmie); break;

                            // *** RIVIERVILLE *** //
                            // --- Promontoire --- //
                            case "10C429": QuartierHandler(Ville.q_Mielfaine); break;
                            case "08D2B2": QuartierHandler(Ville.q_Boishetre); break;
                            case "9FFB0D": QuartierHandler(Ville.q_Blancheur); break;
                            // --- Oiselle --- //
                            case "DB2815": QuartierHandler(Ville.q_Cheveche); break;
                            case "F48910": QuartierHandler(Ville.q_Perroquet); break;
                            // --- Grace --- //
                            case "9F7AEF": QuartierHandler(Ville.q_Charite); break;
                            case "4ADAF7": QuartierHandler(Ville.q_Aronde); break;
                            case "3969F2": QuartierHandler(Ville.q_Palaisreine); break;
                            // --- Parcville --- //
                            case "009600": QuartierHandler(Ville.q_Parcoiseau); break;

                            // *** BOISVILLE *** //
                            // --- Conte --- //
                            case "E72839": QuartierHandler(Ville.q_Nectar); break;
                            case "E749BA": QuartierHandler(Ville.q_Lambruche); break;
                            // --- Serein --- //
                            case "4FE67B": QuartierHandler(Ville.q_Accord); break;
                            // --- Versantvert --- //
                            case "1854D6": QuartierHandler(Ville.q_Pivoine); break;
                            case "7B4AC9": QuartierHandler(Ville.q_Peinardise); break;
                            // --- Clemence -- //
                            case "3941FF": QuartierHandler(Ville.q_Purete); break;
                            case "2EDEFA": QuartierHandler(Ville.q_Renardeau); break;
                            case "4FA5FA": QuartierHandler(Ville.q_Ormaie); break;
                            // --- Prestige --- //
                            case "E735FF": QuartierHandler(Ville.q_Comtefleur); break;
                            case "F43E68": QuartierHandler(Ville.q_Licorne); break;
                            case "EFB9C9": QuartierHandler(Ville.q_Gare); break;
                            // --- Occidental --- //
                            case "C0FB00": QuartierHandler(Ville.q_Bruyere); break;

                            // *** MERVILLE *** //
                            // --- Lotus --- //
                            case "E7372E": QuartierHandler(Ville.q_Interfluve); break;
                            case "FFF64A": QuartierHandler(Ville.q_Orchidee); break;
                            case "EC7C10": QuartierHandler(Ville.q_Cygneblanch); break;
                            // --- Zenith --- //
                            case "5899EF": QuartierHandler(Ville.q_Aber); break;
                            case "343BE7": QuartierHandler(Ville.q_Suavite); break;
                            case "9C55E7": QuartierHandler(Ville.q_Suffle); break;
                            case "1B74EF": QuartierHandler(Ville.q_Harmonie); break;
                            // --- Vanille --- //
                            case "5AF02E": QuartierHandler(Ville.q_Cedres); break;
                            case "03B62E": QuartierHandler(Ville.q_Gattilier); break;
                            // --- Maritime --- //
                            case "E12FC3": QuartierHandler(Ville.q_Littoral); break;
                            case "EA9F2C": QuartierHandler(Ville.q_Coquille); break;
                            case "D96C8C": QuartierHandler(Ville.q_Goeland); break;
                            // --- Phare --- //
                            case "4ACFD9": QuartierHandler(Ville.q_Tissage); break;
                            case "94E815": QuartierHandler(Ville.q_Port); break;
                        }
                        break;
                    }
                    case Mode.Canton: {
                        switch (hexCode)
                        {
                            // FLEURVILLE //
                            case "0BC373": CantonHandler(Ville.c_MontFleur); break;
                            case "EC2745": CantonHandler(Ville.c_Coeurville); break;
                            case "9A82F4": CantonHandler(Ville.c_Gloir); break;
                            case "CBFE39": CantonHandler(Ville.c_Imperial); break;
                            case "EA9B39": CantonHandler(Ville.c_Promission); break;
                            case "89FFFF": CantonHandler(Ville.c_Palefroi); break;

                            // COTIERVILLE //
                            case "0BEBA2": CantonHandler(Ville.c_Soleil); break;
                            case "F44173": CantonHandler(Ville.c_Couleur); break;
                            case "1837F7": CantonHandler(Ville.c_Castel); break;
                            case "F48F6E": CantonHandler(Ville.c_Chaleur); break;
                            case "08B67B": CantonHandler(Ville.c_Tropique); break;

                            // MONTVILLE //
                            case "1EF018": CantonHandler(Ville.c_Roquerie); break;
                            case "398DFF": CantonHandler(Ville.c_Ravinlis); break;
                            case "E11468": CantonHandler(Ville.c_Liberte); break;
                            case "81F4FF": CantonHandler(Ville.c_Brume); break;

                            // RIVIERVILLE //
                            case "9FFB0D": CantonHandler(Ville.c_Promontoire); break;
                            case "DB2815": CantonHandler(Ville.c_Oiselle); break;
                            case "9F7AEF": CantonHandler(Ville.c_Grace); break;
                            case "009600": CantonHandler(Ville.c_Parcville); break;

                            // BOISVILLE //
                            case "E72839": CantonHandler(Ville.c_Conte); break;
                            case "4FE67B": CantonHandler(Ville.c_Serein); break;
                            case "7B4AC9": CantonHandler(Ville.c_Versantvert); break;
                            case "3941FF": CantonHandler(Ville.c_Clemence); break;
                            case "E735FF": CantonHandler(Ville.c_Prestige); break;
                            case "C0FB00": CantonHandler(Ville.c_Occidental); break;

                            // MERVILLE //
                            case "FFF64A": CantonHandler(Ville.c_Lotus); break;
                            case "5899EF": CantonHandler(Ville.c_Zenith); break;
                            case "03B62E": CantonHandler(Ville.c_Vanille); break;
                            case "D96C8C": CantonHandler(Ville.c_Maritime); break;
                            case "4ACFD9": CantonHandler(Ville.c_Phare); break;
                        }
                        break;
                    }
                    case Mode.Villette: {
                        switch (hexCode)
                        {
                            case "FCFF84": VilletteHandler(Ville.v_Fleurville); break;
                            case "FF6C91": VilletteHandler(Ville.v_Cotierville); break;
                            case "84FF91": VilletteHandler(Ville.v_Montville); break;
                            case "94FF5A": VilletteHandler(Ville.v_Rivierville); break;
                            case "E77CFF": VilletteHandler(Ville.v_Boisville); break;
                            case "FFC16B": VilletteHandler(Ville.v_Merville); break;
                        }
                        break;
                    }
                    case Mode.Ville:
                        VillHandler();
                        break;
                }
            }
        }

        void QuartierHandler(Ville quartier)
        {
            DistrictData dat = DataVille.Information(quartier);

            int countResidents = 0;
            int countEmployes = 0;
            int emloyerGroupCounter = 0;
            int placeCounter = 0;

            bool employersExists = false;
            bool placeExists = false;


            foreach (HomeData home in dat.homeDataList)
            {
                int homeSize = 0;
                int homeCount = home.appartaments.Length;

                for (int i = 0; i < homeCount; i++)
                {
                    homeSize += home.appartaments[i];
                }

                countResidents += home.count * homeSize * appartamentHabitans;
            }

            foreach (EmployerType employers in allEmployerTypes)
            {
                int employerInGroup = Mathf.RoundToInt(dat.employersDataDictionary[employers] * employersPerUnit);

                if (employerInGroup > 0)
                {
                    countEmployes += employerInGroup;
                    objTextDraw.TextWrite(allEmployerNames[employers], employerInGroup.ToString(), 30f, 600f + 30f * emloyerGroupCounter, 12, Color.black);
                    emloyerGroupCounter++;

                    if (!employersExists)
                    {
                        employersExists = true;
                    }
                }
            }

            foreach (string objectName in dat.placeDataList)
            {
                objTextDraw.TextWrite(objectName, 400f, 450f + 25f * placeCounter, 10, Color.black);
                placeCounter++;

                if (!placeExists)
                {
                    placeExists = true;
                }
            }

            objTextDraw.TextWrite(dat.quartier, 30f, 50f, 20, Color.red);
            objTextDraw.TextWrite("Canton", dat.canton, 30f, 130f, 14, Color.red);
            objTextDraw.TextWrite("Villette", dat.villette, 30f, 180f, 14, Color.red);

            objTextDraw.TextWrite("COMMUNAUTÉ", 30f, 280f, 14, Color.red);
            objTextDraw.TextWrite("Résidents", countResidents.ToString(), 30f, 340f, 12, Color.black);
            objTextDraw.TextWrite("Employés", countEmployes.ToString(), 30f, 370f, 12, Color.black);
            objTextDraw.TextWrite("Superficie", dat.square.ToString(), 30f, 400f, 12, Color.black);
            objTextDraw.TextWrite("Densité repos", (Mathf.RoundToInt(countResidents / dat.square) * 100).ToString(), 30f, 430f, 12, Color.black);
            objTextDraw.TextWrite("Densité actif", (Mathf.RoundToInt((countEmployes + (countResidents / 2)) / dat.square) * 100).ToString(), 30f, 460f, 12, Color.black);
            objTextDraw.TextWrite("Député", Mathf.RoundToInt((countResidents + countEmployes) / (float)deputeDictictHabitans).ToString(), 30f, 490f, 12, Color.black);

            if (employersExists)
            {
                objTextDraw.TextWrite("EMPLOI", 30f, 550f, 14, Color.red);
            }

            if (placeExists)
            {
                objTextDraw.TextWrite("ESPACE PUBLIC", 400f, 400f, 12, Color.red);
            }
        }

        void CantonHandler(Ville canton)
        {
            int cantonIndex = (int)canton;
            int cantonNextIndex = cantonIndex + 10;

            string cantonName = "";
            string villetteName = "";

            float squareCanton = 0f;
            int countResidents = 0;
            int countEmployers = 0;
            int localDepute = 0;

            Dictionary<SocialState, int> residentsDictionary = new Dictionary<SocialState, int>();
            Dictionary<EmployerType, int> employersDictionary = new Dictionary<EmployerType, int>();

            int emloyerGroupCounter = 0;

            foreach (SocialState socialState in allSocialStates)
            {
                residentsDictionary.Add(socialState, 0);
            }

            foreach (EmployerType employerType in allEmployerTypes)
            {
                employersDictionary.Add(employerType, 0);
            }

            foreach (Ville quartier in allQuarties)
            {
                int quartierIndex = (int)quartier;

                if (quartierIndex > cantonIndex && quartierIndex < cantonNextIndex)
                {
                    DistrictData dat = DataVille.Information(quartier);

                    squareCanton += dat.square;

                    int quartierHabitans = 0;
                    int quartierEmployers = 0;

                    if (cantonName == "")
                    {
                        cantonName = dat.canton;
                        villetteName = dat.villette;
                    }

                    foreach (HomeData home in dat.homeDataList)
                    {
                        int homeSize = 0;
                        int homeCount = home.appartaments.Length;
                        int habitans = 0;

                        for (int i = 0; i < homeCount; i++)
                        {
                            homeSize += home.appartaments[i];
                        }

                        habitans = home.count * homeSize * appartamentHabitans;

                        residentsDictionary[home.social] += habitans;
                        countResidents += habitans;
                        quartierHabitans += habitans;
                    }

                    foreach (EmployerType employers in allEmployerTypes)
                    {
                        int employersInGroup = Mathf.RoundToInt(dat.employersDataDictionary[employers] * employersPerUnit);

                        if (employersInGroup > 0)
                        {
                            countEmployers += employersInGroup;
                            employersDictionary[employers] += employersInGroup;
                            quartierEmployers += employersInGroup;
                        }
                    }

                    localDepute += Mathf.RoundToInt((quartierHabitans + quartierEmployers) / (float)deputeDictictHabitans);
                }
            }

            objTextDraw.TextWrite(cantonName, 30f, 50f, 20, Color.red);
            objTextDraw.TextWrite("Villette", villetteName, 30f, 140f, 14, Color.red);

            objTextDraw.TextWrite("COMMUNAUTÉ", 30f, 280f, 14, Color.red);
            objTextDraw.TextWrite("Résidents", countResidents.ToString(), 30f, 340f, 12, Color.black);
            objTextDraw.TextWrite("Employés", countEmployers.ToString(), 30f, 370f, 12, Color.black);
            objTextDraw.TextWrite("Superficie", squareCanton.ToString(), 30f, 400f, 12, Color.black);
            objTextDraw.TextWrite("Densité repos", (Mathf.RoundToInt(countResidents / squareCanton) * 100).ToString(), 30f, 430f, 12, Color.black);
            objTextDraw.TextWrite("Densité actif", (Mathf.RoundToInt((countEmployers + (countResidents / 2)) / squareCanton) * 100).ToString(), 30f, 460f, 12, Color.black);
            objTextDraw.TextWrite("Député", localDepute.ToString(), 30f, 490f, 12, Color.black);

            objTextDraw.TextWrite("SOCIÉTÉ", 30f, 560f, 14, Color.red);
            objTextDraw.TextWrite("Ouvrier", residentsDictionary[SocialState.Worker].ToString(), 30f, 600f, 12, Color.black);
            objTextDraw.TextWrite("Spécialiste", residentsDictionary[SocialState.Specialist].ToString(), 30f, 630f, 12, Color.black);
            objTextDraw.TextWrite("Professionnel", residentsDictionary[SocialState.Professional].ToString(), 30f, 660f, 12, Color.black);
            objTextDraw.TextWrite("Responsable", residentsDictionary[SocialState.Responsible].ToString(), 30f, 690f, 12, Color.black);

            objTextDraw.TextWrite("EMPLOI", 400f, 280f, 14, Color.red);

            foreach (EmployerType employers in allEmployerTypes)
            {
                objTextDraw.TextWrite(allEmployerNames[employers], employersDictionary[employers].ToString(), 400f, 340f + 30f * emloyerGroupCounter, 12, Color.black);
                emloyerGroupCounter++;
            }
        }

        void VilletteHandler(Ville villette)
        {
            int villetteIndex = (int)villette;
            int villetteNextIndex = villetteIndex + 100;

            string villetteName = "";

            float squareVillette = 0f;
            int countResidents = 0;
            int countEmployers = 0;

            Dictionary<SocialState, int> residentsDictionary = new Dictionary<SocialState, int>();
            Dictionary<EmployerType, int> employersDictionary = new Dictionary<EmployerType, int>();

            int emloyerGroupCounter = 0;

            foreach (SocialState socialState in allSocialStates)
            {
                residentsDictionary.Add(socialState, 0);
            }

            foreach (EmployerType employerType in allEmployerTypes)
            {
                employersDictionary.Add(employerType, 0);
            }

            foreach (Ville quartier in allQuarties)
            {
                int quartierIndex = (int)quartier;

                if (quartierIndex > villetteIndex && quartierIndex < villetteNextIndex && quartierIndex % 10 != 0)
                {
                    DistrictData dat = DataVille.Information(quartier);

                    squareVillette += dat.square;

                    if (villetteName == "")
                    {
                        villetteName = dat.villette;
                    }

                    foreach (HomeData home in dat.homeDataList)
                    {
                        int homeSize = 0;
                        int homeCount = home.appartaments.Length;
                        int habitans = 0;

                        for (int i = 0; i < homeCount; i++)
                        {
                            homeSize += home.appartaments[i];
                        }

                        habitans = home.count * homeSize * appartamentHabitans;

                        residentsDictionary[home.social] += habitans;
                        countResidents += habitans;
                    }

                    foreach (EmployerType employers in allEmployerTypes)
                    {
                        int employersInGroup = Mathf.RoundToInt(dat.employersDataDictionary[employers] * employersPerUnit);

                        if (employersInGroup > 0)
                        {
                            countEmployers += employersInGroup;
                            employersDictionary[employers] += employersInGroup;
                        }
                    }
                }
            }

            objTextDraw.TextWrite(villetteName, 30f, 50f, 20, Color.red);

            objTextDraw.TextWrite("COMMUNAUTÉ", 30f, 280f, 14, Color.red);
            objTextDraw.TextWrite("Résidents", countResidents.ToString(), 30f, 340f, 12, Color.black);
            objTextDraw.TextWrite("Employés", countEmployers.ToString(), 30f, 370f, 12, Color.black);
            objTextDraw.TextWrite("Superficie", squareVillette.ToString(), 30f, 400f, 12, Color.black);
            objTextDraw.TextWrite("Densité repos", (Mathf.RoundToInt(countResidents / squareVillette) * 100).ToString(), 30f, 430f, 12, Color.black);
            objTextDraw.TextWrite("Densité actif", (Mathf.RoundToInt((countEmployers + (countResidents / 2)) / squareVillette) * 100).ToString(), 30f, 460f, 12, Color.black);

            objTextDraw.TextWrite("SOCIÉTÉ", 30f, 560f, 14, Color.red);
            objTextDraw.TextWrite("Ouvrier", residentsDictionary[SocialState.Worker].ToString(), 30f, 620f, 12, Color.black);
            objTextDraw.TextWrite("Spécialiste", residentsDictionary[SocialState.Specialist].ToString(), 30f, 650f, 12, Color.black);
            objTextDraw.TextWrite("Professionnel", residentsDictionary[SocialState.Professional].ToString(), 30f, 680f, 12, Color.black);
            objTextDraw.TextWrite("Responsable", residentsDictionary[SocialState.Responsible].ToString(), 30f, 710f, 12, Color.black);

            objTextDraw.TextWrite("EMPLOI", 400f, 280f, 14, Color.red);

            foreach (EmployerType employers in allEmployerTypes)
            {
                objTextDraw.TextWrite(allEmployerNames[employers], employersDictionary[employers].ToString(), 400f, 340f + 30f * emloyerGroupCounter, 12, Color.black);
                emloyerGroupCounter++;
            }
        }

        void VillHandler()
        {
            float squareVille = 0f;
            int countResidents = 0;
            int countEmployers = 0;

            Dictionary<SocialState, int> residentsDictionary = new Dictionary<SocialState, int>();
            Dictionary<EmployerType, int> employersDictionary = new Dictionary<EmployerType, int>();

            int emloyerGroupCounter = 0;

            foreach (SocialState socialState in allSocialStates)
            {
                residentsDictionary.Add(socialState, 0);
            }

            foreach (EmployerType employerType in allEmployerTypes)
            {
                employersDictionary.Add(employerType, 0);
            }

            foreach (Ville quartier in allQuarties)
            {
                if ((int)quartier % 10 != 0)
                {
                    DistrictData dat = DataVille.Information(quartier);

                    squareVille += dat.square;

                    foreach (HomeData home in dat.homeDataList)
                    {
                        int homeSize = 0;
                        int homeCount = home.appartaments.Length;
                        int habitans = 0;

                        for (int i = 0; i < homeCount; i++)
                        {
                            homeSize += home.appartaments[i];
                        }

                        habitans = home.count * homeSize * appartamentHabitans;

                        residentsDictionary[home.social] += habitans;
                        countResidents += habitans;
                    }

                    foreach (EmployerType employers in allEmployerTypes)
                    {
                        int employersInGroup = Mathf.RoundToInt(dat.employersDataDictionary[employers] * employersPerUnit);

                        if (employersInGroup > 0)
                        {
                            countEmployers += employersInGroup;
                            employersDictionary[employers] += employersInGroup;
                        }
                    }
                }
            }

            objTextDraw.TextWrite("PARADISE", 30f, 50f, 20, Color.red);

            objTextDraw.TextWrite("COMMUNAUTÉ", 30f, 280f, 14, Color.red);
            objTextDraw.TextWrite("Résidents", countResidents.ToString(), 30f, 340f, 12, Color.black);
            objTextDraw.TextWrite("Employés", countEmployers.ToString(), 30f, 370f, 12, Color.black);
            objTextDraw.TextWrite("Superficie", squareVille.ToString(), 30f, 400f, 12, Color.black);
            objTextDraw.TextWrite("Densité repos", (Mathf.RoundToInt(countResidents / squareVille) * 100).ToString(), 30f, 430f, 12, Color.black);
            objTextDraw.TextWrite("Densité actif", (Mathf.RoundToInt((countEmployers + (countResidents / 2)) / squareVille) * 100).ToString(), 30f, 460f, 12, Color.black);

            objTextDraw.TextWrite("SOCIÉTÉ", 30f, 560f, 14, Color.red);
            objTextDraw.TextWrite("Ouvrier", residentsDictionary[SocialState.Worker].ToString(), 30f, 620f, 12, Color.black);
            objTextDraw.TextWrite("Spécialiste", residentsDictionary[SocialState.Specialist].ToString(), 30f, 650f, 12, Color.black);
            objTextDraw.TextWrite("Professionnel", residentsDictionary[SocialState.Professional].ToString(), 30f, 680f, 12, Color.black);
            objTextDraw.TextWrite("Responsable", residentsDictionary[SocialState.Responsible].ToString(), 30f, 710f, 12, Color.black);

            objTextDraw.TextWrite("EMPLOI", 400f, 280f, 14, Color.red);

            foreach (EmployerType employers in allEmployerTypes)
            {
                objTextDraw.TextWrite(allEmployerNames[employers], employersDictionary[employers].ToString(), 400f, 340f + 30f * emloyerGroupCounter, 12, Color.black);
                emloyerGroupCounter++;
            }
        }
    }
}
