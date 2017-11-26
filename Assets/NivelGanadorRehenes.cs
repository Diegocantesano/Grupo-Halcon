using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NivelGanadorRehenes : MonoBehaviour {

	public int rehenesparaganar;

	void Update () {
		if (EnemyMana.instance.muertes >= rehenesparaganar)
			Application.LoadLevel ("Ganaste2");
		
	}
}
