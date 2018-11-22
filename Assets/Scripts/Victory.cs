using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    //variabel som ersätter "Level1" till levelToload för att göra det enklare att skriva
    public string levelToload = "Level2";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //ifall objektet (Flaggan) rör ett annat objekt (Player) med taggen Player så printas "YOU WON!!!" 
        //Och loadar om Scenen ("Level1") så allt börjas om från start
        if (collision.tag == "Player")
        {
            print("YOU WON!!!");
            SceneManager.LoadScene(levelToload);
        }
    }
}