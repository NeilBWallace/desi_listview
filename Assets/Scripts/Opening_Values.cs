using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Opening_Values : MonoBehaviour {

	public static int move =0;

	public static string selectedfood;


	[SerializeField]
	private GameObject desi;


	[SerializeField]
	private  GameObject opening_text;

	[SerializeField]
	private GameObject foodpanel;

	[SerializeField]
	private Text ot;
	// Use this for initialization
	void Start () {
		foodpanel.SetActive (false);		
		desi.SetActive (false);
		ot.GetComponent<Text> ().text = "Parents: Please select three food items from the scrollable food bank" +
			" to load the scene. -->";
	//	fd.color= new Color(fd.color.r,fd.color.g,fd.color.b,Mathf.Sin(Time.time*2));


	}

	




			


}
