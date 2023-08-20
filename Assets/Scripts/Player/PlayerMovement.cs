using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour
{
	public float walkingSpeed = 6f;
	public float walkingWhileFiringSpeed = 6f;
	public GameObject gun;
	Vector3 movement;                   // The vector to store the direction of the player's movement.
	Animator anim;                      // Reference to the animator component.
	Rigidbody playerRigidbody;          // Reference to the player's rigidbody.
#if !MOBILE_INPUT
	int floorMask;                      // A layer mask so that a ray can be cast just at gameobjects on the floor layer.
	float camRayLength = 100f;          // The length of the ray from the camera into the scene.
#endif

	void Awake()
	{
#if !MOBILE_INPUT
		// Create a layer mask for the floor layer.
		floorMask = LayerMask.GetMask("Floor");
#endif

		// Set up references.
		anim = GetComponent<Animator>();
		playerRigidbody = GetComponent<Rigidbody>();
	}


	void FixedUpdate()
	{
		// Store the input axes.
		float h = CrossPlatformInputManager.GetAxisRaw("Horizontal");
		float v = CrossPlatformInputManager.GetAxisRaw("Vertical");
		bool firing = CrossPlatformInputManager.GetButton("Fire1");

		float speed = firing ? walkingWhileFiringSpeed : walkingSpeed;

		// Move the player around the scene.
		Move(h, v, speed);

		// Animate the player.
		
		Animating(h, v, firing);

        gameObject.tag = "Player";

	}


	void Move(float h, float v, float speed)
	{
	
		Vector3 nextDir = new Vector3(h, 0, v);
		if (nextDir != Vector3.zero)
		{
			playerRigidbody.transform.rotation = Quaternion.LookRotation(nextDir);
		}
		
		// Set the movement vector based on the axis input.
		movement.Set(h, 0f, v);

		// Normalise the movement vector and make it proportional to the speed per second.
		movement = movement.normalized * speed * Time.deltaTime;

		// Move the player to it's current position plus the movement.
		playerRigidbody.MovePosition(transform.position + movement);
		
	}


	void Animating(float h, float v, bool firing)
	{
		
		// Create a boolean that is true if either of the input axes is non-zero.
		bool walking = h != 0f || v != 0f;

		if (walking)
		{
			gun.SetActive(false);
			anim.SetTrigger("Walk");
		}
		else
		{
			anim.SetTrigger("StopWalk");
			gun.SetActive(true);
		}
		

		// Tell the animator whether or not the player is walking.
			anim.SetBool("Walk", walking);
	}


}

