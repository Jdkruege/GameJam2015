using UnityEngine;
using System.Collections;

public class BreakScript : MonoBehaviour {

	private bool flipped = false;
	public string objectToBreak;

    void OnTriggerEnter2D()
    {
		if (!flipped) 
		{
			Vector3 scale = transform.localScale;
			scale.x *= -1;
			transform.localScale = scale;

			flipped = true;
		}

        Destroy(GameObject.Find(objectToBreak));
    }
}
