using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initialisation : MonoBehaviour
{
    //temp
    int numberOfPops = 10;

    public List<GameObject> currentNumPops = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i <= numberOfPops; i++)
        {

            GameObject pop = new GameObject();
            pop.AddComponent<pops>();
            currentNumPops.Add(pop);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
}
