using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
	public GameObject content_panel, panel_datos_curiosos;
	// Start is called before the first frame update
    void Start()
	{
	    var random = new System.Random();
		var aleatorio = random.Next(0,7);
	    activar_dato_curioso(aleatorio);
    }
	void activar_dato_curioso(int aleatorio)
	{
		var dato_curioso = content_panel.transform.GetChild(aleatorio);
		if(dato_curioso != null)
		{
			desactivar_hijos(content_panel.transform);
			dato_curioso.gameObject.SetActive(true);
			panel_datos_curiosos.SetActive(true);
		}	
	}
	void desactivar_hijos(Transform padre)
	{
		for (int i = 0; i < padre.childCount; i++) 
		{
			var hijo = padre.GetChild(i);
			if (hijo != null)
			{
				hijo.gameObject.SetActive(false);
			}
		}
	}
	public void cerrar_panel_datos_cuiosos()
	{
		panel_datos_curiosos.SetActive(false);
	}
	
}
