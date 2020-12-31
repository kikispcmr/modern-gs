using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class pops : MonoBehaviour
{
    public float income = 10f;
    public float currentWealth = 0f;
    public int happiness = 0;
    
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
                currentWealth -= Random.Range(1000, 9000);
            }
        }
    }
}
