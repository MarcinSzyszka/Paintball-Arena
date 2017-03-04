using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Unit : MonoBehaviour
{
	protected Rigidbody2D Rigid
	{
		get { return GetComponent<Rigidbody2D>(); }
	}

	protected virtual void Start()
	{
		Rigid.gravityScale = 0;
	}
}
