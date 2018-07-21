using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class playerboundary :MonoBehaviour
{

	public float playerBoundaryLeft;
	public float playerBoundaryRight; 




    private void Update()
	{



		if (transform.position.x < playerBoundaryLeft)
		{
			transform.position = new Vector3(playerBoundaryLeft, transform.position.y, transform.position.z);
		}


	}

}