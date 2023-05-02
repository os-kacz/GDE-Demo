using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterFill : MonoBehaviour
{
    public GameObject fillBar;
    public GameObject fillHeatBar;
    Image heatBar;
    Image bar;
    public float currentHeat;
    public float currentWater;


    public void SetWater(float water)
    {
        bar.fillAmount = water;
    }

    public void SetTemp(float temperature)
    {
        heatBar.fillAmount = temperature;
    }

    void Start()
    {
        bar = fillBar.GetComponent<Image>();
        heatBar = fillHeatBar.GetComponent<Image>();
    }

    void Update()
    {

        if(bar.fillAmount > 0)
        {
            if (Input.GetMouseButton(0))
            {
                currentWater -= 0.2f * Time.deltaTime;
            }
        }
        else if (bar.fillAmount <= 0)
        {
            currentHeat += 0.2f * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            currentHeat -= 0.3f * Time.deltaTime;
            currentWater += 0.2f * Time.deltaTime;
        }

        SetWater(currentWater);
        SetTemp(currentHeat);
    }

}
