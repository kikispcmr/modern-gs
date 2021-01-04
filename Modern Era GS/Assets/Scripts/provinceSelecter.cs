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

    // Start is called before the first frame update
    void Start()
    {

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
                Debug.Log(hitpoint);
                }
            
        }
    }
}
