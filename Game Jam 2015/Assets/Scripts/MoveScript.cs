using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {

	private bool hasJumped = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
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


	}
}
