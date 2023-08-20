using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalMedieval : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag =="Player") 
        {
            /*
                Quando o personagem colide com o portal,
                ele é teletransportado para o mundo futurístico.
             */
            print("Portal encontrado");
            SceneManager.LoadScene(1);
        }
    }
}
