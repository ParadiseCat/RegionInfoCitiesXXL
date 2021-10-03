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
                DataMap dmap = new DataMap();

                switch (mode)
                {
                    case Mode.Quartier: QuartierHandler(dmap.GetQuartier(hexCode)); break;
                    case Mode.Canton: CantonHandler(dmap.GetCanton(hexCode)); break;
                    case Mode.Villette: VilletteHandler(dmap.GetVillette(hexCode)); break;
                    case Mode.Ville: VilleHandler(); break;
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
            output.FoundedData(30f, 520f);
            output.EmployersDataNoZero(30f, 600f);
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
