using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PuzzlelLoad : MonoBehaviour
{
	
	public GameObject StartPanel;
	public GameObject Puzzle1;
	public GameObject Puzzle2;
	public GameObject Puzzle3;
	public GameObject Puzzle4;

	public void SetPuzzlePhoto(Image Photo)
	{
		GameObject[] objects = GameObject.FindGameObjectsWithTag("Puzzle");
		for (int i = 0; i < 36; i++)
		{
			GameObject.Find("Piece(" + i + ")").transform.Find("Puzzle").GetComponent<SpriteRenderer>().sprite = Photo.sprite;
			
		}
		StartPanel.SetActive(false);

		
	}
	
}
