using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire_2 : MonoBehaviour
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

        if (Input.GetKey(KeyCode.I))
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
