using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {

	private bool hasJumped = false;
	private bool lookingleft = false;
	public bool isPast;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.E)) {

			Vector3 holderLoc = GameObject.Find("PlayerTimeHolder").transform.position;
			GameObject.Find("PlayerTimeHolder").transform.position = transform.position;
			transform.position = holderLoc;
			GameObject.Find("PlayerTimeHolder").GetComponent<PlaceHolderScript>().right *= -1;
		} 
        float moveHoriz = Input.GetAxis("Horizontal");
        
        if (Input.GetKeyDown (KeyCode.Space) && !hasJumped) {
			rigidbody2D.velocity = new Vector2 (moveHoriz * 2f, 5f);
			hasJumped = true;
		} 
		else {
			rigidbody2D.velocity = new Vector2 (moveHoriz * 2f, rigidbody2D.velocity.y);

		}

		if (rigidbody2D.velocity.y == 0) {
			hasJumped = false;
		}

		if (moveHoriz < 0 && !lookingleft)
		{
			transform.Rotate(new Vector3(0, 180, 0));
			lookingleft = true;
		}
		if (moveHoriz > 0 && lookingleft)
		{
			transform.Rotate(new Vector3(0, 180, 0));
			lookingleft = false;
		}

	}
}
