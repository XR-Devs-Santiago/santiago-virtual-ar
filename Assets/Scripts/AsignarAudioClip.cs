using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsignarAudioClip : MonoBehaviour
{
	
	public AudioClip audio_clip = null;
	public AudioSource _source = null;
	
    // Start is called before the first frame update
    void Start()
	{
		_source = GameObject.FindGameObjectWithTag("Play").GetComponent<AudioSource>();
		_source.clip = audio_clip;
		
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
