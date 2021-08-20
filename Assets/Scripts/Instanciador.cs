using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciador : MonoBehaviour
{
    // Objecto a instanciar
	public GameObject centroLeon;
	//public GameObject monumento;
	//public GameObject catedral;
	//public GameObject hotelMatum;
	//public GameObject auroraCigar;
	//public GameObject estadioCibao;
	//public GameObject centroDeLaCultura;
	//public GameObject fortalezaSanLuis;
	//public GameObject campDavid;
	//public GameObject parqueCentral;

	// El indicador, donde lo instanciamos
    Indicador ElIndicador;
	GameObject obj1;
	// GameObject obj2;

    int spawned = 0;

    // Start is called before the first frame update
    void Start()
    {
        ElIndicador = FindObjectOfType<Indicador>();
    }

    // Update is called once per frame
    void Update()
    {
        // toco la pantalla para instanciar un objecto
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
        	// Solo instanceamos una vez
        	if (obj1 == null) {
	        	Destroy(obj1, 0f);
	        	// Instancear al modelo del centro leon
	        	obj1 = Instantiate(centroLeon, ElIndicador.transform.position, ElIndicador.transform.rotation);
        	}
	       
        }
    }
}
