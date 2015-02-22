using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {

	private bool hasJumped = false;
	private bool lookingleft = false;
	public bool isPast;

	private Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
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
        
		anim.SetFloat("Speed", Mathf.Abs(moveHoriz));

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
			FlipFacing();
		}
		if (moveHoriz > 0 && lookingleft)
		{
			FlipFacing();
		}

	}

	private void FlipFacing()
	{
		lookingleft = !lookingleft;
		Vector3 charScale = transform.localScale;
		charScale.x *= -1;
		transform.localScale = charScale;
	}
}
