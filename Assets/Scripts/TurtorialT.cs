using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtorialT : MonoBehaviour
{
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
            //"OOOOOF, Your firts obsticle") printas
            print("OOOOOF, Your firts obsticle");
        }
    }



}