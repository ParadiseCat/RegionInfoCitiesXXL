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

                HeadData();
                GeneralData(30f, 230f, 30f, 12, 12);
                MaisonData(30f, 480f, 25f, 12, 10);
                EmployersData(30f, 705f, 25f, 12, 10);
                PublicData(350f, 480f, 25f, 12, 10);

                void HeadData()
                {
                    if (dat.str_id != "0")
                    {
                        TextWrite("ID", dat.str_id, 30f, 50f, 12, Color.red);
                        TextWrite(dat.quartier, 350f, 50f, 16, Color.red);
                        TextWrite("Canton", dat.canton, 30f, 110f, 14, Color.black);
                        TextWrite("Villette", dat.villette, 30f, 160f, 14, Color.black);
                    }
                }

                void GeneralData(float start_x, float start_y, float step, int sizeHead, int sizeElems)
                {
                    if (dat.str_id != "0")
                    {
                        TextWrite("COMMUNAUTÉ", start_x, start_y, sizeHead, Color.red);
                        start_y += sizeHead;

                        start_y = DrawWithReturnPos("Résidents", dat.str_residents, start_x, start_y + step, sizeElems, Color.black);
                        start_y = DrawWithReturnPos("Employés", dat.str_employ, start_x, start_y + step, sizeElems, Color.black);
                        start_y = DrawWithReturnPos("Superficie", dat.str_superf, start_x, start_y + step, sizeElems, Color.black);
                        start_y = DrawWithReturnPos("Densité repos", dat.str_denct, start_x, start_y + step, sizeElems, Color.black);
                        start_y = DrawWithReturnPos("Densité actif", dat.str_denstwork, start_x, start_y + step, sizeElems, Color.black);
                        DrawWithReturnPos("Député", dat.str_deputat, start_x, start_y + step, sizeElems, Color.black);
                    }
                }

                void MaisonData(float start_x, float start_y, float step, int sizeHead, int sizeElems)
                {
                    int size = dat.maisons.Length - 1;
                    float headAdd = 10f;
                    bool dataExists = false;

                    for(byte i = 0; i < size; i++)
                    {
                        if(dat.maisons[i] != " ")
                        {
                            TextWrite(dat.maisons[i], start_x, start_y + (i + 1) * step + headAdd, sizeElems, Color.black);
                            if (!dataExists) dataExists = true;
                        }
                    }

                    if (dataExists) TextWrite("MAISONS", start_x, start_y, sizeHead, Color.red);
                }

                void EmployersData(float start_x, float start_y, float step, int sizeHead, int sizeElems)
                {
                    if (dat.str_id != "0")
                    {
                        int size = dat.employe.Length - 1;
                        float headAdd = 10f;
                        string[] keys = new string[10] {
                        "Production", "Bureau", "Commerce", "Culture", "Hôtel",
                        "Éducation",  "Médecine", "Services d'utilité", "Sport", "Administration"};

                        TextWrite("EMPLOI", start_x, start_y, sizeHead, Color.red);

                        for (byte i = 0; i < size; i++)
                        {
                            TextWrite(keys[i], dat.employe[i], start_x, start_y + (i + 1) * step + headAdd, sizeElems, Color.black);
                        }
                    }
                }

                void PublicData(float start_x, float start_y, float step, int sizeHead, int sizeElems)
                {
                    int size = dat.place.Length - 1;
                    float headAdd = 10f;
                    bool dataExists = false;

                    for (byte i = 0; i < size; i++)
                    {
                        if (dat.place[i] != " ")
                        {
                            TextWrite(dat.place[i], start_x, start_y + (i + 1) * step + headAdd, sizeElems, Color.black);
                            if (!dataExists) dataExists = true;
                        }
                    }

                    if (dataExists) TextWrite("ESPACE PUBLIC", start_x, start_y, sizeHead, Color.red);
                }

                float DrawWithReturnPos(string name, string text, float fx, float fy, int size, Color col)
                {
                    TextWrite(name, text, fx, fy, size, col);
                    return fy;
                }
            }
        }

        private void TextClean()
        {
            foreach (GameObject obj in listTextObjects) Object.Destroy(obj);
            listTextObjects.Clear();
        }
    }
}
