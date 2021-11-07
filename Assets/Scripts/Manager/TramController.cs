using System.Linq;
using System.Collections.Generic;
using UnityEngine;

namespace ParadiseVille
{
    public class TramController : MonoBehaviour
    {
        const float AVERAGE_SPEED = 16f;
        const float MIN_IN_HOUR = 60f;
        const float STOP_TIME = 0.5f;

        public Routier routeSelect;
        List<Routier> allRoutier;

        TextDraw objTextDraw;
        GameObject objTramLine;
        Transform transformTramLine;
        List<GameObject> listStations;

        int buttonFontSize = 25;
        Vector2 start = new Vector2(60f, 300f);
        Vector2 button = new Vector2(200f, 50f);
        float distance = 10f;

        Sprite spriteStation;
        Material lineMaterial;
        Material stationMaterial;

        Color selectButtonColor;
        Color defaultButtonColor;

        public float drawLineXstart { set; get; }

        void Start()
        {
            allRoutier = System.Enum.GetValues(typeof(Routier)).Cast<Routier>().ToList();
            defaultButtonColor = new Color(0.1f, 0.7f, 0.9f);
            selectButtonColor = new Color(0f, 1.0f, 0.5f);
            routeSelect = Routier.None;
            objTextDraw = new TextDraw();
            spriteStation = Resources.Load<Sprite>("station");
            lineMaterial = Resources.Load<Material>("Materials/TramLine");
            stationMaterial = Resources.Load<Material>("Materials/TramStation");
            listStations = new List<GameObject>();
        }

        void OnDestroy()
        {
            if (objTramLine != null)
            {
                Destroy(objTramLine);
            }

            if (objTextDraw != null)
            {
                objTextDraw.Destroy();
            }

            foreach (GameObject obj in listStations)
            {
                Destroy(obj);
            }

            listStations.Clear();
        }

        public void OnGUI()
        {
            GUIStyle buttonStyle = new GUIStyle(GUI.skin.button);
            buttonStyle.fontSize = Mathf.RoundToInt(buttonFontSize * GameCamera.scaleCamera);
            buttonStyle.padding = new RectOffset(0, 0, 0, 0);

            int count = 0;

            foreach (Routier route in allRoutier)
            {
                RouteData dat = GetRoute(route);
                string name = dat.number;

                if (name != null)
                {
                    Rect rect = GetScaleRect(start.x, start.y, button.x, button.y, distance, 0, count);
                    GUIButtonDraw(rect, name, buttonStyle, route);
                    count++;
                }
            }
        }

        Rect GetScaleRect(float x, float y, float w, float h, float dist, int posX, int posY)
        {
            return new Rect(
                (x + posX * (w + dist)) * GameCamera.scaleCamera,
                (y + posY * (h + dist)) * GameCamera.scaleCamera,
                w * GameCamera.scaleCamera,
                h * GameCamera.scaleCamera);
        }

        void GUIButtonDraw(Rect position, string text, GUIStyle style, Routier route)
        {
            if (route == routeSelect)
            {
                GUI.color = selectButtonColor;
            }
            else
            {
                GUI.color = defaultButtonColor;
            }

            if (GUI.Button(position, text, style))
            {
                routeSelect = route;
                ShowTramLine();
            }
        }

        void ShowTramLine()
        {
            CleanTramLine();

            int pointCount = 0;
            int stationCount = 0;
            float length = 0f;
            int time;

            RouteData route = GetRoute(routeSelect);
            Queue<StationData> routeStations= route.GetPathStations();

            List<Vector2> routePoints = new List<Vector2>();
            StationData preview = new StationData();
            Vector2 defaultVec = new Vector2(-1f, -1f);
            Vector2 startPos = defaultVec;

            objTramLine = new GameObject(route.name);
            LineRenderer lineRenderer = objTramLine.AddComponent<LineRenderer>();
            transformTramLine = objTramLine.transform;
            lineRenderer.material = lineMaterial;
            lineRenderer.startWidth = 5f;

            while (routeStations.Count > 0)
            {
                stationCount++;
                StationData data = routeStations.Dequeue();

                string name = data.name;
                objTextDraw.TextWrite(stationCount.ToString() + ". " + name, 400f, 400f + 25f * stationCount, 20, Color.black);
                SetPoint(name, PointCoord(data.pos));

                if (stationCount > 1)
                {
                    Vector2[] pathPoints = preview.GetPath(data.station);
                    Debug.Log("get sta = " + data.station.ToString());

                    for (int i = 0; i < pathPoints.Length; i++)
                    {
                        routePoints.Add(pathPoints[i]);
                    }
                }

                preview = data;
                routePoints.Add(data.pos);
            }

            lineRenderer.positionCount = routePoints.Count;
            foreach (Vector2 point in routePoints)
            {
                Vector2 normPosition = PointCoord(point);
                lineRenderer.SetPosition(pointCount, new Vector3(normPosition.x, normPosition.y));

                if (startPos != defaultVec)
                {
                    length += GetDistance(startPos, normPosition);
                }

                startPos = normPosition;
                pointCount++;
            }

            length = Mathf.RoundToInt(length) / 100f;
            time = Mathf.RoundToInt((stationCount - 1) * STOP_TIME + length / AVERAGE_SPEED * MIN_IN_HOUR);

            objTextDraw.TextWrite(route.name, 400f, 300f, 36, Color.black);
            objTextDraw.TextWrite("Len", length.ToString() + " km", 400f, 350f, 24, Color.black);
            objTextDraw.TextWrite("Time", time.ToString() + " min", 400f, 380f, 24, Color.black);
        }

        void SetPoint(string name, Vector2 position)
        {
            GameObject obj = new GameObject("st_" + name);

            Transform transform = obj.transform;
            transform.SetParent(transformTramLine);
            transform.position = position;

            SpriteRenderer renderer = obj.AddComponent<SpriteRenderer>();
            renderer.sprite = spriteStation;
            renderer.material = stationMaterial;

            listStations.Add(obj);
        }

        float GetDistance(Vector2 start, Vector2 end)
        {
            return Mathf.Sqrt(Mathf.Pow(start.x - end.x, 2f) + Mathf.Pow(start.y - end.y, 2f));
        }

        Vector2 PointCoord(Vector2 position)
        {
            float fx = position.x - 512f + drawLineXstart;
            float fy = position.y - GameCamera.cameraHalf_Height;

            return new Vector2(fx, fy);
        }

        void CleanTramLine()
        {
            objTextDraw.TextClean();

            foreach (GameObject obj in listStations)
            {
                Destroy(obj);
            }

            listStations.Clear();

            if (objTramLine != null)
            {
                Destroy(objTramLine);
            }
        }

        RouteData GetRoute(Routier routier)
        {
            switch (routier)
            {
                case Routier.Route_6: {
                    RouteData route = new RouteData(Routier.Route_6, 6, "R_06. Sacré Cœur");
                    route.AddStations(
                        GetStation(Station.Museumoiseau),
                        GetStation(Station.Pain),
                        GetStation(Station.Parcoiseau),
                        GetStation(Station.Tourreine),
                        GetStation(Station.Cadeaux),
                        GetStation(Station.Staderiviere),
                        GetStation(Station.Parcgrace),
                        GetStation(Station.Sacrecoeur),
                        GetStation(Station.Charite),
                        GetStation(Station.Ecologique),
                        GetStation(Station.Mielfaine),
                        GetStation(Station.Marchefleurs),
                        GetStation(Station.Gareroutiere),
                        GetStation(Station.Art),
                        GetStation(Station.Societe),
                        GetStation(Station.Amour),
                        GetStation(Station.Premiumhotel),
                        GetStation(Station.Ciel),
                        GetStation(Station.Seminaire),
                        GetStation(Station.Fleurville),
                        GetStation(Station.Parfum),
                        GetStation(Station.Governeur),
                        GetStation(Station.Roifrenaie),
                        GetStation(Station.Sinodroine),
                        GetStation(Station.Montfleur));
                    return route;
                }
                case Routier.Route_21: {
                    RouteData route = new RouteData(Routier.Route_21, 21, "R_21. Fleurville");
                    route.AddStations(
                        GetStation(Station.Gareroutiere),
                        GetStation(Station.Royaumetour),
                        GetStation(Station.Amour),
                        GetStation(Station.Theater),
                        GetStation(Station.Halles),
                        GetStation(Station.Bonheur),
                        GetStation(Station.Familie),
                        GetStation(Station.Hotel),
                        GetStation(Station.Passage),
                        GetStation(Station.Governeur),
                        GetStation(Station.Roifrenaie),
                        GetStation(Station.Sinodroine),
                        GetStation(Station.Montfleur));
                    return route;
                }
            }

            return new RouteData();
        }

        StationData GetStation(Station station)
        {
            StationData data;
            // CANTON - V LYCEE - V CENTER - VILL

            switch (station)
            {
                case Station.Amour: { // + + + +
                    data = new StationData(Station.Amour, "Synagogue de l'Amour", new Vector2(540f, 518f));
                    data.AddPath(Station.Royaumetour, new Vector2(555f, 518f), new Vector2(555f, 534f));
                    data.AddPath(Station.Theater);
                    data.AddPath(Station.Societe);
                    data.AddPath(Station.Premiumhotel);
                    return data;
                }
                case Station.Art: { // + + + +
                    data = new StationData(Station.Art, "Musée d'Art", new Vector2(540f, 572f));
                    data.AddPath(Station.Gareroutiere);
                    data.AddPath(Station.Societe);
                    return data;
                }
                case Station.Bonheur: { // + - - +
                    data = new StationData(Station.Bonheur, "Synagogue de Bonheur", new Vector2(512f, 444f));
                    data.AddPath(Station.Halles);
                    data.AddPath(Station.Familie, new Vector2(512f, 436f), new Vector2(504f, 436f));
                    return data;
                }
                case Station.Cadeaux: { // + - - +
                    data = new StationData(Station.Cadeaux, "Palais des Cadeaux", new Vector2(380f, 716f));
                    data.AddPath(Station.Tourreine);
                    data.AddPath(Station.Staderiviere, new Vector2(380f, 730f), new Vector2(390f, 734f));
                    return data;
                }
                case Station.Charite: { // + - - +
                    data = new StationData(Station.Charite, "Charité", new Vector2(508f, 684f));
                    data.AddPath(Station.Sacrecoeur, new Vector2(518f, 700f), new Vector2(516f, 692f));
                    data.AddPath(Station.Ecologique);
                    return data;
                }
                case Station.Ciel: { // + - - +
                    data = new StationData(Station.Ciel, "Porte du Ciel", new Vector2(602f, 518f));
                    data.AddPath(Station.Premiumhotel);
                    data.AddPath(Station.Seminaire);
                    return data;
                }
                case Station.Familie: { // + - - +
                    data = new StationData(Station.Familie, "Palais de la Famille", new Vector2(504f, 410f));
                    data.AddPath(Station.Bonheur, new Vector2(504f, 436f), new Vector2(512f, 436f));
                    data.AddPath(Station.Hotel, new Vector2(504f, 394f));
                    return data;
                }
                case Station.Fleurville: { // + - - +
                    data = new StationData(Station.Fleurville, "Fleurville Hôtel", new Vector2(584f, 444f));
                    data.AddPath(Station.Seminaire, new Vector2(602f, 464f));
                    data.AddPath(Station.Parfum);
                    return data;
                }
                case Station.Ecologique: { // + - - +
                    data = new StationData(Station.Ecologique, "Centre Écologique", new Vector2(532f, 660f));
                    data.AddPath(Station.Charite);
                    data.AddPath(Station.Mielfaine);
                    return data;
                }
                case Station.Gareroutiere: { // + + - +
                    data = new StationData(Station.Gareroutiere, "Gare Routière", new Vector2(580f, 572f));
                    data.AddPath(Station.Royaumetour);
                    data.AddPath(Station.Marchefleurs, new Vector2(580f, 594f));
                    data.AddPath(Station.Art);
                    return data;
                }
                case Station.Governeur: { // + - - +
                    data = new StationData(Station.Governeur, "Palais du Governeur", new Vector2(584f, 376f));
                    data.AddPath(Station.Passage, new Vector2(584f, 394f));
                    data.AddPath(Station.Roifrenaie, new Vector2(578f, 364f));
                    data.AddPath(Station.Parfum);
                    return data;
                }
                case Station.Halles: { // + - - +
                    data = new StationData(Station.Halles, "Halles de Ville", new Vector2(540f, 444f));
                    data.AddPath(Station.Theater);
                    data.AddPath(Station.Bonheur);
                    return data;
                }
                case Station.Hotel: { // + - - +
                    data = new StationData(Station.Hotel, "Hôtel de Ville", new Vector2(526f, 394f));
                    data.AddPath(Station.Familie, new Vector2(504f, 394f));
                    data.AddPath(Station.Passage);
                    return data;
                }
                case Station.Marchefleurs: { // + + + +
                    data = new StationData(Station.Marchefleurs, "Marché aux Fleurs", new Vector2(586f, 606f));
                    data.AddPath(Station.Mielfaine);
                    data.AddPath(Station.Gareroutiere, new Vector2(580f, 594f));
                    return data;
                }
                case Station.Mielfaine: { // + - - +
                    data = new StationData(Station.Mielfaine, "Mielfaine", new Vector2(564f, 628f));
                    data.AddPath(Station.Ecologique);
                    data.AddPath(Station.Marchefleurs);
                    return data;
                }
                case Station.Montfleur: { // + - - +
                    data = new StationData(Station.Montfleur, "Montfleur", new Vector2(554f, 328f));
                    data.AddPath(Station.Sinodroine, new Vector2(546f, 320f), new Vector2(532f, 328f));
                    return data;
                }
                case Station.Museumoiseau: { // + - - +
                    data = new StationData(Station.Museumoiseau, "Musée des Oiseaux", new Vector2(432f, 640f));
                    data.AddPath(Station.Pain);
                    return data;
                }
                case Station.Pain: { // + - - +
                    data = new StationData(Station.Pain, "Fabrique de Pain", new Vector2(404f, 640f));
                    data.AddPath(Station.Museumoiseau);
                    data.AddPath(Station.Parcoiseau);
                    return data;
                }
                case Station.Parcgrace: { // + - - +
                    data = new StationData(Station.Parcgrace, "Parc de la Grâce", new Vector2(468f, 724f));
                    data.AddPath(Station.Staderiviere, new Vector2(458f, 732f));
                    data.AddPath(Station.Sacrecoeur, new Vector2(492f, 724f));
                    return data;
                }
                case Station.Parcoiseau: { // + - - +
                    data = new StationData(Station.Parcoiseau, "Parcoiseau", new Vector2(380f, 640f));
                    data.AddPath(Station.Pain);
                    data.AddPath(Station.Tourreine);
                    return data;
                }
                case Station.Parfum: { // + + + +
                    data = new StationData(Station.Parfum, "Maison de parfum", new Vector2(584f, 410f));
                    data.AddPath(Station.Fleurville);
                    data.AddPath(Station.Governeur);
                    return data;
                }
                case Station.Premiumhotel: { // + + + +
                    data = new StationData(Station.Premiumhotel, "Premium Lux Hôtel", new Vector2(572f, 518f));
                    data.AddPath(Station.Amour);
                    data.AddPath(Station.Ciel);
                    return data;
                }
                case Station.Passage: { // + - - +
                    data = new StationData(Station.Passage, "Passage de Ville", new Vector2(570f, 394f));
                    data.AddPath(Station.Hotel);
                    data.AddPath(Station.Governeur, new Vector2(584f, 394f));
                    return data;
                }
                case Station.Roifrenaie: { // + - - +
                    data = new StationData(Station.Roifrenaie, "Roifrênaie", new Vector2(560f, 350f));
                    data.AddPath(Station.Governeur, new Vector2(578f, 364f));
                    data.AddPath(Station.Sinodroine, new Vector2(538f, 346f));
                    return data;
                }
                case Station.Royaumetour: { // + + - +
                    data = new StationData(Station.Royaumetour, "Royaumetour", new Vector2(580f, 534f));
                    data.AddPath(Station.Gareroutiere);
                    data.AddPath(Station.Amour, new Vector2(555f, 534f), new Vector2(555f, 518f));
                    return data;
                }
                case Station.Sacrecoeur: { // + - - +
                    data = new StationData(Station.Sacrecoeur, "Sacré Cœur", new Vector2(508f, 710f));
                    data.AddPath(Station.Parcgrace, new Vector2(492f, 724f));
                    data.AddPath(Station.Charite, new Vector2(516f, 692f), new Vector2(518f, 700f));
                    return data;
                }
                case Station.Seminaire: { // + + + +
                    data = new StationData(Station.Seminaire, "Séminaire", new Vector2(602f, 482f));
                    data.AddPath(Station.Ciel);
                    data.AddPath(Station.Fleurville, new Vector2(602f, 464f));
                    return data;
                }
                case Station.Sinodroine: { // + - - +
                    data = new StationData(Station.Sinodroine, "Synédroin", new Vector2(534f, 338f));
                    data.AddPath(Station.Roifrenaie, new Vector2(538f, 346f));
                    data.AddPath(Station.Montfleur, new Vector2(532f, 328f), new Vector2(546f, 320f));
                    return data;
                }
                case Station.Societe: { // + + + +
                    data = new StationData(Station.Societe, "Institut de la Société", new Vector2(540f, 548f));
                    data.AddPath(Station.Art);
                    data.AddPath(Station.Amour);
                    return data;
                }
                case Station.Staderiviere: { // + - - +
                    data = new StationData(Station.Staderiviere, "Stade de Rivièrville", new Vector2(422f, 732f));
                    data.AddPath(Station.Cadeaux, new Vector2(390f, 734f), new Vector2(380f, 730f));
                    data.AddPath(Station.Parcgrace, new Vector2(458f, 732f));
                    return data;
                }
                case Station.Theater: { // + - - +
                    data = new StationData(Station.Theater, "Grand Théâter", new Vector2(540f, 474f));
                    data.AddPath(Station.Amour);
                    data.AddPath(Station.Halles);
                    return data;
                }
                case Station.Tourreine: { // + - - +
                    data = new StationData(Station.Tourreine, "Tour de la Reine", new Vector2(380f, 682f));
                    data.AddPath(Station.Parcoiseau);
                    data.AddPath(Station.Cadeaux);
                    return data;
                }
            }

            return new StationData();
        }
    }
}
