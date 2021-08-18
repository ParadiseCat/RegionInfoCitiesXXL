using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

namespace ParadiseVille
{
    /// <summary>
    /// Handler data info for it input in Game as text
    /// </summary>
    public class DataHandler
    {
        TextDraw objTextDraw;

        const int appartamentHabitans = 2;
        const int deputeDictictHabitans = 500;
        const float employersPerUnit = 5.41f;

        string hexColor = "";
        Mode mapMode;

        List<EmployerType> allEmployerTypes;
        List<SocialState> allSocialStates;
        List<Ville> allQuarties;

        public DataHandler(Mode modeDefault)
        {
            objTextDraw = new TextDraw();
            allEmployerTypes = Enum.GetValues(typeof(EmployerType)).Cast<EmployerType>().ToList();
            allSocialStates = Enum.GetValues(typeof(SocialState)).Cast<SocialState>().ToList();
            allQuarties = Enum.GetValues(typeof(Ville)).Cast<Ville>().ToList();

            mapMode = modeDefault;
        }

        public void ResetData()
        {
            objTextDraw.TextClean();
            objTextDraw.TextWrite("PARADISE", 30f, 50f, 60, Color.red);
        }

        public void ShowData(Mode mode, string hexCode, bool reset)
        {
            if (hexColor != hexCode || mapMode != mode || reset)
            {
                hexColor = hexCode;
                mapMode = mode;

                switch (mode)
                {
                    case Mode.Quartier: {
                        switch (hexCode)
                        {
                            // *** FLEURVILLE *** //
                            // --- Montfleur --- //
                            case "B6FF00": QuartierHandler(Ville.q_Jardinfleuri); break;
                            case "00FF32": QuartierHandler(Ville.q_Ilechateau); break;
                            case "0BC274": QuartierHandler(Ville.q_Roifrenaie); break;
                            case "46FF00": QuartierHandler(Ville.q_Cotelevant); break;
                            // --- Coeurville --- //
                            case "FF0000": QuartierHandler(Ville.q_Hotel); break;
                            case "FF7F92": QuartierHandler(Ville.q_Riveciel); break;
                            case "ED2644": QuartierHandler(Ville.q_Eclaires); break;
                            // --- Gloir --- //
                            case "6127E8": QuartierHandler(Ville.q_Hallesluxe); break;
                            case "9A81F4": QuartierHandler(Ville.q_Aquarelle); break;
                            case "AB0CF4": QuartierHandler(Ville.q_Promenade); break;
                            // --- Imperial --- //
                            case "6FF91F": QuartierHandler(Ville.q_Idylle); break;
                            case "CAFD38": QuartierHandler(Ville.q_Anthese); break;
                            // --- Promission --- //
                            case "E99B3A": QuartierHandler(Ville.q_Perpetuel); break;
                            case "F8C227": QuartierHandler(Ville.q_Sabbat); break;
                            // --- Palefroi --- //
                            case "8AFFFF": QuartierHandler(Ville.q_Victoire); break;
                            case "7F96FF": QuartierHandler(Ville.q_Lumiere); break;
                            case "3DAEFF": QuartierHandler(Ville.q_Iris); break;
                            case "1462C1": QuartierHandler(Ville.q_Sophora); break;

                            // *** COTIERVILLE *** //
                            // --- Soleil --- //
                            case "0BEAA3": QuartierHandler(Ville.q_Charme); break;
                            case "9BEF13": QuartierHandler(Ville.q_Cotecorail); break;
                            case "00A600": QuartierHandler(Ville.q_Artisan); break;
                            // --- Couleur --- //
                            case "F40DB8": QuartierHandler(Ville.q_Chandelle); break;
                            case "D50CC6": QuartierHandler(Ville.q_Parfumeur); break;
                            case "F44174": QuartierHandler(Ville.q_Gremil); break;
                            case "E4421D": QuartierHandler(Ville.q_Hulotte); break;
                            // --- Castel --- //
                            case "18A7CD": QuartierHandler(Ville.q_Prosperite); break;
                            case "1837F8": QuartierHandler(Ville.q_Pastel); break;
                            case "843EEE": QuartierHandler(Ville.q_Sansonnet); break;
                            // --- Chaleur --- //
                            case "F22E62": QuartierHandler(Ville.q_Cotepalmier); break;
                            case "F48F6E": QuartierHandler(Ville.q_Cotecafe); break;
                            case "F8DF31": QuartierHandler(Ville.q_Brise); break;
                            // --- Tropique --- //
                            case "7CF008": QuartierHandler(Ville.q_Tadorne); break;
                            case "21F90B": QuartierHandler(Ville.q_Cocotier); break;
                            case "07B67C": QuartierHandler(Ville.q_Montfee); break;

                            // *** MONTVILLE *** //
                            // --- Roquerie --- //
                            case "52EC1C": QuartierHandler(Ville.q_Nichoir); break;
                            case "04D123": QuartierHandler(Ville.q_Horizon); break;
                            case "1CEC7C": QuartierHandler(Ville.q_Genievre); break;
                            // --- Ravinlis --- //
                            case "6574BA": QuartierHandler(Ville.q_Paysage); break;
                            case "1137EB": QuartierHandler(Ville.q_Croissance); break;
                            case "3A8CFF": QuartierHandler(Ville.q_Tilleul); break;
                            case "5B9BFF": QuartierHandler(Ville.q_Trefleblue); break;
                            // --- Liberte --- //
                            case "DE664A": QuartierHandler(Ville.q_Enchanteur); break;
                            case "E01469": QuartierHandler(Ville.q_Sublimite); break;
                            // --- Brume --- //
                            case "6171C9": QuartierHandler(Ville.q_Tulipier); break;
                            case "82F4FF": QuartierHandler(Ville.q_Montpistache); break;
                            case "3AB6EC": QuartierHandler(Ville.q_Accalmie); break;

                            // *** RIVIERVILLE *** //
                            // --- Promontoire --- //
                            case "0FC42A": QuartierHandler(Ville.q_Mielfaine); break;
                            case "08D1B2": QuartierHandler(Ville.q_Boishetre); break;
                            case "9FFB0C": QuartierHandler(Ville.q_Blancheur); break;
                            // --- Oiselle --- //
                            case "DB2714": QuartierHandler(Ville.q_Cheveche); break;
                            case "F48810": QuartierHandler(Ville.q_Perroquet); break;
                            // --- Grace --- //
                            case "9E7AEF": QuartierHandler(Ville.q_Charite); break;
                            case "4AD9F8": QuartierHandler(Ville.q_Aronde); break;
                            case "3A69F1": QuartierHandler(Ville.q_Palaisreine); break;
                            // --- Parcville --- //
                            case "019600": QuartierHandler(Ville.q_Parcoiseau); break;

                            // *** BOISVILLE *** //
                            // --- Conte --- //
                            case "E8273A": QuartierHandler(Ville.q_Nectar); break;
                            case "E849BA": QuartierHandler(Ville.q_Lambruche); break;
                            // --- Serein --- //
                            case "50E57A": QuartierHandler(Ville.q_Accord); break;
                            // --- Versantvert --- //
                            case "1753D6": QuartierHandler(Ville.q_Pivoine); break;
                            case "7C4AC9": QuartierHandler(Ville.q_Peinardise); break;
                            // --- Clemence -- //
                            case "3A41FF": QuartierHandler(Ville.q_Purete); break;
                            case "2FDDF9": QuartierHandler(Ville.q_Renardeau); break;
                            case "4FA4F9": QuartierHandler(Ville.q_Ormaie); break;
                            // --- Prestige --- //
                            case "E835FF": QuartierHandler(Ville.q_Comtefleur); break;
                            case "F43E69": QuartierHandler(Ville.q_Licorne); break;
                            case "F0B9C8": QuartierHandler(Ville.q_Gare); break;
                            // --- Occidental --- //
                            case "C0FA00": QuartierHandler(Ville.q_Bruyere); break;

                            // *** MERVILLE *** //
                            // --- Lotus --- //
                            case "E8372F": QuartierHandler(Ville.q_Interfluve); break;
                            case "FFF549": QuartierHandler(Ville.q_Orchidee); break;
                            case "EC7C10": QuartierHandler(Ville.q_Cygneblanch); break;
                            // --- Zenith --- //
                            case "5898EE": QuartierHandler(Ville.q_Aber); break;
                            case "333AE8": QuartierHandler(Ville.q_Suavite); break;
                            case "9B55E8": QuartierHandler(Ville.q_Suffle); break;
                            case "1C74F0": QuartierHandler(Ville.q_Harmonie); break;
                            // --- Vanille --- //
                            case "59F02F": QuartierHandler(Ville.q_Cedres); break;
                            case "03B62F": QuartierHandler(Ville.q_Gattilier); break;
                            // --- Maritime --- //
                            case "E12FC2": QuartierHandler(Ville.q_Littoral); break;
                            case "E99F2B": QuartierHandler(Ville.q_Coquille); break;
                            case "D96B8B": QuartierHandler(Ville.q_Goeland); break;
                            // --- Phare --- //
                            case "49CFD8": QuartierHandler(Ville.q_Tissage); break;
                            case "93E814": QuartierHandler(Ville.q_Port); break;
                        }
                        break;
                    }
                    case Mode.Canton: {
                        switch (hexCode)
                        {
                            // FLEURVILLE //
                            case "0BC274": CantonHandler(Ville.c_MontFleur); break;
                            case "ED2644": CantonHandler(Ville.c_Coeurville); break;
                            case "9A81F4": CantonHandler(Ville.c_Gloir); break;
                            case "CAFD38": CantonHandler(Ville.c_Imperial); break;
                            case "E99B3A": CantonHandler(Ville.c_Promission); break;
                            case "8AFFFF": CantonHandler(Ville.c_Palefroi); break;

                            // COTIERVILLE //
                            case "0BEAA3": CantonHandler(Ville.c_Soleil); break;
                            case "F44174": CantonHandler(Ville.c_Couleur); break;
                            case "1837F8": CantonHandler(Ville.c_Castel); break;
                            case "F48F6E": CantonHandler(Ville.c_Chaleur); break;
                            case "07B67C": CantonHandler(Ville.c_Tropique); break;

                            // MONTVILLE //
                            case "1FF018": CantonHandler(Ville.c_Roquerie); break;
                            case "3A8CFF": CantonHandler(Ville.c_Ravinlis); break;
                            case "E01469": CantonHandler(Ville.c_Liberte); break;
                            case "82F4FF": CantonHandler(Ville.c_Brume); break;

                            // RIVIERVILLE //
                            case "9FFB0C": CantonHandler(Ville.c_Promontoire); break;
                            case "DB2714": CantonHandler(Ville.c_Oiselle); break;
                            case "9E7AEF": CantonHandler(Ville.c_Grace); break;
                            case "019600": CantonHandler(Ville.c_Parcville); break;

                            // BOISVILLE //
                            case "E8273A": CantonHandler(Ville.c_Conte); break;
                            case "50E57A": CantonHandler(Ville.c_Serein); break;
                            case "7C4AC9": CantonHandler(Ville.c_Versantvert); break;
                            case "3A41FF": CantonHandler(Ville.c_Clemence); break;
                            case "E835FF": CantonHandler(Ville.c_Prestige); break;
                            case "C0FA00": CantonHandler(Ville.c_Occidental); break;

                            // MERVILLE //
                            case "FFF549": CantonHandler(Ville.c_Lotus); break;
                            case "5898EE": CantonHandler(Ville.c_Zenith); break;
                            case "03B62F": CantonHandler(Ville.c_Vanille); break;
                            case "D96B8B": CantonHandler(Ville.c_Maritime); break;
                            case "49CFD8": CantonHandler(Ville.c_Phare); break;
                        }
                        break;
                    }
                    case Mode.Villette: {
                        switch (hexCode)
                        {
                            case "FCFF84": VilletteHandler(Ville.v_Fleurville); break;
                            case "FF6B90": VilletteHandler(Ville.v_Cotierville); break;
                            case "7AFFB6": VilletteHandler(Ville.v_Montville); break;
                            case "94FF5B": VilletteHandler(Ville.v_Rivierville); break;
                            case "E77CFF": VilletteHandler(Ville.v_Boisville); break;
                            case "FFC16B": VilletteHandler(Ville.v_Merville); break;
                        }
                        break;
                    }
                    case Mode.Ville: {
                        VillHandler();
                        break;
                    }
                }
            }
        }

        void QuartierHandler(Ville quartier)
        {
            objTextDraw.TextClean();

            DistrictData dat = DataVille.Information(quartier);

            Dictionary<EmployerType, string> allEmployerNames = new Dictionary<EmployerType, string>();

            int countResidents = 0;
            int countEmployes = 0;
            int emloyerGroupCounter = 0;
            int placeCounter = 0;

            bool employersExists = false;
            bool placeExists = false;

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
                    objTextDraw.TextWrite(allEmployerNames[employers], employerInGroup.ToString(), 30f, 600f + 30f * emloyerGroupCounter, 25, Color.black);
                    emloyerGroupCounter++;

                    if (!employersExists)
                    {
                        employersExists = true;
                    }
                }
            }

            foreach (string objectName in dat.placeDataList)
            {
                objTextDraw.TextWrite(objectName, 400f, 340f + 30f * placeCounter, 25, Color.black);
                placeCounter++;

                if (!placeExists)
                {
                    placeExists = true;
                }
            }

            objTextDraw.TextWrite(dat.quartier, 30f, 50f, 60, Color.red);
            objTextDraw.TextWrite("Canton", dat.canton, 30f, 130f, 40, Color.red);
            objTextDraw.TextWrite("Villette", dat.villette, 30f, 180f, 40, Color.red);

            objTextDraw.TextWrite("COMMUNAUTÉ", 30f, 280f, 40, Color.red);
            objTextDraw.TextWrite("Résidents", countResidents.ToString(), 30f, 340f, 25, Color.black);
            objTextDraw.TextWrite("Employés", countEmployes.ToString(), 30f, 370f, 25, Color.black);
            objTextDraw.TextWrite("Superficie", dat.square.ToString(), 30f, 400f, 25, Color.black);
            objTextDraw.TextWrite("Densité repos", (Mathf.RoundToInt(countResidents / dat.square) * 100).ToString(), 30f, 430f, 25, Color.black);
            objTextDraw.TextWrite("Densité actif", (Mathf.RoundToInt((countEmployes + (countResidents / 2)) / dat.square) * 100).ToString(), 30f, 460f, 25, Color.black);
            objTextDraw.TextWrite("Député", Mathf.RoundToInt((countResidents + countEmployes) / (float)deputeDictictHabitans).ToString(), 30f, 490f, 25, Color.black);

            if (employersExists)
            {
                objTextDraw.TextWrite("EMPLOI", 30f, 550f, 40, Color.red);
            }

            if (placeExists)
            {
                objTextDraw.TextWrite("ESPACE PUBLIC", 400f, 280f, 40, Color.red);
            }
        }

        void CantonHandler(Ville canton)
        {
            objTextDraw.TextClean();

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

            squareCanton = Mathf.Round(squareCanton * 10f) / 10f;

            objTextDraw.TextWrite(cantonName, 30f, 50f, 60, Color.red);
            objTextDraw.TextWrite("Villette", villetteName, 30f, 140f, 40, Color.red);

            objTextDraw.TextWrite("COMMUNAUTÉ", 30f, 280f, 40, Color.red);
            objTextDraw.TextWrite("Résidents", countResidents.ToString(), 30f, 340f, 25, Color.black);
            objTextDraw.TextWrite("Employés", countEmployers.ToString(), 30f, 370f, 25, Color.black);
            objTextDraw.TextWrite("Superficie", squareCanton.ToString(), 30f, 400f, 25, Color.black);
            objTextDraw.TextWrite("Densité repos", (Mathf.RoundToInt(countResidents / squareCanton) * 100).ToString(), 30f, 430f, 25, Color.black);
            objTextDraw.TextWrite("Densité actif", (Mathf.RoundToInt((countEmployers + (countResidents / 2)) / squareCanton) * 100).ToString(), 30f, 460f, 25, Color.black);
            objTextDraw.TextWrite("Député", localDepute.ToString(), 30f, 490f, 25, Color.black);

            int[] social = new int[4]
            {
                residentsDictionary[SocialState.Worker],
                residentsDictionary[SocialState.Specialist],
                residentsDictionary[SocialState.Professional],
                residentsDictionary[SocialState.Responsible]
            };

            int[] socialPercent = PercentValuesGet(countResidents, social);

            objTextDraw.TextWrite("SOCIÉTÉ", 30f, 560f, 40, Color.red);
            objTextDraw.TextWrite("Ouvrier", social[0].ToString(), socialPercent[0], 30f, 600f, 25, Color.black);
            objTextDraw.TextWrite("Spécialiste", social[1].ToString(), socialPercent[1], 30f, 630f, 25, Color.black);
            objTextDraw.TextWrite("Professionnel", social[2].ToString(), socialPercent[2], 30f, 660f, 25, Color.black);
            objTextDraw.TextWrite("Responsable", social[3].ToString(), socialPercent[3], 30f, 690f, 25, Color.black);

            int[] employ = new int[10]
            {
                employersDictionary[EmployerType.Production],
                employersDictionary[EmployerType.Office],
                employersDictionary[EmployerType.Trade],
                employersDictionary[EmployerType.Culture],
                employersDictionary[EmployerType.Hotel],
                employersDictionary[EmployerType.Education],
                employersDictionary[EmployerType.Medicine],
                employersDictionary[EmployerType.Services],
                employersDictionary[EmployerType.Sport],
                employersDictionary[EmployerType.Administration]
            };

            int[] employPercent = PercentValuesGet(countEmployers, employ);

            objTextDraw.TextWrite("EMPLOI", 400f, 280f, 40, Color.red);
            objTextDraw.TextWrite("Production", employ[0].ToString(), employPercent[0], 400f, 340f, 25, Color.black);
            objTextDraw.TextWrite("Office", employ[1].ToString(), employPercent[1], 400f, 370f, 25, Color.black);
            objTextDraw.TextWrite("Trade", employ[2].ToString(), employPercent[2], 400f, 400f, 25, Color.black);
            objTextDraw.TextWrite("Culture", employ[3].ToString(), employPercent[3], 400f, 430f, 25, Color.black);
            objTextDraw.TextWrite("Hotel", employ[4].ToString(), employPercent[4], 400f, 460f, 25, Color.black);
            objTextDraw.TextWrite("Education", employ[5].ToString(), employPercent[5], 400f, 490f, 25, Color.black);
            objTextDraw.TextWrite("Medicine", employ[6].ToString(), employPercent[6], 400f, 520f, 25, Color.black);
            objTextDraw.TextWrite("Services", employ[7].ToString(), employPercent[7], 400f, 550f, 25, Color.black);
            objTextDraw.TextWrite("Sport", employ[8].ToString(), employPercent[8], 400f, 580f, 25, Color.black);
            objTextDraw.TextWrite("Administration", employ[9].ToString(), employPercent[9], 400f, 610f, 25, Color.black);
        }

        void VilletteHandler(Ville villette)
        {
            objTextDraw.TextClean();

            int villetteIndex = (int)villette;
            int villetteNextIndex = villetteIndex + 100;

            string villetteName = "";

            float squareVillette = 0f;
            int countResidents = 0;
            int countEmployers = 0;
            int localDepute = 0;

            Dictionary<SocialState, int> residentsDictionary = new Dictionary<SocialState, int>();
            Dictionary<EmployerType, int> employersDictionary = new Dictionary<EmployerType, int>();

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

                    int quartierHabitans = 0;
                    int quartierEmployers = 0;

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

            squareVillette = Mathf.Round(squareVillette * 10f) / 10f;

            objTextDraw.TextWrite(villetteName, 30f, 50f, 60, Color.red);

            objTextDraw.TextWrite("COMMUNAUTÉ", 30f, 280f, 40, Color.red);
            objTextDraw.TextWrite("Résidents", countResidents.ToString(), 30f, 340f, 25, Color.black);
            objTextDraw.TextWrite("Employés", countEmployers.ToString(), 30f, 370f, 25, Color.black);
            objTextDraw.TextWrite("Superficie", squareVillette.ToString(), 30f, 400f, 25, Color.black);
            objTextDraw.TextWrite("Densité repos", (Mathf.RoundToInt(countResidents / squareVillette) * 100).ToString(), 30f, 430f, 25, Color.black);
            objTextDraw.TextWrite("Densité actif", (Mathf.RoundToInt((countEmployers + (countResidents / 2)) / squareVillette) * 100).ToString(), 30f, 460f, 25, Color.black);
            objTextDraw.TextWrite("Député", localDepute.ToString(), 30f, 490f, 25, Color.black);

            int[] social = new int[4]
            {
                residentsDictionary[SocialState.Worker],
                residentsDictionary[SocialState.Specialist],
                residentsDictionary[SocialState.Professional],
                residentsDictionary[SocialState.Responsible]
            };

            int[] socialPercent = PercentValuesGet(countResidents, social);

            objTextDraw.TextWrite("SOCIÉTÉ", 30f, 560f, 40, Color.red);
            objTextDraw.TextWrite("Ouvrier", social[0].ToString(), socialPercent[0], 30f, 620f, 25, Color.black);
            objTextDraw.TextWrite("Spécialiste", social[1].ToString(), socialPercent[1], 30f, 650f, 25, Color.black);
            objTextDraw.TextWrite("Professionnel", social[2].ToString(), socialPercent[2], 30f, 680f, 25, Color.black);
            objTextDraw.TextWrite("Responsable", social[3].ToString(), socialPercent[3], 30f, 710f, 25, Color.black);

            int[] employ = new int[10]
            {
                employersDictionary[EmployerType.Production],
                employersDictionary[EmployerType.Office],
                employersDictionary[EmployerType.Trade],
                employersDictionary[EmployerType.Culture],
                employersDictionary[EmployerType.Hotel],
                employersDictionary[EmployerType.Education],
                employersDictionary[EmployerType.Medicine],
                employersDictionary[EmployerType.Services],
                employersDictionary[EmployerType.Sport],
                employersDictionary[EmployerType.Administration]
            };

            int[] employPercent = PercentValuesGet(countEmployers, employ);

            objTextDraw.TextWrite("EMPLOI", 400f, 280f, 40, Color.red);
            objTextDraw.TextWrite("Production", employ[0].ToString(), employPercent[0], 400f, 340f, 25, Color.black);
            objTextDraw.TextWrite("Office", employ[1].ToString(), employPercent[1], 400f, 370f, 25, Color.black);
            objTextDraw.TextWrite("Trade", employ[2].ToString(), employPercent[2], 400f, 400f, 25, Color.black);
            objTextDraw.TextWrite("Culture", employ[3].ToString(), employPercent[3], 400f, 430f, 25, Color.black);
            objTextDraw.TextWrite("Hotel", employ[4].ToString(), employPercent[4], 400f, 460f, 25, Color.black);
            objTextDraw.TextWrite("Education", employ[5].ToString(), employPercent[5], 400f, 490f, 25, Color.black);
            objTextDraw.TextWrite("Medicine", employ[6].ToString(), employPercent[6], 400f, 520f, 25, Color.black);
            objTextDraw.TextWrite("Services", employ[7].ToString(), employPercent[7], 400f, 550f, 25, Color.black);
            objTextDraw.TextWrite("Sport", employ[8].ToString(), employPercent[8], 400f, 580f, 25, Color.black);
            objTextDraw.TextWrite("Administration", employ[9].ToString(), employPercent[9], 400f, 610f, 25, Color.black);
        }

        void VillHandler()
        {
            objTextDraw.TextClean();

            float squareVille = 0f;
            int countResidents = 0;
            int countEmployers = 0;
            int localDepute = 0;

            Dictionary<SocialState, int> residentsDictionary = new Dictionary<SocialState, int>();
            Dictionary<EmployerType, int> employersDictionary = new Dictionary<EmployerType, int>();

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

                    int quartierHabitans = 0;
                    int quartierEmployers = 0;

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

            squareVille = Mathf.Round(squareVille * 10f) / 10f;

            objTextDraw.TextWrite("PARADISE", 30f, 50f, 60, Color.red);

            objTextDraw.TextWrite("COMMUNAUTÉ", 30f, 280f, 40, Color.red);
            objTextDraw.TextWrite("Résidents", countResidents.ToString(), 30f, 340f, 25, Color.black);
            objTextDraw.TextWrite("Employés", countEmployers.ToString(), 30f, 370f, 25, Color.black);
            objTextDraw.TextWrite("Superficie", squareVille.ToString(), 30f, 400f, 25, Color.black);
            objTextDraw.TextWrite("Densité repos", (Mathf.RoundToInt(countResidents / squareVille) * 100).ToString(), 30f, 430f, 25, Color.black);
            objTextDraw.TextWrite("Densité actif", (Mathf.RoundToInt((countEmployers + (countResidents / 2)) / squareVille) * 100).ToString(), 30f, 460f, 25, Color.black);
            objTextDraw.TextWrite("Député", localDepute.ToString(), 30f, 490f, 25, Color.black);

            int[] social = new int[4]
            {
                residentsDictionary[SocialState.Worker],
                residentsDictionary[SocialState.Specialist],
                residentsDictionary[SocialState.Professional],
                residentsDictionary[SocialState.Responsible]
            };

            int[] socialPercent = PercentValuesGet(countResidents, social);

            objTextDraw.TextWrite("SOCIÉTÉ", 30f, 560f, 40, Color.red);
            objTextDraw.TextWrite("Ouvrier", social[0].ToString(), socialPercent[0], 30f, 620f, 25, Color.black);
            objTextDraw.TextWrite("Spécialiste", social[1].ToString(), socialPercent[1], 30f, 650f, 25, Color.black);
            objTextDraw.TextWrite("Professionnel", social[2].ToString(), socialPercent[2], 30f, 680f, 25, Color.black);
            objTextDraw.TextWrite("Responsable", social[3].ToString(), socialPercent[3], 30f, 710f, 25, Color.black);

            int[] employ = new int[10]
            {
                employersDictionary[EmployerType.Production],
                employersDictionary[EmployerType.Office],
                employersDictionary[EmployerType.Trade],
                employersDictionary[EmployerType.Culture],
                employersDictionary[EmployerType.Hotel],
                employersDictionary[EmployerType.Education],
                employersDictionary[EmployerType.Medicine],
                employersDictionary[EmployerType.Services],
                employersDictionary[EmployerType.Sport],
                employersDictionary[EmployerType.Administration]
            };

            int[] employPercent = PercentValuesGet(countEmployers, employ);

            objTextDraw.TextWrite("EMPLOI", 400f, 280f, 40, Color.red);
            objTextDraw.TextWrite("Production", employ[0].ToString(), employPercent[0], 400f, 340f, 25, Color.black);
            objTextDraw.TextWrite("Office", employ[1].ToString(), employPercent[1], 400f, 370f, 25, Color.black);
            objTextDraw.TextWrite("Trade", employ[2].ToString(), employPercent[2], 400f, 400f, 25, Color.black);
            objTextDraw.TextWrite("Culture", employ[3].ToString(), employPercent[3], 400f, 430f, 25, Color.black);
            objTextDraw.TextWrite("Hotel", employ[4].ToString(), employPercent[4], 400f, 460f, 25, Color.black);
            objTextDraw.TextWrite("Education", employ[5].ToString(), employPercent[5], 400f, 490f, 25, Color.black);
            objTextDraw.TextWrite("Medicine", employ[6].ToString(), employPercent[6], 400f, 520f, 25, Color.black);
            objTextDraw.TextWrite("Services", employ[7].ToString(), employPercent[7], 400f, 550f, 25, Color.black);
            objTextDraw.TextWrite("Sport", employ[8].ToString(), employPercent[8], 400f, 580f, 25, Color.black);
            objTextDraw.TextWrite("Administration", employ[9].ToString(), employPercent[9], 400f, 610f, 25, Color.black);
        }

        private int[] PercentValuesGet(int total, params int[] dataArray)
        {
            int arrLength = dataArray.Length;
            int percentTotal = 100;

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
                        arrPercents[i] = Mathf.RoundToInt(dataArray[i] / (float)total * percentTotal);
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

                        if(loop >= 10)
                        {
                            Debug.Log("error cycle while");
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

            foreach (Ville quartier in allQuarties)
            {
                if ((int)quartier % 10 != 0 /*&& (int)quartier < 200*/)
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

                    foreach (EmployerType employers in allEmployerTypes)
                    {
                        workPlaceUnit += dat.employersDataDictionary[employers];
                    }
                }
            }

            Debug.Log("count = " + employersCount.ToString() 
                + " unit = " + employersUnit.ToString()
                + " work unit = " + workPlaceUnit.ToString() 
                + " work places = " + (workPlaceUnit / (float)employersUnit).ToString()
                + " employers per unit = " + (employersCount / (float)employersUnit).ToString());
        }
    }
}
