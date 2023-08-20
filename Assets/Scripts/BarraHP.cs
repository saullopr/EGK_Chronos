using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BarraHP : MonoBehaviour {

    public Slider vida;
    public int hp = 100;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void Update () {
        vida.value = hp;
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy") 
        {
            /*
                Atacado pelo inimigo, o personagem perde 1 vida.
             */
            hp = hp - 1;                       
        }

        if(other.gameObject.tag == "Cristal")
        {
            /*
                Encontrando as fragmentos do cristal, o personagem ganha 50 vidas.
             */

            other.gameObject.SetActive(false);
            hp = hp + 50;
        }
        print("HP ATUAL: " + hp);

        if(other.gameObject.tag == "CristalNegro")
        {
            SceneManager.LoadScene(5);
        }

        if(hp <= 0)
        {
            /*
                Vida = 0, game over.    
            */
            SceneManager.LoadScene(4);
        }
        
    }
}
