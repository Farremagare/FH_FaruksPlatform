using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    //variablen "score" är en int som lägger till "5" i poängsumman
    public int score = 1;

    //En private void som har OnTriggerEnter2D funktionen. Och OnTriggerEnter2d är att när ett annat objekt går
    //in i en trigger collider bifogat till detta objektet(2D physics bara)
    //Collider2D är en föräldrar class för collider typer använda med 2D gameplay, 
    //d.v.s olika typer av colliders som är mest använda vilket gör de till föräldrar class
    //(måste användas med 2D gameplay)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //ifall colider med taggen "Player" rör ett annat objekt med en colider(Trigger) 
        if (collision.tag == "Player")
        {
            //skapa en temporär variabel "controller" och sätt den till 
            //resultatet av sökningen efter objektet med taggen "gameController"
            GameObject controller = GameObject.FindWithTag("GameController");
            if (controller != null)
            {
                //skapa en temporär variabel "tracker" och sätt den till 
                //resultatet av sökningen efter komponenten "ScoreTracker"
                ScoreTracker tracker = controller.GetComponent<ScoreTracker>();
                if (tracker != null)
                {
                    //lägger till +score till totalscoret
                    tracker.totalScore += score;
                }
                //men om Scriptet "ScoreTracker" saknas i GameController, 
                //printa "ScoreTracker saknas på GameController"
                else
                {
                    Debug.LogError("ScoreTracker saknas på GameController");

                }
            }
            //men om GameController inte finns på objektet, printas "GameController finns inte"
            else
            {
                Debug.LogError("GameController finns inte");
            }
            //Gör sönder objectet med scriptet och printar "1p!"
            Destroy(gameObject);

            print("1p!");
        }
    }

}
