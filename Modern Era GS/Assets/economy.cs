using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class economy : MonoBehaviour
{
    public float gdp;
    float consumerism;

    public float consumer_consumption;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        calculate_gdp(consumer_consumption, 1, 1, 1, 1);
    }
    public void add_consumerism(int consm)
    {
        consumer_consumption += consm;
    }

    void calculate_gdp(float consumer_consumption, float invesetment, float government_spending, float exports, float imports)
    {
        gdp += consumer_consumption;
    }
}
