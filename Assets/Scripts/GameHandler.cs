using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandlerer : MonoBehaviour
{
    [SerializeField] private HealthBar healthBar;
    // Use this for initialization
    private void Start()
    {
        healthBar.SetSize(0.4f);
    }


}
