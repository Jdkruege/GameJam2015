using UnityEngine;
using System.Collections;

public class OpenScript : MonoBehaviour {

		private bool flipped = false;
	public Sprite sprite;
		
		void OnTriggerEnter2D()
		{
			if (!flipped) 
			{
				Vector3 scale = transform.localScale;
				scale.x *= -1;
				transform.localScale = scale;
				
				flipped = true;
			}
		GameObject.Find ("Shut").GetComponent<SpriteRenderer>().sprite = sprite;

		}
}
