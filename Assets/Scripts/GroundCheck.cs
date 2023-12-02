using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    private bool Grounded;
    public GameObject Player;
    public 
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Grounded = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Player")
        {
            Grounded = true;
            Player.GetComponent<PlayerScript>().GroundCheck = Grounded;
        }
    }
    private void OnTriggerExit2D()
    {
        Grounded = false;
        Player.GetComponent<PlayerScript>().GroundCheck = Grounded;
    }
}
