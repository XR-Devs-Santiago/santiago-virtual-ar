using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorLeonJimenez : MonoBehaviour
{
	public GameObject panelModeloSeleccionado;
	public GameObject panelModeloCentroLeon;
	
	public GameObject fondoTitulo;
	public GameObject botonesPredeterminado;

	
    // Start is called before the first frame update
    void Start()
	{
		Handheld.Vibrate();
	    panelModeloSeleccionado = GameObject.Find("05- Modelo Seleccionado");
	    panelModeloCentroLeon = GameObject.Find("modeloCentroCulturalLeonJimenes");
	    fondoTitulo = GameObject.Find("fondoTitulo");
	    panelModeloSeleccionado = GameObject.Find("Botones predeterminado");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
	public void mostrarCentroLeon() {
		Handheld.Vibrate();
		panelModeloSeleccionado.SetActive(true);
		panelModeloCentroLeon.SetActive(true);
		fondoTitulo.SetActive(true);
		botonesPredeterminado.SetActive(true);
	}
}
