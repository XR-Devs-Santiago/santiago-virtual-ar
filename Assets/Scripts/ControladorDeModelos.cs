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
	GameObject ModeloSeleccionadoManager;
	
	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	protected void Start()
	{
		ModeloSeleccionadoManager = GameObject.Find("ModeloSeleccionadoManager");
	}

	// OnMouseDown es llamado cuando el usuario preciona el boton del mouse o al toque de un objecto que tenga el component collider. El GameObject debe tener algun tipo de collider para que esta funcion funcione.
	void OnMouseDown() {
		seleccionarModelo();
	}

	public void seleccionarModelo() {
		GameObject backButton = GameObject.Find("btn - Atras de panel principal");
		GameObject i = GameObject.Find("Instanciador");
		Instanciador instanciador = (Instanciador) i.GetComponent(typeof(Instanciador));
		if (backButton != null) {
			backButton.SetActive(false);
		}
		GameObject canvas = GameObject.Find("Canvas");
		var panelModeloSeleccionado = canvas.transform.GetChild(4).gameObject;

		switch(modeloSeleccionado) {
			case "estadio_cibao":
				ValoresGlobales.modelo_seleccionado = Modelos.estadio_cibao;
				panelModeloSeleccionado.SetActive(true);
				ModeloSeleccionadoManager.GetComponent<ModeloSeleccionado>().modeloSelecionado();
				Handheld.Vibrate();
				break;
			case "centro_leon":
				Debug.Log("centro_leon case");
				ValoresGlobales.modelo_seleccionado = Modelos.centro_leon;
				panelModeloSeleccionado.SetActive(true);
				ModeloSeleccionadoManager.GetComponent<ModeloSeleccionado>().modeloSelecionado();
				Handheld.Vibrate();
				break;
			case "monumento":
				ValoresGlobales.modelo_seleccionado = Modelos.monumento;
				panelModeloSeleccionado.SetActive(true);
				ModeloSeleccionadoManager.GetComponent<ModeloSeleccionado>().modeloSelecionado();
				Handheld.Vibrate();
				break;
			case "aurora":
				ValoresGlobales.modelo_seleccionado = Modelos.aurora;
				panelModeloSeleccionado.SetActive(true);
				ModeloSeleccionadoManager.GetComponent<ModeloSeleccionado>().modeloSelecionado();
				Handheld.Vibrate();
				break;
			case "teatro":
				ValoresGlobales.modelo_seleccionado = Modelos.teatro;
				panelModeloSeleccionado.SetActive(true);
				ModeloSeleccionadoManager.GetComponent<ModeloSeleccionado>().modeloSelecionado();
				Handheld.Vibrate();
				break;
			case "catedral":
				ValoresGlobales.modelo_seleccionado = Modelos.catedral;
				panelModeloSeleccionado.SetActive(true);
				ModeloSeleccionadoManager.GetComponent<ModeloSeleccionado>().modeloSelecionado();
				Handheld.Vibrate();
				break;
			case "fortaleza":
				ValoresGlobales.modelo_seleccionado = Modelos.fortaleza;
				panelModeloSeleccionado.SetActive(true);
				ModeloSeleccionadoManager.GetComponent<ModeloSeleccionado>().modeloSelecionado();
				//Handheld.Vibrate();
				break;
			case "matum":
				ValoresGlobales.modelo_seleccionado = Modelos.matum;
				panelModeloSeleccionado.SetActive(true);
				ModeloSeleccionadoManager.GetComponent<ModeloSeleccionado>().modeloSelecionado();
				Handheld.Vibrate();
				break;
			case "camp_david":
				ValoresGlobales.modelo_seleccionado = Modelos.camp_david;
				panelModeloSeleccionado.SetActive(true);
				ModeloSeleccionadoManager.GetComponent<ModeloSeleccionado>().modeloSelecionado();
				Handheld.Vibrate();
				break;
			case "parque_central":
				ValoresGlobales.modelo_seleccionado = Modelos.parque_central;
				panelModeloSeleccionado.SetActive(true);
				ModeloSeleccionadoManager.GetComponent<ModeloSeleccionado>().modeloSelecionado();
				Handheld.Vibrate();
				break;
			default:
				Debug.Log("Modelo Seleccionado no encontrado");
				break;

		}

		if (instanciador) {
			instanciador.destroySantiago3D();
		}
	}
}
