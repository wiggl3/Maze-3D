using UnityEngine;
using System.Collections;

public class EsquemaFolhas : MonoBehaviour {

	[SerializeField]
	GameObject folhas;
	public bool sumir = true;

	Pausa stop;

	// Use this for initialization
	void Start () {
		stop = GameObject.FindObjectOfType<Pausa> ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.eulerAngles += new Vector3 (0, 40 * Time.deltaTime, 0);

		if (sumir == false) 
		{
			folhas.SetActive (true);
			stop.pause = true;

			if (Input.GetKey (KeyCode.Return)) 
			{
				folhas.SetActive (false);
				Destroy (gameObject);
				stop.pause = false;
			}
		}

		if (sumir == true) 
		{
			folhas.SetActive (false);
		}
	}

	void OnTriggerEnter (Collider pages)
	{
		if (pages.gameObject.tag == "Player")
		{
			sumir = false;
		}			
	}
}
