using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    private Wave _enemyScript;

    private Player _playerScript;
    
    public Button restart;

    public GameObject titleScreen;

    public bool isGameActive;

    public Button pause;

    public Button resume;
    
    public LevelController levelController;
    
    // Start is called before the first frame update
    void Start()
    {
        //communicate with scripts
       // _enemyScript = GameObject.Find("Wave_1").GetComponent<Wave>();
       //_playerScript = GameObject.Find("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    public void StartGame()
    {
        isGameActive = true;
        pause.gameObject.SetActive(true);
        resume.gameObject.SetActive(true);
        titleScreen.gameObject.SetActive(false);
        
    }

    public void PlayerDeath()
    {
        
        restart.gameObject.SetActive(true);
        isGameActive = false;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Pause()
    {
        Time.timeScale = 0;
        
    }

    public void Resume()
    {
        Time.timeScale = 1;
    }

    public void LevelControl()
    {
        levelController.gameObject.SetActive(true);

    }
}
