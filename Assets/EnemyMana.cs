using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemyMana : MonoBehaviour {

	// atento.
	public static EnemyMana instance;
	public int muertes ;
	void Awake () {

		if (instance == null)
		{
			//Hago que yo sea el manager global
			instance = this;

		}


	}
}
