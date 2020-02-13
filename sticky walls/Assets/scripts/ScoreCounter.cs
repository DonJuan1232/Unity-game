using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ScoreCounter : MonoBehaviour
{

	public float timeStart = 0;
	public Text textBox;

	public float currentTime;

	// Use this for initialization
	void Start()
	{
		textBox.text = timeStart.ToString();
	}

	// Update is called once per frame
	void Update()
	{
		timeStart += Time.deltaTime;
		textBox.text = Mathf.Round(timeStart).ToString();

		currentTime = Mathf.Round(timeStart);

		PlayerPrefs.SetFloat("currentTime", currentTime);
	}


}
