using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioPlayManager : MonoBehaviour
{
	
	GameObject PanelInformacion;
	GameObject BtnPlayStop;
	
	
	public Button boton;
	public AudioClip audio_clip = null;
	public AudioSource _source = null;
	bool reproduciendo;
	public Sprite pausa;
	public Sprite play;
	
	
    // Start is called before the first frame update
    void Start()
	{
		_source = GetComponent<AudioSource>();
		boton = GetComponent<Button>();
		boton.onClick.AddListener(ReproducirAudio);
		
	}
    
	public void ReproducirAudio()
	{
		if(!reproduciendo){
			if(_source.clip == null)
			{
			Debug.Log("Audio Source is NULL");
			}else
			{
				//_source.clip = audio_clip;
				Debug.Log("Funciona");
				reproduciendo = true;
				_source.Play();
				boton.gameObject.GetComponent<Image>().sprite = pausa;
				
			}
		}else{
			_source.Pause();
			reproduciendo = false;
			boton.gameObject.GetComponent<Image>().sprite = play;
		}
	}

    // Update is called once per frame
    void Update()
    {
        
    }
    
	public void DesactivarAudio()
	{
		_source.clip = null;
		reproduciendo = false;
		boton.gameObject.GetComponent<Image>().sprite = play;
	}
}
