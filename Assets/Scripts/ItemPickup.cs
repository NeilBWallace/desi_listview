using UnityEngine;
using UnityEngine.UI;
public class ItemPickup : Interactable {

	[SerializeField]
	public GameObject eat_food_panel;
	[SerializeField]
	public GameObject food_panel;
	[SerializeField]
	private Text food_title1;

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
	private Text food_description;

	[SerializeField]
	private Image food;


	public Item item;	// Item to put in the inventory on pickup

	// When the player interacts with the item
	public override void Interact()
	{
		base.Interact();

		PickUp();	// Pick it up!
	}

	// Pick up the item
	void PickUp ()
	{
		 Opening_Values.move =0;
		food_panel.SetActive (true);	
		eat_food_panel.SetActive (true);
	//	item.name = name;
		foodbank1.sprite = Resources.Load<Sprite> ("flags/" +item.name);
		food_title1.GetComponent<Text> ().text = item.name;
		health.text = item.health.ToString();
		strength.text = item.strength.ToString();
		smartness.text = item.smartness.ToString();
		food_description.text = item.fd;
		Debug.Log("Picking up item" + item.name + " " + item.health + " " + item.strength + " " + item.smartness + item.fd);
	//	bool wasPickedUp = Inventory.instance.Add(item);	// Add to inventory





		// If successfully picked up
//		if (wasPickedUp)
		Destroy(gameObject);	// Destroy item from scene
	}

}
