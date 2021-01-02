using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class pops : MonoBehaviour
{
    public float income = 10f;
    public float currentWealth = 0f;
    public int happiness = 0;
    public string countryOfOrigin;
    int consumerism;
    GameObject main;
    
    // public ScriptableObject speciality;

     void FixedUpdate()
    {
        updateWealth();
        consumerismCheck();
    }


    public void updateWealth()
    {
        currentWealth += income / (Time.deltaTime*10);
    }

    public void consumerismCheck()
    {
       if (currentWealth >= 10000)
        {
            if(Random.Range(0,10) >= 5 )
            {
                consumerism = Random.Range(1000, 9000);
                currentWealth -= consumerism;
                shareToEconomy(consumerism);
            }
        }
    }

    public void shareToEconomy(int consm)
    {
        main = GameObject.Find("Brain");
        economy econ = main.GetComponent<economy>();
        econ.add_consumerism(consm);
    }
}
