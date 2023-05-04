using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndTempTimer : MonoBehaviour
{
    public GameObject fillTempBar;
    Image tempbar;
    public float currentTemp;

    public void SetTemp(float temp)
    {
        tempbar.fillAmount = temp;
    }

    // Start is called before the first frame update
    void Start()
    {
        tempbar = fillTempBar.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        currentTemp += 0.01f * Time.deltaTime;


        SetTemp(currentTemp);
        
    }
}
