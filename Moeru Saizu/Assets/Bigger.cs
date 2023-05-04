using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bigger : MonoBehaviour
{
    public GameObject level;
    public GameObject player;
    public GameObject camera;
    public GameObject water;
    private LvlScript levelScript;
    private CinemachineCameraOffset cameraScript;
    public float tempLvl;
    public float tempZ = -69;
    public float tempWater = 0.2f;

    private void Start()
    {
        levelScript = level.GetComponent<LvlScript>();
        cameraScript = camera.GetComponent<CinemachineCameraOffset>();
        tempLvl = levelScript.lvl;
        water.SetActive(false);
    }
    private void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            Debug.Log("mouse pressed");
            water.SetActive(true);
        }

        if(Input.GetMouseButtonUp(1))
        {
            water.SetActive(false);
        }

        if(levelScript.lvl > tempLvl)
        {
            player.transform.localScale = new Vector3((float)tempLvl + 3, (float)tempLvl + 3, (float)tempLvl + 3);
            cameraScript.m_Offset = new Vector3(0f, 0.7f, tempZ-= 6);
            tempLvl = levelScript.lvl;
        }
    }
}
