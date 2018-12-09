using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {

    public Transform ball;

    private Vector3 offset;
	void Start () {
        offset = transform.position - ball.position;
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = offset + ball.position;
	}
}
