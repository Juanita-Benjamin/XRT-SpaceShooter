using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class HighScore : MonoBehaviour
{ 
    public GameObject highScoreUi;

    public Score playerScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
//change to scores if not working
    public bool isHighScore(Score newScore)
    {
        foreach (Score score in Scores.Instance.scores)
        {
            if (newScore.score > score.score)
            {
                return true;
            }
        }

        return false;
    }

    public void AddNewScore(Score newScore)
    {
        Score[] scores = new Score[10];
        scores[0] = newScore;
        Scores.Instance.scores = scores;
    }
}
