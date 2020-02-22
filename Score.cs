using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{   public Text t;
    public Transform player;
   
    void Update()
    {
     t.text=player.position.z.ToString("0");   
    }
}
