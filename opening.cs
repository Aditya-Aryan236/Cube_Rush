using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class opening : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("yes");
       
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
       
	}
    
}
