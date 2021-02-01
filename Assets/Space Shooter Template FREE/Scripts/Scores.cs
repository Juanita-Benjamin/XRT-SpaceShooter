using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Scores
{
    private static Scores _instance = new Scores();

    public Score[] scores = new Score[10];

    private Scores()
    {
        for (int i = 0; i < scores.Length; i++)
        {
            scores[i] = new Score();
        }
    }

    public static Scores Instance
    {
        get => _instance;
        //get{return _Instance;}
        set => Instance = value;
    }
}