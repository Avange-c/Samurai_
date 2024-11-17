using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShurikenDestroy : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D col)
    {
		if (col.gameObject.tag == "Shuriken") {
			Destroy (col.gameObject);
		}
	}
}
