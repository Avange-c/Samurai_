using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour
{
  void OnCollisionEnter2D(Collision2D col)
  {
		if (col.gameObject.tag == "Enemy") {
			Destroy (col.gameObject);
			EnemyMove._shootInEnemy = 0;
		}
	}

}
