using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class choose_the_food : MonoBehaviour {
	[SerializeField]
	public GameObject food_panel;

	[SerializeField]
	public GameObject choose_food_panel;

	[SerializeField]
	public GameObject rb;

	public Material[] material;
	Renderer rend;
	public static int chosen=0;
	[SerializeField]
	private GameObject fo1;

	[SerializeField]
	private GameObject fo2;

	[SerializeField]
	private GameObject fo3;

	public Button yourbutton;
	// Use this for initialization
	void Start () {
		Button btn = yourbutton.GetComponent<Button> ();
		btn.onClick.AddListener (TaskOnClick);
	}

	void TaskOnClick()
	{
		if (chosen == 0) {
			fo1 = GameObject.FindGameObjectWithTag ("FO1");
			ItemPickup i = fo1.GetComponent<ItemPickup> ();
			i.item.name = 	Opening_Values.selectedfood;
			i.item.strength = Opening_Values.selectedfoodstrength;
			i.item.health = Opening_Values.selectedfoodhealth;
			i.item.smartness = Opening_Values.selectedfoodsmartness;
			i.item.fd = Opening_Values.selectedfoodfd;
			rend = fo1.GetComponent<Renderer> ();
			rend.material.color = Color.green;
			chosen++;
		}else if(chosen == 1){
			fo2 = GameObject.FindGameObjectWithTag ("FO2");
			ItemPickup i = fo2.GetComponent<ItemPickup> ();
			i.item.name = 	Opening_Values.selectedfood;
			i.item.strength = Opening_Values.selectedfoodstrength;
			i.item.health = Opening_Values.selectedfoodhealth;
			i.item.smartness = Opening_Values.selectedfoodsmartness;
			i.item.fd = Opening_Values.selectedfoodfd;
			rend = fo2.GetComponent<Renderer> ();
			rend.material.color = Color.green;
			chosen++;

		}else if(chosen == 2){
			fo3 = GameObject.FindGameObjectWithTag ("FO3");
			ItemPickup i = fo3.GetComponent<ItemPickup> ();
			i.item.name = 	Opening_Values.selectedfood;
			i.item.strength = Opening_Values.selectedfoodstrength;
			i.item.health = Opening_Values.selectedfoodhealth;
			i.item.smartness = Opening_Values.selectedfoodsmartness;
			i.item.fd = Opening_Values.selectedfoodfd;
			rend = fo3.GetComponent<Renderer> ();
			rend.material.color = Color.green;
			chosen++;

			rb.gameObject.SetActive(true);

		}
		choose_food_panel.gameObject.SetActive (false);
		food_panel.gameObject.SetActive (false);
	}
	// Update is called once per frame
	void Update () {

	}
}
