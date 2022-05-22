using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instanciar_Hasta_0 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject cubePrefab;
    int counter=0;

    public void Instantiator()
    {
       if(counter < 1)
        {
            Instantiate(cubePrefab);
            counter++;
        }
        else
        {
            Debug.Log("Instancia ya Creada");
        }

    }
}
