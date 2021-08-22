using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeloSeleccionado : MonoBehaviour
{
	
	public Manager manager; //= new Manager();
	
	public GameObject panelBotones;
	public GameObject panelModeloSeleccionado;
	
	
	public GameObject btnHistoria;
	public GameObject btnInfo;
	public GameObject btnUbicacion;
	public GameObject btnAtras;
	
	public void modeloSelecionado(){

		// Obtenemos el lugar seleccionado
		var lugar = ValoresGlobales.modelo_seleccionado;
		Debug.Log("Modelo seleccionado: "+ValoresGlobales.modelo_seleccionado);

		// Determinamos cual panel se activan de acuerdo a ese lugar
		switch(lugar){
			
			
		case Modelos.monumento:
			manager.mostrarPanel(manager.panelModeloMonumento);
			panelModeloSeleccionado.SetActive(true);
			panelBotones.SetActive(true);
			break;

		case Modelos.centro_leon:
			manager.mostrarPanel(manager.panelModeloCentroLeon);
			panelModeloSeleccionado.SetActive(true);
			panelBotones.SetActive(true);
			break;
		case Modelos.aurora:
			manager.mostrarPanel(manager.panelModeloAurora);
			panelModeloSeleccionado.SetActive(true);
			panelBotones.SetActive(true);
			
			break;
		case Modelos.teatro:
			manager.mostrarPanel(manager.panelModeloTeatro);
			panelModeloSeleccionado.SetActive(true);
			panelBotones.SetActive(true);
			break;
		case Modelos.catedral:
			manager.mostrarPanel(manager.panelModeloCatedral);
			panelModeloSeleccionado.SetActive(true);
			panelBotones.SetActive(true);
			break;
		case Modelos.fortaleza:
			manager.mostrarPanel(manager.panelModeloFortaleza);
			panelModeloSeleccionado.SetActive(true);
			panelBotones.SetActive(true);
			break;
		case Modelos.matum:
			manager.mostrarPanel(manager.panelModeloMatum);
			panelModeloSeleccionado.SetActive(true);
			panelBotones.SetActive(true);
			break;
		case Modelos.camp_david:
			manager.mostrarPanel(manager.panelModeloCampDavid);
			panelModeloSeleccionado.SetActive(true);
			panelBotones.SetActive(true);
			break;
		case Modelos.parque_central:
			manager.mostrarPanel(manager.panelModeloParqueCentral);
			panelModeloSeleccionado.SetActive(true);
			panelBotones.SetActive(true);
			break;
		case Modelos.estadio_cibao:
			manager.mostrarPanel(manager.panelModeloEstadio);
			panelModeloSeleccionado.SetActive(true);
			panelBotones.SetActive(true);
			break;
			
		default:
			Debug.Log("Ubicacion sin pantalla");
			break;
		}
	}	
}
