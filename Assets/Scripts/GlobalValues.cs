using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GlobalValues
{
	public static Modelos modelo_seleccionado;
	//función que desactiva todos los hijos de un padre dado
	public static void desactivar_hijos(Transform padre)
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
}
	

