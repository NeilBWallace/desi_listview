using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Eat_Item : MonoBehaviour {
	//[SerializeField]
//	private GameObject food_panel;

//	[SerializeField]
//	private GameObject eat_food_panel;


	public Button yourbutton;
	// Use this for initialization
	void Start () {
//		Button btn = yourbutton.GetComponent<Button> ();
	///	btn.onClick.AddListener (TaskOnClick);
	}

	void TaskOnClick()
	{
		Debug.Log ("you clicked");
		Opening_Values.move = 1;
		//food_panel.SetActive (false);
	//	eat_food_panel.SetActive (false);

	}


}
