using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BeginGame : MonoBehaviour
{
    public Button start;
    
    
    public void StartGame()
    {
        //SceneManager.LoadScene("Demo_Scene");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
        start.gameObject.SetActive(false);
    }
}
