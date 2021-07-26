using UnityEngine;

namespace ParadiseVille
{
    public enum Mode { Quartier, Canton, Ville };

    public class GameController : MonoBehaviour
    {
        // ***
        // контроллер
        // ***

        GameMap objMap;
        TextDraw objText;
        string hexColor;

        const int mapX = 10000;
        Mode mode;

        void Start()
        {
            mode = Mode.Quartier;

            objMap = new GameMap();
            objMap.ObjectSpriteCreate(GameCamera.cameraHalf_Width - 512f, 0f, "ville");
            objMap.TextureExtractFromSprite("quartier");

            objText = new TextDraw();
        }

        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 inputMouse = Input.mousePosition;
                hexColor = objMap.GetTexturePixel(ref inputMouse.x, ref inputMouse.y);
                objText.TextDrawInfo(mode, hexColor);
            }
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                int pixelCount = objMap.GetPixelCount(ref hexColor);
                CalcRegionSquare(mapX, objMap.GetTextureWidth(), pixelCount);
            }
            else if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
        }

        void CalcRegionSquare(int mapX, int pictureX, int pixelCount)
        {
            float sq = Mathf.RoundToInt(Mathf.Pow((float)mapX / pictureX, 2f) * pixelCount / 1000) / 10f;
            Debug.Log("Color is: " + hexColor + " pCnt: " + pixelCount.ToString() + " => " + sq.ToString());
        }
    }

    internal static class GameCamera
    {
        static public float cameraHalf_Height = Camera.main.orthographicSize;
        static public float cameraHalf_Width = cameraHalf_Height* Camera.main.aspect;
        static public float scaleCamera = Camera.main.pixelHeight / (cameraHalf_Height* 2);
    }

    interface ISprite
    {
        public GameObject ObjectSpriteCreate(float xpos, float ypos, string source);
    }

    interface ITexture
    {
        public Texture2D TextureExtractFromSprite(string source);
        public string GetTexturePixel(ref float mouseX, ref float mouseY);
        public string GetTexturePixel(ref int posX, ref int posY);
        public int GetPixelCount(ref string hexColor);
        public int GetTextureWidth();
    }

    interface IText
    {
        public void TextWrite(string name, float fx, float fy, int size, Color col);
        public void TextWrite(string name, string text, float fx, float fy, int size, Color col);
    }

    interface ITextConfiguration
    {
        public void TextDrawInfo(Mode mode, string hexCode);
    }
}
