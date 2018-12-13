using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    //En int variabel som visar på hur många saker/object rör något
    public int touches;

    //En private void som har OnTriggerEnter2D funktionen. Och OnTriggerEnter2d är att när ett annat objekt går
    //in i en trigger collider bifogat till detta objektet(2D physics only)
    //Collider2D är en föräldrar class för collider typer använda med 2D gameplay, 
    //d.v.s olika typer av colliders som är mest använda vilket gör de till föräldrar class
    //(måste användas med 2D gameplay)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //ifall objectet med detta scriptet rör ett annat objet så visar den att den rör den
        touches++;
    }
    //En private void som har OnTriggerExit2D funktionen. Och OnTriggerExit2d är när ett annat object lämnar
    //en trigger collider bifogat till detta objektet(2D physics only)
    //Collider2D är en föräldrar class för collider typer använda med 2D gameplay, 
    //d.v.s olika typer av colliders som är mest använda vilket gör de till föräldrar class
    //(måste användas med 2D gameplay)
    private void OnTriggerExit2D(Collider2D collision)
    {
        //ifall objectet med detta scriptet inte rör ett annat objet så visar den det
        touches--;
    }
















}
