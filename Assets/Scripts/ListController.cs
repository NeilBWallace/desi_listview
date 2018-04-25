//
//  ListControllerTest.cs
//
//  Author:
//       Tomaz Saraiva <tomaz.saraiva@gmail.com>
//
//  Copyright (c) 2017 Tomaz Saraiva
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using AddComponent;
using UnityEngine.UI;
using System.Linq;

public class ListController : MonoBehaviour
{
	public static int chosen=0;


	[SerializeField]
	public GameObject rb;

	public Material[] material;
	Renderer rend;

	[SerializeField]
	private GameObject fo1;

	[SerializeField]
	private GameObject fo2;

	[SerializeField]
	private GameObject fo3;

	[SerializeField]
	private Image Food1;

	[SerializeField]
	private Image Food2;

	[SerializeField]
	private Image Food3;

	[SerializeField]
	private Image strength_red;

	[SerializeField]
	private Image health_red;

	[SerializeField]
	private Image smartness_red;


	[SerializeField]
	private Text health;
	[SerializeField]
	private Text strength;
	[SerializeField]
	private Text smartness;


	[SerializeField]
	private Image foodbank1;

	[SerializeField]
	private Text food_group;


	[SerializeField]
	private Text food_title1;

	[SerializeField]
	private Text food_description;

	[SerializeField]
	private Image food;

	[SerializeField]
	private  Text fd;


	[SerializeField]
	private List _list;

	[SerializeField]
	private ListItemBase _listItem;


	private AudioSource[] allAudioSources;

	static string description;

	private int _selectedIndex;

	private ListItemCountry _selectedItem;

	private List<KeyValuePair<string, Country>> _countries;


	void Start()
	{
		strength_red.fillAmount = StrengthScript.strength_red;
		health_red.fillAmount = StrengthScript.health_red;
		smartness_red.fillAmount = StrengthScript.smartness_red;
		_countries = Countries.Dictionary.ToList ();

		_list.onItemLoaded = HandleOnItemLoadedHandler;		// called when an item is recycled
		_list.onItemSelected = HandleOnItemSelectedHandler;	// called when the item is selected

		_list.Create (_countries.Count, _listItem); // create the list with a number and a prefab
		_list.gameObject.SetActive (true);
	}

	void Update()
	{
		
	}
	void HandleOnItemSelectedHandler (ListItemBase item) // reference to the selected list item
	{
		if(_selectedItem != null)
		{
			_selectedItem.Select (false);
		}

		_selectedItem = (ListItemCountry)item;
		_selectedItem.Select (true);

		_selectedIndex = _selectedItem.Index;
	
		StrengthScript.strength_red -= float.Parse(_countries[item.Index].Value.Strength)/10;
		strength_red.fillAmount = StrengthScript.strength_red;

		StrengthScript.health_red -= float.Parse(_countries[item.Index].Value.Health)/10;
		health_red.fillAmount = StrengthScript.health_red;

		StrengthScript.smartness_red -= float.Parse(_countries[item.Index].Value.Smartness)/10;
		smartness_red.fillAmount = StrengthScript.smartness_red;
		StrengthScript.current_food = _countries [item.Index].Value.Name.ToLower ();

		food_title1.GetComponent<Text> ().text = StrengthScript.current_food;
			foodbank1.sprite = Resources.Load<Sprite> ("flags/" +StrengthScript.current_food);
		food.sprite = Resources.Load<Sprite> ("flags/" +StrengthScript.current_food);
		food_description.GetComponent<Text>().text =StrengthScript.current_food;
		fd.GetComponent<Text>().text =_countries[item.Index].Value.CodeAlpha3;
	    food_group.GetComponent<Text>().text =_countries[item.Index].Value.FoodGroups;
		health.GetComponent<Text>().text =_countries[item.Index].Value.Health;
		strength.GetComponent<Text>().text =_countries[item.Index].Value.Strength;

	//	strength.GetComponent<Text>().text =_countries[item.Index].Value.Strength;


		smartness.GetComponent<Text>().text =_countries[item.Index].Value.Smartness;

		AudioSource audio = gameObject.AddComponent<AudioSource>();
		allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];

			foreach(AudioSource audioS in allAudioSources){
				audioS.Stop();
			}
		audio.PlayOneShot((AudioClip)Resources.Load("audio/" + _countries [item.Index].Value.Name));

		if (chosen == 0) {
			fo1 = GameObject.FindGameObjectWithTag ("FO1");
			ItemPickup i = fo1.GetComponent<ItemPickup> ();
			i.name = _countries [item.Index].Value.Name;
			rend = fo1.GetComponent<Renderer> ();
			rend.material.color = Color.green;
			chosen++;
		}else if(chosen == 1){
				fo2 = GameObject.FindGameObjectWithTag ("FO2");
				ItemPickup i = fo2.GetComponent<ItemPickup> ();
				i.name = _countries [item.Index].Value.Name;
				rend = fo2.GetComponent<Renderer> ();
				rend.material.color = Color.green;
			chosen++;
		
	}else if(chosen == 2){
		fo3 = GameObject.FindGameObjectWithTag ("FO3");
		ItemPickup i = fo3.GetComponent<ItemPickup> ();
		i.name = _countries [item.Index].Value.Name;
		rend = fo3.GetComponent<Renderer> ();
		rend.material.color = Color.green;
			chosen++;

			rb.gameObject.SetActive(true);
	}

			#if UNITY_EDITOR || DEVELOPMENT_BUILD
		Debug.Log("Selected Country | " + _countries[item.Index].Value.Name  + "sfsf" + _countries[item.Index].Value.CodeAlpha3)    ;
		#endif
	}

	void HandleOnItemLoadedHandler (ListItemBase item) // reference to the loaded list item
	{
		if(item == (ListItemCountry)_selectedItem)
		{
			_selectedItem.Select (_selectedIndex == _selectedItem.Index);	
		}

		ListItemCountry countryItem = (ListItemCountry)item;	// cast to your own ListItem
		countryItem.SetCode (_countries[item.Index].Key);
		countryItem.SetLabel (_countries[item.Index].Value.Name);
	}
}