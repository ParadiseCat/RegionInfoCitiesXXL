using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ParadiseVille
{
    /// <summary>
    /// Show text as GameObjects in Game
    /// </summary>
    public class TextDraw
    {
        GameObject objCanvas;
        Font gameFont;
        List<GameObject> listTextObjects;
        Transform transformCanvas;

        public TextDraw()
        {
            objCanvas = new GameObject("objCanvas");
            objCanvas.AddComponent<Canvas>().renderMode = RenderMode.ScreenSpaceOverlay;
            transformCanvas = objCanvas.transform;

            transformCanvas.position = new Vector3(GameCamera.realWidth, GameCamera.realHeight);

            gameFont = Resources.GetBuiltinResource<Font>("Arial.ttf");
            listTextObjects = new List<GameObject>();
        }

        public void Destroy()
        {
            TextClean();

            if (objCanvas != null)
            {
                Object.Destroy(objCanvas);
            }
        }

        public void TextClean()
        {
            foreach (GameObject obj in listTextObjects) Object.Destroy(obj);
            listTextObjects.Clear();
        }

        public void TextWrite(string name, string text, string extText, float fx, float fy, int size, Color col)
        {
            fx = fx * GameCamera.scaleCamera;
            fy = (2 * GameCamera.cameraHalf_Height - fy) * GameCamera.scaleCamera;
            size = Mathf.RoundToInt(size * GameCamera.scaleCamera);

            GameObject obj = new GameObject("objText_" + name);
            obj.transform.SetParent(objCanvas.transform);

            Text c_text = obj.AddComponent<Text>();
            c_text.text = name + ": " + text + " ( " + extText + "% )";
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

        public void TextWrite(string name, string text, float fx, float fy, int size, Color col)
        {
            fx = fx * GameCamera.scaleCamera;
            fy = (2 * GameCamera.cameraHalf_Height - fy) * GameCamera.scaleCamera;
            size = Mathf.RoundToInt(size * GameCamera.scaleCamera);

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
            size = Mathf.RoundToInt(size * GameCamera.scaleCamera);

            GameObject obj = new GameObject("objText_" + name);
            obj.transform.SetParent(transformCanvas);

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
    }
}
