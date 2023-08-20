using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Gun : MonoBehaviour
{
	public float damage = 10f;
	public float ranger = 100f;

	public Camera fpsCam;
	void update()
	{

		if (Input.GetButtonDown("Fire1"))
			{
				Shoot();	
			}
	}

	void Shoot()
	{
		RaycastHit hit;
		if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, ranger))
		{

		}
	}
}

