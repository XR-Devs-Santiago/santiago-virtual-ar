using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GoogleMaps : MonoBehaviour
{	
	//Variable que almacena las ubicaciones para abrir en maps
	public String Location;
	
	//funcion que detecta en que pantalla se preciono el boton de maps
	public void openUrl(int UbicacionBtn)
	{
		
		//Abrir ubicacion Monumento
		if (UbicacionBtn == 1){
			Location = "https://goo.gl/maps/NtLaq1eFM6RxSPvK9";
		}
		// Abrir hotel Matum
		else if (UbicacionBtn == 2){
			Location = "https://goo.gl/maps/dbckAUFMVABncU1NA";
		}
		
		//Abrir estadio cibao
		else if(UbicacionBtn == 3){
			Location = "https://goo.gl/maps/MzLJoDspdJC9xp7s5";		
		}
		
		//Abrir estadio Cigar World Aurora
		else if(UbicacionBtn == 4){
			Location = "https://goo.gl/maps/x2wiPUAVDxKvtnbE8";			
		}
		
		//Abrir estadio gran teatro del cibao
		else if(UbicacionBtn == 5){
			Location = "https://goo.gl/maps/P8yBCkkaBWedqoZY7";			
		}
		
		//Abrir Camp david
		else if(UbicacionBtn == 6){
			Location = "https://g.page/camp-david-ranch?share";
		}
		
		//Abrir Centro Leon
		else if(UbicacionBtn == 7){
			Location = "https://goo.gl/maps/8gZvLs9ZVVHewz7H7";
		}
		
		//abrir parque central
		else if(UbicacionBtn == 8){
			Location = "https://goo.gl/maps/JntPJNoisBmxTHxt8";
		}
		
		//abrir Catedral Santiago Apostol
		else if(UbicacionBtn == 9){
			Location = "https://goo.gl/maps/dsDkET4yAkA8nV3U9";
		}
		
		//abrir fortaleza San Luis
		else if(UbicacionBtn == 10){
			Location = "https://goo.gl/maps/tiKbmcoH46hXAGyZ9";
		}
		Application.OpenURL(Location);
	
	}
}
