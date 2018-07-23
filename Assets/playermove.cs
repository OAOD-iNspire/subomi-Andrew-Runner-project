using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour {


	public KeyCode moveL;
	public KeyCode moveR;
	Rigidbody playerRigidbody;
	public int laneNum = 2;
	public string controllocked ="n";
	public float horizvel = 0;

	// Use this for initialization
	void Start () {
		playerRigidbody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		GetComponent<Rigidbody> ().velocity = new Vector3 (horizvel, 0, 4);

		if((Input.GetKeyDown (moveL))&&(laneNum>1)&&(controllocked =="n"))
		{

			horizvel = -2;
			StartCoroutine(StopSlide());
			laneNum -=1;
			controllocked ="y";
		
		}
		if((Input.GetKeyDown(moveR)) && (laneNum<3) && (controllocked =="n"))
		{
			horizvel = 2;
			StartCoroutine(StopSlide());
			laneNum +=1;
			controllocked ="y";
		}
	}
	IEnumerator StopSlide()
	{
		yield return new WaitForSeconds (.5f);
		horizvel = 0;
		controllocked = "n";
	}

}
