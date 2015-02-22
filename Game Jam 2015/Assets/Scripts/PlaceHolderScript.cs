using UnityEngine;
using System.Collections;

public class PlaceHolderScript : MonoBehaviour {

	public float distanceAway;
	public int right = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 PlayerPos =  GameObject.Find ("Character").transform.position;

		transform.position = new Vector3 (PlayerPos.x + distanceAway * right, PlayerPos.y, PlayerPos.z);
	}
}
