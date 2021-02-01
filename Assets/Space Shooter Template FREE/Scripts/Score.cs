using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Score 
{
    //did not have "new: before
    public string name;
    
    public double score;
    
    public Score()
    {
        name = " ";
        score = 0;
    }
    
    public Score(string name, int score)
    {
        this.name = name;
        this.score = score;
    }
    
}
