

namespace ParadiseVille
{
    public class CityData 
    {
        public string str_id = " - ";
        public string quartier = " - ";
        public string canton = " - ";
        public string villette = " - ";
        public string str_residents = " - ";
        public string str_employ = " - ";
        public string str_superf = " - ";
        public string str_denct = " - ";

        public string[] maisons = new string[7] { " - ", " - ", " - ", " - ", " - ", " - ", " - " };
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
        int services = 0;
        int sport = 0;
        int administration = 0;

        const float emp_index = 5.5f;

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
                        culture = 1 * 2 + 1 * 22;
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
                        break;
                    }
                case "6328E7":
                    {
                        id = 131;
                        quartier = "HALLESLUXE";
                        canton = "Gloir";
                        villette = "Fleurville";
                        superficie = 20.3f;
                        maisons[0] = GenMaisonData("Coi", 2, 44, new int[6] { 4, 4, 4, 4, 4, 2 });
                        maisons[1] = GenMaisonData("Faç", 2, 52, new int[6] { 4, 5, 5, 5, 5, 2 });
                        trade = 2 * 7;
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
                        office = 28 * 6 + 1 * 2 + 11 * 4;
                        culture = 3 * 8;
                        trade = 1 * 2 + 1 * 6;
                        hotel = 2 * 4;
                        services = 1 * 8 + 1 * 6 + 1 * 11 + 1 * 10;
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
                        office = 1 * 4;
                        culture = 1 * 3 + 1 * 12;
                        hotel = 6 * 4 + 1 * 6;
                        administration = 1 * 9;
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
                        administration = 1 * 15 + 1 * 36 + 1 * 7;
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
                        break;
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
            byte cnt = 9;
            int[] dat = new int[cnt];
            string[] arr = new string[cnt];

            dat[0] = (int)(production * emp_index);
            dat[1] = (int)(office * emp_index);
            dat[2] = (int)(trade * emp_index);
            dat[3] = (int)(culture * emp_index);
            dat[4] = (int)(hotel * emp_index);
            dat[5] = (int)(education * emp_index);
            dat[6] = (int)(services * emp_index);
            dat[7] = (int)(sport * emp_index);
            dat[8] = (int)(administration * emp_index);

            for (byte i = 0; i < cnt; i++)
            {
                employ += dat[i];
                arr[i] = dat[i].ToString();
            }

            return arr;
        }
    }
}
