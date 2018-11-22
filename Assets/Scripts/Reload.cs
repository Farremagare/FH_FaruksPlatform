using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reload : MonoBehaviour
{

    //variabel som ersätter "Scene till levelToload för att göra det enklare
    public string levelToload = "Scene";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //ifall Spelaren åker ut ur världen så respawnas spelaren och printas "YOU DIED! :/" 
        if (collision.tag == "Player")
        {
            print("YOU DIED! :/");
            SceneManager.LoadScene(levelToload);
        }
    }
}
