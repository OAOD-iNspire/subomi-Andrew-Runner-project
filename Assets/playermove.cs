using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour {


	public KeyCode moveL;
	public KeyCode moveR;


	public float horizvel = 0;

	public float vertvel = 0;

	private int currentLane = 2;

	// Use this for initialization
	private void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{



		GetComponent<Rigidbody> ().velocity = new Vector3 (horizvel, 0, 1);

		if (Input.GetKeyDown (moveL) &&(currentLane > 1)) {
			horizvel = -2;
			StartCoroutine(stopSlide());
			currentLane -= 1;
		}

		if (Input.GetKeyDown (moveR) && (currentLane < 3)) {
			horizvel = 2;
			StartCoroutine(stopSlide());
			currentLane += 1;
		}


	}
	IEnumerator stopSlide() 
	{
		yield return new WaitForSeconds (.5f);
		horizvel = 0;
	}
}