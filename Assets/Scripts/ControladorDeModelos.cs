using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDeModelos : MonoBehaviour
{
	// Modelo a seleccionar
	public string modeloSeleccionado;
	// Panel Modelo Seleccionado
	public GameObject panelModeloSeleccionado;
	public Instanciador instanciador;
	public Manager manager;
	
	// OnMouseDown es llamado cuando el usuario preciona el boton del mouse o al toque de un objecto que tenga el component collider. El GameObject debe tener algun tipo de collider para que esta funcion funcione.
	void OnMouseDown() {
		seleccionarModelo();
	}

	public void buscarActivarPanelModeloSelecionado() {
		Handheld.Vibrate();

		GameObject canvas = GameObject.Find("Canvas");

		if (canvas == null) {
			Debug.LogError("No se encontro un GameObject con el nombre 'Canvas'");
		}
		var child = canvas.transform.GetChild(4);


		//for (int i = 0; i < canvas.transform.childCount; i++) 
		//{

		//	var child = canvas.transform.GetChild(i);

		//	if (child != null && child.name == "05- Modelo Seleccionado")
		//	{
		//		panelModeloSeleccionado = child.gameObject;
		//	}
		//}
		

		//manager.panelModeloSeleccionado.SetActive(true);
			
		panelModeloSeleccionado.SetActive(true);
	}

	public void seleccionarModelo() {	
		//GameObject backButton = GameObject.Find("btn - Atras de panel principal");
		//GameObject i = GameObject.Find("Instanciador");
		//Instanciador instanciador = (Instanciador) i.GetComponent(typeof(Instanciador));
		//backButton.SetActive(false);
		GameObject canvas = GameObject.Find("Canvas");
		var child = canvas.transform.GetChild(4).gameObject;

		switch(modeloSeleccionado) {
			case "estadio_cibao":
				ValoresGlobales.modelo_seleccionado = Modelos.estadio_cibao;
				child.SetActive(true);
				Handheld.Vibrate();
				//instanciador.destroySantiago3D();
				break;
			case "centro_leon":
				ValoresGlobales.modelo_seleccionado = Modelos.centro_leon;
				child.SetActive(true);
				Handheld.Vibrate();
				//instanciador.destroySantiago3D();
				break;
			case "monumento":
				ValoresGlobales.modelo_seleccionado = Modelos.monumento;
				child.SetActive(true);
				Handheld.Vibrate();
				//instanciador.destroySantiago3D();
				break;
			case "aurora":
				ValoresGlobales.modelo_seleccionado = Modelos.aurora;
				child.SetActive(true);
				Handheld.Vibrate();
				//instanciador.destroySantiago3D();
				break;
			case "teatro":
				ValoresGlobales.modelo_seleccionado = Modelos.teatro;
				child.SetActive(true);
				Handheld.Vibrate();
				//instanciador.destroySantiago3D();
				break;
			case "catedral":
				ValoresGlobales.modelo_seleccionado = Modelos.catedral;
				child.SetActive(true);
				Handheld.Vibrate();
				//instanciador.destroySantiago3D();
				break;
			case "fortaleza":
				ValoresGlobales.modelo_seleccionado = Modelos.fortaleza;
				child.SetActive(true);
				Handheld.Vibrate();
				//instanciador.destroySantiago3D();
				break;
			case "matum":
				ValoresGlobales.modelo_seleccionado = Modelos.matum;
				child.SetActive(true);
				Handheld.Vibrate();
				//instanciador.destroySantiago3D();
				break;
			case "camp_david":
				ValoresGlobales.modelo_seleccionado = Modelos.camp_david;
				child.SetActive(true);
				Handheld.Vibrate();
				//instanciador.destroySantiago3D();
				break;
			case "parque_central":
				ValoresGlobales.modelo_seleccionado = Modelos.parque_central;
				child.SetActive(true);
				Handheld.Vibrate();
				//instanciador.destroySantiago3D();
				break;
		}
	}
}
