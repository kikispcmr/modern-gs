using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class provinceHighlight : MonoBehaviour
{
   public Material highlight;
    // Start is called before the first frame update
    void Start()
    {
       // highlight = gameObject.GetComponent<Material>();
       
    }

    public void highlightProvince(Color provCol)
    {
        highlight.SetColor("set_color", provCol);
        Debug.Log("Highlighted Province!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
