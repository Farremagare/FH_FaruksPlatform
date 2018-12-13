using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // lägger till unityengine för scene managements

public class HurtObject : MonoBehaviour
{
    ////variabel som ersätter "Level1" till "levelToload" för att kunna skriva smidigare i scriptet
    public string levelToLoad = "Level1";

    //En private void som har OnTriggerEnter2D funktionen. Och OnTriggerEnter2d är att när ett annat objekt går
    //in i en trigger collider bifogat till detta objektet(2D physics bara)
    //Collider2D är en föräldrar class för collider typer använda med 2D gameplay, 
    //d.v.s olika typer av colliders som är mest använda vilket gör de till föräldrar class
    //(måste användas med 2D gameplay)
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //ifall ett gameobject med taggen "Player"(med en collider som är trigger) 
        //colliderar med gameobjektet(med en collider som är trigger) med detta scriptet
        //printas "HAHAHAHA YOU DIED!!!" 
        if (collision.gameObject.tag == "Player")
        {
            print("HAHAHAHA YOU DIED!!!");
            //SceneManager.GetActiveScene().IsValid();
            SceneManager.LoadScene(levelToLoad);

            
        }
    }
    
}
