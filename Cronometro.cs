using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Cronometro : MonoBehaviour {

	public float timer;
	public int min;
	public Text contador;
	public Text minuto;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		contador.text = timer.ToString();
		minuto.text = min.ToString ();

		if (timer >= 60) 
		{
			min += 1;
			timer = 0;
		}


	}
}
