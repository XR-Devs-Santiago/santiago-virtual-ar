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
	
	// OnMouseDown es llamado cuando el usuario preciona el boton del mouse o al toque de un objecto que tenga el component collider. El GameObject debe tener algun tipo de collider para que esta funcion funcione.
	void OnMouseDown() {
		seleccionarModelo();
	}

	public void buscarActivarPanelModeloSelecionado() {
		GameObject canvas = GameObject.Find("Canvas");

		if (canvas == null) {
			Debug.LogError("No se encontro un GameObject con el nombre 'Canvas'");
		}

		for (int i = 0; i < canvas.transform.childCount; i++) 
		{
			var child = canvas.transform.GetChild(i);

			if (child != null && child.name == "05- Modelo Seleccionado")
			{
				panelModeloSeleccionado = child.gameObject;
			}
		}

		panelModeloSeleccionado.SetActive(true);
	}

	public void seleccionarModelo() {	
		GameObject backButton = GameObject.Find("btn - Atras de panel principal");
		GameObject i = GameObject.Find("Instanciador");
		Instanciador instanciador = (Instanciador) i.GetComponent(typeof(Instanciador));
		backButton.SetActive(false);

		switch(modeloSeleccionado) {
			case "estadio_cibao":
				ValoresGlobales.modelo_seleccionado = Modelos.estadio_cibao;
				buscarActivarPanelModeloSelecionado();
				Handheld.Vibrate();
				instanciador.destroySantiago3D();
				break;
			case "centro_leon":
				ValoresGlobales.modelo_seleccionado = Modelos.centro_leon;
				buscarActivarPanelModeloSelecionado();
				Handheld.Vibrate();
				instanciador.destroySantiago3D();
				break;
			case "monumento":
				ValoresGlobales.modelo_seleccionado = Modelos.monumento;
				buscarActivarPanelModeloSelecionado();
				Handheld.Vibrate();
				instanciador.destroySantiago3D();
				break;
			case "aurora":
				ValoresGlobales.modelo_seleccionado = Modelos.aurora;
				buscarActivarPanelModeloSelecionado();
				Handheld.Vibrate();
				instanciador.destroySantiago3D();
				break;
			case "teatro":
				ValoresGlobales.modelo_seleccionado = Modelos.teatro;
				buscarActivarPanelModeloSelecionado();
				Handheld.Vibrate();
				instanciador.destroySantiago3D();
				break;
			case "catedral":
				ValoresGlobales.modelo_seleccionado = Modelos.catedral;
				buscarActivarPanelModeloSelecionado();
				Handheld.Vibrate();
				instanciador.destroySantiago3D();
				break;
			case "fortaleza":
				ValoresGlobales.modelo_seleccionado = Modelos.fortaleza;
				buscarActivarPanelModeloSelecionado();
				Handheld.Vibrate();
				instanciador.destroySantiago3D();
				break;
			case "matum":
				ValoresGlobales.modelo_seleccionado = Modelos.matum;
				buscarActivarPanelModeloSelecionado();
				Handheld.Vibrate();
				instanciador.destroySantiago3D();
				break;
			case "camp_david":
				ValoresGlobales.modelo_seleccionado = Modelos.camp_david;
				buscarActivarPanelModeloSelecionado();
				Handheld.Vibrate();
				instanciador.destroySantiago3D();
				break;
			case "parque_central":
				ValoresGlobales.modelo_seleccionado = Modelos.parque_central;
				buscarActivarPanelModeloSelecionado();
				Handheld.Vibrate();
				instanciador.destroySantiago3D();
				break;
		}
	}
}
