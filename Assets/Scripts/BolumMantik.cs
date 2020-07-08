using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BolumMantik : MonoBehaviour
{
    public Button[] butonlar;

    public int level_idem;

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
        level_idem = PlayerPrefs.GetInt("levelidSample");

        if (level_idem > 0)
        {
            butonlar[level_idem].interactable = true;
           
       
        }

        for (int i = 0; i <= level_idem; i++)
        {

            butonlar[i].interactable = true;
            for (int j = 0; j <= LevelUnLocked.Length; j++)
            {
                if(j < level_idem)
                {
                    LevelUnLocked[j].SetActive(false);
                }

                

            }

        }
       
    }
}



