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

	public void instancearModelo(string modeloSeleccionado, Vector3 position) {
		Destroy(modeloInstanceado, 0f);

		switch(modeloSeleccionado) {
		case "estadio_cibao":
			modeloInstanceado = Instantiate(ModeloEstadioCibao, position, ModeloEstadioCibao.transform.rotation);
			break;
		case "centro_leon":
			modeloInstanceado = Instantiate(ModeloCentroLeon, position, ModeloCentroLeon.transform.rotation);
			break;
		case "monumento":
			modeloInstanceado = Instantiate(ModeloMonumento, position, ModeloMonumento.transform.rotation);
			break;
		case "aurora":
			modeloInstanceado = Instantiate(ModeloAurora, position, ModeloAurora.transform.rotation);
			break;
		case "teatro":
			modeloInstanceado = Instantiate(ModeloTeatro, position, ModeloTeatro.transform.rotation);
			break;
		case "catedral":
			modeloInstanceado = Instantiate(ModeloCatedral, position, ModeloCatedral.transform.rotation);
			break;
		case "fortaleza":
			modeloInstanceado = Instantiate(ModeloFortaleza, position, ModeloFortaleza.transform.rotation);
			break;
		case "matum":
			modeloInstanceado = Instantiate(ModeloCampDavid, position, ModeloCampDavid.transform.rotation);
			break;
		case "camp_david":
			modeloInstanceado = Instantiate(ModeloCampDavid, position, ModeloCampDavid.transform.rotation);
			break;
		case "parque_central":
			modeloInstanceado = Instantiate(ModeloParqueCentral, position, ModeloParqueCentral.transform.rotation);
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
