using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public Vector3 speed;
    public int direction;


    // Use this for initialization
    void Start () {
        Destroy(this.gameObject, 2.0f);
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = this.transform.position + speed * direction;
		
	}
}
