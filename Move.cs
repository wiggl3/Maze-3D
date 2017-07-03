using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

    Rigidbody rb;

    float vel = 0;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        move();
        vel = Input.GetAxisRaw("Vertical");
	}

    void move()
    {

        if (vel > 0)
        {
            rb.velocity = transform.forward * 1000 * Time.deltaTime;
        }

        if (vel < 0)
        {
            rb.velocity = -transform.forward * 1000 * Time.deltaTime;
        }

        transform.eulerAngles += new Vector3(0, Input.GetAxisRaw("Horizontal") * 5, 0);

		/*if (Input.GetKey (KeyCode.Space)) 
		{
			rb.velocity = new Vector3 (0, 20, 0);
		}*/
    }
}
