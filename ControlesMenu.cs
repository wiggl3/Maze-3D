using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ControlesMenu : MonoBehaviour {

	public void Iniciar()
	{
		SceneManager.LoadScene("labirinto1");
	}

	public void Creditos()
	{
		SceneManager.LoadScene("Creditos");
	}

	public void Controles()
	{
		SceneManager.LoadScene("Controles");
	}

	public void Menu()
	{
		SceneManager.LoadScene("Menu");
	}
}
