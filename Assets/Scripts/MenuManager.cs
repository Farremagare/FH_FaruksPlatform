using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    //variabel som ersätter "Turtorial" (tutorial igentligen men jag skrev fel och har inte tid att ändra) till levelToLoad
    public string levelToLoad = "Turtorial";


    //public void med namnet "ToGame" laddar levelToLoad, I detta fallet "Turtorial"
    public void ToGame()
    {
    SceneManager.LoadScene(levelToLoad);
    }
}
