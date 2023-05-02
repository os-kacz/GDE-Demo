using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    public GameObject TimeMinutesText;
    public GameObject TimeSecondsText;

    private TMP_Text textMinutes;
    private TMP_Text textSeconds;

    public string timeMinutesString;
    public string timeSecondsString;

    private float timeSeconds;
    private float timeMinutes;
    private float time;

    private void Start()
    {
        textMinutes = TimeMinutesText.GetComponent<TMP_Text>();
        textSeconds = TimeSecondsText.GetComponent<TMP_Text>();
    }

    private void Update()
    {

        time += Time.deltaTime;

        if(time >= 1)
        {
            time = 0;
            timeSeconds++;
        }

        if (timeSeconds == 60)
        {
            timeSeconds = 0;
            timeMinutes++;
        }

        timeMinutesString = timeMinutes.ToString();
        timeSecondsString = timeSeconds.ToString();

        textMinutes.text = timeMinutesString;
        textSeconds.text = timeSecondsString;

    }
}