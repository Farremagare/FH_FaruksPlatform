using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;// lägger till scene manegement så att man kan loada och ändra scenes

public class Victory : MonoBehaviour
{
    //variabel som ersätter "Level2" till levelToload för att göra det smidigare när man codar
    public string levelToload = "Level2";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //ifall objektet (Flaggan) rör ett annat objekts collider med taggen "Player" så printas "YOU WON!!!" 
        //Och Loadar scenen "levelToLoad" vilket i detta fallet är "Level2"
        if (collision.tag == "Player")
        {
            print("YOU WON!!!");
            SceneManager.LoadScene(levelToload);
        }
    }
}