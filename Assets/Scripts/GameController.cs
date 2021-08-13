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

        int buttonFontSize = 25;

        Color defaultButtonColor;
        Color selectButtonColor;

        void Start()
        {
            objMap = new GameMap();
            objMap.ObjectSpriteCreate(GameCamera.cameraHalf_Width - 512f, 0f, "ville", 0);

            objTextureMap = new GameMap();
            objDataHandler = new DataHandler(Mode.Ville);

            Vector2 start = new Vector2(500f, 30f);
            Vector2 button = new Vector2(120f, 60f);
            float distance = 10f;

            buttonRects = new Rect[4]
            {
                GetScaleRect(start.x, start.y, button.x, button.y), 
                GetScaleRect(start.x + button.x + distance, start.y, button.x, button.y),
                GetScaleRect(start.x, start.y + button.y + distance, button.x, button.y),
                GetScaleRect(start.x + button.x + distance, start.y + button.y + distance, button.x, button.y)
            };

            defaultButtonColor = new Color(0.1f, 0.7f, 0.9f);
            selectButtonColor = new Color(1.0f, 0.3f, 0.2f);

            SetModeMap(Mode.Ville);
        }

        public void OnGUI()
        {
            GUIStyle buttonStyle = new GUIStyle(GUI.skin.button);
            buttonStyle.fontSize = Mathf.RoundToInt(buttonFontSize * GameCamera.scaleCamera);
            buttonStyle.padding = new RectOffset(0, 0, 0, 0);

            GUIButtonDraw(buttonRects[0], "Ville", buttonStyle, Mode.Ville);
            GUIButtonDraw(buttonRects[1], "Villette", buttonStyle,  Mode.Villette);
            GUIButtonDraw(buttonRects[2], "Canton", buttonStyle, Mode.Canton);
            GUIButtonDraw(buttonRects[3], "Quartier", buttonStyle, Mode.Quartier);
        }

        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 inputMouse = Input.mousePosition;
                hexColor = objTextureMap.GetTexturePixel(ref inputMouse.x, ref inputMouse.y);

                if (hexColor != "")
                {
                    objDataHandler.ShowData(mode, hexColor);
                }
            }
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                int pixelCount = objTextureMap.GetPixelCount(ref hexColor);
                CalcRegionSquare(mapX, objTextureMap.GetTextureWidth(), pixelCount);
            }
            else if (Input.GetKeyDown(KeyCode.Backspace))
            {
                objDataHandler.CalcEmployersPerUnit();
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
            if (mode != modeType)
            {
                mode = modeType;
                objTextureMap.ObjectReset();

                switch (mode)
                {
                    case Mode.Ville: {
                        objDataHandler.ShowData(mode, "FFFFFF");
                        break;
                    }
                    case Mode.Villette:
                    {
                        objDataHandler.ShowData(mode, "FCFF84");
                        ShowTexturedSprite("villette");
                        break;
                    }
                    case Mode.Canton: {
                        objDataHandler.ShowData(mode, "0BC373");
                        ShowTexturedSprite("canton");
                        break;
                    }
                    case Mode.Quartier: {
                        objDataHandler.ShowData(mode, "B5FF00");
                        ShowTexturedSprite("quartier");
                        break;
                    }
                }
            }

            void ShowTexturedSprite(string dataFile)
            {
                objTextureMap.ObjectSpriteCreate(GameCamera.cameraHalf_Width - 512f, 0f, dataFile, 1);
                objTextureMap.TextureExtractFromSprite(dataFile);
            }
        }

        void GUIButtonDraw(Rect position, string text, GUIStyle style, Mode modeVilleAction)
        {
            if (modeVilleAction == mode)
            {
                GUI.color = selectButtonColor;
            }
            else
            {
                GUI.color = defaultButtonColor;
            }

            if (GUI.Button(position, text, style))
            {
                SetModeMap(modeVilleAction);
            }
        }

        Rect GetScaleRect(float x, float y, float w, float h)
        {
            return new Rect(x * GameCamera.scaleCamera, y * GameCamera.scaleCamera, w * GameCamera.scaleCamera, h * GameCamera.scaleCamera);
        }
    }
}
