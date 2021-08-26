using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciador : MonoBehaviour
{
    // Objecto a instanciar
	public GameObject santiago3D;
	// Panel principal
	public GameObject panelPrincipal;
	// 05- Modelo Seleccionado
	public GameObject panelModeloSeleccionado;
	// El indicador, donde lo instanciamos
	Indicador ElIndicador;
	// Objecto instanceado
	public GameObject obj1;

    // Start is called before the first frame update
    void Start()
    {
        ElIndicador = FindObjectOfType<Indicador>();
    }

    // Update is called once per frame
    void Update()
	{
		
		
		// Toco la pantalla para instanciar un objecto, ATENCION si panelModeloSeleccionado esta activo no permitir instanciar el modelo santiago3D
		if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began && (!panelModeloSeleccionado.gameObject.active || panelModeloSeleccionado == null))
		{
			Destroy(obj1, 0f);
        	// Instancear al modelo del centro leon
		    obj1 = Instantiate(santiago3D, ElIndicador.transform.position, ElIndicador.transform.rotation);
		    ElIndicador.gameObject.SetActive(false);
		    panelPrincipal.gameObject.SetActive(true);
        }
    }
    
	public void destroySantiago3D () {
		obj1.SetActive(false);
		//var position = new Vector2(Screen.width / 2, Screen.height / 2);
		//Destroy(obj1, 0f);
		//Vector3 position = new Vector3(0, 0, 0);
		//Quaternion rotation = new Quaternion(0.0f, 0.0f, 0.0f, 0.0f);

		//switch(ValoresGlobales.modelo_seleccionado) {
		//	case Modelos.monumento:
		//		obj1 = Instantiate(monumento, position, rotation);
		//		break;
		//	case Modelos.centro_leon:
		//		obj1 = Instantiate(centro_leon, position, rotation);
		//		break;
		//	case Modelos.aurora:
		//		obj1 = Instantiate(aurora, position, rotation);
		//		break;
		//	case Modelos.teatro:
		//		obj1 = Instantiate(teatro, position, rotation);
		//		break;
		//	case Modelos.catedral:
		//		obj1 = Instantiate(catedral, position, rotation);
		//		break;
		//	case Modelos.fortaleza:
		//		obj1 = Instantiate(fortaleza, position, rotation);
		//		break;
		//	case Modelos.camp_david:
		//		obj1 = Instantiate(camp_david, position, rotation);
		//		break;
		//	case Modelos.parque_central:
		//		obj1 = Instantiate(parque_central, position, rotation);
		//		break;
		//	case Modelos.estadio_cibao:
		//		obj1 = Instantiate(estadio_cibao, position, rotation);
		//		break;
		//}
	}

	public void activarSantiago3D () {
		obj1.SetActive(true);
	}
}

