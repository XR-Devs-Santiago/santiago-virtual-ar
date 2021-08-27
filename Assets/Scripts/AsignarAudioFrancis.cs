using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsignarAudioFrancis : MonoBehaviour
{
	public AudioClip audio_clip = null;
	public AudioSource audio_source;
	
    // Start is called before the first frame update
    void Start()
    {
		    
	    audio_source.clip = audio_clip;
	    audio_source.Play();
    }

   
}
