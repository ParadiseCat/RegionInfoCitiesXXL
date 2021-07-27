using UnityEngine;

namespace ParadiseVille
{
    public class CityData 
    {
        public string str_id = " ";
        public string quartier = " ";
        public string canton = " ";
        public string villette = " ";
        public string str_residents = " ";
        public string str_employ = " ";
        public string str_superf = " ";
        public string str_denct = " ";
        public string str_denstwork = " ";
        public string str_deputat = " ";

        public string[] maisons = new string[7] { " ", " ", " ", " ", " ", " ", " " };
        public string[] place = new string[14] { " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };
        public string[] employe;

        int id = 0;
        int employ = 0;
        int id_res = 0;
        int residents = 0;
        float superficie = 0;

        int production = 0;
        int office = 0;
        int trade = 0;
        int culture = 0;
        int hotel = 0;
        int education = 0;
        int medicine = 0;
        int services = 0;
        int sport = 0;
        int administration = 0;

        const float emp_index = 5.5f;
        const float deputat_district = 500;

        public CityData(Mode mode, string code)
        {
            switch (mode)
            {
                case Mode.Quartier: GetDataQuartier(code); break;
                case Mode.Canton: GetDataCanton(code); break;
                case Mode.Ville: GetDataVille(code); break;
            }

            employe = WorkersSet();
            str_id = id.ToString();
            str_residents = residents.ToString();
            str_employ = employ.ToString();
            str_superf = superficie.ToString();
            str_denct = ((int)(residents / superficie) * 100).ToString();
            str_denstwork = ((int)((employ + (residents / 2)) / superficie) * 100).ToString();
            str_deputat = Mathf.RoundToInt((residents + employ) / deputat_district).ToString();
        }

        void GetDataQuartier(string code)
        {
            switch (code)
            {
                case "B5FF00":
                    {
                        id = 111;
                        quartier = "JARDINFLEURI";
                        canton = "Montfleur";
                        villette = "Fleurville";
                        superficie = 93.3f;
                        maisons[0] = GenMaisonData("Cas", 1, 1, new int[1] { 1 });
                        maisons[1] = GenMaisonData("Boi", 2, 25, new int[1] { 4 });
                        culture = 1 * 22;
                        administration = 1 * 2;
                        place[0] = "Château de Paradis";
                        place[1] = "Synédroin";
                        place[2] = "Bois de Paradis";
                        place[3] = "Synagogue de Bois";
                        place[4] = "place de Boisé";
                        break;
                    }
                case "00FF31":
                    {
                        id = 112;
                        quartier = "ÎLECHÂTEAU";
                        canton = "Montfleur";
                        villette = "Fleurville";
                        superficie = 24.8f;
                        maisons[0] = GenMaisonData("Blu", 2, 14, new int[4] { 5, 5, 5, 3 });
                        maisons[1] = GenMaisonData("Arg", 2, 8, new int[3] { 2, 3, 3 });
                        maisons[2] = GenMaisonData("Rou", 2, 12, new int[3] { 2, 2, 3 });
                        maisons[3] = GenMaisonData("Jeu", 2, 6, new int[2] { 5, 5 });
                        maisons[4] = GenMaisonData("Anc", 2, 10, new int[3] { 0, 2, 2 });
                        maisons[5] = GenMaisonData("Boi", 2, 9, new int[3] { 5, 5, 5 });
                        trade = 2 * 6;
                        hotel = 3 * 6 + 1 * 4;
                        culture = 3 * 3;
                        place[0] = "Château de Ciel";
                        place[1] = "Marché du Château";
                        place[2] = "Auberge exclusive";
                        place[3] = "Synagogue de la création";
                        place[4] = "Hôtel du Château";
                        place[5] = "Synagogue de Roi";
                        place[6] = "Maison de Rabbin";
                        place[7] = "place du Château";
                        place[8] = "place de Communautè";
                        place[9] = "place de Île";
                        place[10] = "place de Rivemarché";
                        place[11] = "place des Artisans";
                        place[12] = "place de Ville haute";
                        place[13] = "place de Ville bas";
                        break;
                    }
                case "0BC373":
                    {
                        id = 113;
                        quartier = "ROIFRÊNAIE";
                        canton = "Montfleur";
                        villette = "Fleurville";
                        superficie = 10.8f;
                        maisons[0] = GenMaisonData("Ora", 1, 6, new int[4] { 2, 2, 2, 2 });
                        maisons[1] = GenMaisonData("Jeu", 1, 7, new int[4] { 0, 5, 5, 5 });
                        maisons[2] = GenMaisonData("Blu", 1, 5, new int[3] { 0, 2, 1 });
                        maisons[3] = GenMaisonData("Vil", 1, 1, new int[2] { 2, 0 });
                        maisons[4] = GenMaisonData("Gri", 1, 3, new int[2] { 3, 0 });
                        maisons[5] = GenMaisonData("Rou", 1, 4, new int[2] { 3, 0 });
                        maisons[6] = GenMaisonData("Cer", 1, 1, new int[2] { 1, 0 });
                        culture = 1 * 3;
                        hotel = 4 * 4;
                        education = 1 * 6;
                        place[0] = "Synagogue de la Petit fleur";
                        place[1] = "place de la Terrase";
                        break;
                    }
                case "46FF00":
                    {
                        id = 114;
                        quartier = "CÔTELEVANT";
                        canton = "Montfleur";
                        villette = "Fleurville";
                        superficie = 14.3f;
                        maisons[0] = GenMaisonData("Rou", 2, 81, new int[3] { 0, 5, 4 });
                        maisons[1] = GenMaisonData("Bla", 5, 1, new int[3] { 7, 8, 8 });
                        trade = 1 * 6;
                        hotel = 2 * 4;
                        place[0] = "palais du Governeur";
                        place[1] = "Source de guérison";
                        place[2] = "place de l'Aube";
                        place[3] = "place du Lagune";
                        break;
                    }
                case "FF0000":
                    {
                        id = 121;
                        quartier = "HÔTEL";
                        canton = "Cœurville";
                        villette = "Fleurville";
                        superficie = 13.6f;
                        maisons[0] = GenMaisonData("Rou", 2, 65, new int[4] { 0, 4, 4, 2});
                        culture = 1 * 3;
                        administration = 1 * 9;
                        place[0] = "Hôtel de Ville";
                        place[1] = "Grand porte du Paradise";
                        place[2] = "Synagogue de la Joie";
                        place[3] = "Boulevard du Fleurs";
                        place[4] = "place du Cœure";
                        place[5] = "place de Porte";
                        place[6] = "place de Vie";
                        place[7] = "place piémont";
                        break;
                    }
                case "FF7F91":
                    {
                        id = 122;
                        quartier = "RIVECIEL";
                        canton = "Cœurville";
                        villette = "Fleurville";
                        superficie = 8.9f;
                        maisons[0] = GenMaisonData("Rou", 2, 64, new int[4] { 0, 4, 4, 2 });
                        trade = 1 * 6;
                        hotel = 1 * 4;
                        place[0] = "Palais de la famille";
                        place[1] = "Parc familial";
                        place[2] = "Quai céleste";
                        place[3] = "Boulevard des Saints";
                        place[4] = "Place du nouvelle marché";
                        break;
                    }
                case "EC2745":
                    {
                        id = 123;
                        quartier = "ÉCLAIRÉS";
                        canton = "Cœurville";
                        villette = "Fleurville";
                        superficie = 7.2f;
                        maisons[0] = GenMaisonData("Rou", 2, 41, new int[4] { 0, 4, 4, 2 });
                        office = 1 * 4;
                        education = 1 * 6;
                        place[0] = "Synagogue de Bonheur";
                        place[1] = "Boulevard d'Amour";
                        place[2] = "Banque près de la Synagogue";
                        place[3] = "place de la Synagogue";
                        place[4] = "place d'Honneur";
                        break;
                    }
                case "6328E7":
                    {
                        id = 131;
                        quartier = "HALLESLUXE";
                        canton = "Gloir";
                        villette = "Fleurville";
                        superficie = 20.3f;
                        maisons[0] = GenMaisonData("Coi", 2, 25, new int[6] { 4, 4, 4, 4, 4, 2 });
                        maisons[1] = GenMaisonData("Faç", 2, 32, new int[6] { 4, 5, 5, 5, 5, 2 });
                        trade = 2 * 7;
                        place[0] = "Halles de Ville";
                        place[1] = "Marché du luxe";
                        place[2] = "parc de Soleil";
                        place[3] = "place de Marché";
                        break;
                    }
                case "9A82F4":
                    {
                        id = 132;
                        quartier = "AQUARELLE";
                        canton = "Gloir";
                        villette = "Fleurville";
                        superficie = 25.2f;
                        break;
                    }
                case "AA0CF4":
                    {
                        id = 133;
                        quartier = "PROMENADE";
                        canton = "Gloir";
                        villette = "Fleurville";
                        superficie = 9.3f;
                        office = 27 * 6 + 1 * 2 + 11 * 4;
                        culture = 3 * 8;
                        trade = 1 * 2 + 1 * 6;
                        hotel = 2 * 4;
                        medicine = 1 * 11 + 1 * 10 + 1 * 6;
                        services = 1 * 8;
                        administration = 1 * 6;
                        place[0] = "lac Royal";
                        place[1] = "Gouvernance de Jardin";
                        place[2] = "Hôpital de Fleurville";
                        place[3] = "Cental post de Ville";
                        place[4] = "Boulevard Royal";
                        place[5] = "Passage de Ville";
                        place[6] = "Maison de parfum et des huiles";
                        place[7] = "Synagogue de Promenade";
                        place[8] = "place de Passage";
                        place[9] = "place Royal";
                        place[10] = "place de la Post";
                        break;
                    }
                case "6FF921":
                    {
                        id = 141;
                        quartier = "IDYLLE";
                        canton = "Impérial";
                        villette = "Fleurville";
                        superficie = 18.6f;
                        maisons[0] = GenMaisonData("Coi", 2, 28, new int[6] { 4, 4, 4, 4, 4, 2 });
                        maisons[1] = GenMaisonData("Faç", 2, 22, new int[6] { 4, 5, 5, 5, 5, 2 });
                        culture = 1 * 3 + 1 * 12;
                        hotel = 6 * 4 + 1 * 6;
                        administration = 1 * 9 + 1 * 4;
                        place[0] = "Grand Hôtel de Ville";
                        place[1] = "Public conseil de Ville";
                        place[2] = "Club de Philosophie";
                        place[3] = "Departament de Nature";
                        place[4] = "Boulevard de Théâtre";
                        place[5] = "Quai de Roses";
                        place[6] = "place de Roi";
                        break;
                    }
                case "CAFD39":
                    {
                        id = 142;
                        quartier = "ANTHÈSE";
                        canton = "Impérial";
                        villette = "Fleurville";
                        superficie = 13.9f;
                        maisons[0] = GenMaisonData("Coi", 2, 12, new int[6] { 4, 4, 4, 4, 4, 2 });
                        maisons[1] = GenMaisonData("Tri", 5,  8, new int[5] { 0, 16, 16, 16, 16 });
                        office = 1 * 2 + 6 * 4;
                        culture = 1 * 14;
                        education = 1 * 6 + 1 * 7;
                        sport = 1 * 8;
                        administration = 1 * 15 + 1 * 36 + 1 * 9;
                        place[0] = "Fleurville Hôtel";
                        place[1] = "Departament de Développement";
                        place[2] = "Conseil du Royaume";
                        place[3] = "parc de Fluerville";
                        place[4] = "Grand Théâter de Ville";
                        place[5] = "Stade de Fleurville";
                        place[6] = "Bibliothèque de Fleurville";
                        place[7] = "place de Théâter";
                        break;
                    }
                case "EA9B39":
                    {
                        id = 151;
                        quartier = "PERPÉTUEL";
                        canton = "Promission";
                        villette = "Fleurville";
                        superficie = 12.8f;
                        maisons[0] = GenMaisonData("Coi", 2, 24, new int[6] { 4, 4, 4, 4, 4, 2 });
                        maisons[1] = GenMaisonData("Faç", 2, 24, new int[6] { 4, 5, 5, 5, 5, 2 });
                        education = 1 * 15;
                        place[0] = "Lycée de Vlle";
                        place[1] = "Parc de Lycée";
                        break;
                        // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                        // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                    }
                case "F7C329":
                    {
                        id = 152;
                        quartier = "SABBAT";
                        canton = "Promission";
                        villette = "Fleurville";
                        superficie = 38.6f;
                        break;
                    }

                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
            }
        }

        void GetDataCanton(string code)
        {

        }

        void GetDataVille(string code)
        {

        }

        string GenMaisonData(string type, int grandeur, int count, int[] config)
        {
            type += " : ";

            int configCount = config.Length;
            int appartaments = 0;

            for (byte i = 0; i < configCount; i++)
            {
                type += config[i].ToString() + " ";
                appartaments += config[i];
            }

            residents += appartaments * count * 2;
            id_res += appartaments * grandeur;

            type += " => " + count.ToString();
            return type;
        }

        string[] WorkersSet()
        {
            byte cnt = 10;
            int[] dat = new int[cnt];
            string[] arr = new string[cnt];

            dat[0] = (int)(production * emp_index);
            dat[1] = (int)(office * emp_index);
            dat[2] = (int)(trade * emp_index);
            dat[3] = (int)(culture * emp_index);
            dat[4] = (int)(hotel * emp_index);
            dat[5] = (int)(education * emp_index);
            dat[6] = (int)(medicine * emp_index);
            dat[7] = (int)(services * emp_index);
            dat[8] = (int)(sport * emp_index);
            dat[9] = (int)(administration * emp_index);

            for (byte i = 0; i < cnt; i++)
            {
                employ += dat[i];
                arr[i] = dat[i].ToString();
            }

            return arr;
        }
    }
}
