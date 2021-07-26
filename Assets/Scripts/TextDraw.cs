using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ParadiseVille
{
    public class TextDraw : IText, ITextConfiguration
    {
        GameObject objCanvas;
        Font gameFont;

        string hexColor = "";

        List<GameObject> listTextObjects;

        public TextDraw()
        {
            objCanvas = new GameObject("objCanvas");
            objCanvas.AddComponent<Canvas>().renderMode = RenderMode.ScreenSpaceOverlay;
            objCanvas.transform.position = new Vector3(0f, 0f);

            gameFont = Resources.GetBuiltinResource<Font>("Arial.ttf");
            listTextObjects = new List<GameObject>();
        }

        ~ TextDraw()
        {
            if (objCanvas != null) Object.Destroy(objCanvas);
            TextClean();
        }

        public void TextWrite(string name, string text, float fx, float fy, int size, Color col)
        {
            fx = fx * GameCamera.scaleCamera;
            fy = (2 * GameCamera.cameraHalf_Height - fy) * GameCamera.scaleCamera;

            GameObject obj = new GameObject("objText_" + name);
            obj.transform.SetParent(objCanvas.transform);

            Text c_text = obj.AddComponent<Text>();
            c_text.text = name + ": " + text;
            c_text.font = gameFont;
            c_text.fontSize = size;
            c_text.color = col;

            RectTransform c_rect = obj.GetComponent<RectTransform>();
            c_rect.anchorMin = new Vector2(0f, 1f);
            c_rect.anchorMax = new Vector2(0f, 1f);
            c_rect.pivot = new Vector2(0f, 1f);
            c_rect.position = new Vector3(fx, fy);
            c_rect.sizeDelta = new Vector2(400, 2 * size);

            listTextObjects.Add(obj);
        }

        public void TextWrite(string name, float fx, float fy, int size, Color col)
        {
            fx = fx * GameCamera.scaleCamera;
            fy = (2 * GameCamera.cameraHalf_Height - fy) * GameCamera.scaleCamera;

            GameObject obj = new GameObject("objText_" + name);
            obj.transform.SetParent(objCanvas.transform);

            Text c_text = obj.AddComponent<Text>();
            c_text.text = name;
            c_text.font = gameFont;
            c_text.fontSize = size;
            c_text.color = col;

            RectTransform c_rect = obj.GetComponent<RectTransform>();
            c_rect.anchorMin = new Vector2(0f, 1f);
            c_rect.anchorMax = new Vector2(0f, 1f);
            c_rect.pivot = new Vector2(0f, 1f);
            c_rect.position = new Vector3(fx, fy);
            c_rect.sizeDelta = new Vector2(400, 2 * size);

            listTextObjects.Add(obj);
        }

        public void TextDrawInfo(Mode mode, string hexCode)
        {
            if (hexColor != hexCode)
            {
                hexColor = hexCode;
                TextClean();
                CityData dat = new CityData(mode, hexCode);

                TextWrite("ID", dat.str_id, 30f, 50f, 12, Color.red);

                TextWrite(dat.quartier, 350f, 50f, 16, Color.red);
                TextWrite("Canton", dat.canton, 30f, 110f, 14, Color.black);
                TextWrite("Villette", dat.villette, 30f, 160f, 14, Color.black);

                TextWrite("COMMUNAUTÉ", 30f, 230f, 12, Color.red);
                TextWrite("Résidents", dat.str_residents, 30f, 270f, 12, Color.black);
                TextWrite("Employés", dat.str_employ, 30f, 300f, 12, Color.black);
                TextWrite("Superficie", dat.str_superf, 30f, 330f, 12, Color.black);
                TextWrite("Densité", dat.str_denct, 30f, 360f, 12, Color.black);

                TextWrite("MAISONS", 30f, 410f, 12, Color.red);
                TextWrite(dat.maisons[0], 30f, 450f, 12, Color.black);
                TextWrite(dat.maisons[1], 30f, 480f, 12, Color.black);
                TextWrite(dat.maisons[2], 30f, 510f, 12, Color.black);
                TextWrite(dat.maisons[3], 30f, 540f, 12, Color.black);
                TextWrite(dat.maisons[4], 30f, 570f, 12, Color.black);
                TextWrite(dat.maisons[5], 30f, 600f, 12, Color.black);
                TextWrite(dat.maisons[6], 30f, 630f, 12, Color.black);

                TextWrite("EMPLOI", 30f, 680f, 12, Color.red);
                TextWrite("Production", dat.employe[0], 30f, 720f, 12, Color.black);
                TextWrite("Bureau", dat.employe[1], 30f, 750f, 12, Color.black);
                TextWrite("Commerce", dat.employe[2], 30f, 780f, 12, Color.black);
                TextWrite("Culture", dat.employe[3], 30f, 810f, 12, Color.black);
                TextWrite("Hôtel", dat.employe[4], 30f, 840f, 12, Color.black);
                TextWrite("Éducation", dat.employe[5], 30f, 870f, 12, Color.black);
                TextWrite("Services d'utilité", dat.employe[6], 30f, 900f, 12, Color.black);
                TextWrite("Sport", dat.employe[7], 30f, 930f, 12, Color.black);
                TextWrite("Administration", dat.employe[8], 30f, 960f, 12, Color.black);
            }
        }

        private void TextClean()
        {
            foreach (GameObject obj in listTextObjects) Object.Destroy(obj);
            listTextObjects.Clear();
        }
    }
}
