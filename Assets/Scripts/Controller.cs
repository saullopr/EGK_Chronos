using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
    public GameObject bullet;
    public Transform muzzle;
    Rigidbody rb;
    bool isGrounded;

	// Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody>();
        isGrounded = false;
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.rotation = Quaternion.Euler(new Vector3(0.0F, -90.0F, 0.0F));
            this.transform.position = this.transform.position + new Vector3(-0.03f, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.rotation = Quaternion.Euler(new Vector3(0.0F, +90.0F, 0.0F));
            this.transform.position = this.transform.position + new Vector3(+0.03f, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
			this.transform.rotation = Quaternion.Euler(new Vector3(0.0F, 180.0F, 0.0F));
			this.transform.position = this.transform.position + new Vector3(0.0f, 0.0f, -0.03f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
			this.transform.rotation = Quaternion.Euler(new Vector3(0.0F, 0.0F, 0.0F));
			this.transform.position = this.transform.position + new Vector3(0.0f, 0.0f, +0.03f);
        }
        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(new Vector3(0.0f, 1.0f, 0.0f), ForceMode.Impulse);
           // isGrounded = false;
        }
        if (Input.GetKey(KeyCode.W))
        {
            GameObject obj = GameObject.Instantiate(bullet);
            obj.transform.position = muzzle.transform.position;
            obj.GetComponent<Bullet>().direction = this.transform.rotation.eulerAngles.y == 90.0f ? 1 : -1;
        }

    }
    void OnCollisionEnter(Collision collision)
    {
       if(collision.gameObject.name.Equals("Ground"))
        {
            isGrounded = true;
        }
        
    }

}
