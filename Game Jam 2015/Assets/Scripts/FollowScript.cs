using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {

	public int distanceAway;
	public bool turnWithPlayer;
	private bool lookingLeft = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void Update(){

        Vector3 PlayerPOS = GameObject.Find("BasePerson").transform.transform.position;
        transform.position = new Vector3(PlayerPOS.x, PlayerPOS.y, PlayerPOS.z - distanceAway);

		if (turnWithPlayer) {
			Vector3 PlayerRot = GameObject.Find ("BasePerson").transform.rotation.eulerAngles;
			if(((int)PlayerRot.y == 180) && !lookingLeft)
			{
				transform.Rotate(new Vector3(0, -90, 0));
				lookingLeft = true;
			}
			if(((int)PlayerRot.y == 0) && lookingLeft)
			{
				transform.Rotate(new Vector3(0, 90, 0));
				lookingLeft = false;
			}
		}
 }
}
