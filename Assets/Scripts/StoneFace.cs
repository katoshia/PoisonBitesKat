using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneFace : MonoBehaviour
{
    private Animator anim;
    [SerializeField] private string trigger;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // checking for collision with player 
        if(collision.gameObject.name=="Player")
        {
            // settign our tag on collision trigger 
            Debug.Log("Trigger");
            gameObject.tag = "Trap";
        }
        else if (collision.gameObject.name == "Terrain")
        {
            // checking for collision with terrain
            anim.SetTrigger(trigger);
        }

    }

}
