using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour {

	public bool  pause;
	public GameObject Menu;
	public GameObject Relogio; 

	EsquemaFolhas es;

	// Use this for initialization
	void Start () {
		es = FindObjectOfType<EsquemaFolhas> ();
	}
	
	// Update is called once per frame
	void Update () {
	if (pause == true) 
		{
			Menu.SetActive(true);
			Relogio.SetActive(false);
			Time.timeScale = 0;
		}

	if (pause == false) 
		{
			Menu.SetActive(false);
			Relogio.SetActive(true);
			Time.timeScale = 1;
		}

		Pausando ();
	}

	public void Pausando ()
	{
		if (Input.GetKeyDown (KeyCode.P))
			pause = !pause;
		/*if (Input.GetKey (KeyCode.P))
		{
			pause = true;

			Menu.SetActive(true);
			Relogio.SetActive(false);
		}*/
	}

	public void Voltando ()
	{ 
		pause = false;
		Menu.SetActive(false);
		Relogio.SetActive(true);
	}

	public void menu ()
	{ 
		SceneManager.LoadScene("Menu");
	}
}
