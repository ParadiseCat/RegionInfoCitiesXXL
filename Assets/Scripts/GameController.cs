using UnityEngine;

namespace ParadiseVille
{
    /// <summary>
    /// controller game
    /// </summary>
    public class GameController : MonoBehaviour
    {
        GameMap objMap;
        GameMap objTextureMap;
        DataHandler objDataHandler;

        string hexColor;

        const int mapX = 10000;
        Mode mode;
        Rect[] buttonRects;

        void Start()
        {
            objMap = new GameMap();
            objMap.ObjectSpriteCreate(GameCamera.cameraHalf_Width - 512f, 0f, "ville", 0);

            objTextureMap = new GameMap();
            objDataHandler = new DataHandler(Mode.Ville);

            buttonRects = new Rect[4]
            {
                GetScaleRect(450f, 30f, 100f, 60f), 
                GetScaleRect(560f, 30f, 100f, 60f),
                GetScaleRect(450f, 120f, 100f, 60f),
                GetScaleRect(560f, 120f, 100f, 60f)
            };
                
            SetModeMap(Mode.Ville);
        }

        public void OnGUI()
        {
            if (GUI.Button(buttonRects[0], "Ville"))
            {
                if(mode != Mode.Ville) SetModeMap(Mode.Ville);
            }

            if (GUI.Button(buttonRects[1], "Villette"))
            {
                if (mode != Mode.Villette) SetModeMap(Mode.Villette);
            }

            if (GUI.Button(buttonRects[2], "Canton"))
            {
                if (mode != Mode.Canton) SetModeMap(Mode.Canton);
            }

            if (GUI.Button(buttonRects[3], "Quartier"))
            {
                if (mode != Mode.Quartier) SetModeMap(Mode.Quartier);
            }
        }

        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 inputMouse = Input.mousePosition;
                hexColor = objTextureMap.GetTexturePixel(ref inputMouse.x, ref inputMouse.y);
                objDataHandler.ShowData(mode, hexColor);
            }
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                int pixelCount = objTextureMap.GetPixelCount(ref hexColor);
                CalcRegionSquare(mapX, objTextureMap.GetTextureWidth(), pixelCount);
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

        void SetModeMap(Mode modeType)
        {
            mode = modeType;
            objTextureMap.ObjectReset();

            if (mode == Mode.Ville)
            {
                objDataHandler.ShowData(mode, "FFFFFF");
            }
            else
            {
                string dataFile = "quartier";

                if (mode == Mode.Canton)
                {
                    dataFile = "canton";
                }
                else if (mode == Mode.Villette)
                {
                    dataFile = "villette";
                }

                objTextureMap.ObjectSpriteCreate(GameCamera.cameraHalf_Width - 512f, 0f, dataFile, 1);
                objTextureMap.TextureExtractFromSprite(dataFile);

                objDataHandler.ShowData(mode, "FFFFFF");
            }
        }

        Rect GetScaleRect(float x, float y, float w, float h)
        {
            return new Rect(x * GameCamera.scaleCamera, y * GameCamera.scaleCamera, w * GameCamera.scaleCamera, h * GameCamera.scaleCamera);
        }
    }
}
