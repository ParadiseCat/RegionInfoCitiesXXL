using System.Collections.Generic;

namespace ParadiseVille
{
    public class DataMap
    {
        Dictionary<string, Quartier> quartiers;
        Dictionary<string, Canton> cantons;
        Dictionary<string, Villette> villettes;

        Dictionary<Quartier, string> quartierCodes;

        public Quartier GetQuartier(string code)
        {
            if (quartiers == null)
            {
                QuartierInit();
            }

            return quartiers[code];
        }

        public string GetQuartierCode(Quartier quartier)
        {
            if (quartierCodes == null)
            {
                QuartierCodesInit();
            }

            return quartierCodes[quartier];
        }

        public Canton GetCanton(string code)
        {
            if (cantons == null)
            {
                CantonInit();
            }

            return cantons[code];
        }

        public Villette GetVillette(string code)
        {
            if (villettes == null)
            {
                VilletteInit();
            }

            return villettes[code];
        }

        void QuartierCodesInit()
        {
            QuartierInit();
            quartierCodes = new Dictionary<Quartier, string>();

            foreach (string code in quartiers.Keys)
            {
                quartierCodes.Add(quartiers[code], code);
            }
        }


        void QuartierInit()
        {
            quartiers = new Dictionary<string, Quartier>()
            {
                { "5898EE", Quartier.q_Abreuvoir },
                { "3AB6EC", Quartier.q_Accalmie },
                { "50E57A", Quartier.q_Accord },
                { "D96B8B", Quartier.q_Albatros },
                { "ED57EA", Quartier.q_Anthese },
                { "4AD9F8", Quartier.q_Aronde },
                { "00A600", Quartier.q_Artisan },
                { "FF4992", Quartier.q_Artois },
                { "9FFB0C", Quartier.q_Blancheur },
                { "08D1B2", Quartier.q_Boishetre },
                { "F8DF31", Quartier.q_Brise },
                { "C0FA00", Quartier.q_Bruyere },
                { "DB3B75", Quartier.q_Buquet},
                { "59F02F", Quartier.q_Cedres },
                { "F40DB8", Quartier.q_Chandelle },
                { "9E7AEF", Quartier.q_Charite },
                { "0BEAA3", Quartier.q_Charme },
                { "DB2714", Quartier.q_Chatterie },
                { "313AE0", Quartier.q_Ciel },
                { "21F90B", Quartier.q_Cocotier },
                { "E835FF", Quartier.q_Comtefleur },
                { "F48F6E", Quartier.q_Cotecafe },
                { "9BEF13", Quartier.q_Cotecorail },
                { "46FF00", Quartier.q_Cotelevant },
                { "F22E62", Quartier.q_Cotepalmier },
                { "1137EB", Quartier.q_Croissance },
                { "EF4507", Quartier.q_Douceur},
                { "ED2644", Quartier.q_Eclaires },
                { "EC7C10", Quartier.q_Embrume },
                { "DE664A", Quartier.q_Enchanteur },
                { "2AA3CC", Quartier.q_Flute},
                { "03B62F", Quartier.q_Gattilier },
                { "F0B9C8", Quartier.q_Gare },
                { "1CEC7C", Quartier.q_Genievre },
                { "F44174", Quartier.q_Gremil },
                { "6127E8", Quartier.q_Hallesluxe },
                { "1C74F0", Quartier.q_Harmonie },
                { "FF0000", Quartier.q_Hotel },
                { "04D123", Quartier.q_Horizon},
                { "E4421D", Quartier.q_Hulotte },
                { "6FF91F", Quartier.q_Idylle },
                { "00FF32", Quartier.q_Ilechateau },
                { "EF881F", Quartier.q_Iris },
                { "B6FF00", Quartier.q_Jardinfleuri },
                { "E849BA", Quartier.q_Lambruche },
                { "F43E69", Quartier.q_Licorne },
                { "E12FC2", Quartier.q_Littoral },
                { "E8372F", Quartier.q_Lotus },
                { "7F96FF", Quartier.q_Lumiere },
                { "0FC42A", Quartier.q_Mielfaine },
                { "82F4FF", Quartier.q_Montazur },
                { "07B67C", Quartier.q_Montfee },
                { "E8273A", Quartier.q_Nectar },
                { "52EC1C", Quartier.q_Nichoir },
                { "12EA07", Quartier.q_Orchidee },
                { "4FA4F9", Quartier.q_Ormaie },
                { "3A69F1", Quartier.q_Reinevue },
                { "28A6EF", Quartier.q_Palaisroyal },
                { "D50CC6", Quartier.q_Parfumeur },
                { "E75388", Quartier.q_Parcamour },
                { "019600", Quartier.q_Parcoiseau },
                { "1837F8", Quartier.q_Pastel },
                { "6574BA", Quartier.q_Paysage },
                { "7C4AC9", Quartier.q_Peinardise },
                { "E99B3A", Quartier.q_Perpetuel },
                { "F48810", Quartier.q_Perroquet },
                { "1753D6", Quartier.q_Pivoine },
                { "E2C028", Quartier.q_Poesie },
                { "93E814", Quartier.q_Port },
                { "AB0CF4", Quartier.q_Promenade },
                { "18A7CD", Quartier.q_Prosperite },
                { "3A41FF", Quartier.q_Purete },
                { "9BEF2D", Quartier.q_Ramage },
                { "2FDDF9", Quartier.q_Renardeau },
                { "FF7F92", Quartier.q_Riveciel },
                { "0BC274", Quartier.q_Roifrenaie },
                { "3CF2C7", Quartier.q_Roseraie },
                { "F8C227", Quartier.q_Sabbat },
                { "843EEE", Quartier.q_Sansonnet },
                { "1462C1", Quartier.q_Sophora },
                { "333AE8", Quartier.q_Suavite },
                { "E01469", Quartier.q_Sublimite },
                { "9B55E8", Quartier.q_Suffle },
                { "7CF008", Quartier.q_Tadorne },
                { "3A8CFF", Quartier.q_Tilleul },
                { "49CFD8", Quartier.q_Tissage },
                { "18E23D", Quartier.q_Theatrie },
                { "5B9BFF", Quartier.q_Trefleblue },
                { "6171C9", Quartier.q_Tulipier },
                { "8AFFFF", Quartier.q_Victoire },
                { "E99F2B", Quartier.q_Voilure }
            };
        }

        void CantonInit()
        {
            cantons = new Dictionary<string, Canton>()
            {
                { "82F4FF", Canton.c_Brume },
                { "1837F8", Canton.c_Castel },
                { "F48F6E", Canton.c_Chaleur },
                { "3A41FF", Canton.c_Clemence },
                { "ED2644", Canton.c_Coeurville },
                { "E8273A", Canton.c_Conte },
                { "F44174", Canton.c_Couleur },
                { "12EA07", Canton.c_Floraison },
                { "49CFD8", Canton.c_Flux },
                { "9A81F4", Canton.c_Gloir },
                { "9E7AEF", Canton.c_Grace },
                { "CAFD38", Canton.c_Imperial },
                { "E2C028", Canton.c_Juvenilite },
                { "E01469", Canton.c_Liberte },
                { "E550CF", Canton.c_Lucide},
                { "D96B8B", Canton.c_Maritime },
                { "0BC274", Canton.c_MontFleur},
                { "8AFFFF", Canton.c_Palefroi },
                { "019600", Canton.c_Parcville },
                { "E99B3A", Canton.c_Perfection },
                { "E835FF", Canton.c_Prestige },
                { "28A6EF", Canton.c_Prince },
                { "9FFB0C", Canton.c_Promontoire },
                { "3A8CFF", Canton.c_Ravinlis },
                { "1FF018", Canton.c_Roquerie },
                { "50E57A", Canton.c_Serein },
                { "FF4992", Canton.c_Sinousite },
                { "0BEAA3", Canton.c_Soleil },
                { "07B67C", Canton.c_Tropique },
                { "C0FA00", Canton.c_Occidental },
                { "DB2714", Canton.c_Oiselle },
                { "03B62F", Canton.c_Vanille },
                { "2AA3CC", Canton.c_Verger},
                { "7C4AC9", Canton.c_Versantvert },
                { "5898EE", Canton.c_Volage }
            };
        }

        void VilletteInit()
        {
            villettes = new Dictionary<string, Villette>()
            {
                { "E77CFF", Villette.v_Boisville },
                { "FF6B90", Villette.v_Cotierville },
                { "FCFF84", Villette.v_Fleurville },
                { "FFC16B", Villette.v_Merville },
                { "7AFFB6", Villette.v_Montville },
                { "94FF5B", Villette.v_Rivierville }
            };
        }
    }
}
