using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour {

	private Transform myTransform;
	public float TeclaPositiva;
	public float TeclaNegativa;
	void Start () {
		myTransform = GetComponent <Transform>();
	}
	void Update () {

		if (Input.GetKey (KeyCode.W))
			myTransform.Translate (new Vector3 (0, TeclaPositiva, 0));
			
		if (Input.GetKey (KeyCode.S))
			myTransform.Translate (new Vector3 (0, TeclaNegativa, 0));

		/*if (Input.GetKey (KeyCode.A))
			myTransform.Translate (new Vector3 (TeclaNegativa, 0, 0));

		if (Input.GetKey (KeyCode.D))
			myTransform.Translate (new Vector3 (TeclaPositiva, 0, 0));
*/	}
}
