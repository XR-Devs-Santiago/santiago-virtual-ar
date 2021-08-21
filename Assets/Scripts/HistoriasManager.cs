using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HistoriasManager : MonoBehaviour
{
	//variables que almacenan las historias a mostrar
	public GameObject monumento_info, estadio_info, aurora_info, teatro_info, catedral_info, 
		parque_central_info, camp_david_info, centro_leon_info, 
		fortaleza_san_luis_info;
	//variable que almancena el panel de historias y su panel de contenido
	public GameObject panel_historias, panel_historia_content;
	//variables para el botón de personajes y el texto conoce sus personajes
	public GameObject boton_personajes, conoce_sus_personajes;
	
	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	protected void Start()
	{
		activar_panel_historia();
	}
	public void activar_panel_historia()
	{
		//validamos el botón personajes
		validar_boton_personajes();
		//activamos la historia de acuerdo al modelo seleccionado
		activar_historia();
	}

	//función para activar la historia del modelo seleccionado
	public void activar_historia()
	{
		//desactivamos todos los elementos de contenido del panel historia
		GlobalFunctions.desactivar_hijos(panel_historia_content.transform);
		//buscamos el modelo seleccionado
		var modelo_seleccionado = ValoresGlobales.modelo_seleccionado;
		switch(modelo_seleccionado)
		{
			case Modelos.monumento:
				monumento_info.SetActive(true);
				break;
			case Modelos.aurora:
				aurora_info.SetActive(true);
				break;
			case Modelos.estadio_cibao:
				estadio_info.SetActive(true);
				break;
			case Modelos.teatro:
				teatro_info.SetActive(true);
				break;
			case Modelos.catedral:
				catedral_info.SetActive(true);
				break;
			case Modelos.parque_central:
				parque_central_info.SetActive(true);
				break;
			case Modelos.camp_david:
				camp_david_info.SetActive(true);
				break;
			case Modelos.centro_leon:
				centro_leon_info.SetActive(true);
				break;
			case Modelos.fortaleza:
				fortaleza_san_luis_info.SetActive(true);
				break;
		}
	}
	//función para volver al panel anterior
	//public void volver_a_modelo_seleccionado()
	//{
	//	var manager = GameObject.FindObjectOfType<Manager>();
	//	manager.mostrarPanel(manager.panelModeloSeleccionado);
	//	activar_modelo_seleccionado();
	//}
	
	//función que determinar si el botón personaajes debe mostrarse o no
	void validar_boton_personajes()
	{
		var modelo_seleccionado = ValoresGlobales.modelo_seleccionado;
		if(modelo_seleccionado ==	Modelos.monumento || modelo_seleccionado == Modelos.aurora || modelo_seleccionado == Modelos.centro_leon)
		{
			boton_personajes.SetActive(true);
			conoce_sus_personajes.SetActive(true);
		}
		else
		{
			boton_personajes.SetActive(false);	
			conoce_sus_personajes.SetActive(false);
		}
	}
	
}
