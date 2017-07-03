using UnityEngine;
using System.Collections;

public class Porta : MonoBehaviour {

	private Animator abrefecha;
	bool portaAberta;
	public float timer;
	public AudioSource somPorta;

	// Use this for initialization
	void Start () {
		abrefecha = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

		/*if (Input.GetKey (KeyCode.Alpha0)) 
		{
			abrefecha.SetInteger ("porta1", 0);
		}

		if (Input.GetKey (KeyCode.Alpha1)) 
		{
			abrefecha.SetInteger ("porta1", 1);
			portaAberta = true;
			somPorta.Play ();
		}*/
			
		if (timer >= 6) 
		{
			abrefecha.SetInteger ("porta1", 2);
			portaAberta = false;
			timer = 0;
			somPorta.Play ();
		}
		/*
		if (Input.GetKey (KeyCode.Alpha2)) 
		{
			abrefecha.SetInteger ("porta1", 2);
		}*/
		if (portaAberta == true) 
		{
			timer += Time.deltaTime;
		}
	}

	void OnTriggerEnter (Collider jogador)
	{
		if (jogador.gameObject.tag == "Player") 
		{
			abrefecha.SetInteger ("porta1", 1);
			portaAberta = true;
			somPorta.Play ();
		}
	}

	/*void OnTriggerStay (Collider jogador)
	{
		if (jogador.gameObject.tag == "Player") 
		{
			abrefecha.SetInteger ("porta1", 0);
			//portaAberta = true;
		}
	}*/

	/*void OnTriggerExit (Collider jogador)
	{
		if (jogador.gameObject.tag == "Player") 
		{
			abrefecha.SetInteger ("porta1", 2);
			//portaAberta = true;
		}
	}*/
}
