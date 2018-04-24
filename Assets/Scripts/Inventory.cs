﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

	public static Inventory instance;

	#region Singleton
	void Awake ()
	{
		if (instance != null) {
			Debug.LogWarning ("More than one instance of inventory");
			return;
		}
		instance = this;
	}
	#endregion
	public List<Item> items = new List<Item>();
	public void Add( Item item)
	{
		items.Add (item);
	}
	public void Remove (Item item)
	{
		items.Remove (item);
	}
}
