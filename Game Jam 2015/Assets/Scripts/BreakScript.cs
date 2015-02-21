using UnityEngine;
using System.Collections;

public class BreakScript : MonoBehaviour {

    void Start()
    {
    }

    void OnTriggerEnter2D()
    {
        Destroy(GameObject.Find("FallthroughBricks"));
    }
}
