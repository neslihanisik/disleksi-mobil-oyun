using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ses : MonoBehaviour
{
	[SerializeField]
	public List<Button> btns = new List<Button>();
	// Start is called before the first frame update
	void Start()
    {

		GetButtons();
		

	}

	void GetButtons()
	{
		GameObject[] objects = GameObject.FindGameObjectsWithTag("PuzzleButton");

		for (int i = 0; i < objects.Length; i++)
		{
			btns.Add(objects[i].GetComponent<Button>());
			
		}
	}
}
