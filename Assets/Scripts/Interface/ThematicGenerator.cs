using System.IO;
using UnityEngine;

namespace ParadiseVille
{
    public class ThematicGenerator : MonoBehaviour
    {
        Quartier[] quartierList;
        DataMap map;
        Texture2D baseTexture;
        const string PATH = "Assets/Resources/Dist/";

        bool execute = false;
        int index = 0;
        int count = 0;
        int stepExec = 100;
        int stepCurrent = 0;

        Color existsColor = new Color(1.0f, 1.0f, 1.0f, 0.5f);
        Color pasteColor = new Color(1.0f, 1.0f, 1.0f, 0.0f);

        int width;
        int height;

        public void Create(ref Texture2D baseTexture, int width, int height)
        {
            this.width = width;
            this.height = height;
            this.baseTexture = baseTexture;

            quartierList = (Quartier[])System.Enum.GetValues(typeof(Quartier));
            map = new DataMap();
            index = 0;
            count = quartierList.Length;

            execute = true;

            Debug.Log("Start execute!");
        }

        void Update()
        {
            if (execute)
            {
                stepCurrent++;

                if (stepCurrent == stepExec)
                {
                    stepCurrent = 0;

                    Quartier quartier = quartierList[index];
                    string code = map.GetQuartierCode(quartier);
                    GenerateQuartierResource(ref code, quartier);
                    index++;

                    Debug.Log("Success district " + index.ToString() + " / " + count.ToString());

                    if (index == count)
                    {
                        execute = false;
                    }
                }
            }
        }

        void GenerateQuartierResource(ref string code, Quartier quartier)
        {
            Texture2D texture = new Texture2D(width, height);
            string quartierCode = ((int)quartier).ToString();

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (GetTexturePixel(ref i, ref j) == code)
                    {
                        texture.SetPixel(i, j, existsColor);
                    }
                    else
                    {
                        texture.SetPixel(i, j, pasteColor);
                    }
                }
            }

            byte[] pngFormat = texture.EncodeToPNG();
            File.WriteAllBytes(PATH + quartierCode + ".png", pngFormat);
        }

        string GetTexturePixel(ref int posX, ref int posY)
        {
            if (baseTexture != null)
            {
                string colHex;

                Color32 col = baseTexture.GetPixel(posX, posY);
                colHex = col.r.ToString("X2") + col.g.ToString("X2") + col.b.ToString("X2");

                return colHex;
            }
            else
                return "";
        }
    }
}