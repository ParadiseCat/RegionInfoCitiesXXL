using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;


namespace ParadiseVille
{
    public class TramMenu : MonoBehaviour
    {
        int buttonFontSize = 25;

        Vector2 start = new Vector2(100f, 300f);
        Vector2 button = new Vector2(120f, 60f);
        float distance = 10f;

        public Routier routeSelect;
        List<Routier> allRoutier;

        GameObject objTramLine;
        TextDraw objTextDraw;
        public float drawLineXstart { set; get; }

        Color selectButtonColor;
        Color defaultButtonColor;

        void Start()
        {
            allRoutier = Enum.GetValues(typeof(Routier)).Cast<Routier>().ToList();
            defaultButtonColor = new Color(0.1f, 0.7f, 0.9f);
            selectButtonColor = new Color(0f, 1.0f, 0.5f);
            routeSelect = Routier.None;
            objTextDraw = new TextDraw();
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
        }

        public void OnGUI()
        {
            GUIStyle buttonStyle = new GUIStyle(GUI.skin.button);
            buttonStyle.fontSize = Mathf.RoundToInt(buttonFontSize * GameCamera.scaleCamera);
            buttonStyle.padding = new RectOffset(0, 0, 0, 0);

            int count = 0;

            foreach (Routier route in allRoutier)
            {
                string name = GetRouteName(route);

                if (name != "")
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
            string name = GetRouteName(routeSelect);
            int indexCount = 0;
            int stationCount = 0;
            float length = 0f;
            List<Station> listOfPoints;

            Vector3 startPoint = new Vector3();
            bool startLength = false;

            switch (routeSelect)
            {
                case Routier.Route_21: 
                    listOfPoints = new List<Station>()
                    {
                        Station.Gareroutiere,
                        Station.Royaume, Station.Royaume_c1, Station.Royaume_c2,
                        Station.Vitalite,
                        Station.Theater,
                        Station.Halles,
                        Station.Bonheur, Station.Bonheur_c1, Station.Bonheur_c2,
                        Station.Familie, Station.Familie_c1,
                        Station.Hotel,
                        Station.Passage, Station.Passage_c1,
                        Station.Governeur, Station.Governeur_c1,
                        Station.Roifrenaie, Station.Roifrenaie_c1,
                        Station.Sinodroine, Station.Sinodroine_c1, Station.Sinodroine_c2,
                        Station.Montfleur
                    };
                    break;

                default:
                    listOfPoints = new List<Station>();
                    break;
            }

            objTramLine = new GameObject(name);
            LineRenderer lineRenderer = objTramLine.AddComponent<LineRenderer>();
            lineRenderer.material = Resources.Load<Material>("Materials/TramLine");
            lineRenderer.startWidth = 5f;
            lineRenderer.positionCount = listOfPoints.Count;

            objTextDraw.TextClean();

            foreach (Station station in listOfPoints)
            {
                Vector3 position = GetPointStation(station);
                string nameStation = GetStationName(station);
                lineRenderer.SetPosition(indexCount, PointCoord(position));
                indexCount++;

                if (!startLength)
                {
                    startPoint = position;
                    startLength = true;
                }
                else
                {
                    length += GetDistance(startPoint, position);
                    startPoint = position;
                }

                if (nameStation != "")
                {
                    stationCount++;
                    objTextDraw.TextWrite(
                        stationCount.ToString() + ". " + nameStation,
                        400f, 370f + 30f * stationCount, 20, Color.black);
                }
            }

            length = Mathf.RoundToInt(length) / 100f;

            objTextDraw.TextWrite(name, 400f, 300f, 36, Color.black);
            objTextDraw.TextWrite("Len", length.ToString() + " km", 400f, 350f, 24, Color.black);
        }

        float GetDistance(Vector3 start, Vector3 end)
        {
            return Mathf.Sqrt(Mathf.Pow(start.x - end.x, 2f) + Mathf.Pow(start.y - end.y, 2f));
        }

        Vector3 GetPointStation(Station station)
        {
            switch (station)
            {
                case Station.Gareroutiere: return new Vector3(580f, 572f);
                case Station.Royaume: return new Vector3(580f, 534f);
                case Station.Royaume_c1: return new Vector3(555f, 534f);
                case Station.Royaume_c2: return new Vector3(555f, 518f);
                case Station.Vitalite: return new Vector3(540f, 518f);
                case Station.Theater: return new Vector3(540f, 474f);
                case Station.Halles: return new Vector3(540f, 444f);
                case Station.Bonheur: return new Vector3(512f, 444f);
                case Station.Bonheur_c1: return new Vector3(512f, 436f);
                case Station.Bonheur_c2: return new Vector3(504f, 436f);
                case Station.Familie: return new Vector3(504f, 410f);
                case Station.Familie_c1: return new Vector3(504f, 394f);
                case Station.Hotel: return new Vector3(526f, 394f);
                case Station.Passage: return new Vector3(570f, 394f);
                case Station.Passage_c1: return new Vector3(584f, 394f);
                case Station.Governeur: return new Vector3(584f, 376f);
                case Station.Governeur_c1: return new Vector3(578f, 364f);
                case Station.Roifrenaie: return new Vector3(560f, 350f);
                case Station.Roifrenaie_c1: return new Vector3(538f, 346f);
                case Station.Sinodroine: return new Vector3(534f, 338f);
                case Station.Sinodroine_c1: return new Vector3(532f, 328f);
                case Station.Sinodroine_c2: return new Vector3(546f, 320f);
                case Station.Montfleur: return new Vector3(554f, 328f);
                default: return new Vector3(0f, 0f);
            }
        }

        Vector3 PointCoord(Vector3 position)
        {
            float fx = position.x - 512f + drawLineXstart;
            float fy = position.y - GameCamera.cameraHalf_Height;

            return new Vector3(fx, fy);
        }

        string GetRouteName(Routier route)
        {
            switch (route)
            {
                case Routier.Route_21: return "Route 21";
                case Routier.None: return "";
                default: return "";
            }
        }

        string GetStationName(Station station)
        {
            switch (station)
            {
                case Station.Gareroutiere: return "Gare Routière";
                case Station.Royaume: return "Royaume";
                case Station.Vitalite: return "Vitalité";
                case Station.Theater: return "Grand Théâter";
                case Station.Halles: return "Halles de Ville";
                case Station.Bonheur: return "Synagogue de Bonheur";
                case Station.Familie: return "Palais de la Famille";
                case Station.Hotel: return "Hôtel de Ville";
                case Station.Passage: return "Passage de Ville";
                case Station.Governeur: return "Palais du Governeur";
                case Station.Roifrenaie: return "Roifrênaie";
                case Station.Sinodroine: return "Synédroin";
                case Station.Montfleur: return "Montfleur";
                default: return "";
            }
        }
    }
}
