using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class pops : MonoBehaviour
{
    float income;
    // Start is called before the first frame update

    specialities speciality;

    //temp
    //string chosenSpec = "labourer";

    public void set_speciality(string chosenSpec)
    {
        speciality = gameObject.GetComponent<specialities>();
        speciality.set_speciality("labourer");
    }
}
