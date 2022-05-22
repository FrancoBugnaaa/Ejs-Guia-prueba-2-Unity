using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PreFabEj06 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject Capsule;
    public Text maxcant;

    public void InstantiateNext()
    {

        if (maxcant.text == "")
        {

        }

        else if (int.Parse(maxcant.text) > 0)
        {
            float distancia;
            distancia = 2;

            GameObject CapsuleClone;
            CapsuleClone = Instantiate(Capsule);

            CapsuleClone.transform.position = new Vector3(distancia, 0, 0);
            Destroy(CapsuleClone, 2);

            distancia += 1.1f;
        }



    }
}
