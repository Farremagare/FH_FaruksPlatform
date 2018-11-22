using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    //variablen "score" lägger till "1" varje gång ett objekt rör objektet som scriptet är på
    public int score = 1;

    //en private void för collidern
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //triggar collidern när objektets collider rör ett annat objekt med tagen "Player" 
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
                    tracker.totalScore += score;
                }
                //Printar ("") ifall "ScoreTrackern" sacknas på "GameControllen",
                //alltså att scriptet finns men saknas på rutan
                else
                {
                    Debug.LogError("ScoreTracker saknas på GameController");

                }
            }
            //printar ("") ifall "GameControllern" inte finns
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
