using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WinScript : MonoBehaviour {

	void OnTriggerEnter2D()
	{
		GameObject.Find ("WinText").GetComponent<Text>().text = "You Win!";
		
	}
}
