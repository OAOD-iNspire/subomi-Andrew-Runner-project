using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour {


	public KeyCode moveL;
	public KeyCode moveR;


	public float horizvel = 0;

	public float vertvel = 0;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		GetComponent<Rigidbody> ().velocity = new Vector3 (horizvel, 0, 4);

		if (Input.GetKeyDown (moveL)) {

			horizvel = -2;
		
		}
	}






