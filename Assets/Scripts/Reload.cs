using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;// lägger till engingen för scenesmanagements så att 
//du kan loada scenes genom att coda

public class Reload : MonoBehaviour
{

    //variabel som ersätter "Level1" till "levelToload" för att kunna skriva smidigare i scriptet
    public string levelToload = "Level1";

    //En private void som har OnTriggerEnter2D funktionen. Och OnTriggerEnter2d är att när ett annat objekt går
    //in i en trigger collider bifogat till detta objektet(2D physics bara)
    //Collider2D är en föräldrar class för collider typer använda med 2D gameplay, 
    //d.v.s olika typer av colliders som är mest använda vilket gör de till föräldrar class
    //(måste användas med 2D gameplay)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //ifall objektet med taggen "player" rör collidern, printas "Welcome to Level1" 
        //och loada scenen levelToload(Variabel), vilket är "Level1"
        if (collision.tag == "Player")
        {
            print("Welcome to Level1");
            SceneManager.LoadScene(levelToload);
        }
    }
}
