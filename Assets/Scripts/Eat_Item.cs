using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Eat_Item : MonoBehaviour {
	//[SerializeField]
//	private GameObject food_panel;

//	[SerializeField]
//	private GameObject eat_food_panel;
//	public Item item;	// Item to put in the inventory on pickup

	[SerializeField]
	private Text strength;

	[SerializeField]
	private Text health;

	[SerializeField]
	private Text smartness;

	[SerializeField]
	private Image strength_red;

	[SerializeField]
	private Image health_red;

	[SerializeField]
	private Image smartness_red;

	public Button yourbutton;
	// Use this for initialization
	void Start () {
	Button btn = yourbutton.GetComponent<Button> ();
btn.onClick.AddListener (TaskOnClick);
	}

	void TaskOnClick()
	{
		Debug.Log ("eat food");
		Opening_Values.move = 1;

		Debug.Log ("smartness" + float.Parse(smartness.text)/10);


		Debug.Log ("smartness red" + StrengthScript.smartness_red);


	StrengthScript.strength_red -=float.Parse(strength.text)/10; 
	strength_red.fillAmount = StrengthScript.strength_red; 

		StrengthScript.health_red -=float.Parse(health.text)/10; 
	health_red.fillAmount = StrengthScript.health_red; 


	
	StrengthScript.smartness_red -= float.Parse(smartness.text)/10; 
			smartness_red.fillAmount = StrengthScript.smartness_red; 

		CanvasGroup c =GameObject.Find("Food_Panel").GetComponent<CanvasGroup> ();
		c.alpha = 0;
		c =GameObject.Find("Eat_Food_Panel").GetComponent<CanvasGroup> ();
		c.alpha = 0;
	

	}


}
