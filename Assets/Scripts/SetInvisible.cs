using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetInvisible : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //Sätter enable till false alltså funkar enable som en on/off swtich beroende på vad man vill göra
        //och gör det på componenten SpriteRenderer
        //d.v.s den tar bort Spriterenderern när spelet börjar
        GetComponent<SpriteRenderer>().enabled = false;
    }
}
