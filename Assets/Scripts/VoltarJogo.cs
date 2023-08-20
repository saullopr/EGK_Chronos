using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VoltarJogo : MonoBehaviour {
    public Button btnVoltar;
	// Use this for initialization
	void Start () {
		/*btnVoltar.onClick = new Button.ButtonClickedEvent();
        btnVoltar.onClick.AddListener(() => Voltar());*/
        print("oi");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Voltar()
    {
        print("clicou no botão");
        SceneManager.LoadScene(1);
    }
}
