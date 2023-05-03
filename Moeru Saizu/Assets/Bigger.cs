using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bigger : MonoBehaviour
{
    public GameObject level;
    public GameObject player;
    public GameObject camera;
    private LvlScript levelScript;
    private CinemachineCameraOffset cameraScript;
    public float tempLvl;
    public float tempZ = -69;

    private void Start()
    {
        levelScript = level.GetComponent<LvlScript>();
        cameraScript = camera.GetComponent<CinemachineCameraOffset>();
        tempLvl = levelScript.lvl;
    }
    private void Update()
    {
        Debug.Log(tempLvl);

        if(levelScript.lvl > tempLvl)
        {
            player.transform.localScale = new Vector3((float)tempLvl + 3, (float)tempLvl + 3, (float)tempLvl + 3);
            cameraScript.m_Offset = new Vector3(0f, 0.7f, tempZ-= 3);
            tempLvl = levelScript.lvl;
        }
    }
}
