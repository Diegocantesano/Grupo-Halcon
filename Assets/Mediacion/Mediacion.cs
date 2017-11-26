using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Mediacion : MonoBehaviour {

	// rehenes para salvar


	// el reloj
	public float TiempoRestante = 900;
	// el tiempo del reloj que vere en pantalla
	public int tiempo;
	public Text RELOJ;

	// codigo de empatia
	public int Empatia;

	// aca mension las variantes para el DIALOGO
	public Text BText1;
	public Text BText2;

	// aca me indicara quien es el que habla  ( nombre del personaje)
	public Text SText1;
	public Text SText2;

	//contador de la charlas
	public int Dialogo = 1;

	// las opciones a elejir

	//Mediacion Caso 1-1
	public GameObject Presentarte;
	public GameObject LosRehenes;
	public GameObject UnTrato;
	//Mediacion Caso 1-2
	public GameObject QuienEs;
	public GameObject LosRehenes2;
	public GameObject QueQuieres;
	//Mediacion Caso 2-1
	public GameObject LosRehenes3;
	public GameObject ComoEsta;
	//Mediacion Caso 2-3
	public GameObject MenosCondena;
	public GameObject Liberar;
	public GameObject Alimentos;


	// proximo dialogo
	public GameObject nextbutton;

	public GameObject Texto;
	public GameObject Nombre;


	void Update()
	{
		// reloj en decresimiento
		TiempoRestante -= Time.deltaTime;

		// transforma el float en un int y me permite verlo en pantalla
		tiempo = (int)TiempoRestante;
		RELOJ.text = " " + tiempo;
			// tiempo para la primera mediacion
		if (tiempo ==  890)
		{	
		Texto.SetActive(true);
		Nombre.SetActive(true);
		nextbutton.SetActive(true);
			// si no esta esto.. se reduce  2 segundos
		TiempoRestante = 890;
		Hablando();	}


		//tiempo para la segunda mediacion
		if (tiempo ==  750)
		{	
			Texto.SetActive(true);
			Nombre.SetActive(true);
			nextbutton.SetActive(true);
			TiempoRestante = 750;
			Hablando();	
		}
		
		if (tiempo ==  450)
		{	TiempoRestante = 450;
			Hablando();	}

	
		// VICTORIA
		if (tiempo ==  500)
		{	TiempoRestante = 500;
			Hablando();	}
		
	}




	public	void Hablando()
	{
		Dialogo = Dialogo + 1;
	
		// ETAPA 1--------------------------------

		if(Dialogo == 2) // Mediador - charla 1 - 01
		{
			BText1.text = "Hola señor, aca le habla el mediador, me escucha bien?";
			SText1.text = "Mediador";
			// aca se declara en blanco tiene que siempre estar asi cuando es la segunda persona.
			BText2.text = "";
			SText2.text = "";
			// cada vez que aumente en uno ira llendo a los diferentes dialogos acorde al orden creado.
		}		
		else	if(Dialogo == 3) // Malandra - charla 1 - 02
		{	
			BText1.text = "";
			SText1.text = "";
			BText2.text = "Eh... si ... hola... me escuchas solo vos no? no estoy en alta voz o algo asi?";
			SText2.text = "Malandra";
		}
		else	if(Dialogo == 4)// Mediador - charla 1 - 03
		{
			BText1.text = "No se preocupe, que la charla esta totalmente privada para nosotros dos, nadie mas nos esta escuchando, pero ants que nada....";
			SText1.text = "Mediador";
			BText2.text = "";
			SText2.text = "";
			// ETAPA 1 seleccion de preguntas
			nextbutton.SetActive(false);
			Presentarte.SetActive(true);
			LosRehenes.SetActive(true);
			UnTrato.SetActive(true);
		}
		// opciones de primera seleccion
		else	if(Dialogo == 6) // opcion 1 - Malandra - chalra 1 - 04 A
		{
			BText1.text = "";
			SText1.text = "";
			BText2.text = "a bueno... esta bien...";
			SText2.text = "Malandra";
		}
				else if (Dialogo == 7) // opcion 1 - Mediador - chalra 1 - 05 A
				{
					BText1.text = "Bueno, ahora que me eh presentado podria...";
					SText1.text = "Mediador";
					BText2.text = "";
					SText2.text = "";
					nextbutton.SetActive(false);
					QuienEs.SetActive(true);
					LosRehenes2.SetActive(true);
					QueQuieres.SetActive(true);
				}		
								else if (Dialogo == 9) // opcion 1 - Mediador - chalra 1 - 06 AA
								{
									BText1.text = "";
									SText1.text = "";
									BText2.text = "Me llamo Oscar Lean, es lo unico que te voy a decir, asi que recordalo loco";
									SText2.text = "Malandra";
									Dialogo = 28; 
								}				
								else if (Dialogo == 11) // opcion 1 - Mediador - chalra 1 - 06 AB
								{
									BText1.text = "";
									SText1.text = "";
									BText2.text = "Los rehenes estan bien, no te preocupes por eso mientras no intentes nada loco";
									SText2.text = "Malandra";
									Dialogo = 28; 
								}		
								else if (Dialogo == 13) // opcion 1 - Mediador - chalra 1 - 06 AC
								{
									BText1.text = "";
									SText1.text = "";
									BText2.text = "Loco aguanta un poco, no estamos en confianza para hablar asi";
									SText2.text = "Malandra";
									Dialogo = 28; 
								}		
				else if (Dialogo == 15) // opcion 1 - Mediador - chalra 1 - 05 B
				{
					BText1.text = "";
					SText1.text = "";
					BText2.text = "Eh.. Las personas tan bien.. No les voy a hacer nada loco .. Mientras no intenten nada raro no van a pasar nada me entandes?";
					SText2.text = "Malandra";
				}	
				else if (Dialogo == 16) // opcion 1 - Mediador - chalra 1 - 06 B
				{
					BText1.text = "Si, no se preocupe no estamos intentando nada raro, solo quiero que todo esté bien te lo aseguro.";
					SText1.text = "Mediador";
					BText2.text = "";
					SText2.text = "";
					Dialogo = 28; 
				}	
				else if (Dialogo == 19) // opcion 1 - Mediador - chalra 1 - 05 C
				{
					BText1.text = "";
					SText1.text = "";
					BText2.text = "Eh.. Las personas tan bien.. No les voy a hacer nada loco .. Mientras no intenten nada raro no van a pasar nada me entandes?";
					SText2.text = "Malandra";
					Dialogo = 28; 
				}	
				else if (Dialogo == 29) // opcion 1 - Mediador - chalra 1 - FINAL
				{
			BText1.text = "bueno señor, quédese calmado que yo ahora voy a hablar con mis superiores para que podamos hablar del la situación actual y como solucionarla, le pido paciencia y calma";
					SText1.text = "Mediador";
					BText2.text = "";
					SText2.text = "";
				}	
	if(Dialogo == 30)
	{
		BText1.text = "";
		SText1.text = "";
		
		BText2.text = "";
		SText2.text = "";
		Texto.SetActive(false);
		Nombre.SetActive(false);
		nextbutton.SetActive(false);
	}	

		// ETAPA 2--------------------------------

		if(Dialogo == 31) // Mediador - charla 2 - 01
		{
			Texto.SetActive(true);
			Nombre.SetActive(true);
			nextbutton.SetActive(true);
			BText1.text = "Hola… soy yo otra vez, me escucha claro?";
			SText1.text = "Mediador";
			BText2.text = "";
			SText2.text = "";
		}		
		if(Dialogo == 32) // Mediador - charla 2 - 02
		{
			BText1.text = "";
			SText1.text = "";
			BText2.text = "Ehh.. si se escucha loco";
			SText2.text = "Malandra";
		}		
		if(Dialogo == 33) // Mediador - charla 2 - 03
		{
			BText1.text = "Bueno antes que nada una pregunta";
			SText1.text = "Mediador";
			BText2.text = "";
			SText2.text = "";
			nextbutton.SetActive(false);
			LosRehenes3.SetActive(true);
			ComoEsta.SetActive(true);
		}
					if(Dialogo == 35) // Mediador - charla 2 - 04 A 1
					{
						BText1.text = "";
						SText1.text = "";
						BText2.text = "Los rehenes estan bien, no les paso nada asi que ojito loco";
						SText2.text = "Malandra";
					

					}		
					if(Dialogo == 36) // Mediador - charla 2 - 05 A 1
					{
						BText1.text = "No se preocupe señor que tiene mi palabra que no estamos intentando nada, se lo aseguro, solo conserver la calma.";
						SText1.text = "Mediador";
						BText2.text = "";
						SText2.text = "";
						Dialogo = 49; 

					}		
					if(Dialogo == 38) // Mediador - charla 2 - 04 A 2
					{
						Empatia = Empatia - 20;
						BText1.text = "";
						SText1.text = "";
						BText2.text = "Que importa como estan, por ahora estan vivos loco, parece que estas mas preocupapados por ellos....";
						SText2.text = "Malandra";
					

					}		
					if(Dialogo == 39) // Mediador - charla 2 - 05 A 2
					{
						BText1.text = "Señor conserve la calma, que podemos hablar con tranquilidad, yo solamente quiero ayudarlo";
						SText1.text = "Mediador";
						BText2.text = "";
						SText2.text = "";
						Dialogo = 49; 
					}		
		if(Dialogo == 41) // Mediador - charla 2 - 04 B 1
		{
			BText1.text = "";
			SText1.text = "";
			BText2.text = "yo estoy calmado, asi que mientras esten las cosas asi nadie va  tener problemas me tendes?";
			SText2.text = "Malandra";
		
		}		
		if(Dialogo == 42) // Mediador - charla 2 - 05 B 1
		{
			Empatia = Empatia + 5;
			BText1.text = "Totalmente, no se preocupe esta con una persona de confianza, me asegurare de poder cumplir sus demadnas para que todo estemos bien sin ninguna baja";
			SText1.text = "Mediador";
			BText2.text = "";
			SText2.text = "";
			Dialogo = 49; 
		}				
		if(Dialogo == 44) // Mediador - charla 2 - 04 B 2
		{
			BText1.text = "";
			SText1.text = "";
			BText2.text = "Yo estoy normal, mientras no se asome ningun soldadito suyo no tendremos probelmas entendido?";
			SText2.text = "Malandra";
	
		}		
		if(Dialogo == 45) // Mediador - charla 2 - 05 B 2
		{
			Empatia = Empatia + 15;
			BText1.text = "no se preocupe que de eso ya lo tengo en cuenta y lo unico que busco es poder hablar con usted para que tengamos una solucion pacifica sin problemas";
			SText1.text = "Mediador";
			BText2.text = "";
			SText2.text = "";
			Dialogo = 49; 
		}		
		if(Dialogo == 50) // Mediador - charla 2 - 06
		{
			
			BText1.text = "Bueno, hablemos un poco de como podemos resolver esto, yo eh hablado con mis superiores y rechase muchas de las cosas que no serian beneficiosas para usted";
			SText1.text = "Mediador";
			BText2.text = "";
			SText2.text = "";
		}		
		if(Dialogo == 51) // Mediador - charla 2 - 07
		{

			BText1.text = "asi que tengo aca un pedido de ellos en el cual podriamos llegar a un acuerdo...";
			SText1.text = "Mediador";
			BText2.text = "";
			SText2.text = "";
			nextbutton.SetActive(false);
			Liberar.SetActive(true);
			MenosCondena.SetActive(true);
			if(Empatia == 85)
				Alimentos.SetActive(true);	
		}				
		if(Dialogo == 53) // Mediador - charla 2 - 08 A
		{
			BText1.text = "";
			SText1.text = "";
			BText2.text = "ENTREGARME... NI LOCO... NO LLAME MAS.... Y A LA CARCEL NO PIENSO IR... MUERTO ANTES QUE ENCERRADO";
			SText2.text = "Malandra";
			Empatia = Empatia - 90;
			Dialogo = 666; 

		}

		if(Dialogo == 667)
		{
			BText1.text = "";
			SText1.text = "";

			BText2.text = "";
			SText2.text = "";
			Texto.SetActive(false);
			Nombre.SetActive(false);
			nextbutton.SetActive(false);
			// AGREGAR IMAGEN DE GAME OVER////////////////////////////////////////
			Application.LoadLevel ("Derrota");
		}	
		if(Dialogo == 55) // Mediador - charla 2 - 08 B
		{
			BText1.text = "";
			SText1.text = "";
			BText2.text = "Bueno loco... esperare a que me digas una mejor oferta, y espero que este buena... sino te entrego una coladera de rehen...";
			SText2.text = "Malandra";
		}		
		if(Dialogo == 56) // Mediador - charla 2 - 09 B
		{
			BText1.text = "No porfavor... si genera ese conflicto em complicaras conseguir algo mejor para usted, este atento que voy a hablar con mis superiores para ofrecer algo mejor en la proxima llamada. porfavor este atento y calmado.";
			SText1.text = "Mediador";
			BText2.text = "";
			SText2.text = "";
			Dialogo = 300; 
		}		

		if(Dialogo == 301) // Mediador - charla 2 - 09 C
		{
			BText1.text = "hola.. aca le hablo otra vez";
			SText1.text = "Mediador";
			BText2.text = "";
			SText2.text = "";
		}
		if(Dialogo == 302) // Mediador - charla 2 - 10
		{
			BText1.text = "";
			SText1.text = "";
			BText2.text = "quere saber algo.. ya toy cansado de esto.. asi que no llame otra vez porque no atendere -- se corta --";
			SText2.text = "Malandra";
		}	
		if(Dialogo == 303) // Mediador - charla 2 - 09 C
		{
			BText1.text = "no.. espere señor..";
			SText1.text = "Mediador";
			BText2.text = "";
			SText2.text = "";
		}
		if(Dialogo == 304) // Mediador - charla 2 - 10
		{
			BText1.text = "";
			SText1.text = "";
			BText2.text = ".....";
			SText2.text = "Malandra";
		}	
		if(Dialogo == 305) // Mediador - charla 2 - 09 C
		{
			BText1.text = "mierda... tendremos que entrar por la fuerza...";
			SText1.text = "Mediador";
			BText2.text = "";
			SText2.text = "";
		}
		if(Dialogo == 306)
		{
			BText1.text = "";
			SText1.text = "";

			BText2.text = "";
			SText2.text = "";
			Texto.SetActive(false);
			Nombre.SetActive(false);
			nextbutton.SetActive(false);
		}	

		if(Dialogo == 58) // Mediador - charla 2 - 08 C
		{
			BText1.text = "";
			SText1.text = "";
			BText2.text = "Bueno loco... me gusta esa idea... pero tendria que darme algo a cambio";
			SText2.text = "Malandra";
		}		
		if(Dialogo == 59) // Mediador - charla 2 - 09 C
		{
			BText1.text = "si... digame que necesita";
			SText1.text = "Mediador";
			BText2.text = "";
			SText2.text = "";
		}
		if(Dialogo == 60) // Mediador - charla 2 - 10
		{
			BText1.text = "";
			SText1.text = "";
			BText2.text = "Si yo me entrego quiero poder ver a mi familia lo mas seguido posible";
			SText2.text = "Malandra";
		}		
		if(Dialogo == 61) // Mediador - charla 2 - 11
		{
			BText1.text = "No tenga preocupacion de eso.. yo puedo arreglar facilmente ese acuerdo";
			SText1.text = "Mediador";
			BText2.text = "";
			SText2.text = "";
		}		
		if(Dialogo == 62) // Mediador - charla 2 - 12
		{
			BText1.text = "";
			SText1.text = "";
			BText2.text = "Bueno.. dejeme pensarlo y hablarlo con mi compañero";
			SText2.text = "Malandra";
	
		}		
		if(Dialogo == 61) // Mediador - charla 2 - 13
		{
			BText1.text = "yo ire a hablar con mis superiores para informarle la novedad y me comunicare con usted";
			SText1.text = "Mediador";
			BText2.text = "";
			SText2.text = "";
			Empatia = 100;
			Dialogo = 1000;
			Texto.SetActive(false);
			Nombre.SetActive(false);
			nextbutton.SetActive(false);
		}

	//VICTORIAAAAAAAAAAAAAAAA

		if(Dialogo == 1001) 
		{			

			Texto.SetActive(true);
			Nombre.SetActive(true);
			nextbutton.SetActive(true);
			BText1.text = "Hola señor... mire eh hablado una vez mas y ya podemos tener un trato justo para usted";
			SText1.text = "Mediador";
			BText2.text = "";
			SText2.text = "";
		}
		if(Dialogo == 1002) 
		{
			BText1.text = "";
			SText1.text = "";
			BText2.text = "Contame loco";
			SText2.text = "Malandra";
		}
		if(Dialogo == 1003) 
		{
			BText1.text = "Al entregarce tendra una reducion de condena lo mas proxima a su libertad y tambien contara con la visita de sufamilia teniendo en cuenta las video llamada y llamadas telofonicas. Y podra ser alojado en un penal lo mas sercano a su familia";
			SText1.text = "Mediador";
			BText2.text = "";
			SText2.text = "";
		}	
		if(Dialogo == 1004) 
		{
			BText1.text = "";
			SText1.text = "";
			BText2.text = "Bueno loco.. esta bien...";
			SText2.text = "Malandra";
		}	
			if(Dialogo == 1005) 
		{
			BText1.text = "no se preocupe señor que todo saldra bien se lo prometo";
			SText1.text = "Mediador";
			BText2.text = "";
			SText2.text = "";
		}
		if(Dialogo == 1006) 
		{
			BText1.text = "";
			SText1.text = "";
			BText2.text = "Dale loco... te lo agradesco.. gracias..";
			SText2.text = "Malandra";
		}	
		if(Dialogo == 1007) 
		{
			BText1.text = "No se preocupe.. es mi trabajo.. el bienestar de todos";
			SText1.text = "Mediador";
			BText2.text = "";
			SText2.text = "";


		}
		if(Dialogo == 1008)
		{
			BText1.text = "";
			SText1.text = "";

			BText2.text = "";
			SText2.text = "";
			Texto.SetActive(false);
			Nombre.SetActive(false);
			nextbutton.SetActive(false);
			/// IR A PANTALLA DE VICTORIA
			Application.LoadLevel ("Ganaste");
		}	
	}
	




	// codigos de botones

	// boton charla 1 
	public void opcion1()
	{
		BText1.text = " Me llamo .... de las fuerzas especiales del grupo halcon";
		SText1.text = "Mediador";
		BText2.text = "";
		SText2.text = "";
		Empatia = Empatia + 20;
		Dialogo = 5;

		Presentarte.SetActive(false);
		LosRehenes.SetActive(false);
		UnTrato.SetActive(false);
		nextbutton.SetActive(true);
	}
					public void opcion1A()
					{
						BText1.text = " Con quien tengo el gusto de hablar...";
						SText1.text = "Mediador";
						BText2.text = "";
						SText2.text = "";
						Empatia = Empatia + 10;
						Dialogo = 8;

						QuienEs.SetActive(false);
						LosRehenes2.SetActive(false);
						QueQuieres.SetActive(false);
						nextbutton.SetActive(true);
					}
					public void opcion1B()
					{
						BText1.text = "Me gustaría saber si podrías decirme el estado de las personas adentro.";
						SText1.text = "Mediador";
						BText2.text = "";
						SText2.text = "";
						Empatia = Empatia + 5;
						Dialogo = 10;

						QuienEs.SetActive(false);
						LosRehenes2.SetActive(false);
						QueQuieres.SetActive(false);
						nextbutton.SetActive(true);
					}
					public void opcion1C()
					{
						BText1.text = "Me gustaría que pudiéramos llegar a un acuerdo pacífico para su detención";
						SText1.text = "Mediador";
						BText2.text = "";
						SText2.text = "";
						Empatia = Empatia + 0;
						Dialogo = 12;

						QuienEs.SetActive(false);
						LosRehenes2.SetActive(false);
						QueQuieres.SetActive(false);
						nextbutton.SetActive(true);
					}
	public void opcion2()
	{	
		BText1.text = "me gustaria saber si podrias decirme el estado de las personas adentro";
		SText1.text = "Mediador";
		BText2.text = "";
		SText2.text = "";
		Empatia = Empatia + 10;
		Dialogo = 14;
		Presentarte.SetActive(false);
		LosRehenes.SetActive(false);
		UnTrato.SetActive(false);
		nextbutton.SetActive(true);

	}
	public void opcion3()
	{
		BText1.text = "megustaria que pudieramos llegar a un acuerdo pacifico para su detencion";
		SText1.text = "Mediador";
		BText2.text = "";
		SText2.text = "";
		Empatia = Empatia - 20;
		Dialogo = 17;
		Presentarte.SetActive(false);
		LosRehenes.SetActive(false);
		UnTrato.SetActive(false);
		nextbutton.SetActive(true);
	}
	// boton charla 2
	public void opcion4()
	{
		BText1.text = "Como están los rehenes?";
		SText1.text = "Mediador";
		BText2.text = "";
		SText2.text = "";
		if(Empatia == 80)
		{
		Dialogo = 34;
		LosRehenes3.SetActive(false);
		ComoEsta.SetActive(false);
		nextbutton.SetActive(true);
		}
		else if(Empatia == 75)
		{
		Dialogo = 34;
		LosRehenes3.SetActive(false);
		ComoEsta.SetActive(false);
		nextbutton.SetActive(true);
		}
		else if(Empatia == 70)
		{
		Dialogo = 34;
		LosRehenes3.SetActive(false);
		ComoEsta.SetActive(false);
		nextbutton.SetActive(true);
		}
		else if(Empatia == 60)
		{
		Dialogo = 37;
		LosRehenes3.SetActive(false);
		ComoEsta.SetActive(false);
		nextbutton.SetActive(true);
		}
		else if(Empatia == 30)
		{
		Dialogo = 37;
		LosRehenes3.SetActive(false);
		ComoEsta.SetActive(false);
		nextbutton.SetActive(true);
		}

	}
	public void opcion5()
	{
		BText1.text = "Como se encuentra usted?";
		SText1.text = "Mediador";
		BText2.text = "";
		SText2.text = "";
		if(Empatia == 80)
		{
			Dialogo = 40;
			LosRehenes3.SetActive(false);
			ComoEsta.SetActive(false);
			nextbutton.SetActive(true);
		}
		else if(Empatia == 75)
		{
			Dialogo = 40;
			LosRehenes3.SetActive(false);
			ComoEsta.SetActive(false);
			nextbutton.SetActive(true);
		}
		else if(Empatia == 70)
		{
			Dialogo = 40;
			LosRehenes3.SetActive(false);
			ComoEsta.SetActive(false);
			nextbutton.SetActive(true);
		}
		else if(Empatia == 60)
		{
			Dialogo = 43;
			LosRehenes3.SetActive(false);
			ComoEsta.SetActive(false);
			nextbutton.SetActive(true);
		}
		else if(Empatia == 30)
		{
			Dialogo = 43;
			LosRehenes3.SetActive(false);
			ComoEsta.SetActive(false);
			nextbutton.SetActive(true);
		}
	}
					public void opcion6()
					{	
						BText1.text = "Entregarse y tener una reduccion de condena";
						SText1.text = "Mediador";
						BText2.text = "";
						SText2.text = "";
						Dialogo = 52;
						Liberar.SetActive(false);
						MenosCondena.SetActive(false);
						nextbutton.SetActive(true);
					}
					public void opcion7()
					{	
						BText1.text = " Tener la posibilidad de liberar a un rehen para poder mejorar la oferta en relacon a su condena con mas benficios";
						SText1.text = "Mediador";
						BText2.text = "";
						SText2.text = "";
						Dialogo = 54;
						Liberar.SetActive(false);
						MenosCondena.SetActive(false);
						nextbutton.SetActive(true);
					}
					public void opcion8()
					{	
						BText1.text = "podremos ofrecerle comida y agua en caso que lo necesite ahora, pero tendriamos que dejar a uno de los rehenes libre en lo posible. ademas de esta forma podre hablar con mis superiores para hacer una contraoferta mas acorde a su comodidad";
						SText1.text = "Mediador";
						BText2.text = "";
						SText2.text = "";
						Dialogo = 57;
						Liberar.SetActive(false);
						MenosCondena.SetActive(false);
						Alimentos.SetActive(false);
						nextbutton.SetActive(true);
					}
}
