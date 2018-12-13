using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//objektet med detta scriptet behöver (require) Rigidbody2D för att scriptet ska funka
[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
    //speed rangen kan endast vara mellan 0-20
    [Range(0, 20f)]
    public float moveSpeed;
    public float jumpHeight;

    //variabel för groundcheck collidern 
    public GroundCheck groundCheck; 

    private Rigidbody2D rbody;

    // Use this for initialization
    void Start()
    {
        //Hämtar en component till scriptet 
        //(just i detta fallet så hämtar den componenten ("Rigidbody2D"))
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //rbodyn åker/går horisontalt, alltså höger vänster på X-axeln
        rbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, rbody.velocity.y); 
        
        //Klicka på "space knappen" för att hoppa eller åka i Y-axeln
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //ifall groundCheck rör mer än 0 så får objektet en hastighet i Y-axeln
            if (groundCheck.touches > 0)
            {
            rbody.velocity = new Vector2(rbody.velocity.x, jumpHeight);
            }
        }
    }

}
