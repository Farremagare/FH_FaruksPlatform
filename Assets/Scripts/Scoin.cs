using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoin : MonoBehaviour
{
    //variablen "score" är en int som lägger till "5" varje gång ett objekt med taggen "Player" rör objektet som scriptet är på
    public int score = 5;

    //En private void som triggeras endast när ett annat objekt med taggen "Player" rör objektet med detta scriptet
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //ifall colider med taggen "Player" rör objekktet med detta scriptet  
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
                    //lägger till +score till totalscoret
                    tracker.totalScore += score;
                }
                else
                {
                    //men om Scriptet ScoreTracker saknas i objektet, printa "ScoreTracker saknas på GameController"
                    Debug.LogError("ScoreTracker saknas på GameController");

                }
            }
            else
            {
                //men om GameController inte finns på objektet, printas "GameController finns inte"
                Debug.LogError("GameController finns inte");
            }
            //Objektet försvinner (destroyas)
            Destroy(gameObject);

            //printar "5P!" i konsollen 
            print("5p!");
        }
    }

}
