using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorDeModelo : MonoBehaviour
{
	// Objectos a instanciar
	public GameObject ModeloEstadioCibao;
	public GameObject ModeloCentroLeon;
	public GameObject ModeloMonumento;
	public GameObject ModeloAurora;
	public GameObject ModeloTeatro;
	public GameObject ModeloCatedral;
	public GameObject ModeloCampDavid;
	public GameObject ModeloParqueCentral;
	public GameObject ModeloFortaleza;
	// Modelo instanceado
	GameObject modeloInstanceado;
	public GameObject cube;
	
    // Update is called once per frame
  void Update()
	{
		//if (modeloInstanceado != null) {
			// TODO: PROBAR CON UN CUBE EN LUAGR DE LOS MODELOS
			//Vector3 position = new Vector3(0.0f, -0.5f, 1.0f);
			//Quaternion rotation = new Quaternion(0.0f, 0.0f, 0.0f, 0.0f);
			//modeloInstanceado = Instantiate(cube, position, rotation);
			//Handheld.Vibrate();
		//}
	}

	public void instancearModelo(string modeloSeleccionado, Vector3 position, Quaternion rotation) {
		//Vector3 position = new Vector3(0.0f, -0.5f, 1.0f);
		//Quaternion rotation = new Quaternion(0.0f, 0.0f, 0.0f, 0.0f);

		switch(modeloSeleccionado) {
		case "estadio_cibao":
			modeloInstanceado = Instantiate(cube, position, rotation);
			break;
		case "centro_leon":
			modeloInstanceado = Instantiate(cube, position, rotation);
			break;
		case "monumento":
			modeloInstanceado = Instantiate(cube, position, rotation);
			break;
		case "aurora":
			modeloInstanceado = Instantiate(cube, position, rotation);
			break;
		case "teatro":
			modeloInstanceado = Instantiate(cube, position, rotation);
			break;
		case "catedral":
			modeloInstanceado = Instantiate(cube, position, rotation);
			break;
		case "fortaleza":
			modeloInstanceado = Instantiate(cube, position, rotation);
			break;
		case "matum":
			modeloInstanceado = Instantiate(cube, position, rotation);
			break;
		case "camp_david":
			modeloInstanceado = Instantiate(cube, position, rotation);
			break;
		case "parque_central":
			modeloInstanceado = Instantiate(cube, position, rotation);
			break;
		default:
			Debug.Log("Modelo Seleccionado no encontrado");
			break;

		}
	}
    
	public void destroyModeloInstanceado () {
		Destroy(modeloInstanceado, 0f);
	}
}
