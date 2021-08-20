using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosCuriososManager : MonoBehaviour
{
	//variables del panel de contenido de datos curiosos y panel de datos curiosos
	public GameObject content_panel, panel_datos_curiosos;
	
	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	//Nota: este método es sólo para fines de prueba en la versión final del proyecto no debe esta puesto que la lógica de datos curiosos debe arrancar al hacer clic en el botón de datos curiosos. 
	protected void Start()
	{
		ValoresGlobales.modelo_seleccionado = Modelos.monumento;
		//activar_datos_curiosos();
	}
	//función que activa el panel de datos curiosos mostrando un valor aleatorio
	public void activar_datos_curiosos()
	{
		//se crea un instancia de clase random para generar un número aleatorio
		var random = new System.Random();
		//se genera un número aleatorio entre 0 y 7
		var aleatorio = random.Next(0,7);
		//se toma uno de los datos curiosos del panel de contenido para datos curiosos
		var dato_curioso = content_panel.transform.GetChild(aleatorio);
		//se valida que el objeto no esté nulo
		if(dato_curioso != null)
		{
			/*se desactivan todos los mensajes de datos curiosos por si quedó uno activo en una ejecución anterior*/
			GlobalFunctions.desactivar_hijos(content_panel.transform);
			//se activa el dato curioso
			dato_curioso.gameObject.SetActive(true);
			//se activa el panel de datos curiosos para poder visualizar el mensaje
			panel_datos_curiosos.SetActive(true);
		}	
	}
	
	//función que desactiva el panel de datos curiosos
	public void cerrar_panel_datos_cuiosos()
	{
		panel_datos_curiosos.SetActive(false);
	}
	
}
