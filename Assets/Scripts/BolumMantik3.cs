using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BolumMantik3 : MonoBehaviour
{
    public Button[] butonlar;

    public int level_id;

    public GameObject[] LevelUnLocked;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.DeleteAll();
        for (int i = 1; i <= butonlar.Length - 1; i++)
        {
            butonlar[i].interactable = false;


        }

    }

    // Update is called once per frame
    void Update()
    {
        level_id = PlayerPrefs.GetInt("levelidCross");

        if (level_id > 0)
        {
            butonlar[level_id].interactable = true;


        }

        for (int i = 0; i <= level_id; i++)
        {

            butonlar[i].interactable = true;
            for (int j = 0; j <= LevelUnLocked.Length; j++)
            {
                if (j < level_id)
                {
                    LevelUnLocked[j].SetActive(false);
                }



            }

        }

    }
}
