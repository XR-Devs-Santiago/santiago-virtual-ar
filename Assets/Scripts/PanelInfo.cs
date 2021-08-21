using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelInfo : MonoBehaviour
{
	public Manager elmanager;
	
	public GameObject MonumentoInfo;
	public GameObject CatedralInfo;
	public GameObject EstadioInfo;
	public GameObject AuroraInfo;
	public GameObject TeatroInfo;
	public GameObject FortalezaInfo;
	public GameObject HotelMInfo;
	public GameObject CampDavidInfo;
	public GameObject ParqueCentralInfo;
	public GameObject CentroLeonInfo;

	
	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	protected void Start()
	{
	
		elmanager = FindObjectOfType<Manager>();
	}
	
	public void showPanel(GameObject panelToShow){
		
		MonumentoInfo.SetActive(false);
		CatedralInfo.SetActive(false);
		EstadioInfo.SetActive(false);
		AuroraInfo.SetActive(false);
		TeatroInfo.SetActive(false);
		FortalezaInfo.SetActive(false);
		HotelMInfo.SetActive(false);
		CampDavidInfo.SetActive(false);
		ParqueCentralInfo.SetActive(false);
		CentroLeonInfo.SetActive(false);
		panelToShow.SetActive(true);
	
	}
	
	public void modeloseleccionado()
	{
		//modeloseleccionadocodigo = seleccion;
		var lugar = ValoresGlobales.modelo_seleccionado;
		
		
		if (lugar == Modelos.monumento)
		{showPanel(MonumentoInfo);}
		
		if (lugar == Modelos.catedral)
		{showPanel(CatedralInfo);}
		
		if (lugar == Modelos.estadio_cibao)
		{showPanel(CatedralInfo);}
		
		if (lugar == Modelos.aurora)
		{showPanel(AuroraInfo);}
		
		if (lugar == Modelos.teatro)
		{showPanel(TeatroInfo);}
		
		if (lugar == Modelos.fortaleza)
		{showPanel(CatedralInfo);}
		
		if (lugar == Modelos.matum)
		{showPanel(CatedralInfo);}
		
		if (lugar == Modelos.camp_david)
		{showPanel(CatedralInfo);}
		
		if (lugar == Modelos.parque_central)
		{showPanel(ParqueCentralInfo);}
		
		if (lugar == Modelos.centro_leon)
		{showPanel(CentroLeonInfo);}
		
		
	}

}
