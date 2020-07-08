using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class sahneDegis : MonoBehaviour
{ 
   

    private void Update()
    {
        if(Input.GetKeyDown("kolay") )
        {

            SceneManager.LoadScene("PuzzleGame");

        }
        if (Input.GetKeyDown("orta"))
        {

            SceneManager.LoadScene("PuzzleGame");

        }
        if (Input.GetKeyDown("zor"))
        {

            SceneManager.LoadScene("PuzzleGame");
        }
    }
}
