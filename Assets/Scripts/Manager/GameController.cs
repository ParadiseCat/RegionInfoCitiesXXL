using UnityEngine;
using ParadiseVille.Handler;

namespace ParadiseVille
{
    /// <summary>
    /// controller of game
    /// </summary>
    public class GameController : MonoBehaviour
    {
        public static GameController instance;

        GameMap objMap;
        GameMap objTextureMap;
        DataHandler objDataHandler;

        GameObject tramMenu;

        bool tramShow = false;

        string hexColor;

        const int mapX = 10000;
        Mode mode;
        Mode textureMode;
        Rect[] buttonRects;

        int buttonFontSize = 25;

        Color defaultButtonColor;
        Color selectButtonColor;
        Color tramButtonColor;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
        }

        void Start()
        {
            objMap = new GameMap();
            objMap.ObjectSpriteCreate("objMap", GameCamera.cameraHalf_Width - 512f, 0f, "ville", 0);

            objTextureMap = new GameMap();
            objDataHandler = new DataHandler(Mode.Ville);

            Vector2 start = new Vector2(500f, 30f);
            Vector2 button = new Vector2(120f, 60f);
            float distance = 10f;

            buttonRects = new Rect[5]
            {
                GetScaleRect(start.x, start.y, button.x, button.y, distance, 0, 0),
                GetScaleRect(start.x, start.y, button.x, button.y, distance, 0, 1),
                GetScaleRect(start.x, start.y, button.x, button.y, distance, 1, 0),
                GetScaleRect(start.x, start.y, button.x, button.y, distance, 1, 1),
                GetScaleRect(start.x, start.y, button.x, button.y, distance, 0, 2)
            };

            defaultButtonColor = new Color(0.1f, 0.7f, 0.9f);
            selectButtonColor = new Color(1.0f, 0.3f, 0.2f);
            tramButtonColor = new Color(1.0f, 1.0f, 0f);

            SetModeMap(Mode.Ville, false);
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
            GUIButtonDraw(buttonRects[4], "Tram", buttonStyle, Mode.Tram);
        }

        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 inputMouse = Input.mousePosition;
                hexColor = objTextureMap.GetTexturePixel(ref inputMouse.x, ref inputMouse.y);

                if (hexColor != "")
                {
                    objDataHandler.ShowData(mode, hexColor, false);
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
            else if (Input.GetKeyDown(KeyCode.RightShift))
            {
                // for test
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

        void SetModeMap(Mode modeType, bool reset)
        {
            if (textureMode != modeType)
            {
                mode = modeType;
                objTextureMap.ObjectReset();

                switch (mode)
                {
                    case Mode.Ville: {
                        if (!tramShow)
                        {
                            objDataHandler.ShowData(mode, "FFFFFF", reset);
                        }

                        textureMode = mode;
                        break;
                    }
                    case Mode.Villette: {
                        if (!tramShow)
                        {
                            objDataHandler.ShowData(mode, "FCFF84", reset);
                        }

                        textureMode = mode;
                        ShowTexturedSprite("villette");
                        break;
                    }
                    case Mode.Canton: {
                        if (!tramShow)
                        {
                            objDataHandler.ShowData(mode, "0BC274", reset);
                        }

                        textureMode = mode;
                        ShowTexturedSprite("canton");
                        break;
                    }
                    case Mode.Quartier: {
                        if (!tramShow)
                        {
                            objDataHandler.ShowData(mode, "B6FF00", reset);
                        }

                        textureMode = mode;
                        ShowTexturedSprite("quartier");
                        break;
                    }
                    case Mode.Tram: {
                        if (!tramShow)
                        {
                            tramShow = true;
                            ShowTramMenu();
                            objDataHandler.ResetData();
                        }
                        else
                        {
                            tramShow = false;
                            HideTramMenu();
                            Mode current = textureMode;
                            textureMode = Mode.None;
                            SetModeMap(current, true);
                        }
                        break;
                    }
                }
            }

            void ShowTexturedSprite(string dataFile)
            {
                objTextureMap.ObjectSpriteCreate("objMapData", GameCamera.cameraHalf_Width - 512f, 0f, dataFile, 1);
                objTextureMap.TextureExtractFromSprite(dataFile);
            }
        }

        void GUIButtonDraw(Rect position, string text, GUIStyle style, Mode modeVilleAction)
        {
            if (modeVilleAction == textureMode)
            {
                GUI.color = selectButtonColor;
            }
            else
            {
                GUI.color = defaultButtonColor;
            }

            if (modeVilleAction == Mode.Tram && tramShow)
            {
                GUI.color = tramButtonColor;
            }

            if (GUI.Button(position, text, style))
            {
                SetModeMap(modeVilleAction, false);
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

        void ShowTramMenu()
        {
            tramMenu = new GameObject("objTramMenu");
            TramMenu tramComponent = tramMenu.AddComponent<TramMenu>();
            tramComponent.drawLineXstart = GameCamera.cameraHalf_Width - 512f;
        }

        void HideTramMenu()
        {
            Destroy(tramMenu);
        }
    }
}
