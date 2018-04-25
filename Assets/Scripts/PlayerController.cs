

using UnityEngine;
using UnityEngine.AI;


[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{
	
	Camera cam;
	public LayerMask movementMask;
	public Animation anim;

	PlayerMotor motor;


	void Start(){
		anim = GetComponent<Animation>();
		cam =Camera.main;
		motor = GetComponent<PlayerMotor> ();
	}
	void Update()
	{


		if (Input.GetMouseButtonDown (0)) {
			Ray ray = cam.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast (ray, out hit)) {
				Debug.Log ("we hit" + hit.collider.name + " " + hit.point);	}
		motor.MoveToPoint (hit.point);
		
		//	var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
		//	var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;
		//	var walkSpeed = Input.GetAxis ("Vertical");
		//	Debug.Log ("rotation" + x);
		//	Debug.Log (walkSpeed);

	//		if ((Mathf.Abs(x) > 0.05) || (Mathf.Abs(walkSpeed) > 0.05)) {

				
	//		}
	//		else {
	//			anim.Stop("stand");
	//		}

		}
	

	//	transform.Rotate(0, x, 0);
	//	transform.Translate(0, 0, z);

	
	}
}
