using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {

	public int distanceAway;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void Update(){

        Vector3 PlayerPOS = GameObject.Find("BasePerson").transform.transform.position;
        transform.position = new Vector3(PlayerPOS.x, PlayerPOS.y, PlayerPOS.z - distanceAway);
 }
}
