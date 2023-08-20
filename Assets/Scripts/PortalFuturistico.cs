using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalFuturistico : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            /*
                Quando o personagem colide com o portal,
                ele é teletransportado para o mundo medieval.
             */
            print("Portal encontrado");
            SceneManager.LoadScene(3);
        }
    }
}
