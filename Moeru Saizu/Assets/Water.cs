using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Water : MonoBehaviour
{
    public GameObject fillBar;
    public GameObject fillTempBar;
    Image tempBar;
    Image bar;
    public float currentTemp;
    public float currentWater;
    

    public void SetWater(float water)
    {
        bar.fillAmount = water;
    }

    public void SetTemp(float temperature)
    {
        tempBar.fillAmount = temperature;
    }

    // Start is called before the first frame update
    void Start()
    {
        bar = fillBar.GetComponent<Image>();
        tempBar = fillTempBar.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (bar.fillAmount >= 0)
        {
            if (Input.GetMouseButton(0))
            {
                currentWater -= 0.2f * Time.deltaTime;
            }
        }
        else if (bar.fillAmount <= 0)
        {
            currentTemp += 0.2f * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            currentTemp = 0f;
            currentWater += 0.2f * Time.deltaTime;
        }
        
        SetWater(currentWater);
        SetTemp(currentTemp);
    }



}
