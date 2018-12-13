using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //<- "namespace"
//using UnityEngine.UI
//Enginen TMPro gör så att man kan ändra namn TMPro på Gameobject som det ligger på

public class ScoreTracker : MonoBehaviour
{
    //skapar en text på TMProGUI 
    public TextMeshProUGUI scoreText;
    //variabel för total scoret
    public int totalScore;

    //Printar score eller siffror (totalt)
    private void Update()
    {
        //scoreText är en text som ska printa "Score {0}" 
        //som är totalscoret på den specifika scenen som detta scriptet ligger på
        scoreText.text = string.Format("Score: {0}", totalScore);      
    }



}
