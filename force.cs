using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class force : MonoBehaviour
{
    public Rigidbody rb;
    public float forward=500f;
    public float side=500f;
    public float up=500f;

    
   // void Start()
   // {
      //rb.AddForce(0, 100 , 0);
        
   // }

    
  void FixedUpdate()
 {
     // rb.AddForce(0,0,100 );
        
    
    if(Input.GetKey("w"))
    {
     rb.AddForce(0,0,forward);
	}
    if(Input.GetKey("s"))
    {
     rb.AddForce(0,0,-forward);
	}
    if(Input.GetKey("a"))
    {
     rb.AddForce(-side,0,0, ForceMode.VelocityChange);
	}
    if(Input.GetKey("d"))
    {
     rb.AddForce(side,0,0, ForceMode.VelocityChange);
    }
    
    if(rb.position.y<-1)
    {
     FindObjectOfType<gamemanager>().endgame();
	}
    
 }
    
}
