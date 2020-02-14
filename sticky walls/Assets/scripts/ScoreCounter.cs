using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ScoreCounter : MonoBehaviour
{

	public float timeStart = 0;
	public Text textBox;

	public float currentTime;

	
	void Start()
	{
		textBox.text = timeStart.ToString();
	}

	
	void Update()
	{
		timeStart += Time.deltaTime;
		textBox.text = Mathf.Round(timeStart).ToString();

		currentTime = Mathf.Round(timeStart);

		PlayerPrefs.SetFloat("currentTime", currentTime);

		
	}


}
