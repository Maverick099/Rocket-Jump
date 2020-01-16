using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
public class bird_physics : MonoBehaviour
{
    public float upforce = 500;                         //change to change click jump amount
    private bool isDead = false;
    private Rigidbody2D rb2d;
    private Animator anim;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (isDead == false)
        {
            if (Input.GetMouseButtonDown(0))
                //add ardunio serial input
            {
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(0, upforce));
                anim.SetTrigger("Flap");

            }
            if (ArdunioController.Input.Data == "High")
            {
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(0, upforce));
                anim.SetTrigger("Flap");
            }
        }

    }
    void OnCollisionEnter2D()                           //Unity function for collison 
    {
        rb2d.velocity = Vector2.zero;
        isDead = true;                                  //bird is dead
        anim.SetTrigger("Dead");
        Game_controller.Instance.birdDead();
    }
}