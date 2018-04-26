using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button : MonoBehaviour {

	[SerializeField]
	public GameObject foodbank_panel;

	[SerializeField]
	public GameObject food_panel;

	[SerializeField]
	public GameObject rb;

	[SerializeField]
	public GameObject desi;

	public Button yourbutton;
	// Use this for initialization
	void Start () {
		Button btn = yourbutton.GetComponent<Button> ();
		btn.onClick.AddListener (TaskOnClick);
	}

	void TaskOnClick()
	{
		Debug.Log ("you clicked");
		Opening_Values.move = 1;
		foodbank_panel.SetActive (false);
		food_panel.SetActive (false);
		desi.SetActive (true);
		rb.SetActive (false);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
