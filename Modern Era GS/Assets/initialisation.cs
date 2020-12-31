using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initialisation : MonoBehaviour
{
    //temp
    int numberOfPops = 10;

    public List<pops> currentNumPops = new List<pops>();
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i <= numberOfPops; i++)
        {
            GameObject pop1 = new GameObject().;
            pops pop = pop1.AddComponent<pops>();
            //currentNumPops.Add(new pops("labourer"));
            pop.set_speciality("labourer");
            currentNumPops.Add(pop);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
}
