namespace ParadiseVille
{
    /// <summary>
    /// Data of city disctricts
    /// </summary>
    public static class DataVille
    {
        public static DistrictData Information(Quartier quartier)
        {
            DistrictData dat;

            switch (quartier)
            {
                case Quartier.q_Jardinfleuri: {
                    dat = new DistrictData("JARDINFLEURI", "Montfleur", "Fleurville", 91.9f, 0);
                    dat.HomeDataAdd("Cas", SocialState.Responsible, 1, 1, new int[1] { 1 });
                    dat.HomeDataAdd("Boi", SocialState.Specialist, 2, 25, new int[1] { 4 });
                    dat.EmployersDataAdd(EmployerType.Culture, 1 * 22);
                    dat.EmployersDataAdd(EmployerType.Administration, 1 * 2);
                    dat.PlaceDataAdd("Château de Paradis", "Synédroin", "Synagogue de Bois");
                    dat.PlaceDataAdd("place de Boisé");
                    dat.PlaceDataAdd("Bois de Paradis");
                    return dat;
                }
                case Quartier.q_Ilechateau: {
                    dat = new DistrictData("ÎLECHÂTEAU", "Montfleur", "Fleurville", 24.8f, -300);
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
                case Quartier.q_Roifrenaie: {
                    dat = new DistrictData("ROIFRÊNAIE", "Montfleur", "Fleurville", 13.8f, 3);
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
                case Quartier.q_Cotelevant: {
                    dat = new DistrictData("CÔTELEVANT", "Montfleur", "Fleurville", 19.0f, 12);
                    dat.HomeDataAdd("Rou", SocialState.Professional, 2, 81, new int[3] { 0, 5, 4 });
                    dat.HomeDataAdd("Bla", SocialState.Responsible, 5, 1, new int[3] { 7, 8, 8 });
                    dat.EmployersDataAdd(EmployerType.Hotel, 1 * 6);
                    dat.EmployersDataAdd(EmployerType.Trade, 2 * 4);
                    dat.PlaceDataAdd("palais du Governeur", "Source de guérison");
                    dat.PlaceDataAdd("place de l'Aube", "place du Lagune");
                    dat.PlaceDataAdd("parc de Governeur");
                    return dat;
                }
                case Quartier.q_Hotel: {
                    dat = new DistrictData("HÔTEL", "Cœurville", "Fleurville", 8.9f, 4);
                    dat.HomeDataAdd("Rou", SocialState.Specialist, 2, 47, new int[4] { 0, 4, 4, 2 });
                    dat.EmployersDataAdd(EmployerType.Administration, 1 * 9);
                    dat.EmployersDataAdd(EmployerType.Culture, 1 * 3);
                    dat.PlaceDataAdd("Hôtel de Ville", "Synagogue de la Joie", "Boulevard du Fleurs");
                    dat.PlaceDataAdd("place du Cœure", "place Piémont");
                    return dat;
                }
                case Quartier.q_Riveciel: {
                    dat = new DistrictData("RIVECIEL", "Cœurville", "Fleurville", 12.6f, 8);
                    dat.HomeDataAdd("Rou", SocialState.Specialist, 2, 64, new int[4] { 0, 4, 4, 2 });
                    dat.EmployersDataAdd(EmployerType.Hotel, 1 * 4);
                    dat.EmployersDataAdd(EmployerType.Trade, 1 * 6);
                    dat.PlaceDataAdd("Palais de la Famille", "Quaie Céleste", "Boulevard des Saints", "Marche de la Rive");
                    dat.PlaceDataAdd("place du Nouvelle marché", "place de la Foire");
                    dat.PlaceDataAdd("parc Familial");
                    return dat;
                }
                case Quartier.q_Eclaires: {
                    dat = new DistrictData("ÉCLAIRÉS", "Cœurville", "Fleurville", 13.3f, 19);
                    dat.HomeDataAdd("Rou", SocialState.Specialist, 2, 67, new int[4] { 0, 4, 4, 2 });
                    dat.EmployersDataAdd(EmployerType.Education, 1 * 6);
                    dat.EmployersDataAdd(EmployerType.Office, 1 * 4);
                    dat.PlaceDataAdd("Synagogue de Bonheur", "Grand porte du Paradise", "Boulevard d'Amour",
                                     "Banque près de la Synagogue");
                    dat.PlaceDataAdd("place de la Synagogue", "place d'Honneur", "place de Porte");
                    return dat;
                }
                case Quartier.q_Hallesluxe: {
                    dat = new DistrictData("HALLESLUXE", "Gloir", "Fleurville", 14.5f, 11);
                    dat.HomeDataAdd("Coi", SocialState.Responsible, 2, 16, new int[6] { 4, 4, 4, 4, 4, 2 });
                    dat.HomeDataAdd("Faç", SocialState.Professional, 2, 22, new int[6] { 4, 5, 5, 5, 5, 2 });
                    dat.EmployersDataAdd(EmployerType.Trade, 1 * 7);
                    dat.PlaceDataAdd("Halles de Ville");
                    dat.PlaceDataAdd("place de Marché");
                    dat.PlaceDataAdd("parc Doré");
                    return dat;
                }
                case Quartier.q_Promenade: {
                    dat = new DistrictData("PROMENADE", "Gloir", "Fleurville", 12.1f, 9);
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
                    return dat;
                }
                case Quartier.q_Idylle: {
                    dat = new DistrictData("IDYLLE", "Impérial", "Fleurville", 21.3f, 25);
                    dat.HomeDataAdd("Coi", SocialState.Responsible, 2, 28, new int[6] { 4, 4, 4, 4, 4, 2 });
                    dat.HomeDataAdd("Faç", SocialState.Professional, 2, 22, new int[6] { 4, 5, 5, 5, 5, 2 });
                    dat.EmployersDataAdd(EmployerType.Administration, 1 * 9 + 1 * 4);
                    dat.EmployersDataAdd(EmployerType.Culture, 1 * 3 + 1 * 12);
                    dat.EmployersDataAdd(EmployerType.Hotel, 1 * 6 + 5 * 4);
                    dat.EmployersDataAdd(EmployerType.Education, 1 * 6);
                    dat.PlaceDataAdd("Grand Hôtel de Ville", "Public conseil de Ville", "Club de Philosophie", "Quai de Roses",
                                     "Departament de Nature", "Boulevard de Théâtre");
                    dat.PlaceDataAdd("place de la Philosophie");
                    return dat;
                }
                case Quartier.q_Theatrie: {
                    dat = new DistrictData("THÉÂTRIE", "Impérial", "Fleurville", 10.7f, 28);
                    dat.HomeDataAdd("Coi", SocialState.Responsible, 2, 16, new int[6] { 4, 4, 4, 4, 4, 2 });
                    dat.HomeDataAdd("Faç", SocialState.Professional, 2, 8, new int[6] { 4, 5, 5, 5, 5, 2 });
                    dat.EmployersDataAdd(EmployerType.Office, 6 * 4);
                    dat.EmployersDataAdd(EmployerType.Culture, 1 * 14);
                    dat.EmployersDataAdd(EmployerType.Trade, 1 * 2);
                    dat.PlaceDataAdd("place de Théâter");
                    dat.PlaceDataAdd("Grand Théâter de Ville");
                    return dat;
                }
                case Quartier.q_Anthese: {
                    dat = new DistrictData("ANTHÈSE", "Impérial", "Fleurville", 13.6f, 21);
                    dat.HomeDataAdd("Coi", SocialState.Responsible, 2, 4, new int[6] { 4, 4, 4, 4, 4, 2 });
                    dat.HomeDataAdd("Tri", SocialState.Professional, 5, 8, new int[5] { 0, 16, 16, 16, 16 });
                    dat.EmployersDataAdd(EmployerType.Administration, 1 * 36 + 1 * 15 + 1 * 9);
                    dat.EmployersDataAdd(EmployerType.Education, 1 * 7 + 1 * 6);
                    dat.EmployersDataAdd(EmployerType.Sport, 1 * 8);
                    dat.EmployersDataAdd(EmployerType.Trade, 1 * 7);
                    dat.PlaceDataAdd("Fleurville Hôtel", "Departament de Développement", "Conseil du Royaume",
                                     "Stade de Fleurville", "Bibliothèque de Fleurville", "Marché du Luxe");
                    dat.PlaceDataAdd("parc de Fluerville");
                    return dat;
                }
                case Quartier.q_Perpetuel: {
                    dat = new DistrictData("PERPÉTUEL", "Perfection", "Fleurville", 18.5f, 27);
                    dat.HomeDataAdd("Coi", SocialState.Responsible, 2, 28, new int[6] { 4, 4, 4, 4, 4, 2 });
                    dat.HomeDataAdd("Faç", SocialState.Professional, 2, 18, new int[6] { 4, 5, 5, 5, 5, 2 });
                    dat.EmployersDataAdd(EmployerType.Education, 1 * 15 + 1 * 6);
                    dat.PlaceDataAdd("Lycée de Vlle");
                    dat.PlaceDataAdd("parc de Lycée");
                    dat.PlaceDataAdd("place d'Amour");
                    return dat;
                }
                case Quartier.q_Sabbat: {
                    dat = new DistrictData("SABBAT", "Perfection", "Fleurville", 17.8f, 48);
                    dat.HomeDataAdd("Noi", SocialState.Responsible, 2, 6, new int[6] { 0, 3, 3, 3, 3, 3 });
                    dat.HomeDataAdd("Jeu", SocialState.Responsible, 5, 6, new int[7] { 8, 8, 8, 8, 8, 8, 8 });
                    dat.HomeDataAdd("Bla", SocialState.Responsible, 5, 5, new int[3] { 7, 8, 8 });
                    dat.EmployersDataAdd(EmployerType.Culture, 1 * 24 + 1 * 3);
                    dat.EmployersDataAdd(EmployerType.Hotel, 1 * 4);
                    dat.EmployersDataAdd(EmployerType.Trade, 1 * 6);
                    dat.PlaceDataAdd("Synagogue de l'Amour", "Boulevard de la Cathédrale", "Grattes Ciels du Dôme",
                                     "Boulevard Pastoral", "Quaie de Samedi");
                    dat.PlaceDataAdd("place du Dôme");
                    dat.PlaceDataAdd("parc de Création");
                    return dat;
                }
                case Quartier.q_Palaisroyal: {
                    dat = new DistrictData("PALAISROYAL", "Prince", "Fleurville", 11.0f, 24);
                    dat.HomeDataAdd("Tri", SocialState.Responsible, 5, 11, new int[6] { 6, 12, 12, 12, 12, 4 });
                    dat.HomeDataAdd("Coi", SocialState.Responsible, 2, 5, new int[6] { 4, 4, 4, 4, 4, 2 });
                    dat.EmployersDataAdd(EmployerType.Education, 1 * 11 + 1 * 6);
                    dat.EmployersDataAdd(EmployerType.Hotel, 1 * 4);
                    dat.EmployersDataAdd(EmployerType.Sport, 1 * 8);
                    dat.EmployersDataAdd(EmployerType.Trade, 1 * 6);
                    dat.PlaceDataAdd("Centre Éducatif");
                    dat.PlaceDataAdd("place de l'Éducation");
                    return dat;
                }
                case Quartier.q_Roseraie: {
                    dat = new DistrictData("ROSERAIE", "Prince", "Fleurville", 16.2f, 17);
                    dat.HomeDataAdd("Tri", SocialState.Responsible, 5, 4, new int[6] { 6, 12, 12, 12, 12, 4 });
                    dat.HomeDataAdd("Coi", SocialState.Responsible, 2, 18, new int[6] { 4, 4, 4, 4, 4, 2 });
                    dat.HomeDataAdd("Faç", SocialState.Professional, 2, 10, new int[6] { 4, 5, 5, 5, 5, 2 });
                    dat.EmployersDataAdd(EmployerType.Culture, 1 * 16);
                    dat.PlaceDataAdd("synagogue de l'Esprit de Dieu");
                    dat.PlaceDataAdd("place de la Porte Sud", "place du Portail du Chapelet");
                    dat.PlaceDataAdd("parc du Lac Royal", "parc Paradis Fleuri");
                    return dat;
                }
                case Quartier.q_Victoire: {
                    dat = new DistrictData("VICTOIRE", "Palefroi", "Fleurville", 15.3f, 26);
                    dat.EmployersDataAdd(EmployerType.Administration, 3 * 10 + 1 * 4);
                    dat.EmployersDataAdd(EmployerType.Hotel, 1 * 28 + 3 * 10 + 1 * 6 + 1 * 4);
                    dat.EmployersDataAdd(EmployerType.Office, 11 * 6 + 4 * 4);
                    dat.EmployersDataAdd(EmployerType.Trade, 1 * 10);
                    dat.PlaceDataAdd("Premium Lux Hôtel", "Hôtel de Monde Perpétuel", 
                                     "Centre d'affaires de Paradise", "Hôtel Royal", "Dép-t d'éducation",  
                                     "Dép-t de l'énergie", "Dép-t du commerce");
                    dat.PlaceDataAdd("place d'Élite", "place de Vitalité");
                    return dat;
                }
                case Quartier.q_Lumiere: {
                    dat = new DistrictData("LUMIÈRE", "Palefroi", "Fleurville", 22.9f, 29);
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
                case Quartier.q_Sophora: {
                    dat = new DistrictData("SOPHORA", "Palefroi", "Fleurville", 10.5f, 56);
                    dat.EmployersDataAdd(EmployerType.Education, 1 * 18);
                    dat.EmployersDataAdd(EmployerType.Hotel, 2 * 6 + 1 * 4);
                    dat.EmployersDataAdd(EmployerType.Office, 7 * 6 + 20 * 4);
                    dat.EmployersDataAdd(EmployerType.Services, 2 * 5);
                    dat.EmployersDataAdd(EmployerType.Trade, 2 * 7 + 2 * 6);
                    dat.PlaceDataAdd("Institut de Liaison", "Gare routière Centrale", "Marché aux Fleurs");
                    dat.PlaceDataAdd("parc Heureux");
                    return dat;
                }
                case Quartier.q_Ciel: {
                    dat = new DistrictData("CIEL", "Palefroi", "Fleurville", 10.3f, 22);
                    dat.EmployersDataAdd(EmployerType.Administration, 2 * 15 + 4 * 10 + 1 * 6);
                    dat.EmployersDataAdd(EmployerType.Culture, 1 * 16);
                    dat.EmployersDataAdd(EmployerType.Education, 1 * 15);
                    dat.EmployersDataAdd(EmployerType.Hotel, 1 * 16 + 2 * 6);
                    dat.EmployersDataAdd(EmployerType.Office, 2 * 6);
                    dat.EmployersDataAdd(EmployerType.Trade, 1 * 7 + 1 * 2);
                    dat.PlaceDataAdd("Centre culturel du Royaume", "Royaumetour", "Dép-t d'économie", 
                                     "Dép-t des transports", "Dép-t de l'eau et des ressources", "Dép-t des arts",
                                     "Dép-t de haute technologie", "Dép-t de l'environnement", 
                                     "Dép-t de la société");
                    dat.PlaceDataAdd("place de l'Unité", "place de le Monde", "place de l'Eau");
                    return dat;
                }
                case Quartier.q_Iris: {
                    dat = new DistrictData("IRIS", "Lucide", "Fleurville", 13.8f, 28);
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Parcamour: {
                    dat = new DistrictData("PARCAMOUR", "Lucide", "Fleurville", 31.5f, 24);
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Charme: {
                    dat = new DistrictData("CHARME", "Soleil", "Côtierville", 20.5f, 69);
                    dat.HomeDataAdd("---", SocialState.Professional, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Cotecorail: {
                    dat = new DistrictData("CÔTECORAIL", "Soleil", "Côtierville", 22.8f, 117);
                    dat.HomeDataAdd("---", SocialState.Responsible, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Artisan: {
                    dat = new DistrictData("ARTISAN", "Soleil", "Côtierville", 34.2f, 65);
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Chandelle: {
                    dat = new DistrictData("CHANDELLE", "Couleur", "Côtierville", 27.7f, 110);
                    dat.HomeDataAdd("---", SocialState.Specialist, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Parfumeur: {
                    dat = new DistrictData("PARFUMEUR", "Couleur", "Côtierville", 11.3f, 112);
                    dat.HomeDataAdd("---", SocialState.Worker, 2, 50, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Gremil: {
                    dat = new DistrictData("GRÉMIL", "Couleur", "Côtierville", 20.9f, 128);
                    dat.HomeDataAdd("---", SocialState.Worker, 2, 50, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Hulotte: {
                    dat = new DistrictData("HULOTTE", "Couleur", "Côtierville", 113.8f, 90);
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Prosperite:  {
                    dat = new DistrictData("PROSPÉRITÉ", "Castel", "Côtierville", 23.3f, 79);
                    dat.HomeDataAdd("---", SocialState.Specialist, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Pastel: {
                    dat = new DistrictData("PASTEL", "Castel", "Côtierville", 29.0f, 86);
                    dat.HomeDataAdd("---", SocialState.Specialist, 2, 50, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Sansonnet: {
                    dat = new DistrictData("SANSONNET", "Castel", "Côtierville", 24.5f, 194);
                    dat.HomeDataAdd("---", SocialState.Professional, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Cotepalmier: {
                    dat = new DistrictData("CÔTEPALMIER", "Chaleur", "Côtierville", 54.1f, 127); // 127 - palace // 211 - aquapark
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Cotecafe:  {
                    dat = new DistrictData("CÔTECAFÉ", "Chaleur", "Côtierville", 14.0f, 147);
                    dat.HomeDataAdd("---", SocialState.Professional, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Brise: {
                    dat = new DistrictData("BRISE", "Chaleur", "Côtierville", 15.6f, 151);
                    dat.HomeDataAdd("---", SocialState.Responsible, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Tadorne: {
                    dat = new DistrictData("TADORNE", "Tropique", "Côtierville", 39.1f, 91);
                    dat.HomeDataAdd("---", SocialState.Professional, 2, 50, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Cocotier: {
                    dat = new DistrictData("COCOTIER", "Tropique", "Côtierville", 31.5f, 164);
                    dat.HomeDataAdd("---", SocialState.Specialist, 2, 100, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Montfee: {
                    dat = new DistrictData("MONTFÉE", "Tropique", "Côtierville", 203.6f, 215);
                    dat.HomeDataAdd("---", SocialState.Responsible, 2, 25, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Nichoir: {
                    dat = new DistrictData("NICHOIR", "Roquerie", "Montville", 43.1f, 260);
                    dat.HomeDataAdd("Jeu", SocialState.Worker, 2, 55, new int[3] { 4, 4, 4 });
                    dat.EmployersDataAdd(EmployerType.Education, 1 * 6);
                    dat.EmployersDataAdd(EmployerType.Sport, 1 * 3);
                    dat.EmployersDataAdd(EmployerType.Trade, 1 * 3);
                    dat.PlaceDataAdd("parc de Chant");
                    return dat;
                }
                case Quartier.q_Horizon: {
                    dat = new DistrictData("HORIZON", "Roquerie", "Montville", 24.0f, 378);
                    dat.HomeDataAdd("Rou", SocialState.Worker, 2, 43, new int[3] { 4, 4, 4 });
                    dat.EmployersDataAdd(EmployerType.Sport, 1 * 6 + 1 * 4);
                    dat.EmployersDataAdd(EmployerType.Services, 1 * 8);
                    dat.PlaceDataAdd("sylviculture de Ville");
                    dat.PlaceDataAdd("place de Porte de Mont");
                    dat.PlaceDataAdd("parc d'Horizon Vert");
                    return dat;
                }
                case Quartier.q_Genievre: {
                    dat = new DistrictData("GENIÈVRE", "Roquerie", "Montville", 181.5f, 382);
                    dat.HomeDataAdd("Blu", SocialState.Professional, 1, 29, new int[4] { 2, 2, 2, 1 });
                    dat.EmployersDataAdd(EmployerType.Culture, 1 * 3);
                    dat.EmployersDataAdd(EmployerType.Production, 9 * 10 + 3 * 4);
                    dat.PlaceDataAdd("CC Roquerie", "Technoparc de étoile d'été", "Synagogue Roquerie");
                    dat.PlaceDataAdd("bois de Chênes Côtière");
                    return dat;
                }
                case Quartier.q_Paysage: {
                    dat = new DistrictData("PAYSAGE", "Ravinlis", "Montville", 28.1f, 149);
                    dat.HomeDataAdd("---", SocialState.Specialist, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Croissance: {
                    dat = new DistrictData("CROISSANCE", "Ravinlis", "Montville", 36.0f, 153);
                    dat.HomeDataAdd("---", SocialState.Professional, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Tilleul: {
                    dat = new DistrictData("TILLEUL", "Ravinlis", "Montville", 129.7f, 205);
                    dat.HomeDataAdd("---", SocialState.Worker, 2, 50, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Trefleblue: {
                    dat = new DistrictData("TRÈFLEBLUE", "Ravinlis", "Montville", 43.6f, 156);
                    dat.HomeDataAdd("---", SocialState.Specialist, 2, 50, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Enchanteur: {
                    dat = new DistrictData("ENCHANTEUR", "Liberté", "Montville", 41.4f, 182);
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Sublimite: {
                    dat = new DistrictData("SUBLIMITÉ", "Liberté", "Montville", 39.7f, 184);
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Tulipier: {
                    dat = new DistrictData("TULIPIER", "Brume", "Montville", 38.5f, 276);
                    dat.HomeDataAdd("---", SocialState.Professional, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Montazur: {
                    dat = new DistrictData("MONTAZUR", "Brume", "Montville", 152.7f, 299);
                    dat.HomeDataAdd("---", SocialState.Professional, 2, 50, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Accalmie: {
                    dat = new DistrictData("ACCALMIE", "Brume", "Montville", 69.5f, 295);
                    dat.HomeDataAdd("---", SocialState.Specialist, 2, 100, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Mielfaine: {
                    dat = new DistrictData("MIELFAINE", "Promontoire", "Rivièrville", 31.2f, 54);
                    dat.HomeDataAdd("Col", SocialState.Worker, 2, 78, new int[5] { 0, 7, 0, 4, 0 });
                    dat.EmployersDataAdd(EmployerType.Education, 1 * 6);
                    dat.EmployersDataAdd(EmployerType.Office, 1 * 6);
                    dat.EmployersDataAdd(EmployerType.Trade, 1 * 6);
                    dat.PlaceDataAdd("parc Accueillant", "parc de Promontoire", "parc Commercial");
                    return dat;
                }
                case Quartier.q_Boishetre: {
                    dat = new DistrictData("BOISHÊTRE", "Promontoire", "Rivièrville", 33.7f, 55);
                    dat.HomeDataAdd("Bro", SocialState.Worker, 2, 71, new int[4] { 4, 2, 2, 0 });
                    dat.EmployersDataAdd(EmployerType.Culture, 1 * 3);
                    dat.PlaceDataAdd("Synagogue de Promontoire");
                    dat.PlaceDataAdd("place de la Lanternes");
                    dat.PlaceDataAdd("bois de Hêtres des Contreforts", "parc de la Colline Blanche");
                    return dat;
                }
                case Quartier.q_Blancheur: {
                    dat = new DistrictData("BLANCHEUR", "Promontoire", "Rivièrville", 43.1f, 324);
                    dat.HomeDataAdd("Bla", SocialState.Worker, 2, 59, new int[2] { 4, 5 });
                    dat.EmployersDataAdd(EmployerType.Hotel, 1 * 6 + 1 * 4);
                    dat.EmployersDataAdd(EmployerType.Services, 1 * 4);
                    dat.EmployersDataAdd(EmployerType.Trade, 1 * 6);
                    dat.PlaceDataAdd("Centre Écologique de Ville");
                    dat.PlaceDataAdd("place de la Blancheur");
                    dat.PlaceDataAdd("bois de Hêtres des Contreforts");
                    return dat;
                }
                case Quartier.q_Chatterie: {
                    dat = new DistrictData("CHATTERIE", "Oiselle", "Rivièrville", 28.6f, 125);
                    dat.HomeDataAdd("Blu", SocialState.Specialist, 2, 20, new int[5] { 0, 6, 6, 6, 8 });
                    dat.HomeDataAdd("Bla", SocialState.Specialist, 2, 34, new int[4] { 4, 4, 4, 4 });
                    dat.EmployersDataAdd(EmployerType.Culture, 1 * 16);
                    dat.EmployersDataAdd(EmployerType.Office, 8 * 7);
                    dat.EmployersDataAdd(EmployerType.Services, 1 * 1);
                    dat.PlaceDataAdd("Galerie de classiques", "CB Pavillon de Queue");
                    dat.PlaceDataAdd("place de Cheval", "place de la Chatterie", "place les Profitrole");
                    dat.PlaceDataAdd("parc de la Renaissance");
                    return dat;
                }
                case Quartier.q_Perroquet: {
                    dat = new DistrictData("PERROQUET", "Oiselle", "Rivièrville", 31.0f, 171);
                    dat.HomeDataAdd("Gri", SocialState.Responsible, 2, 23, new int[6] { 0, 2, 2, 2, 2, 2 });
                    dat.HomeDataAdd("Blu", SocialState.Professional, 2, 21, new int[7] { 3, 3, 3, 3, 3, 2, 3});
                    dat.HomeDataAdd("Bla", SocialState.Responsible, 5, 10, new int[6] {2, 7, 7, 7, 7, 2});
                    dat.EmployersDataAdd(EmployerType.Administration, 1 * 9);
                    dat.EmployersDataAdd(EmployerType.Sport, 1 * 10 + 1 * 8 + 1 * 1);
                    dat.EmployersDataAdd(EmployerType.Services, 1 * 4);
                    dat.EmployersDataAdd(EmployerType.Culture, 1 * 16 + 1 * 3);
                    dat.EmployersDataAdd(EmployerType.Trade, 1 * 7);
                    dat.EmployersDataAdd(EmployerType.Office, 1 * 4);
                    dat.PlaceDataAdd("Musée des Oiseaux", "CC de la Jardin d'Eden", "Grand Boulevard",
                                     "Synagogue de la Aurora");
                    dat.PlaceDataAdd("place de Perroquet", "place de la Rivièrville", "place de l'Orange");
                    return dat;
                }
                case Quartier.q_Buquet: {
                    dat = new DistrictData("BOUQUET", "Oiselle", "Rivièrville", 21.4f, 122);
                    dat.EmployersDataAdd(EmployerType.Services, 1 * 5 + 1 * 2);
                    dat.EmployersDataAdd(EmployerType.Trade, 1 * 17 + 1 * 13 + 1 * 10 + 1 * 7 + 2 * 4 + 3 * 2);
                    dat.EmployersDataAdd(EmployerType.Culture, 1 * 2 + 1 * 1);
                    dat.EmployersDataAdd(EmployerType.Sport, 2 * 10 + 1 * 4);
                    dat.EmployersDataAdd(EmployerType.Office, 12 * 6 + 7 * 4);
                    dat.EmployersDataAdd(EmployerType.Education, 1  * 20);
                    dat.PlaceDataAdd("Cente Commercial Oiselle", "Centre Commercial Park Boulevard",
                                     "Marché Carrefour", "Centre Technique Principal", "Centre de Musique",
                                     "Home Cinéma", "Complexe Sportif Longévité", "Lycée Professionnel",
                                     "Centre de l'enfant Jeune", "Salle de concert Sophora");
                    dat.PlaceDataAdd("place les Sept Fontaines ", "place des Concerts");
                    return dat;
                }
                case Quartier.q_Charite: {
                    dat = new DistrictData("CHARITÉ", "Grâce", "Rivièrville", 27.2f, 209);
                    dat.HomeDataAdd("Rou", SocialState.Professional, 2, 25, new int[6] { 1, 3, 3, 3, 3, 3 });
                    dat.HomeDataAdd("Noi", SocialState.Professional, 2, 21, new int[6] { 0, 3, 3, 3, 3, 3 });
                    dat.EmployersDataAdd(EmployerType.Services, 1 * 1);
                    dat.EmployersDataAdd(EmployerType.Culture, 1 * 24);
                    dat.PlaceDataAdd("Grand Boulevard", "Synagogue de Sacré Cœur");
                    dat.PlaceDataAdd("place de la Bonne Volonté");
                    dat.PlaceDataAdd("parc de la Sainteté");
                    return dat;
                }
                case Quartier.q_Aronde: {
                    dat = new DistrictData("ARONDE", "Grâce", "Rivièrville", 50.8f, 279);
                    dat.HomeDataAdd("Blu", SocialState.Specialist, 2, 35, new int[5] { 0, 3, 3, 3, 3 });
                    dat.HomeDataAdd("Noi", SocialState.Specialist, 2, 34, new int[5] { 0, 2, 2, 2, 2 });
                    dat.EmployersDataAdd(EmployerType.Sport, 1 * 8);
                    dat.EmployersDataAdd(EmployerType.Education, 1 * 15 + 1 * 6);
                    dat.EmployersDataAdd(EmployerType.Services, 1 * 1);
                    dat.EmployersDataAdd(EmployerType.Production, 2 * 4);
                    dat.EmployersDataAdd(EmployerType.Office, 1 * 6 + 2 * 4);
                    dat.PlaceDataAdd("Stade de Rivièrville", "Boulevard de Palais", "Marché Fertile");
                    dat.PlaceDataAdd("parc de la Grâce", "parc d'Été", "bois de Hêtres des Contreforts");
                    return dat;
                }
                case Quartier.q_Reinevue: {
                    dat = new DistrictData("REINEVUE", "Verger", "Rivièrville", 38.2f, 287);
                    dat.HomeDataAdd("Ver", SocialState.Professional, 2, 50, new int[4] { 4, 4, 4, 4 });
                    dat.EmployersDataAdd(EmployerType.Culture, 1 * 24);
                    dat.EmployersDataAdd(EmployerType.Sport, 1 * 14);
                    dat.EmployersDataAdd(EmployerType.Education, 1 * 6);
                    dat.EmployersDataAdd(EmployerType.Services, 2 * 1);
                    dat.PlaceDataAdd("Manège de la Confrérie", "Palais des Cadeaux", "Boulevard de Palais");
                    return dat;
                }
                case Quartier.q_Flute: {
                    dat = new DistrictData("FLÛTÉ", "Verger", "Rivièrville", 10.0f, 420);
                    dat.HomeDataAdd("Col", SocialState.Professional, 2, 16, new int[5] { 4, 10, 10, 10, 10 });
                    dat.EmployersDataAdd(EmployerType.Production, 6 * 4);
                    dat.PlaceDataAdd("Fabrique de Pain 'Nuage'");
                    dat.PlaceDataAdd("place de Bien");
                    return dat;
                }
                case Quartier.q_Parcoiseau: {
                    dat = new DistrictData("PARCOISEAU", "Parcville", "Rivièrville", 196.5f, 140);
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Nectar: {
                    dat = new DistrictData("NECTAR", "Conte", "Boisville", 70.0f, 61);
                    dat.HomeDataAdd("---", SocialState.Specialist, 2, 100, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Lambruche: {
                    dat = new DistrictData("LAMBRUCHE", "Conte", "Boisville", 46.1f, 136);
                    dat.HomeDataAdd("---", SocialState.Specialist, 2, 100, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Accord: {
                    dat = new DistrictData("ACCORD", "Serein", "Boisville", 80.3f, 63);
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Pivoine: {
                    dat = new DistrictData("PIVOINE", "Versantvert", "Boisville", 74.8f, 180);
                    dat.HomeDataAdd("---", SocialState.Worker, 2, 50, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Peinardise: {
                    dat = new DistrictData("PEINARDISE", "Versantvert", "Boisville", 59.5f, 226);
                    dat.HomeDataAdd("---", SocialState.Professional, 2, 50, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Purete: {
                    dat = new DistrictData("PURETÉ", "Clémence", "Boisville", 36.7f, 83);
                    dat.HomeDataAdd("---", SocialState.Professional, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Renardeau: {
                    dat = new DistrictData("RENARDEAU", "Clémence", "Boisville", 19.2f, 81);
                    dat.HomeDataAdd("---", SocialState.Professional, 2, 50, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Ormaie: {
                    dat = new DistrictData("ORMAIE", "Clémence", "Boisville", 34.4f, 220);
                    dat.HomeDataAdd("---", SocialState.Professional, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Comtefleur: {
                    dat = new DistrictData("COMTEFLEUR", "Prestige", "Boisville", 28.0f, 94);
                    dat.HomeDataAdd("---", SocialState.Responsible, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Licorne: {
                    dat = new DistrictData("LICORNE", "Prestige", "Boisville", 27.4f, 102);
                    dat.HomeDataAdd("---", SocialState.Professional, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Gare: {
                    dat = new DistrictData("GARE", "Prestige", "Boisville", 18.1f, 98); // new bei gare - gate = 105
                    dat.HomeDataAdd("---", SocialState.Professional, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Bruyere: {
                    dat = new DistrictData("BRUYÈRE", "Occidental", "Boisville", 199.3f, 154); // near = 154 // far = 223
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Lotus: {
                    dat = new DistrictData("LOTUS", "Sinousité", "Merville", 27.2f, 42);
                    dat.HomeDataAdd("Col", SocialState.Professional, 2, 25, new int[5] { 4, 10, 10, 10, 10 });
                    dat.EmployersDataAdd(EmployerType.Culture, 1 * 3);
                    dat.PlaceDataAdd("Galerie de la Jeunesse");
                    dat.PlaceDataAdd("place des Jeunes");
                    dat.PlaceDataAdd("Parc aux Canards");
                    return dat;
                }
                case Quartier.q_Artois: {
                    dat = new DistrictData("ARTOIS", "Sinousité", "Merville", 19.5f, 52);
                    dat.EmployersDataAdd(EmployerType.Education, 1 * 7 + 1 * 6);
                    dat.EmployersDataAdd(EmployerType.Culture, 1 * 11 + 1 * 2);
                    dat.EmployersDataAdd(EmployerType.Office, 8 * 6 + 23 * 4);
                    dat.EmployersDataAdd(EmployerType.Medicine, 1 * 6);
                    dat.EmployersDataAdd(EmployerType.Trade, 1 * 6);
                    dat.PlaceDataAdd("Académie des Arts", "Maison des Artistes", "Maison de Chocolat", "Échange royal");
                    dat.PlaceDataAdd("place de la Concorde");
                    dat.PlaceDataAdd("Parc de la Culture");
                    return dat;
                }
                case Quartier.q_Orchidee: {
                    dat = new DistrictData("ORCHIDÉE", "Floraison", "Merville", 20.1f, 42);
                    dat.HomeDataAdd("Col", SocialState.Professional, 2, 23, new int[5] { 4, 10, 10, 10, 10 });
                    dat.EmployersDataAdd(EmployerType.Culture, 1 * 3);
                    dat.EmployersDataAdd(EmployerType.Office, 1 * 6);
                    dat.EmployersDataAdd(EmployerType.Trade, 1 * 7);
                    dat.EmployersDataAdd(EmployerType.Sport, 1 * 6);
                    dat.PlaceDataAdd("Synagogue de Lotus", "Quaie d'Orchidées", "SC Orchidée", "Marche Rivièrebasse");
                    dat.PlaceDataAdd("place de Cielville");
                    dat.PlaceDataAdd("parc de la Miséricorde");
                    return dat;
                }
                case Quartier.q_Ramage: {
                    dat = new DistrictData("RAMAGE", "Floraison", "Merville", 21.3f, 53);
                    dat.HomeDataAdd("Col", SocialState.Professional, 2, 20, new int[5] { 4, 10, 10, 10, 10 });
                    dat.EmployersDataAdd(EmployerType.Culture, 2 * 12 + 4 * 3);
                    dat.EmployersDataAdd(EmployerType.Education, 1 * 6);
                    dat.EmployersDataAdd(EmployerType.Services, 1 * 1);
                    dat.EmployersDataAdd(EmployerType.Office, 2 * 6 + 1 * 4);
                    dat.PlaceDataAdd("Boulevard de Abat-Jour", "Zoo de Petits Animaux", "Maison de Caramel",
                                     "Musée de la Vie");
                    dat.PlaceDataAdd("place des Enfants");
                    return dat;
                }
                case Quartier.q_Embrume: {
                    dat = new DistrictData("EMBRUMÉ", "Juvénilité", "Merville", 10.1f, 54);
                    dat.HomeDataAdd("Col", SocialState.Professional, 2, 14, new int[5] { 4, 10, 10, 10, 10 });
                    dat.EmployersDataAdd(EmployerType.Culture, 1 * 8);
                    dat.PlaceDataAdd("Maison des Poètes", "Boulevrad de la Juvénilité");
                    dat.PlaceDataAdd("place d'Échange");
                    return dat;
                }
                case Quartier.q_Poesie: {
                    dat = new DistrictData("POÉSIE", "Juvénilité", "Merville", 26.6f, 134);
                    dat.HomeDataAdd("Col", SocialState.Professional, 2, 16, new int[5] { 4, 10, 10, 10, 10 });
                    dat.EmployersDataAdd(EmployerType.Culture, 1 * 24);
                    dat.EmployersDataAdd(EmployerType.Trade, 1 * 6);
                    dat.PlaceDataAdd("Château de Repos", "Boulevrad de la Juvénilité");
                    dat.PlaceDataAdd("place Vert");
                    dat.PlaceDataAdd("parc de Poésie");
                    return dat;
                }
                case Quartier.q_Douceur: {
                    dat = new DistrictData("DOUSEUR", "Juvénilité", "Merville", 11.1f, 54);
                    dat.HomeDataAdd("Col", SocialState.Professional, 2, 17, new int[5] { 4, 10, 10, 10, 10 });
                    dat.EmployersDataAdd(EmployerType.Culture, 1 * 3);
                    dat.EmployersDataAdd(EmployerType.Education, 1 * 6);
                    dat.EmployersDataAdd(EmployerType.Hotel, 1 * 4);
                    dat.EmployersDataAdd(EmployerType.Sport, 1 * 8);
                    dat.EmployersDataAdd(EmployerType.Office, 1 * 4);
                    dat.PlaceDataAdd("Synagogue de la Croix", "Boulevrad de la Juvénilité");
                    return dat;
                }
                case Quartier.q_Abreuvoir: {
                    dat = new DistrictData("ABREUVOIR", "Volage", "Merville", 39.1f, 71);
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Suavite: {
                    dat = new DistrictData("SUAVITÉ", "Volage", "Merville", 15.8f, 190);
                    dat.HomeDataAdd("---", SocialState.Professional, 2, 50, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Suffle: {
                    dat = new DistrictData("SUFFLÉ", "Volage", "Merville", 23.5f, 203);
                    dat.HomeDataAdd("---", SocialState.Specialist, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Harmonie: {
                    dat = new DistrictData("HARMONIE", "Volage", "Merville", 18.8f, 266);
                    dat.HomeDataAdd("---", SocialState.Responsible, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Cedres: {
                    dat = new DistrictData("CÈDRES", "Vanille", "Merville", 40.0f, 143);
                    dat.HomeDataAdd("---", SocialState.Worker, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Gattilier: {
                    dat = new DistrictData("GATTILIER", "Vanille", "Merville", 18.9f, 263);
                    dat.HomeDataAdd("---", SocialState.Worker, 2, 50, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Littoral: {
                    dat = new DistrictData("LITTORAL", "Maritime", "Merville", 19.5f, 188);
                    dat.HomeDataAdd("---", SocialState.Professional, 2, 75, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Voilure: {
                    dat = new DistrictData("VOILURE", "Maritime", "Merville", 46.8f, 196);
                    dat.HomeDataAdd("---", SocialState.Responsible, 2, 50, new int[1] { 10 });
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Albatros: {
                    dat = new DistrictData("GOÉLAND", "Maritime", "Merville", 65.5f, 145);
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Tissage: {
                    dat = new DistrictData("TISSAGE", "Flux", "Merville", 139.0f, 271);
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
                case Quartier.q_Port: {
                    dat = new DistrictData("PORT", "Flux", "Merville", 90.3f, 158);
                    return dat;
                    // Â À Æ Ç É Ê È Ë Î Ï Ô Œ Û Ù Ü Ÿ
                    // â à æ ç é ê è ë î ï ô œ û ù ü ÿ
                }
            }

            return new DistrictData();
        }
    }
}
