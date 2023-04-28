using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndTempTimer : MonoBehaviour
{
    public GameObject fillTempBar;
    Image bar;
    public float currentTemp;

    public void SetTemp(float temp)
    {
        bar.fillAmount = temp;
    }

    // Start is called before the first frame update
    void Start()
    {
        bar = fillTempBar.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        currentTemp += 0.01f * Time.deltaTime;


        SetTemp(currentTemp);
        
    }
}
