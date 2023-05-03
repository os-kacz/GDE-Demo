using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LvlScript : MonoBehaviour
{
    public GameObject LvlText;
    public GameObject LvlFill;

    private Image fillImage;
    private TMP_Text text;

    private string lvlString;
    public int lvl = 1;
    public float currentLvl;

    private void SetFill(float lvlBar)
    {
        fillImage.fillAmount = lvlBar;
    }

    private void SetLvl(int levelUp)
    {
        lvlString = levelUp.ToString();
        text.text = lvlString;
    }

    private void Start()
    {
        fillImage = LvlFill.GetComponent<Image>();
        text = LvlText.GetComponent<TMP_Text>();

    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.X))
        {
            if (Input.GetKey(KeyCode.P))
            {
                currentLvl += 0.3f * Time.deltaTime;
            }
        }

        if(currentLvl >= 1)
        {
            currentLvl = 0;
            lvl++;
        }
        
        SetFill(currentLvl);
        SetLvl(lvl);
    }

}
