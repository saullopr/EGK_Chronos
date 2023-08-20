using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
	public Button BotaoJogarN, BotaoSairJ;
	public string nomeCenaJogo = "CENAGAMEOVER";
	private string nomeDaCena;

	// Use this for initialization
	void Start () {
		BotaoJogarN.onClick = new Button.ButtonClickedEvent();
		BotaoSairJ.onClick = new Button.ButtonClickedEvent();
		nomeDaCena = SceneManager.GetActiveScene().name;
		Cursor.visible = true;
		Time.timeScale = 1;
		BotaoJogarN.onClick.AddListener(() => Jogar());
		BotaoSairJ.onClick.AddListener(() => Sair());
	}
	
	// Update is called once per frame
	void Update () {
		if (SceneManager.GetActiveScene().name != nomeDaCena)
		{
			Destroy(gameObject);
		}

	}
	private void Jogar()
	{
		SceneManager.LoadScene(nomeCenaJogo);
	}
	private void Sair()
	{
		Application.Quit();
	}
}
