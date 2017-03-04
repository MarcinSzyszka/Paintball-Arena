using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player1 : Unit
{
	private float speed = 100;
	protected void Update()
	{
		var vector = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
		vector *= Time.deltaTime;
		vector *= speed;

		Rigid.velocity = vector;
	}
}
