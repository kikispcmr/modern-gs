using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class provinceSelecter : MonoBehaviour
{

    /*method checking what province got hit
    send out texture raycast
    check with province dictionary 
    activate shader around that color
    */
    RaycastHit hit;
    public Texture2D mainMap;
    provinceLoader prov;

    // Start is called before the first frame update
    void Start()
    {
       prov = GameObject.Find("Brain").GetComponent<provinceLoader>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Raycast sent");
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
                {
                Vector2 hitpoint = hit.textureCoord;
                hitpoint.x *= mainMap.width;
                hitpoint.y *= mainMap.height;

                Color currentCol = mainMap.GetPixel((int)hitpoint.x, (int)hitpoint.y);

                //compare colors
               foreach(var prv in prov.provincesDic)
                {
                    if(prv.Key == currentCol)
                    {
                        Debug.Log("Found province: " + prv.Value);
                        break;
                    }
                    else
                    {
                        Debug.Log("Province not recorded"); 
                    }
                }

                Debug.Log(currentCol);
                }
            
        }
    }
}
