using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Simple : MonoBehaviour
{

	public GameObject bulletPrefab;
	public Transform positionShoot;
	public float speed_;


	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
            InstantiateBullet();

            //if (!IsInvoking("instantiateBullet"))
            //{
            //	InvokeRepeating("instantiateBullet", 0f, 1f);
            //}
        }
		//if (Input.GetKeyUp(KeyCode.Space))
		//{

		//	CancelInvoke("instantiateBullet");

		//}
	}
	void InstantiateBullet()
	{
		if (bulletPrefab != null)
		{
			GameObject tempBullet = Instantiate(bulletPrefab) as GameObject;
			tempBullet.transform.position = positionShoot.position;
			tempBullet.GetComponent<Rigidbody>().velocity =
							transform.parent.forward * speed_;
		}
	}
}

