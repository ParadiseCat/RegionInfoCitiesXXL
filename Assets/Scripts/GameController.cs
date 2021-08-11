using UnityEngine;
using UnityEngine.UI;

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

        void Start()
        {
            objMap = new GameMap();
            objMap.ObjectSpriteCreate(GameCamera.cameraHalf_Width - 512f, 0f, "ville", 0);

            objTextureMap = new GameMap();

            objDataHandler = new DataHandler(Mode.Ville);

            SetModeMap(Mode.Ville);

            ButtonPanelSet();
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
            else if(Input.GetKeyDown(KeyCode.Backspace))
            {
                switch (mode)
                {
                    case Mode.Quartier:
                        SetModeMap(Mode.Canton);
                        break;
                    case Mode.Canton:
                        SetModeMap(Mode.Villette);
                        break;
                    case Mode.Villette:
                        SetModeMap(Mode.Ville);
                        break;
                    case Mode.Ville:
                        SetModeMap(Mode.Quartier);
                        break;
                }
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
            }
        }

        void ButtonPanelSet()
        {
            GameObject objPanel = new GameObject("objPanel");
            objPanel.AddComponent<Canvas>().renderMode = RenderMode.ScreenSpaceOverlay;
            objPanel.transform.position = new Vector3(319.5f, 179.5f);

            Font panelFont = Resources.GetBuiltinResource<Font>("Arial.ttf");

            GameObject objButton = new GameObject("Button_1");
            objButton.transform.SetParent(objPanel.transform);

            float fx = 450f;
            float fy = 50f;
            fx = fx * GameCamera.scaleCamera;
            fy = (2 * GameCamera.cameraHalf_Height - fy) * GameCamera.scaleCamera;

            RectTransform buttonRectTransform = objButton.AddComponent<RectTransform>();
            buttonRectTransform.pivot = new Vector2(0f, 1f);
            buttonRectTransform.position = new Vector3(fx, fy);
            buttonRectTransform.sizeDelta = new Vector2(50f, 30f);

            Image buttonImage = objButton.AddComponent<Image>();
            buttonImage.material = Resources.Load<Material>("Materials/ButtonSelect");

            Button buttonButton = objButton.AddComponent<Button>();
            //buttonButton.OnPointerClick()
        }
    }
}
