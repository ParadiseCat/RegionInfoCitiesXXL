using UnityEngine;

namespace ParadiseVille
{
    public enum Mode { Quartier, Canton, Villette, Ville };
    public enum SocialState { Worker, Specialist, Professional, Responsible };
    public enum EmployerType { Production, Office, Trade, Culture, Hotel, Education, Medicine, Services, Sport, Administration };

    internal static class GameCamera
    {
        static public float cameraHalf_Height = Camera.main.orthographicSize;
        static public float cameraHalf_Width = Camera.main.orthographicSize * Camera.main.aspect;
        static public float scaleCamera = Camera.main.pixelHeight / (Camera.main.orthographicSize * 2);
        static public float realHeight = Camera.main.orthographicSize * (Camera.main.pixelHeight / (Camera.main.orthographicSize * 2));
        static public float realWidth = Camera.main.orthographicSize * Camera.main.aspect * (Camera.main.pixelHeight / (Camera.main.orthographicSize * 2));
    }


    interface ISprite
    {
        public GameObject ObjectSpriteCreate(float xpos, float ypos, string source, int order);
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
        public void TextClean();
    }
}
