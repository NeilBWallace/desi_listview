using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button : MonoBehaviour {
	[SerializeField]
	public GameObject rb;

	public static int move =0;

	public Button yourbutton;
	// Use this for initialization
	void Start () {
		Button btn = yourbutton.GetComponent<Button> ();
		btn.onClick.AddListener (TaskOnClick);
	}

	void TaskOnClick()
	{
		Debug.Log ("you clicked");
		move = 1;

	//	GameObject desi = GameObject.FindGameObjectWithTag ("desi");
	//	desi.SetActive (false);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
