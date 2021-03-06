using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class Indicador : MonoBehaviour
{
    // Emisor de rayos
    ARRaycastManager losRayos;
    // punto
	GameObject elMapa;
	// Panel de mensaje AR
	public GameObject panelMensajeAR;
	public GameObject instanciador;


    private void Start()
    {
        // Encuentro el objeto con el componente ArRaycastManager
        losRayos = FindObjectOfType<ARRaycastManager>();
        // Busco al punto como mi primer hijo
        elMapa = transform.GetChild(0).gameObject;

        elMapa.SetActive(false);
    }

    private void Update()
    {
        // creo una lista de Hits de radio
        List<ARRaycastHit> hit = new List<ARRaycastHit>();

        // Emito rayos desde el centro de la pantalla
        losRayos.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hit, TrackableType.Planes);

        // si el rayo choca con un plano rntonces
        if (hit.Count > 0)
        {
            transform.position = hit[0].pose.position;
            transform.rotation = hit[0].pose.rotation;
	        elMapa.SetActive(true);
	        //  Activamos el instanciador ahora ya que ahora si se necesita que active los modelos 3d al tocar la pantalla y no antes.
	        instanciador.SetActive(true);
	        // Si el mapa esta activo entonces desactivo pantalla de buscando suelo.
	        panelMensajeAR.SetActive(false);
        }
    }
}
