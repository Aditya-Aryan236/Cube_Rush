using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public force f;
    void OnCollisionEnter(Collision info)
    {
     if(info.collider.tag=="obstacle")  
     {
      f.enabled=false;
            print("hi");
      FindObjectOfType<gamemanager>().endgame();
	 }
	}
}
