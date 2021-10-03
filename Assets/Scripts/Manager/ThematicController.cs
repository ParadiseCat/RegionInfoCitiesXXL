using UnityEngine;
using ParadiseVille.Handler;

namespace ParadiseVille
{
    public class ThematicController : MonoBehaviour
    {
        Themes[] allThemes;
        Themes selectThemes;
        int countThemes;

        Quartier[] quartiers;
        GameObject[] quartierObj;
        SpriteRenderer[] quartierRenderer;
        int quartierCount;
        bool quartiersInit = false;

        Color selectButtonColor;
        Color defaultButtonColor;

        TextDraw objTextDraw;

        int buttonFontSize = 25;
        Vector2 start = new Vector2(60f, 300f);
        Vector2 button = new Vector2(200f, 50f);
        float distance = 10f;

        void Start()
        {
            quartiers = (Quartier[])System.Enum.GetValues(typeof(Quartier));
            quartierCount = quartiers.Length;
            quartierObj = new GameObject[quartierCount];
            quartierRenderer = new SpriteRenderer[quartierCount];

            allThemes = (Themes[])System.Enum.GetValues(typeof(Themes));
            countThemes = allThemes.Length;

            defaultButtonColor = new Color(0.1f, 0.7f, 0.9f);
            selectButtonColor = new Color(0f, 1.0f, 0.5f);
            selectThemes = Themes.None;
            objTextDraw = new TextDraw();
        }

        public void OnGUI()
        {
            GUIStyle buttonStyle = new GUIStyle(GUI.skin.button);
            buttonStyle.fontSize = Mathf.RoundToInt(buttonFontSize * GameCamera.scaleCamera);
            buttonStyle.padding = new RectOffset(0, 0, 0, 0);

            for (int i = 0; i < countThemes - 1; i++)
            {
                Themes thema = allThemes[i];
                string name = GetThemesName(thema);
                Rect rect = GetScaleRect(start.x, start.y, button.x, button.y, distance, 0, i);

                GUIButtonDraw(rect, name, buttonStyle, thema);
            }
        }

        public void OnDestroy()
        {
            CleanThemesInfo();

            for (int i = 0; i < quartierCount; i++)
            {
                Destroy(quartierObj[i]);
            }

            if (objTextDraw != null)
            {
                objTextDraw.Destroy();
            }
        }

        void GUIButtonDraw(Rect position, string text, GUIStyle style, Themes thema)
        {
            if (thema == selectThemes)
            {
                GUI.color = selectButtonColor;
            }
            else
            {
                GUI.color = defaultButtonColor;
            }

            if (GUI.Button(position, text, style))
            {
                selectThemes = thema;
                ShowThemesInfo();
            }
        }

        Rect GetScaleRect(float x, float y, float w, float h, float dist, int posX, int posY)
        {
            return new Rect((x + posX * (w + dist)) * GameCamera.scaleCamera,
                            (y + posY * (h + dist)) * GameCamera.scaleCamera,
                             w * GameCamera.scaleCamera,
                             h * GameCamera.scaleCamera);
        }

        string GetThemesName(Themes thema)
        {
            switch (thema)
            {
                case Themes.DensityGeneral: return "Densité Generale";
                case Themes.DensityActive: return "Densité Active";
                case Themes.DensityAbsolute: return "Densité Maxima";
                case Themes.YearsFoundation: return "Extension";
                default: return "";
            }
        }

        void ShowThemesInfo()
        {
            CleanThemesInfo();

            if (!quartiersInit)
            {
                GenerateQuartierObjects();
                quartiersInit = true;
            }

            switch (selectThemes)
            {
                case Themes.DensityGeneral:
                case Themes.DensityAbsolute:
                case Themes.DensityActive:
                    ExecuteDataDencity();
                    break;
                case Themes.YearsFoundation:
                    ExecuteDataYears();
                    break;
            }
        }

        void CleanThemesInfo()
        {
            objTextDraw.TextClean();
        }

        void GenerateQuartierObjects()
        {
            for (int i = 0; i < quartierCount; i++)
            {
                string name = ((int)quartiers[i]).ToString();

                GameObject obj = new GameObject(name);
                obj.transform.SetParent(transform);
                obj.transform.position = new Vector3(GameCamera.cameraHalf_Width - 512f, 0f);
                obj.transform.localScale = new Vector3(100f, 100f, 100f);

                SpriteRenderer spr = obj.AddComponent<SpriteRenderer>();
                spr.sprite = Resources.Load<Sprite>("Dist/" + name);
                spr.sortingOrder = 5;

                quartierObj[i] = obj;
                quartierRenderer[i] = spr;
            }
        }

        void ExecuteDataDencity()
        {
            float min = 10000f;
            float max = 0f;
            float[] data = new float[quartierCount];

            const int ranges = 7;

            Color[] colors = new Color[ranges]
            {
                new Color(1f, 0f, 0.5f),
                new Color(1f, 0f, 0f),
                new Color(1f, 0.5f, 0f),
                new Color(1f, 1f, 0f),
                new Color(0.5f, 1f, 0f),
                new Color(0f, 1f, 0f),
                new Color(0f, 0.7f, 0.3f)
            };

            float[] range = new float[ranges]
            {
                12000f,
                10000f,
                7000f,
                5000f,
                3000f,
                1000f,
                0f
            };

            for (int i = 0; i < quartierCount; i++)
            {
                Quartier quartier = quartiers[i];
                QuartierData qData = new QuartierData(quartier);
                float denc = 0f;

                switch (selectThemes)
                {
                    case Themes.DensityGeneral: {
                        float square = Mathf.Round(qData.Square * 10f) / 10f;
                        int resCount = qData.CountResidents;
                        denc = Mathf.RoundToInt(resCount / square) * 100;
                        break;
                    }
                    case Themes.DensityActive: {
                        float square = Mathf.Round(qData.Square * 10f) / 10f;
                        int resCount = qData.CountResidents;
                        int empCount = qData.CountEmployers;
                        denc = Mathf.RoundToInt((empCount + (resCount / 2)) / square) * 100;
                        break;
                    }
                    case Themes.DensityAbsolute: {
                        float square = Mathf.Round(qData.Square * 10f) / 10f;
                        int resCount = qData.CountResidents;
                        int empCount = qData.CountEmployers;
                        denc = Mathf.RoundToInt((empCount + resCount) / square) * 100;
                        break;
                    }
                }

                data[i] = denc;
                if (denc < min)
                {
                    min = denc;
                }

                if (denc > max)
                {
                    max = denc;
                }
            }

            for (int i = 0; i < quartierCount; i++)
            {
                int qRange = GetRange(data[i]);
                SpriteRenderer spr = quartierRenderer[i];
                spr.color = colors[qRange];
            }

            int GetRange(float value)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (value > range[j])
                    {
                        return j;
                    }
                }

                return ranges - 1;
            }
        }

        void ExecuteDataYears()
        {
            const int ranges = 21;

            Color[] colors = new Color[ranges]
            {
                new Color(0.4f, 0f, 0f),
                new Color(0.9f, 0f, 0.5f), new Color(0.9f, 0f, 0.25f), new Color(0.9f, 0f, 0f), new Color(0.9f, 0.13f, 0f),
                new Color(0.9f, 0.33f, 0f), new Color(0.9f, 0.52f, 0f), new Color(0.9f, 0.72f, 0f), new Color(0.9f, 0.9f, 0f),
                new Color(0.68f, 0.9f, 0f), new Color(0.49f, 0.9f, 0f), new Color(0.29f, 0.9f, 0f), new Color(0.1f, 0.9f, 0f),
                new Color(0f, 0.9f, 0.09f), new Color(0f, 0.9f, 0.28f), new Color(0f, 0.9f, 0.47f), new Color(0f, 0.9f, 0.68f),
                new Color(0f, 0.9f, 0.9f), new Color(0f, 0.73f, 0.9f), new Color(0f, 0.54f, 0.9f), new Color(0f, 0.34f, 0.9f)
            };

            int[] range = new int[ranges]
            {
                0, 25, 50, 75, 100, 125, 150, 175, 200, 225, 250, 275, 300,
                325, 350, 375, 400, 425, 450, 475, 500
            };

            for (int i = 0; i < quartierCount; i++)
            {
                Quartier quartier = quartiers[i];
                QuartierData qData = new QuartierData(quartier);
                int qRange = GetRange(qData.founded);

                SpriteRenderer spr = quartierRenderer[i];
                spr.color = colors[qRange];
            }

            int GetRange(float rank)
            {
                for (int j = 0; j < ranges; j++)
                {
                    if (rank < range[j])
                    {
                        return j;
                    }
                }

                return ranges - 1;
            }
        }
    }
}
