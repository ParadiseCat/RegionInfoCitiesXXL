using System.Linq;
using System.Collections.Generic;

namespace ParadiseVille.Handler
{
    internal abstract class Hierarcy
    {
        const int RANGE_CANTON = 10;
        const int RANGE_VILLETTE = 100;

        protected List<Quartier> quartierList { get; private set; }

        public Hierarcy(Quartier quartier)
        {
            quartierList = GetListQuartier(quartier);
        }

        public Hierarcy(Canton canton)
        {
            quartierList = GetListCanton(canton);
        }

        public Hierarcy(Villette villette)
        {
            quartierList = GetListVillette(villette);
        }

        public Hierarcy()
        {
            quartierList = GetListVille();
        }

        List<Quartier> GetListQuartier(Quartier quartier)
        {
            List<Quartier> list = new List<Quartier>();
            list.Add(quartier);

            return list;
        }

        List<Quartier> GetListCanton(Canton canton)
        {
            int cantonValue = (int)canton;
            int cantonNext = cantonValue + RANGE_CANTON;

            List<Quartier> list = new List<Quartier>();
            List<Quartier> all = System.Enum.GetValues(typeof(Quartier)).Cast<Quartier>().ToList();

            foreach (Quartier qr in all)
            {
                int id = (int)qr;

                if (id > cantonValue && id < cantonNext)
                {
                    list.Add(qr);
                }
            }

            return list;
        }

        List<Quartier> GetListVillette(Villette villette)
        {
            int villetteValue = (int)villette;
            int villetteNext = villetteValue + RANGE_VILLETTE;

            List<Quartier> list = new List<Quartier>();
            List<Quartier> all = System.Enum.GetValues(typeof(Quartier)).Cast<Quartier>().ToList();

            foreach (Quartier qr in all)
            {
                int id = (int)qr;

                if (id > villetteValue && id < villetteNext)
                {
                    list.Add(qr);
                }
            }

            return list;
        }

        List<Quartier> GetListVille()
        {
            return System.Enum.GetValues(typeof(Quartier)).Cast<Quartier>().ToList();
        }
    }
}
