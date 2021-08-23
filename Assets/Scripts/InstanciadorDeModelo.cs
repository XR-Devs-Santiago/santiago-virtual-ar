using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class InstanciadorDeModelo : MonoBehaviour
{
	// Emisor de rayos
	ARRaycastManager losRayos;
	// Objecto a instanciar
	public GameObject modelo;
	// Modelo instanceado
	GameObject modeloInstanceado;
	
    // Start is called before the first frame update
	private void Start()
	{
		// Encuentro el objeto con el componente ArRaycastManager
		losRayos = FindObjectOfType<ARRaycastManager>();
	}

    // Update is called once per frame
    void Update()
	{
		// creo una lista de Hits de radio
		List<ARRaycastHit> hit = new List<ARRaycastHit>();

		// Emito rayos desde el centro de la pantalla
		losRayos.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hit, TrackableType.Planes);
		// si el rayo choca con un plano rntonces
		if (hit.Count > 0 && modeloInstanceado != null)
		{
			var position = hit[0].pose.position;
			var rotation = hit[0].pose.rotation;
			modeloInstanceado = Instantiate(modelo, position, rotation);
			Handheld.Vibrate();
		}
    }
}
