using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Water : MonoBehaviour
{
    public GameObject fillBar;
    Image bar;
    public float currentWater;
    

    public void SetWater(float water)
    {
        bar.fillAmount = water;
    }

    // Start is called before the first frame update
    void Start()
    {
        bar = fillBar.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetMouseButton(0))
        {
            currentWater -= 0.05f * Time.deltaTime;
        }
        SetWater(currentWater);

    }

}
