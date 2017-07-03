using UnityEngine;
using System.Collections;

public class Laser : MonoBehaviour {

	public GameObject particulaLaser;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		GameObject particula = Instantiate (particulaLaser);
		particula.transform.position = gameObject.transform.position;
	
	}
}
