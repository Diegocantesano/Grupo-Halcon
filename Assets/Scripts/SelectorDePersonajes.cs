using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class SelectorDePersonajes : MonoBehaviour
{

    public GameObject Poli1;
    public GameObject Poli2;
    public GameObject Poli3;

    public bool showGUI = false;

	void Start ()
    {
        Poli2.SetActive(false);
        Poli3.SetActive(false);
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown("m"))
        {
            showGUI = true;
        }
	}

    private void OnGUI()
    {
        if (showGUI==true)
        {
            if (GUI.Button(new Rect(10, 10, 50, 50), "1"))
          
            {
                Poli1.SetActive(true);
                Poli2.SetActive(false);
                Poli3.SetActive(false);
            }

            if(GUI.Button(new Rect(60, 60, 50, 50), "2"))


            {
                Poli1.SetActive(false);
                Poli2.SetActive(true);
                Poli3.SetActive(false);
            }

            if (GUI.Button(new Rect(10, 110, 50, 50), "3"))


            {
                Poli1.SetActive(false);
                Poli2.SetActive(false);
                Poli3.SetActive(true);
            }

        }
    }
}
