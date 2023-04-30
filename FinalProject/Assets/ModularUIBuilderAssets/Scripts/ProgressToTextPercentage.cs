using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ProgressToTextPercentage : MonoBehaviour {

	Text percentageText;

	void Start () {
		percentageText = GetComponent<Text> ();
	}
	
	public void textUpdate (float value){
		percentageText.text = Mathf.RoundToInt (value * 1) + "%";	
	}
}
