using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciador : MonoBehaviour
{
    // Objecto a instanciar
    public GameObject elObjecto;

    // el indicador, donde lo instanciamos
    Indicador ElIndicador;
    GameObject obj;

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

            Destroy(obj, 0f);
            obj = Instantiate(elObjecto, ElIndicador.transform.position, ElIndicador.transform.rotation);


        }
    }
}
