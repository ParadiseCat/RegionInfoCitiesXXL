using System;
using System.Linq;
using System.Collections.Generic;

namespace ParadiseVille
{
    /// <summary>
    /// Data of city disctricts
    /// </summary>
    public static class DataVille
    {
        public static DistrictData Information(Ville quartier)
        {
            DistrictData dat;

            switch (quartier)
            {
                case Ville.q_Jardinfleuri: {
                    dat = new DistrictData("JARDINFLEURI", "Montfleur", "Fleurville", 91.9f);
                    dat.HomeDataAdd("Cas", SocialState.Responsible, 1, 1, new int[1] { 1 });
                    dat.HomeDataAdd("Boi", SocialState.Specialist, 2, 25, new int[1] { 4 });
                    dat.EmployersDataAdd(EmployerType.Culture, 1 * 22);
                    dat.EmployersDataAdd(EmployerType.Administration, 1 * 2);
                    dat.PlaceDataAdd("Château de Paradis", "Synédroin", "Synagogue de Bois");
                    dat.PlaceDataAdd("place de Boisé");
                    dat.PlaceDataAdd("Bois de Paradis");
                    return dat;
                }
                case Ville.q_Ilechateau: {
                    dat = new DistrictData("ÎLECHÂTEAU", "Montfleur", "Fleurville", 24.5f);
                    dat.HomeDataAdd("Blu", SocialState.Specialist, 2, 14, new int[4] { 5, 5, 5, 3 });
                    dat.HomeDataAdd("Arg", SocialState.Specialist, 2, 8, new int[3] { 2, 3, 3 });
                    dat.HomeDataAdd("Rou", SocialState.Specialist, 2, 12, new int[3] { 2, 2, 3 });
                    dat.HomeDataAdd("Jeu", SocialState.Specialist, 2, 6, new int[2] { 5, 5 });
                    dat.HomeDataAdd("Anc", SocialState.Specialist, 2, 10, new int[3] { 0, 2, 2 });
                    dat.HomeDataAdd("Boi", SocialState.Specialist, 2, 9, new int[3] { 5, 5, 5 });
                    dat.EmployersDataAdd(EmployerType.Culture, 3 * 3);
                    dat.EmployersDataAdd(EmployerType.Hotel, 3 * 6 + 1 * 4);
                    dat.EmployersDataAdd(EmployerType.Trade, 2 * 6);
                    dat.PlaceDataAdd("Château de Ciel", "Marché du Château", "Auberge exclusive", "Synagogue de la création",
                                     "Hôtel du Château", "Synagogue de Roi", "Maison de Rabbin");
                    dat.PlaceDataAdd("place du Château", "place de Communautè", "place de Île", "place de Rivemarché",
                                     "place des Artisans", "place de Ville haute", "place de Ville bas");
                    return dat;
                }
                case Ville.q_Roifrenaie: {
                    dat = new DistrictData("ROIFRÊNAIE", "Montfleur", "Fleurville", 10.8f);
                    dat.HomeDataAdd("Ora", SocialState.Responsible, 1, 6, new int[4] { 2, 2, 2, 2 });
                    dat.HomeDataAdd("Jeu", SocialState.Responsible, 1, 7, new int[4] { 0, 5, 5, 5 });
                    dat.HomeDataAdd("Blu", SocialState.Responsible, 1, 5, new int[3] { 0, 2, 1 });
                    dat.HomeDataAdd("Vil", SocialState.Responsible, 1, 1, new int[2] { 2, 0 });
                    dat.HomeDataAdd("Gri", SocialState.Responsible, 1, 3, new int[2] { 3, 0 });
                    dat.HomeDataAdd("Rou", SocialState.Responsible, 1, 4, new int[2] { 3, 0 });
                    dat.HomeDataAdd("Cer", SocialState.Responsible, 1, 1, new int[2] { 1, 0 });
                    dat.EmployersDataAdd(EmployerType.Culture, 1 * 3);
                    dat.EmployersDataAdd(EmployerType.Education, 1 * 6);
                    dat.EmployersDataAdd(EmployerType.Hotel, 4 * 4);
                    dat.PlaceDataAdd("Synagogue de la Petit fleur");
                    dat.PlaceDataAdd("place de la Terrase");
                    return dat;
                }
                case Ville.q_Cotelevant: {
                    dat = new DistrictData("CÔTELEVANT", "Montfleur", "Fleurville", 14.2f);
                    dat.HomeDataAdd("Rou", SocialState.Professional, 2, 81, new int[3] { 0, 5, 4 });
                    dat.HomeDataAdd("Bla", SocialState.Responsible, 5, 1, new int[3] { 7, 8, 8 });
                    dat.EmployersDataAdd(EmployerType.Hotel, 1 * 6);
                    dat.EmployersDataAdd(EmployerType.Trade, 2 * 4);
                    dat.PlaceDataAdd("palais du Governeur", "Source de guérison");
                    dat.PlaceDataAdd("place de l'Aube", "place du Lagune");
                    dat.PlaceDataAdd("parc de Governeur");
                    return dat;
                }
                case Ville.q_Hotel: {
                    dat = new DistrictData("HÔTEL", "Cœurville", "Fleurville", 13.5f);
                    dat.HomeDataAdd("Rou", SocialState.Specialist, 2, 65, new int[4] { 0, 4, 4, 2 });
                    dat.EmployersDataAdd(EmployerType.Administration, 1 * 9);
                    dat.EmployersDataAdd(EmployerType.Culture, 1 * 3);
                    dat.PlaceDataAdd("Hôtel de Ville", "Grand porte du Paradise", "Synagogue de la Joie", "Boulevard du Fleurs");
                    dat.PlaceDataAdd("place du Cœure", "place de Porte", "place de Vie", "place Piémont");
                    return dat;
                }
                case Ville.q_Riveciel: {
                    dat = new DistrictData("RIVECIEL", "Cœurville", "Fleurville", 10.4f);
                    dat.HomeDataAdd("Rou", SocialState.Specialist, 2, 65, new int[4] { 0, 4, 4, 2 });
                    dat.EmployersDataAdd(EmployerType.Hotel, 1 * 4);
                    dat.EmployersDataAdd(EmployerType.Trade, 1 * 6);
                    dat.PlaceDataAdd("Palais de la famille", "Quai céleste", "Boulevard des Saints");
                    dat.PlaceDataAdd("place du Nouvelle marché");
                    dat.PlaceDataAdd("parc Familial");
                    return dat;
                }
                case Ville.q_Eclaires: {
                    dat = new DistrictData("ÉCLAIRÉS", "Cœurville", "Fleurville", 7.2f);
                    dat.HomeDataAdd("Rou", SocialState.Specialist, 2, 65, new int[4] { 0, 4, 4, 2 });
                    dat.EmployersDataAdd(EmployerType.Education, 1 * 6);
                    dat.EmployersDataAdd(EmployerType.Office, 1 * 4);
                    dat.PlaceDataAdd("Synagogue de Bonheur", "Boulevard d'Amour", "Banque près de la Synagogue");
                    dat.PlaceDataAdd("place de la Synagogue", "place d'Honneur");
                    return dat;
                }
                case Ville.q_Hallesluxe: {
                    dat = new DistrictData("HALLESLUXE", "Gloir", "Fleurville", 17.2f);
                    dat.HomeDataAdd("Coi", SocialState.Responsible, 2, 25, new int[6] { 4, 4, 4, 4, 4, 2 });
                    dat.HomeDataAdd("Faç", SocialState.Professional, 2, 32, new int[6] { 4, 5, 5, 5, 5, 2 });
                    dat.EmployersDataAdd(EmployerType.Trade, 2 * 7);
                    dat.PlaceDataAdd("Halles de Ville", "Marché du Luxe");
                    dat.PlaceDataAdd("place de Marché");
                    dat.PlaceDataAdd("parc de Soleil");
                    return dat;
                }
                case Ville.q_Aquarelle: {
                    dat = new DistrictData("AQUARELLE", "Gloir", "Fleurville", 27.0f);
                    dat.HomeDataAdd("---", SocialState.Responsible, 2, 50, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Promenade: {
                    dat = new DistrictData("PROMENADE", "Gloir", "Fleurville", 11.0f);
                    dat.EmployersDataAdd(EmployerType.Administration, 1 * 6);
                    dat.EmployersDataAdd(EmployerType.Culture, 3 * 8);
                    dat.EmployersDataAdd(EmployerType.Hotel, 2 * 4);
                    dat.EmployersDataAdd(EmployerType.Medicine, 1 * 11 + 1 * 10 + 1 * 6);
                    dat.EmployersDataAdd(EmployerType.Office, 27 * 6 + 11 * 4);
                    dat.EmployersDataAdd(EmployerType.Services, 1 * 8);
                    dat.EmployersDataAdd(EmployerType.Trade, 1 * 6 + 2 * 2);
                    dat.PlaceDataAdd("Gouvernance de Jardin", "Hôpital de Fleurville", "Boulevard Royal", "Synagogue de Promenade",
                                     "Cental post de Ville", "Passage de Ville", "Maison de parfum et des huiles");
                    dat.PlaceDataAdd("place de Passage", "place Royal", "place de la Post");
                    dat.PlaceDataAdd("parc du Lac Royal");
                    return dat;
                }
                case Ville.q_Idylle: {
                    dat = new DistrictData("IDYLLE", "Impérial", "Fleurville", 18.2f);
                    dat.HomeDataAdd("Coi", SocialState.Responsible, 2, 25, new int[6] { 4, 4, 4, 4, 4, 2 });
                    dat.HomeDataAdd("Faç", SocialState.Professional, 2, 32, new int[6] { 4, 5, 5, 5, 5, 2 });
                    dat.EmployersDataAdd(EmployerType.Administration, 1 * 9 + 1 * 4);
                    dat.EmployersDataAdd(EmployerType.Culture, 1 * 3 + 1 * 12);
                    dat.EmployersDataAdd(EmployerType.Hotel, 1 * 6 + 6 * 4);
                    dat.PlaceDataAdd("Grand Hôtel de Ville", "Public conseil de Ville", "Club de Philosophie", "Quai de Roses",
                                     "Departament de Nature", "Boulevard de Théâtre");
                    dat.PlaceDataAdd("place de Roi");
                    return dat;
                }
                case Ville.q_Anthese: {
                    dat = new DistrictData("ANTHÈSE", "Impérial", "Fleurville", 13.9f);
                    dat.HomeDataAdd("Coi", SocialState.Responsible, 2, 25, new int[6] { 4, 4, 4, 4, 4, 2 });
                    dat.HomeDataAdd("Tri", SocialState.Professional, 5, 8, new int[5] { 0, 16, 16, 16, 16 });
                    dat.EmployersDataAdd(EmployerType.Administration, 1 * 36 + 1 * 15 + 1 * 9);
                    dat.EmployersDataAdd(EmployerType.Culture, 1 * 14);
                    dat.EmployersDataAdd(EmployerType.Education, 1 * 7 + 1 * 6);
                    dat.EmployersDataAdd(EmployerType.Office, 6 * 4);
                    dat.EmployersDataAdd(EmployerType.Sport, 1 * 8);
                    dat.EmployersDataAdd(EmployerType.Trade, 1 * 2);
                    dat.PlaceDataAdd("Fleurville Hôtel", "Departament de Développement", "Conseil du Royaume",
                                     "Grand Théâter de Ville", "Stade de Fleurville", "Bibliothèque de Fleurville");
                    dat.PlaceDataAdd("place de Théâter");
                    dat.PlaceDataAdd("parc de Fluerville");
                    return dat;
                }
                case Ville.q_Perpetuel: {
                    dat = new DistrictData("PERPÉTUEL", "Promission", "Fleurville", 17.5f);
                    dat.HomeDataAdd("Coi", SocialState.Responsible, 2, 25, new int[6] { 4, 4, 4, 4, 4, 2 });
                    dat.HomeDataAdd("Faç", SocialState.Professional, 2, 32, new int[6] { 4, 5, 5, 5, 5, 2 });
                    dat.EmployersDataAdd(EmployerType.Education, 1 * 15);
                    dat.PlaceDataAdd("Lycée de Vlle");
                    dat.PlaceDataAdd("parc de Lycée");
                    return dat;
                }
                case Ville.q_Sabbat: {
                    dat = new DistrictData("SABBAT", "Promission", "Fleurville", 36.6f);
                    dat.HomeDataAdd("---", SocialState.Responsible, 2, 100, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Victoire: {
                    dat = new DistrictData("VICTOIRE", "Palefroi", "Fleurville", 22.4f);
                    dat.EmployersDataAdd(EmployerType.Administration, 3 * 15 + 6 * 10 + 1 * 6 + 1 * 4);
                    dat.EmployersDataAdd(EmployerType.Culture, 1 * 16);
                    dat.EmployersDataAdd(EmployerType.Education, 1 * 15);
                    dat.EmployersDataAdd(EmployerType.Hotel, 1 * 28 + 1 * 16 + 3 * 10 + 3 * 6 + 1 * 4);
                    dat.EmployersDataAdd(EmployerType.Office, 13 * 6 + 4 * 4);
                    dat.EmployersDataAdd(EmployerType.Trade, 1 * 10 + 1 * 7 + 1 * 2);
                    dat.PlaceDataAdd("Premium Lux Hôtel", "Hôtel de Monde Perpétuel", "Centre d'affaires de Paradise",
                                     "Hôtel Royal", "Centre culturel du Royaume", "Royaumetour",
                                     "Dép-t d'économie", "Dép-t des transports", "Dép-t de l'eau et des ressources",
                                     "Dép-t des arts", "Dép-t d'éducation", "Dép-t de haute technologie", "Dép-t de la société",
                                     "Dép-t de l'environnement", "Dép-t de l'énergie", "Dép-t du commerce");
                    dat.PlaceDataAdd("place d'Élite", "place de l'Unité", "place de Vitalité", "place de la Victoire");
                    return dat;
                }
                case Ville.q_Lumiere: {
                    dat = new DistrictData("LUMIÈRE", "Palefroi", "Fleurville", 19.4f);
                    dat.EmployersDataAdd(EmployerType.Culture, 1 * 11 + 1 * 9 + 1 * 8 + 1 * 3 + 1 * 2);
                    dat.EmployersDataAdd(EmployerType.Education, 1 * 18);
                    dat.EmployersDataAdd(EmployerType.Hotel, 1 * 6);
                    dat.EmployersDataAdd(EmployerType.Office, 24 * 6 + 62 * 4 + 1 * 2);
                    dat.EmployersDataAdd(EmployerType.Trade, 1 * 2);
                    dat.PlaceDataAdd("Musée de la ville", "Musée d'Art", "Institut de la Société", "Monument à l'Harmonie",
                                     "CC Panorama", "Home cinéma");
                    dat.PlaceDataAdd("place de la Paroisse", "place des Arts");
                    return dat;
                }
                case Ville.q_Iris: {
                    dat = new DistrictData("IRIS", "Palefroi", "Fleurville", 33.9f);
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Sophora: {
                    dat = new DistrictData("SOPHORA", "Palefroi", "Fleurville", 10.1f);
                    dat.EmployersDataAdd(EmployerType.Culture, 1 * 1);
                    dat.EmployersDataAdd(EmployerType.Education, 1 * 18);
                    dat.EmployersDataAdd(EmployerType.Hotel, 2 * 6 + 1 * 4);
                    dat.EmployersDataAdd(EmployerType.Office, 7 * 6 + 20 * 4);
                    dat.EmployersDataAdd(EmployerType.Services, 2 * 5);
                    dat.EmployersDataAdd(EmployerType.Sport, 1 * 10 + 1 * 4);
                    dat.EmployersDataAdd(EmployerType.Trade, 2 * 7 + 2 * 6);
                    dat.PlaceDataAdd("Institut de Liaison", "Gare routière Centrale", "Salle de concert Sophora");
                    dat.PlaceDataAdd("place des Concerts");
                    dat.PlaceDataAdd("parc Heureux");
                    return dat;
                }
                case Ville.q_Charme: {
                    dat = new DistrictData("CHARME", "Soleil", "Côtierville", 17.4f);
                    dat.HomeDataAdd("---", SocialState.Professional, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Cotecorail: {
                    dat = new DistrictData("CÔTECORAIL", "Soleil", "Côtierville", 15.0f);
                    dat.HomeDataAdd("---", SocialState.Responsible, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Artisan: {
                    dat = new DistrictData("ARTISAN", "Soleil", "Côtierville", 36.0f);
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Chandelle: {
                    dat = new DistrictData("CHANDELLE", "Couleur", "Côtierville", 24.3f);
                    dat.HomeDataAdd("---", SocialState.Specialist, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Parfumeur: {
                    dat = new DistrictData("PARFUMEUR", "Couleur", "Côtierville", 11.3f);
                    dat.HomeDataAdd("---", SocialState.Worker, 2, 50, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Gremil: {
                    dat = new DistrictData("GRÉMIL", "Couleur", "Côtierville", 18.3f);
                    dat.HomeDataAdd("---", SocialState.Worker, 2, 50, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Hulotte: {
                    dat = new DistrictData("HULOTTE", "Couleur", "Côtierville", 98.4f);
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Prosperite:  {
                    dat = new DistrictData("PROSPÉRITÉ", "Castel", "Côtierville", 21.8f);
                    dat.HomeDataAdd("---", SocialState.Specialist, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Pastel: {
                    dat = new DistrictData("PASTEL", "Castel", "Côtierville", 24.4f);
                    dat.HomeDataAdd("---", SocialState.Specialist, 2, 50, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Sansonnet: {
                    dat = new DistrictData("SANSONNET", "Castel", "Côtierville", 21.5f);
                    dat.HomeDataAdd("---", SocialState.Professional, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Cotepalmier: {
                    dat = new DistrictData("CÔTEPALMIER", "Chaleur", "Côtierville", 46.2f);
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Cotecafe:  {
                    dat = new DistrictData("CÔTECAFÉ", "Chaleur", "Côtierville", 13.4f);
                    dat.HomeDataAdd("---", SocialState.Professional, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Brise: {
                    dat = new DistrictData("BRISE", "Chaleur", "Côtierville", 15.6f);
                    dat.HomeDataAdd("---", SocialState.Responsible, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Tadorne: {
                    dat = new DistrictData("TADORNE", "Tropique", "Côtierville", 31.7f);
                    dat.HomeDataAdd("---", SocialState.Professional, 2, 50, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Cocotier: {
                    dat = new DistrictData("COCOTIER", "Tropique", "Côtierville", 26.7f);
                    dat.HomeDataAdd("---", SocialState.Specialist, 2, 100, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Montfee: {
                    dat = new DistrictData("MONTFÉE", "Tropique", "Côtierville", 203.4f);
                    dat.HomeDataAdd("---", SocialState.Responsible, 2, 25, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Nichoir: {
                    dat = new DistrictData("NICHOIR", "Roquerie", "Montville", 96.4f);
                    dat.HomeDataAdd("---", SocialState.Worker, 2, 50, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Trefleblue: {
                    dat = new DistrictData("TRÈFLEBLUE", "Roquerie", "Montville", 35.9f);
                    dat.HomeDataAdd("---", SocialState.Specialist, 2, 50, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Paysage: {
                    dat = new DistrictData("PAYSAGE", "Ravinlis", "Montville", 22.9f);
                    dat.HomeDataAdd("---", SocialState.Specialist, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Croissance: {
                    dat = new DistrictData("CROISSANCE", "Ravinlis", "Montville", 30.5f);
                    dat.HomeDataAdd("---", SocialState.Professional, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Tilleul: {
                    dat = new DistrictData("TILLEUL", "Ravinlis", "Montville", 117.3f);
                    dat.HomeDataAdd("---", SocialState.Worker, 2, 50, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Enchanteur: {
                    dat = new DistrictData("ENCHANTEUR", "Liberté", "Montville", 36.6f);
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Sublimite: {
                    dat = new DistrictData("SUBLIMITÉ", "Liberté", "Montville", 35.6f);
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Tulipier: {
                    dat = new DistrictData("TULIPIER", "Brume", "Montville", 34.3f);
                    dat.HomeDataAdd("---", SocialState.Professional, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Montpistache: {
                    dat = new DistrictData("MONTPISTACHE", "Brume", "Montville", 142.1f);
                    dat.HomeDataAdd("---", SocialState.Professional, 2, 50, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Accalmie: {
                    dat = new DistrictData("ACCALMIE", "Brume", "Montville", 61.6f);
                    dat.HomeDataAdd("---", SocialState.Specialist, 2, 100, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Mielfaine: {
                    dat = new DistrictData("MIELFAINE", "Promontoire", "Rivièrville", 19.2f);
                    dat.HomeDataAdd("---", SocialState.Worker, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Boishetre: {
                    dat = new DistrictData("BOISHÊTRE", "Promontoire", "Rivièrville", 31.7f);
                    dat.HomeDataAdd("---", SocialState.Worker, 2, 50, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Blancheur: {
                    dat = new DistrictData("BLANCHEUR", "Promontoire", "Rivièrville", 41.0f);
                    dat.HomeDataAdd("---", SocialState.Worker, 2, 50, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Cheveche: {
                    dat = new DistrictData("CHEVÊCHE", "Oiselle", "Rivièrville", 40.9f);
                    dat.HomeDataAdd("---", SocialState.Specialist, 2, 100, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Perroquet: {
                    dat = new DistrictData("PERROQUET", "Oiselle", "Rivièrville", 26.6f);
                    dat.HomeDataAdd("---", SocialState.Responsible, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Charite: {
                    dat = new DistrictData("CHARITÉ", "Grâce", "Rivièrville", 22.6f);
                    dat.HomeDataAdd("---", SocialState.Professional, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Aronde: {
                    dat = new DistrictData("ARONDE", "Grâce", "Rivièrville", 38.8f);
                    dat.HomeDataAdd("---", SocialState.Specialist, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Palaisreine: {
                    dat = new DistrictData("PALAISREINE", "Grâce", "Rivièrville", 31.9f);
                    dat.HomeDataAdd("---", SocialState.Professional, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Parcoiseau: {
                    dat = new DistrictData("PARCOISEAU", "Parcville", "Rivièrville", 193.5f);
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Nectar: {
                    dat = new DistrictData("NECTAR", "Conte", "Boisville", 80.8f);
                    dat.HomeDataAdd("---", SocialState.Specialist, 2, 100, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Lambruche: {
                    dat = new DistrictData("LAMBRUCHE", "Conte", "Boisville", 41.0f);
                    dat.HomeDataAdd("---", SocialState.Specialist, 2, 100, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Accord: {
                    dat = new DistrictData("ACCORD", "Serein", "Boisville", 70.2f);
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Pivoine: {
                    dat = new DistrictData("PIVOINE", "Versantvert", "Boisville", 67.0f);
                    dat.HomeDataAdd("---", SocialState.Worker, 2, 50, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Peinardise: {
                    dat = new DistrictData("PEINARDISE", "Versantvert", "Boisville", 59.5f);
                    dat.HomeDataAdd("---", SocialState.Professional, 2, 50, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Purete: {
                    dat = new DistrictData("PURETÉ", "Clémence", "Boisville", 36.6f);
                    dat.HomeDataAdd("---", SocialState.Professional, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Renardeau: {
                    dat = new DistrictData("RENARDEAU", "Clémence", "Boisville", 16.5f);
                    dat.HomeDataAdd("---", SocialState.Professional, 2, 50, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Ormaie: {
                    dat = new DistrictData("ORMAIE", "Clémence", "Boisville", 31.1f);
                    dat.HomeDataAdd("---", SocialState.Professional, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Comtefleur: {
                    dat = new DistrictData("COMTEFLEUR", "Prestige", "Boisville", 24.1f);
                    dat.HomeDataAdd("---", SocialState.Responsible, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Licorne: {
                    dat = new DistrictData("LICORNE", "Prestige", "Boisville", 22.1f);
                    dat.HomeDataAdd("---", SocialState.Professional, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Gare: {
                    dat = new DistrictData("GARE", "Prestige", "Boisville", 15.1f);
                    dat.HomeDataAdd("---", SocialState.Professional, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Bruyere: {
                    dat = new DistrictData("BRUYÈRE", "Occidental", "Boisville", 188.8f);
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Interfluve: {
                    dat = new DistrictData("INTERFLUVE", "Lotus", "Merville", 17.7f);
                    dat.HomeDataAdd("---", SocialState.Professional, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Orchidee: {
                    dat = new DistrictData("ORCHIDÉE", "Lotus", "Merville", 23.5f);
                    dat.HomeDataAdd("---", SocialState.Professional, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Cygneblanch: {
                    dat = new DistrictData("CYGNEBLANCH", "Lotus", "Merville", 54.3f);
                    dat.HomeDataAdd("---", SocialState.Professional, 2, 100, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Aber: {
                    dat = new DistrictData("ABER", "Zénith", "Merville", 33.4f);
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Suavite: {
                    dat = new DistrictData("SUAVITÉ", "Zénith", "Merville", 13.0f);
                    dat.HomeDataAdd("---", SocialState.Professional, 2, 50, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Suffle: {
                    dat = new DistrictData("SUFFLÉ", "Zénith", "Merville", 23.3f);
                    dat.HomeDataAdd("---", SocialState.Specialist, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Harmonie: {
                    dat = new DistrictData("HARMONIE", "Zénith", "Merville", 16.6f);
                    dat.HomeDataAdd("---", SocialState.Responsible, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Cedres: {
                    dat = new DistrictData("CÈDRES", "Vanille", "Merville", 34.5f);
                    dat.HomeDataAdd("---", SocialState.Worker, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Gattilier: {
                    dat = new DistrictData("GATTILIER", "Vanille", "Merville", 15.0f);
                    dat.HomeDataAdd("---", SocialState.Worker, 2, 50, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Littoral: {
                    dat = new DistrictData("LITTORAL", "Maritime", "Merville", 17.4f);
                    dat.HomeDataAdd("---", SocialState.Professional, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Coquille: {
                    dat = new DistrictData("COQUILLE", "Maritime", "Merville", 35.4f);
                    dat.HomeDataAdd("---", SocialState.Responsible, 2, 50, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Goeland: {
                    dat = new DistrictData("GOÉLAND", "Maritime", "Merville", 57.4f);
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Tissage: {
                    dat = new DistrictData("TISSAGE", "Phare", "Merville", 128.0f);
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Ville.q_Port: {
                    dat = new DistrictData("PORT", "Phare", "Merville", 78.4f);
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
            }
            return new DistrictData();
        }
    }
}
