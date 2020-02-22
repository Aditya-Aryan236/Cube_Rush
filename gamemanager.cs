using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
   public float delay=3f; 
   public bool gameend=false;
   public GameObject levelup;
   public void levelcomplete()
   {
       levelup.SetActive(true);
   }
   public void endgame()
   {
       if(gameend==false)
       {
         gameend=true;
         Debug.Log("GAME OVER");
         Invoke("restart",delay);
       }
   }
   public void restart()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
}
