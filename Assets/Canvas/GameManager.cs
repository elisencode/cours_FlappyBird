using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public Text TxtScore, TxtBestScore;

    private int score;
    public int Score
    {
        get {return score;}

        set
        {
            score = value;
            TxtScore.text = "Score " + score;
        }
    }


    private int bestScore;
    public int BestScore
    {
        get { return bestScore; }

        set
        {
            bestScore = value;
            TxtBestScore.text = "Best Score " + bestScore;
        }

    }

    private void Start()
    {
        BestScore = PlayerPrefs.GetInt("BestScore");
    }

    public void SaveBestScore()
    {
        PlayerPrefs.SetInt("BestScore", BestScore);
    }

    public void AddOnePoint()
    {
        Score++;
    }

}
