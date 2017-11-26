using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Rehenes : MonoBehaviour {

	[SerializeField] 
	public Image Salvar1;
	public Image salvar1a;


	// salvar rehenes animacion
	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Player"))
			Salvar1.enabled = true;
	}

	void OnTriggerExit(Collider other)
	{
		
		Salvar1.enabled = false;
	
		if (other.CompareTag ("Player"))
			EnemyMana.instance.muertes++;
			Destroy(gameObject);

			

	}
}



