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
    //class for constructing a dictionary out of a txt //file
    using system.io;
    using System.Xml; //Needed for XML functionality
    using System.Xml.Serialization; //Needed for XML Functionality
    using System.IO;
    using System.Xml.Linq; //Needed for XDocument

    XDocument XMLprovinces;
    
    public struct provinces {
      public provinces(int provID, string name)
      {
        public int provID{get;}
        public string name{get;}
      }
    }
    
    dictionary<color,provinces> provincesDic = new dictionary<color, provinces>();
    
    void start()
    {
      LoadXML();
      
    }

    void LoadXML()
    {
      XMLprovinces = XDocument.load("Assets/XML Files/Provinces.xml");
      items=XMLprovinces.Descendants("").Elements();
      
      foreach(var items in items)
      {
        if(item.Parent.Atrribute("").value == iteration.toString())
        {
          pageNum = int.Parse (item.Parent.Attribute (“number”).Value); charText = item.Parent.Element(“name”).Value.Trim (); dialogueText = item.Parent.Element (“dialogue”).Value.Trim ();

/*Create a new Index in the List, which will be a new XMLData object and pass the previously assigned variables as arguments so they get assigned to the new object’s variables.

*/
        }
        data.Add (new XMLData(pageNum, charText, dialogueText));


/*To test and make sure the data has been applied to properly, print out the musicClip name from the data list’s current index. This will let us know if the objects in the list have been created successfully and if their variables have been assigned the right values.

*/

Debug.Log (data[iteration].dialogueText);

iteration++; //increment the iteration by 1
      }
    }
    
    string path ="Assets/provinces.txt"
    //loads txt file to read from
    AssetDatabase.ImportAsset(path)
    TextAsset text = Resources.load("provinces");
    
    
    /*method checking what province got hit
    send out texture raycast
    check with province dictionary 
    activate shader around that color
    */
    
}
