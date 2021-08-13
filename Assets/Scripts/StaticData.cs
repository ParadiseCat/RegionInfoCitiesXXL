using UnityEngine;

namespace ParadiseVille
{
    /// <summary>
    /// main camera general settings params
    /// </summary>
    internal static class GameCamera
    {
        static public float cameraHalf_Height = Camera.main.orthographicSize;
        static public float cameraHalf_Width = Camera.main.orthographicSize * Camera.main.aspect;
        static public float scaleCamera = Camera.main.pixelHeight / (Camera.main.orthographicSize * 2);
        static public float realHeight = Camera.main.orthographicSize * (Camera.main.pixelHeight / (Camera.main.orthographicSize * 2));
        static public float realWidth = Camera.main.orthographicSize * Camera.main.aspect * (Camera.main.pixelHeight / (Camera.main.orthographicSize * 2));
    }

    /// <summary>
    /// Enum of types dictict as hierarcy structs of city
    /// </summary>
    public enum Mode
    { 
        Quartier, 
        Canton, 
        Villette, 
        Ville 
    };

    /// <summary>
    /// Enum of types city social groups
    /// </summary>
    public enum SocialState 
    { 
        Worker, 
        Specialist, 
        Professional, 
        Responsible 
    };

    /// <summary>
    /// Enum of types work spheras of city for employers
    /// </summary>
    public enum EmployerType
    { 
        Production, 
        Office, 
        Trade, 
        Culture, 
        Hotel, 
        Education, 
        Medicine, 
        Services, 
        Sport, 
        Administration 
    };

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
                q_Brise = 243,
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
                q_Accalmie = 343,
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
}
