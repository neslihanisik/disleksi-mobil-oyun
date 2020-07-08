using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;


public class DragAndDrop : MonoBehaviour
{

    delegate void DokunDelegate();
    DokunDelegate dokunDelegate;

    public Touch touch;
	int OIL = 1;
	public GameObject SelectedPiece;
	void Start()
	{
     #region PLATFORM FOR TOUCH

        #if UNITY_EDITOR
        dokunDelegate = MouseAyar;

        #endif

        #if UNITY_ANDROID
        dokunDelegate = TouchAyar;

        #endif

     #endregion

    }

    void Update()
	{
        MouseAyar();
     
      
	}

    private void MouseAyar()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.transform.CompareTag("Puzzle"))
            {
                if (!hit.transform.GetComponent<pieceScript>().InRightPosition)
                {

                    SelectedPiece = hit.transform.gameObject;
                    SelectedPiece.GetComponent<pieceScript>().Selected = true;
                    SelectedPiece.GetComponent<SortingGroup>().sortingOrder = OIL;
                    OIL++;
                }


            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            if (SelectedPiece != null)
            {
                SelectedPiece.GetComponent<pieceScript>().Selected = false;
                SelectedPiece = null;

            }


        }

        if (SelectedPiece != null)
        {
            Vector3 MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            SelectedPiece.transform.position = new Vector3(MousePoint.x, MousePoint.y, 0);
        }
    }




    private void TouchAyar()
    {
        if (Input.touchCount >= 1)
        {
            if (Input.touches[0].phase == TouchPhase.Began)
            {
                Touch touch = Input.GetTouch(0);
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(touch.position), Vector2.zero);
                if (hit.transform.CompareTag("Puzzle"))
                {
                    if (!hit.transform.GetComponent<pieceScript>().InRightPosition)
                    {

                        SelectedPiece = hit.transform.gameObject;
                        SelectedPiece.GetComponent<pieceScript>().Selected = true;
                        SelectedPiece.GetComponent<SortingGroup>().sortingOrder = OIL;
                        OIL++;
                    }


                }
            }

            if (Input.touches[0].phase == TouchPhase.Ended)
            {
                if (SelectedPiece != null)
                {
                    SelectedPiece.GetComponent<pieceScript>().Selected = false;
                    SelectedPiece = null;

                }
            }




        }

        if (SelectedPiece != null)
        {
            Vector3 TouchPoint = Camera.main.ScreenToWorldPoint(touch.position);
            SelectedPiece.transform.position = new Vector3(TouchPoint.x, TouchPoint.y, 0);
        }
    }
}
