using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
   public Transform chotu;
   public Vector3 adjustment;
    
    

    
    void Update()
    {
      transform.position=chotu.position+adjustment;
        
    }
}
