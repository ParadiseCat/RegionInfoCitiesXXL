using UnityEngine;

namespace ParadiseVille
{
    class GameMap : ISprite, ITexture
    {
        // ***
        // Игровая карта
        // ***

        GameObject objMap;
        float objMapPositionX;
        float objMapPositionY;

        Texture2D objTexture;
        float objTextureStartLeft;
        float objTextureStartTop;
        int objTextureWidth;
        int objTextureHeight;

        ~ GameMap()
        {
            if (objMap != null) Object.Destroy(objMap);
        }

        public GameObject ObjectSpriteCreate(float xpos, float ypos, string source)
        {
            if (objMap != null) Object.Destroy(objMap);

            objMap = new GameObject("objMap");
            objMap.transform.position = new Vector3(xpos, ypos);
            objMap.AddComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>(source);

            objMapPositionX = xpos;
            objMapPositionY = ypos;

            return objMap;
        }

        public Texture2D TextureExtractFromSprite(string source)
        {
            if (objMap != null)
            {
                int textureWidth;
                int textureHeight;

                Sprite sprite;
                Texture2D textureExtract;
                Texture2D textureSprite;
                RenderTexture renderExtract;
                RenderTexture renderSprite;

                sprite = Resources.Load<Sprite>(source);

                textureSprite = sprite.texture;
                textureWidth = textureSprite.width;
                textureHeight = textureSprite.height;

                renderSprite = RenderTexture.GetTemporary(textureWidth, textureHeight, 0, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
                Graphics.Blit(textureSprite, renderSprite);

                renderExtract = RenderTexture.active;
                RenderTexture.active = renderSprite;

                textureExtract = new Texture2D(textureWidth, textureHeight);
                textureExtract.filterMode = FilterMode.Point;
                textureExtract.ReadPixels(new Rect(0, 0, textureWidth, textureHeight), 0, 0);
                textureExtract.Apply();

                RenderTexture.active = renderExtract;
                RenderTexture.ReleaseTemporary(renderSprite);

                objTexture = textureExtract;
                objTextureStartLeft = objMapPositionX - textureWidth / 2 + GameCamera.cameraHalf_Width;
                objTextureStartTop = objMapPositionY - textureHeight / 2 + GameCamera.cameraHalf_Height;
                objTextureWidth = textureWidth;
                objTextureHeight = textureHeight;

                return textureExtract;
            }
            else
                return null;
        }

        public string GetTexturePixel(ref float mouseX, ref float mouseY)
        {
            if (objTexture != null)
            {
                int px = Mathf.RoundToInt(mouseX / GameCamera.scaleCamera - objTextureStartLeft);
                int py = Mathf.RoundToInt(mouseY / GameCamera.scaleCamera - objTextureStartTop);

                if (px >= 0 && px < objTextureWidth && py >= 0 && py < objTextureHeight)
                {
                    Color32 col = objTexture.GetPixel(px, py);
                    string colHex = col.r.ToString("X2") + col.g.ToString("X2") + col.b.ToString("X2");

                    Debug.Log("color map x=" + px + " y=" + py + " HEX = " + colHex);
                    return colHex;
                }
                else
                    return "";
            }
            else
                return "";
        }

        public string GetTexturePixel(ref int posX, ref int posY)
        {
            if (objTexture != null)
            {
                string colHex;

                Color32 col = objTexture.GetPixel(posX, posY);
                colHex = col.r.ToString("X2") + col.g.ToString("X2") + col.b.ToString("X2");

                return colHex;
            }
            else
                return "";
        }

        public int GetPixelCount(ref string hexColor)
        {
            if (objTexture != null)
            {
                int width = objTexture.width;
                int height = objTexture.height;
                int pixels = 0;

                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        if (GetTexturePixel(ref i, ref j) == hexColor) pixels++;
                    }
                }

                return pixels;
            }
            else
                return 0;
        }

        public int GetTextureWidth()
        {
            if (objTexture != null)
                return objTextureWidth;
            else
                return 1;
        }
    }
}