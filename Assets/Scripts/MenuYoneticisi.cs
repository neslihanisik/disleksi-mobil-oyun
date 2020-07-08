using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuYoneticisi : MonoBehaviour
{
    public void sahneGecis(string sahneGecis)
    {
        SceneManager.LoadScene(sahneGecis);
    }
}
