using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GoogleMaps : MonoBehaviour
{	
	// Variable que almacena las ubicaciones para abrir en maps
	String Location;
	

	public void google(){
		var lugar = ValoresGlobales.modelo_seleccionado;
		Debug.Log("Modelo seleccionado: "+ValoresGlobales.modelo_seleccionado);
		
		switch(lugar){
			
		case Modelos.monumento:
			Location = "https://goo.gl/maps/NtLaq1eFM6RxSPvK9";
			break;

		case Modelos.centro_leon:
			Location = "https://goo.gl/maps/8gZvLs9ZVVHewz7H7";		
			break;
		case Modelos.aurora:
			Location = "https://goo.gl/maps/x2wiPUAVDxKvtnbE8";
			break;
		case Modelos.teatro:
			Location = "https://goo.gl/maps/P8yBCkkaBWedqoZY7";
			break;
		case Modelos.catedral:
			Location = "https://goo.gl/maps/dsDkET4yAkA8nV3U9";
			break;
		case Modelos.fortaleza:
			Location = "https://goo.gl/maps/tiKbmcoH46hXAGyZ9";
			break;
		case Modelos.matum:
			Location = "https://goo.gl/maps/dbckAUFMVABncU1NA";
			break;
		case Modelos.camp_david:
			Location = "https://g.page/camp-david-ranch?share";
			break;
		case Modelos.parque_central:
			Location = "https://goo.gl/maps/JntPJNoisBmxTHxt8";
			break;
		case Modelos.estadio_cibao:
			Location = "https://goo.gl/maps/MzLJoDspdJC9xp7s5";
			break;
		default:
			Debug.Log("Ubicacion sin pantalla");
			break;
		}

		Application.OpenURL(Location);
	}	
}
