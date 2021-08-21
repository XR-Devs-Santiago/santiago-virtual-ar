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
	GameObject obj1;

    // Start is called before the first frame update
    void Start()
    {
        ElIndicador = FindObjectOfType<Indicador>();
    }

    // Update is called once per frame
    void Update()
	{
		
		// Toco la pantalla para instanciar un objecto, ATENCION si panelModeloSeleccionado esta activo no permitir instanciar el modelo santiago3D
		if (obj1 == null && Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began && (!panelModeloSeleccionado.gameObject.active || panelModeloSeleccionado == null))
        {
        	// Instancear al modelo del centro leon
		    obj1 = Instantiate(santiago3D, ElIndicador.transform.position, ElIndicador.transform.rotation);
		    ElIndicador.gameObject.SetActive(false);
		    panelPrincipal.gameObject.SetActive(true);
        }
    }
    
	public void destroySantiago3D () {
		obj1.SetActive(false);
		//Destroy(obj1, 0f);
	}
	
	public void activarSantiago3D () {
		obj1.SetActive(true);
		//Destroy(obj1, 0f);
	}
}

