using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // lägger till unityengine för scene managements

public class HurtObject : MonoBehaviour
{
    //private void som triggeras endast när en collider colliderar med denna
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //ifall gamobjelktet med taggen "Player" colliderar, printas "HAHAHAHA YOU DIED!!!" 
        if (collision.gameObject.tag == "Player")
        {
            print("HAHAHAHA YOU DIED!!!");
         
            
            //SceneManager.GetActiveScene().IsValid();
        }
    }
    
}
