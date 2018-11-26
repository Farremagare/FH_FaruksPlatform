using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;// lägger till engingen för scenes

public class Reload : MonoBehaviour
{

    //variabel som ersätter "Scene" till levelToload för att göra det enklare
    public string levelToload = "Scene";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //ifall objektet med taggen "player" rör collidern, printas "YOU DIED! :/" och loada scenen levelToload, vilket är "Level1"
        if (collision.tag == "Player")
        {
            print("YOU DIED! :/");
            SceneManager.LoadScene(levelToload);
        }
    }
}
