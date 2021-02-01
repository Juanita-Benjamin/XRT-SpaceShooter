using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Serialization;

/// <summary>
/// This script defines which sprite the 'Player" uses and its health.
/// </summary>

public class Player : MonoBehaviour
{
    public GameObject destructionFX;

    public static Player instance;

    public int lives;

    public TextMeshProUGUI livesText;

    public LevelController levelController;
    
    public float invincibilityTime;

    public bool isInvisible;

    public Vector3 spawnPoint;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

            spawnPoint = transform.position;
        }
    }

    //method for damage proceccing by 'Player'
    public void GetDamage(int damage)   
    {
        Destruction();
    }    

    //'Player's' destruction procedure
    void Destruction()
    {
        if (!isInvisible)
        {
            lives--;
            Instantiate(destructionFX, transform.position, Quaternion.identity); //generating destruction visual effect and destroying the 'Player' object

            if (IsGameOver())
            {
                foreach (Renderer rend in gameObject.GetComponentsInChildren<Renderer>())
                {
                    rend.enabled = false;
                }

                isInvisible = true;
            }

            if (IsGameOver())
            {
                Time.timeScale = 0;
                levelController.DisplayGameOver();
            }
            else
            {
                SpawnPlayer();
            }
        }
        //Destroy(gameObject);
    }

    void SpawnPlayer()
    {
        isInvisible = true;
        StartCoroutine(InvincibilityTimer());
        
        foreach (Renderer rend in gameObject.GetComponentsInChildren<Renderer>())
        {
            rend.enabled = true;
        }

        transform.position = spawnPoint;
    }

    IEnumerator InvincibilityTimer()
    {
        float time = 0f;

        while (time <= invincibilityTime)
        {
            time += Time.deltaTime;
            yield return null;
        }

        isInvisible = false;
    }

    bool IsGameOver()
    {
        if (lives == 0)
        {
            return true;
        }

        return false;
    }
    
    private void FixedUpdate()
    {
        if (livesText.text != lives.ToString())
        {
            livesText.text = lives.ToString();
        }
    }

}
















