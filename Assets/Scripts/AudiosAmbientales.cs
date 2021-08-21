using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudiosAmbientales : MonoBehaviour
{
	public AudioClip audio_clip = null;
	public AudioSource audio_source = null;
	private bool reproduciendo;
	//public GameObject PanelAurora;
	//Instancia manager
	public Manager manager;
	
    // Start is called before the first frame update
    void Start()
	{
		//manager = GameObject.FindObjectOfType<Manager>();
	    audio_source = GetComponent<AudioSource>();  
		ReproducirAudio();
    }

	public void ReproducirAudio(){
		if(!reproduciendo){
			if(audio_source.clip == null){
				Debug.Log("NULL");
			}else{
				reproduciendo = true;
				audio_source.Play();
			}
		} else {
			audio_source.Pause();
			reproduciendo = false;
		}
		
	}

}
