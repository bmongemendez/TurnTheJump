using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public float maxScoreCounter;
    public Text ScoreCounterText;
    public GameObject canvas;

    private void Awake()
    {

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
            DontDestroyOnLoad(canvas);
        }
        else
        {
            Destroy(this.gameObject);
        }

    }

    public void sumScore(float sum)
    {
        maxScoreCounter = sum;
        displayMaxScore();
    }

    private void displayMaxScore()
    {
        ScoreCounterText.text = "Score: " + Mathf.Round(maxScoreCounter).ToString();
    }

    public string getMaxScore()
    {
        return ScoreCounterText.text;
    }

    public void resetMaxScore()
    {
        ScoreCounterText.text = "";
    }
}
