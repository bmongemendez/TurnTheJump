using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScoreManager : MonoBehaviour
{
    public Text menuMaxScore;

    // Start is called before the first frame update
    void Start()
    {
        menuMaxScore.text = "Last " + ScoreManager.instance.getMaxScore();
        ScoreManager.instance.resetMaxScore();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
