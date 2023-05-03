using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMetre : MonoBehaviour
{
    public GameObject scoreFill;
    public GameObject multiplierText;
    private TMP_Text mText;
    public string multiplierString;
    Image scoreBar;
    public float currentScore;
    public int currentMultiplier;
    public float multiplierTime;
    public string scoreString;
    public GameObject ScoreText;
    private TMP_Text text;
    private int enemyDefeated;
    

    public void SetScore(float score)
    {
       scoreBar.fillAmount = score;
    }

    private void SetMultiplier(int multiplier)
    {
        if(multiplier == 1)
        {
            multiplierString = "X1";
        }

        multiplierString = "X" + multiplier.ToString();
        mText.text = multiplierString;
    }
    public void ChangeText(float score)
    {
        
        text = ScoreText.GetComponent<TMP_Text>();
        
        scoreString = score.ToString();
        //print(scoreString);
        text.text = scoreString;

    }
    private void Start()
    {
        scoreBar = scoreFill.GetComponent<Image>();
        mText = multiplierText.GetComponent<TMP_Text>();
    }

    private void Update()
    {
 
        multiplierTime += Time.deltaTime;

        if (Input.GetMouseButton(1))
        {
            currentScore += 0.4f * Time.deltaTime;
            multiplierTime = 0;
        }

        if (currentScore >= 1)
        {
            currentScore = 0;
            currentMultiplier++;
            enemyDefeated += 10;
            ChangeText(enemyDefeated);
            SetMultiplier(currentMultiplier);
        }

        if(multiplierTime >= 5)
        {
            currentMultiplier = 1;
            currentScore = 0;
            SetMultiplier(currentMultiplier);
        }

        SetScore(currentScore);
    }
}
