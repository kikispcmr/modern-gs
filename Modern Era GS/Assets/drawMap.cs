using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawMap : MonoBehaviour
{
    public Texture2D gameMap;
    public Texture2D createdMap;

    void Start()
    {
        int width = gameMap.width;
        int height = gameMap.height;

        createdMap = instantiateMap(width, height);
        readBinaryFile(width, height);

        byte[] _bytes = createdMap.EncodeToPNG();
        System.IO.File.WriteAllBytes("C:/Users/kikis/Documents/GitHub/modern-gs/Modern Era GS/Assets", _bytes);
        Debug.Log(_bytes.Length / 1024 + "Kb was saved as: " + "C:/Users/kikis/Documents/GitHub/modern-gs/Modern Era GS/Assets");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void readBinaryFile(int width, int height)
    {
        
        for(int x = 0; x<=width;x++)
        {
            for(int y = 0;y<=height;y++)
            {
                if (gameMap.GetPixel(x, y) != gameMap.GetPixel(x + 1, y))
                {
                    Debug.Log("Creating boundary;");
                    drawPixel(createdMap, x, y);
                }
            }
        }
    }
    Texture2D instantiateMap(int width, int height)
    {
        GameObject map;
        map = GameObject.Find("Map");
        Renderer mRend = map.GetComponent<Renderer>();
        Texture2D mapText = new Texture2D(width, height);

        mRend.material.SetTexture("mapText", mapText);

        return mapText;
    }

    void drawPixel(Texture2D map, int xCord, int yCord)
    {
        map.SetPixel(xCord, yCord, Color.black);
    }
}
