using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextlevel : MonoBehaviour
{
   public void next_level()
   {
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1); 
   }
}
