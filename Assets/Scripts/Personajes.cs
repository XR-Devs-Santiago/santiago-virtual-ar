using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Personajes : MonoBehaviour
{
	
	public GameObject personajesMonumento;
	public GameObject personajesAurora;
	public GameObject personajesTeatro;
	
	//Botones anterior y siguiente
	public GameObject btnAnteriorSiguiente;
	public GameObject btnAnterior;
	public GameObject btnSiguiente;
	
	// Arreglo para los personajes
	public GameObject[] arregloPersonajesMonumento;
	// Panel con el grupo de personajes del arreglo
	public GameObject personaje;
	
	// Manager instancia
	public Manager manager;
	
	// Iniciador del arreglo de personajes
	public int index = 0;
	
	
	protected void Start()
	{
		////Manager principal
		manager = GameObject.FindObjectOfType<Manager>();
		
		////Mostrando panel personajes
		manager.mostrarPanel(manager.panelPersonajes);
	
		// Mostrar personaje(s) del lugar seleccionado al presionar boton desde el panel Historia:
		//mostrarPersonajesDelLugar();
		
	}
	/// <summary>
	/// Metodo para programar la mecanica del boton siguiente
	/// </summary>
	
	public void next(){
		// desactivamos el personaje previo
		personaje = arregloPersonajesMonumento[index];
		personaje.SetActive(false);
		index++;
		// Verifica si no se pasa del # de elementos del arreglo...
		if(index > arregloPersonajesMonumento.Length - 1){
			index = 0;
			Debug.Log("vuelve a 0");
		}
		//Enciende el personaje	
		personaje = arregloPersonajesMonumento[index];
		personaje.SetActive(true);

	}
	
	/// <summary>
	/// Metodo para programar la mecanica del boton anterior
	/// </summary>
	public void previous(){
		// Viene del boton anterior
		// desactivamos el personaje previo
		personaje = arregloPersonajesMonumento[index];
		personaje.SetActive(false);
		index--;
		// Verifica si no se pasa del # de elementos del arreglo...
		if(index < 0){
			index = arregloPersonajesMonumento.Length - 1;
			Debug.Log("vuelve al ultimo elemento del arreglo: 2");
		} 
		//Enciende el personaje	
		personaje = arregloPersonajesMonumento[index];
		personaje.SetActive(true);	

	}
  
	/// <summary>
	/// Metodo para saber de que lugar corresponde el personaje de acuerdo con el lugar seleccionado
	/// </summary>
	/// <param name="lugar"></param>
	public void mostrarPersonajesDelLugar(){
		
		//Obtenemos el lugar seleccionado
		var lugar = ValoresGlobales.modelo_seleccionado;
		Debug.Log("Modelo seleccionado: "+ValoresGlobales.modelo_seleccionado);
		
		//Activamos nuevamente los botones
		btnAnteriorSiguiente.SetActive(true);
		personajesMonumento.SetActive(false);
		personajesAurora.SetActive(false);
		personajesTeatro.SetActive(false);
		
		// Determinamos cuales personajes se activan de acuerdo a ese lugar
		switch(lugar){
			
		case Modelos.monumento:
			personajesMonumento.SetActive(true);
			Debug.Log(personajesMonumento);

			// Sse abre la mecanica para los botones next/previous
			break;
			 	
		case Modelos.centro_leon:
			personajesAurora.SetActive(true);
			// Desactivamos botones siguiente/anterior
			btnAnteriorSiguiente.SetActive(false);
			break;
		case Modelos.aurora:
			personajesAurora.SetActive(true);
			// Desactivamos botones siguiente/anterior
			btnAnteriorSiguiente.SetActive(false);
			break;
		case Modelos.teatro:
			personajesTeatro.SetActive(true);
			// Desactivamos botones siguiente/anterior
			btnAnteriorSiguiente.SetActive(false);
			break;
			default:
				Debug.Log("No se encuentran personajes de este lugar.");
			 	break;
		}
	}

	

 
 
}
