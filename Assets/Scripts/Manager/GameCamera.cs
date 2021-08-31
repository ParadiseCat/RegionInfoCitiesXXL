using UnityEngine;

namespace ParadiseVille
{
    public static class GameCamera
    {
        static public float cameraHalf_Height = Camera.main.orthographicSize;
        static public float cameraHalf_Width = Camera.main.orthographicSize * Camera.main.aspect;
        static public float scaleCamera = Camera.main.pixelHeight / (Camera.main.orthographicSize * 2);
        static public float realHeight = Camera.main.orthographicSize * (Camera.main.pixelHeight / (Camera.main.orthographicSize * 2));
        static public float realWidth = Camera.main.orthographicSize * Camera.main.aspect * (Camera.main.pixelHeight / (Camera.main.orthographicSize * 2));
    }
}
