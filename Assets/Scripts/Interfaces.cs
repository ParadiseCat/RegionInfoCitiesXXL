using UnityEngine;

namespace ParadiseVille
{
    /// <summary>
    /// interface for sprites
    /// </summary>
    interface ISprite
    {
        public GameObject ObjectSpriteCreate(float xpos, float ypos, string source, int order);
    }

    /// <summary>
    /// interfaces for textures
    /// </summary>
    interface ITexture
    {
        public Texture2D TextureExtractFromSprite(string source);
        public string GetTexturePixel(ref float mouseX, ref float mouseY);
        public string GetTexturePixel(ref int posX, ref int posY);
        public int GetPixelCount(ref string hexColor);
        public int GetTextureWidth();
    }

    /// <summary>
    /// interface for texts
    /// </summary>
    interface IText
    {
        public void TextWrite(string name, float fx, float fy, int size, Color col);
        public void TextWrite(string name, string text, float fx, float fy, int size, Color col);
        public void TextWrite(string name, string text, int percent, float fx, float fy, int size, Color col);
        public void TextClean();
    }
}
