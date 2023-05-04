using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bigger_1st : MonoBehaviour
{
    public GameObject level_1;
    public GameObject player_1;
    public GameObject camera_1;
    public GameObject water_1;
    private LvlScript levelScript_1;
    private CinemachineCameraOffset cameraScript_1;
    public float tempLvl_1;
    public float tempZ_1 = -69;
    public float tempWater_1 = 0.2f;

    private void Start()
    {
        levelScript_1 = level_1.GetComponent<LvlScript>();
        cameraScript_1 = camera_1.GetComponent<CinemachineCameraOffset>();
        tempLvl_1 = levelScript_1.lvl;
        water_1.SetActive(false);
    }
    private void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            Debug.Log("mouse pressed");
            water_1.SetActive(true);
        }

        if(Input.GetMouseButtonUp(1))
        {
            water_1.SetActive(false);
        }

        if(levelScript_1.lvl > tempLvl_1)
        {
            player_1.transform.localScale = new Vector3((float)tempLvl_1 + 1, (float)tempLvl_1 + 1, (float)tempLvl_1 + 1);
            cameraScript_1.m_Offset = new Vector3(0f, 0.7f, tempZ_1-= 6);
            water_1.transform.localScale = new Vector3((float)tempWater_1 + 0.1f, (float)tempWater_1 + 0.1f, (float)tempWater_1 + 0.1f);
            tempLvl_1 = levelScript_1.lvl;
        }
    }
}