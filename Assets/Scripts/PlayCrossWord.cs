using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayCrossWord : MonoBehaviour
{
 public void click()
	{
		SceneManager.LoadScene("CrossWordLevel");
	}
}
