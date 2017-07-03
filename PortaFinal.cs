using UnityEngine;
using System.Collections;

public class PortaFinal : MonoBehaviour {

	private Animator abrefecha;
	bool portaAberta;
	public GameObject fogos;
	//public float timer;

	// Use this for initialization
	void Start () {
		abrefecha = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.Alpha0)) 
		{
			abrefecha.SetInteger ("porta1", 0);
		}

		if (Input.GetKey (KeyCode.Alpha2)) 
		{
			abrefecha.SetInteger ("porta1", 1);
			portaAberta = true;
			fogos.SetActive(true);
		}

		/*if (timer >= 6) 
		{
			abrefecha.SetInteger ("porta1", 2);
			portaAberta = false;
			timer = 0;
		}
		/*if (Input.GetKey (KeyCode.Alpha2)) 
		{
			abrefecha.SetInteger ("porta1", 2);
		}
		if (portaAberta == true) 
		{
			timer += Time.deltaTime;
		}*/
	}
}