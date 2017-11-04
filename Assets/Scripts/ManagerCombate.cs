using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerCombate : MonoBehaviour {

    public List<Moverse> Soldados;

    public Button prefab;
    public static ManagerCombate singleton;
    public Text TextoEstado;
    public Transform panel;

    void Awake ()
    {
        if(singleton != null)
        {
            Destroy(gameObject);
            return;
        }
        singleton = this;
		
	}

    public void Actualizarinterface()
    {
        TextoEstado.text = "";
        foreach (var soldado in Soldados)
        {
            if(soldado.SigueVivo)
            {
                TextoEstado.text += "<color=" + (soldado.Aliado ? "green" : "red") + ">" +
                soldado.nombre + "HP: " + soldado.vida + "/100 PM: " + soldado.PM + "/100.</color>\n";
            }
            
        }
    }
    void Start()
    {
        Actualizarinterface();
        StartCoroutine("Bucle");
    }
    List<Button> poolbotones = new List<Button>();
    IEnumerator Bucle()
    {
        while(true)
        {
            IEnumerator c = null;

            foreach(var Soldado in Soldados)
            {
                if(Soldado.SigueVivo)
                {
                    if(Soldado.Aliado)
                    {
                        foreach(var accion in Soldado.Acciones)
                        {
                            Button b = null;
                            for (int i = 0; i < poolbotones.Count; i++)
                            {
                                if (!poolbotones[i].gameObject.activeInHierarchy)
                                {
                                    b = poolbotones[i];
                                 
                                }
                            }

                            b = Instantiate(prefab, panel);

                            b.transform.position = Vector3.zero;
                            b.transform.localScale = Vector3.one;

                            poolbotones.Add(b);

                            b.gameObject.SetActive(true);
                            b.onClick.RemoveAllListeners();
                            b.GetComponentInChildren<Text>().text = accion.nombre;
                            if (Soldado.PM < accion.CostoPM)
                            {
                                b.interactable = false;
                            }
                            else
                            {
                                b.interactable = true;
                                b.onClick.AddListener(() =>
                                {
                                    for (int j = 0; j < poolbotones.Count; j++)
                                    {
                                        poolbotones[j].gameObject.SetActive(false);
                                    }

                                    c = Soldado.EjecutarAccion(
                                         accion,
                                         Soldados[Random.Range(0, Soldados.Count)].transform);
                                });
                            }

                        }

                    }
                    else
                    {
                        c = Soldado.EjecutarAccion(
                        Soldado.Acciones[Random.Range(0, Soldado.Acciones.Count)],
                        Soldados[Random.Range(0, Soldados.Count)].transform);
                    }
                    while(c == null)
                    {
                        yield return null;
                    }

                    yield return StartCoroutine(c);
                    yield return new WaitForSeconds(1);

                }

                
            }
        }
    }

    // Update is called once per frame
    void Update () {

        Actualizarinterface();
    }
}
