using System.Collections;
using UnityEngine;

public static class Noise
{
    public static float[,] GenerateNoiseMap(int mapWidth, int mapHeight, float Scale){
        float[,] noiseMap = new float[mapWidth, mapHeight];
        if(Scale <= 0){
            Scale = 0.0001f;
        }
        for(int y = 0; y < mapHeight; y++){
            for(int x = 0; x < mapWidth; x++){
                float sampleX = x / Scale;
                float sampleY = y / Scale;

                float perlinValue = Mathf.PerlinNoise(sampleX, sampleY);
                noiseMap[x,y] = perlinValue;
            }
        }

        return noiseMap;
    }
}
