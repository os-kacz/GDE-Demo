using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_3 : MonoBehaviour
{
    public GameObject fire;
    public float time;

    void Start()
    {
        fire.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.R))
        {
            time += Time.deltaTime;
        }

        if (time >= 2)
        {
            time = 0;
            fire.SetActive(false);
        }

    }
}
