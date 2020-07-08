using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BolumSistemi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
        
    }
    public Button[] butonlar;
    // Update is called once per frame
  public void bolumAc(string bolumIsmi)
    {
        Application.LoadLevel(bolumIsmi);
      
    }

}
