

using UnityEngine;

public class PlayerController : MonoBehaviour
{

	public Animation anim;

	void Start(){
		anim = GetComponent<Animation>();

	}
	void Update()
	{
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
		var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

		transform.Rotate(0, x, 0);
		transform.Translate(0, 0, z);

		var walkSpeed = Input.GetAxis ("Vertical");
		Debug.Log (walkSpeed);
		if (Mathf.Abs(walkSpeed) > 0.1)  {
			anim.Play("stand");
		}
		else {
			anim.Stop("stand");
		}
	}
}
