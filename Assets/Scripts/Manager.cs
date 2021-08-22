using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
	// Paneles
	public GameObject panelPrincipal;
	public GameObject panelPrincipalMecanica;
	public GameObject panelModeloSeleccionado;
	public GameObject panelInformacion;
	public GameObject panelHistoria;
	public GameObject panelPersonajes;
	
	// SubPaneles
	public GameObject panelModeloEstadio;
	public GameObject panelModeloCentroLeon;
	public GameObject panelModeloMonumento;
	public GameObject panelModeloAurora;
	public GameObject panelModeloTeatro;
	public GameObject panelModeloCatedral;
	public GameObject panelModeloCampDavid;
	public GameObject panelModeloMatum;
	public GameObject panelModeloParqueCentral;
	public GameObject panelModeloFortaleza;
	
	// Método para encender un panel dado
	public void mostrarPanel(GameObject panelAMostrar){
		
		// Apagamos los paneles
		panelHistoria.SetActive(false);
		panelInformacion.SetActive(false);
		panelModeloAurora.SetActive(false);
		panelModeloCampDavid.SetActive(false);
		panelModeloCatedral.SetActive(false);
		panelModeloCentroLeon.SetActive(false);
		panelModeloEstadio.SetActive(false);
		panelModeloMatum.SetActive(false);
		panelModeloMonumento.SetActive(false);
		panelModeloParqueCentral.SetActive(false);
		panelModeloFortaleza.SetActive(false);
		panelModeloSeleccionado.SetActive(false);
		panelModeloTeatro.SetActive(false);
		panelPersonajes.SetActive(false);
		panelPrincipal.SetActive(false);
		panelPrincipalMecanica.SetActive(false);
		
		/// Encendemos el panel
		panelAMostrar.SetActive(true);
	}
	
}
