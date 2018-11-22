using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoin : MonoBehaviour
{
    //variablen "score" lägger till "5" varje gång ett objekt rör objektet som scriptet är på
    public int score = 5;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            //skapa en temporär variabel "controller" och sätt den till 
            //resultatet av sökningen efter objektet med taggen "gameController"
            GameObject controller = GameObject.FindWithTag("GameController");
            if (controller != null)
            {
                //skapa en temporär variabel tracker" och sätt den till 
                //resultatet av sökningen efter komponenten "ScoreTracker"
                ScoreTracker tracker = controller.GetComponent<ScoreTracker>();
                if (tracker != null)
                {
                    tracker.totalScore += score;
                }
                else
                {
                    Debug.LogError("ScoreTracker saknas på GameController");

                }
            }
            else
            {
                Debug.LogError("GameController finns inte");
            }

            Destroy(gameObject);

            print("5p!");
        }
    }

}
