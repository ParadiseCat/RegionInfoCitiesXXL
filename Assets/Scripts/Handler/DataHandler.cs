using UnityEngine;

namespace ParadiseVille.Handler
{
    /// <summary>
    /// Handler data info for it input in Game as text
    /// </summary>
    public class DataHandler
    {
        TextDraw objTextDraw;
        string hexColor = "";
        Mode mapMode;

        public DataHandler(Mode modeDefault)
        {
            objTextDraw = new TextDraw();
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
                            case "B6FF00": QuartierHandler(Quartier.q_Jardinfleuri); break;
                            case "00FF32": QuartierHandler(Quartier.q_Ilechateau); break;
                            case "0BC274": QuartierHandler(Quartier.q_Roifrenaie); break;
                            case "46FF00": QuartierHandler(Quartier.q_Cotelevant); break;
                            // --- Coeurville --- //
                            case "FF0000": QuartierHandler(Quartier.q_Hotel); break;
                            case "FF7F92": QuartierHandler(Quartier.q_Riveciel); break;
                            case "ED2644": QuartierHandler(Quartier.q_Eclaires); break;
                            // --- Gloir --- //
                            case "6127E8": QuartierHandler(Quartier.q_Hallesluxe); break;
                            case "9A81F4": QuartierHandler(Quartier.q_Aquarelle); break;
                            case "AB0CF4": QuartierHandler(Quartier.q_Promenade); break;
                            // --- Imperial --- //
                            case "6FF91F": QuartierHandler(Quartier.q_Idylle); break;
                            case "CAFD38": QuartierHandler(Quartier.q_Anthese); break;
                            // --- Perfection --- //
                            case "E99B3A": QuartierHandler(Quartier.q_Perpetuel); break;
                            case "F8C227": QuartierHandler(Quartier.q_Sabbat); break;
                            // --- Palefroi --- //
                            case "8AFFFF": QuartierHandler(Quartier.q_Victoire); break;
                            case "7F96FF": QuartierHandler(Quartier.q_Lumiere); break;
                            case "1462C1": QuartierHandler(Quartier.q_Sophora); break;
                            case "313AE0": QuartierHandler(Quartier.q_Ciel); break;
                            // --- Lucide --- //
                            case "EF881F": QuartierHandler(Quartier.q_Iris); break;
                            case "E75388": QuartierHandler(Quartier.q_Parcamour); break;

                            // *** COTIERVILLE *** //
                            // --- Soleil --- //
                            case "0BEAA3": QuartierHandler(Quartier.q_Charme); break;
                            case "9BEF13": QuartierHandler(Quartier.q_Cotecorail); break;
                            case "00A600": QuartierHandler(Quartier.q_Artisan); break;
                            // --- Couleur --- //
                            case "F40DB8": QuartierHandler(Quartier.q_Chandelle); break;
                            case "D50CC6": QuartierHandler(Quartier.q_Parfumeur); break;
                            case "F44174": QuartierHandler(Quartier.q_Gremil); break;
                            case "E4421D": QuartierHandler(Quartier.q_Hulotte); break;
                            // --- Castel --- //
                            case "18A7CD": QuartierHandler(Quartier.q_Prosperite); break;
                            case "1837F8": QuartierHandler(Quartier.q_Pastel); break;
                            case "843EEE": QuartierHandler(Quartier.q_Sansonnet); break;
                            // --- Chaleur --- //
                            case "F22E62": QuartierHandler(Quartier.q_Cotepalmier); break;
                            case "F48F6E": QuartierHandler(Quartier.q_Cotecafe); break;
                            case "F8DF31": QuartierHandler(Quartier.q_Brise); break;
                            // --- Tropique --- //
                            case "7CF008": QuartierHandler(Quartier.q_Tadorne); break;
                            case "21F90B": QuartierHandler(Quartier.q_Cocotier); break;
                            case "07B67C": QuartierHandler(Quartier.q_Montfee); break;

                            // *** MONTVILLE *** //
                            // --- Roquerie --- //
                            case "52EC1C": QuartierHandler(Quartier.q_Nichoir); break;
                            case "04D123": QuartierHandler(Quartier.q_Horizon); break;
                            case "1CEC7C": QuartierHandler(Quartier.q_Genievre); break;
                            // --- Ravinlis --- //
                            case "6574BA": QuartierHandler(Quartier.q_Paysage); break;
                            case "1137EB": QuartierHandler(Quartier.q_Croissance); break;
                            case "3A8CFF": QuartierHandler(Quartier.q_Tilleul); break;
                            case "5B9BFF": QuartierHandler(Quartier.q_Trefleblue); break;
                            // --- Liberte --- //
                            case "DE664A": QuartierHandler(Quartier.q_Enchanteur); break;
                            case "E01469": QuartierHandler(Quartier.q_Sublimite); break;
                            // --- Brume --- //
                            case "6171C9": QuartierHandler(Quartier.q_Tulipier); break;
                            case "82F4FF": QuartierHandler(Quartier.q_Montazur); break;
                            case "3AB6EC": QuartierHandler(Quartier.q_Accalmie); break;

                            // *** RIVIERVILLE *** //
                            // --- Promontoire --- //
                            case "0FC42A": QuartierHandler(Quartier.q_Mielfaine); break;
                            case "08D1B2": QuartierHandler(Quartier.q_Boishetre); break;
                            case "9FFB0C": QuartierHandler(Quartier.q_Blancheur); break;
                            // --- Oiselle --- //
                            case "DB2714": QuartierHandler(Quartier.q_Cheveche); break;
                            case "F48810": QuartierHandler(Quartier.q_Perroquet); break;
                            // --- Grace --- //
                            case "9E7AEF": QuartierHandler(Quartier.q_Charite); break;
                            case "4AD9F8": QuartierHandler(Quartier.q_Aronde); break;
                            case "3A69F1": QuartierHandler(Quartier.q_Palaisreine); break;
                            // --- Parcville --- //
                            case "019600": QuartierHandler(Quartier.q_Parcoiseau); break;

                            // *** BOISVILLE *** //
                            // --- Conte --- //
                            case "E8273A": QuartierHandler(Quartier.q_Nectar); break;
                            case "E849BA": QuartierHandler(Quartier.q_Lambruche); break;
                            // --- Serein --- //
                            case "50E57A": QuartierHandler(Quartier.q_Accord); break;
                            // --- Versantvert --- //
                            case "1753D6": QuartierHandler(Quartier.q_Pivoine); break;
                            case "7C4AC9": QuartierHandler(Quartier.q_Peinardise); break;
                            // --- Clemence -- //
                            case "3A41FF": QuartierHandler(Quartier.q_Purete); break;
                            case "2FDDF9": QuartierHandler(Quartier.q_Renardeau); break;
                            case "4FA4F9": QuartierHandler(Quartier.q_Ormaie); break;
                            // --- Prestige --- //
                            case "E835FF": QuartierHandler(Quartier.q_Comtefleur); break;
                            case "F43E69": QuartierHandler(Quartier.q_Licorne); break;
                            case "F0B9C8": QuartierHandler(Quartier.q_Gare); break;
                            // --- Occidental --- //
                            case "C0FA00": QuartierHandler(Quartier.q_Bruyere); break;

                            // *** MERVILLE *** //
                            // --- Sinousité --- //
                            case "E8372F": QuartierHandler(Quartier.q_Lotus); break;
                            case "FF4992": QuartierHandler(Quartier.q_Artois); break;
                            // --- Floraison --- //
                            case "12EA07": QuartierHandler(Quartier.q_Orchidee); break;
                            case "9BEF2D": QuartierHandler(Quartier.q_Ramage); break;
                            // --- Juvénilité --- //
                            case "EC7C10": QuartierHandler(Quartier.q_Embrume); break;
                            case "E2C028": QuartierHandler(Quartier.q_Poesie); break;
                            // --- Volage --- //
                            case "5898EE": QuartierHandler(Quartier.q_Abreuvoir); break;
                            case "333AE8": QuartierHandler(Quartier.q_Suavite); break;
                            case "9B55E8": QuartierHandler(Quartier.q_Suffle); break;
                            case "1C74F0": QuartierHandler(Quartier.q_Harmonie); break;
                            // --- Vanille --- //
                            case "59F02F": QuartierHandler(Quartier.q_Cedres); break;
                            case "03B62F": QuartierHandler(Quartier.q_Gattilier); break;
                            // --- Maritime --- //
                            case "E12FC2": QuartierHandler(Quartier.q_Littoral); break;
                            case "E99F2B": QuartierHandler(Quartier.q_Voilure); break;
                            case "D96B8B": QuartierHandler(Quartier.q_Goeland); break;
                            // --- Flux --- //
                            case "49CFD8": QuartierHandler(Quartier.q_Tissage); break;
                            case "93E814": QuartierHandler(Quartier.q_Port); break;
                        }
                        break;
                    }
                    case Mode.Canton: {
                        switch (hexCode)
                        {
                            // FLEURVILLE //
                            case "0BC274": CantonHandler(Canton.c_MontFleur); break;
                            case "ED2644": CantonHandler(Canton.c_Coeurville); break;
                            case "9A81F4": CantonHandler(Canton.c_Gloir); break;
                            case "CAFD38": CantonHandler(Canton.c_Imperial); break;
                            case "E99B3A": CantonHandler(Canton.c_Perfection); break;
                            case "8AFFFF": CantonHandler(Canton.c_Palefroi); break;
                            case "E550CF": CantonHandler(Canton.c_Lucide); break;
                                    
                            // COTIERVILLE //
                            case "0BEAA3": CantonHandler(Canton.c_Soleil); break;
                            case "F44174": CantonHandler(Canton.c_Couleur); break;
                            case "1837F8": CantonHandler(Canton.c_Castel); break;
                            case "F48F6E": CantonHandler(Canton.c_Chaleur); break;
                            case "07B67C": CantonHandler(Canton.c_Tropique); break;

                            // MONTVILLE //
                            case "1FF018": CantonHandler(Canton.c_Roquerie); break;
                            case "3A8CFF": CantonHandler(Canton.c_Ravinlis); break;
                            case "E01469": CantonHandler(Canton.c_Liberte); break;
                            case "82F4FF": CantonHandler(Canton.c_Brume); break;

                            // RIVIERVILLE //
                            case "9FFB0C": CantonHandler(Canton.c_Promontoire); break;
                            case "DB2714": CantonHandler(Canton.c_Oiselle); break;
                            case "9E7AEF": CantonHandler(Canton.c_Grace); break;
                            case "019600": CantonHandler(Canton.c_Parcville); break;

                            // BOISVILLE //
                            case "E8273A": CantonHandler(Canton.c_Conte); break;
                            case "50E57A": CantonHandler(Canton.c_Serein); break;
                            case "7C4AC9": CantonHandler(Canton.c_Versantvert); break;
                            case "3A41FF": CantonHandler(Canton.c_Clemence); break;
                            case "E835FF": CantonHandler(Canton.c_Prestige); break;
                            case "C0FA00": CantonHandler(Canton.c_Occidental); break;

                            // MERVILLE //
                            case "FF4992": CantonHandler(Canton.c_Sinousite); break;
                            case "5898EE": CantonHandler(Canton.c_Volage); break;
                            case "03B62F": CantonHandler(Canton.c_Vanille); break;
                            case "D96B8B": CantonHandler(Canton.c_Maritime); break;
                            case "49CFD8": CantonHandler(Canton.c_Flux); break;
                            case "12EA07": CantonHandler(Canton.c_Floraison); break;
                            case "E2C028": CantonHandler(Canton.c_Juvenilite); break;
                        }
                        break;
                    }
                    case Mode.Villette: {
                        switch (hexCode)
                        {
                            case "FCFF84": VilletteHandler(Villette.v_Fleurville); break;
                            case "FF6B90": VilletteHandler(Villette.v_Cotierville); break;
                            case "7AFFB6": VilletteHandler(Villette.v_Montville); break;
                            case "94FF5B": VilletteHandler(Villette.v_Rivierville); break;
                            case "E77CFF": VilletteHandler(Villette.v_Boisville); break;
                            case "FFC16B": VilletteHandler(Villette.v_Merville); break;
                        }
                        break;
                    }
                    case Mode.Ville: {
                        VilleHandler();
                        break;
                    }
                }
            }
        }

        void QuartierHandler(Quartier quartier)
        {
            objTextDraw.TextClean();
            QuartierData quart = new QuartierData(quartier);
            DataOutput output = new DataOutput(ref objTextDraw, ref quart);

            output.HeadData(30f, 50f);
            output.MainData(30f, 280f);
            output.EmployersDataNoZero(30f, 550f);
            output.PublicPlacesData(400f, 280f);
        }

        void CantonHandler(Canton canton)
        {
            objTextDraw.TextClean();
            QuartierData quart = new QuartierData(canton);
            DataOutput output = new DataOutput(ref objTextDraw, ref quart);

            output.HeadData(30f, 50f);
            output.MainData(30f, 280f);
            output.SocialData(30f, 560f);
            output.EtagesData(30f, 740f);
            output.EmployersData(400f, 280f);
        }

        void VilletteHandler(Villette villette)
        {
            objTextDraw.TextClean();
            QuartierData quart = new QuartierData(villette);
            DataOutput output = new DataOutput(ref objTextDraw, ref quart);

            output.HeadData(30f, 50f);
            output.MainData(30f, 280f);
            output.SocialData(30f, 560f);
            output.EtagesData(30f, 740f);
            output.EmployersData(400f, 280f);
        }

        void VilleHandler()
        {
            objTextDraw.TextClean();
            QuartierData quart = new QuartierData();
            DataOutput output = new DataOutput(ref objTextDraw, ref quart);

            output.HeadData(30f, 50f);
            output.MainData(30f, 280f);
            output.SocialData(30f, 560f);
            output.EtagesData(30f, 740f);
            output.EmployersData(400f, 280f);
        }

        public void CalcEmployersPerUnit()
        {
            QuartierData qd = new QuartierData();
            qd.CalcEmployersPerUnit();
        }
    }
}
