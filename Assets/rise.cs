using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rise : MonoBehaviour {

	public float speed = 20.0f;
	// Use this for initialization
	void Start () {
		transform.Translate(Vector3.up * speed *Time.deltaTime);
	}
	
	// Update is called once per frame
	void Update () {

	
	//	transform.position= new Vector3(0,50,0);
	}
}
