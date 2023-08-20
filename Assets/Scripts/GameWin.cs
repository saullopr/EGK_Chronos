using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameWin : MonoBehaviour {

	public Button BotaoJogarNN, BotaoSairJJ;
	public string nomeCenaJogo_ = "CENAGAMEOVER";
	private string nomeDaCena_;

	// Use this for initialization
	void Start()
	{
		BotaoJogarNN.onClick = new Button.ButtonClickedEvent();
		BotaoSairJJ.onClick = new Button.ButtonClickedEvent();
		nomeDaCena_ = SceneManager.GetActiveScene().name;
		Cursor.visible = true;
		Time.timeScale = 1;
		BotaoJogarNN.onClick.AddListener(() => Jogar());
		BotaoSairJJ.onClick.AddListener(() => Sair());
	}

	// Update is called once per frame
	void Update()
	{
		if (SceneManager.GetActiveScene().name != nomeDaCena_)
		{
			Destroy(gameObject);
		}

	}
	private void Jogar()
	{
		SceneManager.LoadScene(nomeCenaJogo_);
	}
	private void Sair()
	{
		Application.Quit();
	}
}
