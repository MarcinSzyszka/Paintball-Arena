using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class BunkerBase : Unit
{
	private BoxCollider2D BoxCollider { get { return GetComponent<BoxCollider2D>(); } }
	protected override void Start()
	{
		Rigid.isKinematic = true;
		base.Start();
	}
}
