using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    




    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    //detta är en Debug för om spelaren får hp/liv eller tar damage 
    void OnTriggererStay(Collider other)
    {
        if (other.name == "health")
        {
            Debug.Log("getting healed");
        }
        if(other.name == "Damage")
        {
            Debug.Log("getting damaged");
        }
    }
}
