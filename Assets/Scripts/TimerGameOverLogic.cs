using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;



public class TimerGameOverLogic : MonoBehaviour
{



	int countDownStartValue = 60;
	public Text timerUI;
    void Start()
    {
		countDownTimer();
    }

   void countDownTimer()
	{
		if(countDownStartValue > 0)
		{
			TimeSpan spanTime = TimeSpan.FromSeconds(countDownStartValue);
			
			timerUI.text = + spanTime.Minutes + " : " +spanTime.Seconds;
			countDownStartValue--;
			Invoke("countDownTimer", 1.0f);
		}
		else 
		{
			SceneManager.LoadScene("GameOverScene");
			
		
			
		}
	}
	

}
