using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



//nota     transform.LookAt(objetivo)  sirve para evitar que rote al mirar y lo haga al instante

[System.Serializable]
public struct Accion
{
    public string nombre;
    public bool Estatico;
    public bool SoyObjetivo;

    //controla la vida de forma sencilla, mensaje
    public string mensaje;
    // puede ser cantidad de vida que quita o agrega
    public int Argumento;
    //seria mejor agregar las animaciones desde este script
    public string animacionTrigger;
    //puntos de movimiento
    

    public float CostoPM;

}
public class Moverse : MonoBehaviour {

    public List<Accion> Acciones;

    public string nombre;
    public int vida;
    public float PM;
    public bool Aliado;
    public bool SigueVivo = true;

    public float Distancia;



    void CambiarVida(int cant)
    {
        vida += cant;
        
    }
    void CambiarPuntosDeAccion(float cant)
    {
        PM += cant;
        
    }
    NavMeshAgent NV;
    ManagerCombate mc;
    Animator anim;
    Vector3 Objetivo;

    void Start () 
	{
        //Declaro que voy a usar NavMesh
        anim = GetComponent<Animator>();
		NV = GetComponent<NavMeshAgent> ();
	}

    public IEnumerator EjecutarAccion(Accion accion, Transform objetivo)
    {
        CambiarPuntosDeAccion(-accion.CostoPM);

        if(accion.SoyObjetivo)
        {
            objetivo = transform;
        }
        if(accion.Estatico)
        {
            anim.SetTrigger(accion.animacionTrigger);
            objetivo.SendMessage(accion.mensaje, accion.Argumento);
        }
        else
        {
            Vector3 PosInicial = transform.position;

            NV.SetDestination(objetivo.position);

            while (Vector3.Distance(transform.position, objetivo.position) > 2)
                yield return null;
            anim.SetTrigger(accion.animacionTrigger);
            objetivo.SendMessage(accion.mensaje, accion.Argumento);

        }
    }

	// Update is called once per frame
	void Update () 
	{
		//Si se hace click se guarda la posicion del click
		if (Input.GetMouseButtonDown (0))
		{
            moverme();

            
        
        }
	}

   

    void moverme()
    {
        Ray Rayo = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit Posicion;

        if (Physics.Raycast(Rayo, out Posicion))
        {
            //Posicion.point nos da el lugar exacto donde el rayo choco.
            Objetivo = Posicion.point;
            Distancia = Vector3.Distance(Posicion.point, transform.position);

            Debug.DrawLine(transform.position, Objetivo, Color.green);


           
            SetearPosicion();
            PM = Distancia - PM;

        }
        
        
        
       
    }

	void SetearPosicion()
	{
        if (Aliado == false)
        {
            return;
        }
        if (PM <= 0)
        {
            return;
        }
        else
        {
            NV.SetDestination(Objetivo);
        }
	}
}
