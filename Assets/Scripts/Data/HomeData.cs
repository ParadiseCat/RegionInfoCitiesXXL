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

        public HomeData(string facade, SocialState social, int size, int count, int[] appartaments)
        {
            this.facade = facade;
            this.social = social;
            this.size = size;
            this.count = count;
            this.appartaments = appartaments;
        }
    }
}
