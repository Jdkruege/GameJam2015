using UnityEngine;
using System.Collections;

public class ValuablesPickupScript : MonoBehaviour {

	public int pointValue;
	public string nameToDestroy;

	void OnTriggerEnter2D()
	{
		GameObject.Find ("ScoreText").GetComponent<ScoreScript> ().score += pointValue;
		Destroy (GameObject.Find(nameToDestroy).gameObject);
	}
}
