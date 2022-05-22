using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstanciarMax_Text : MonoBehaviour
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
    public Text maxCant;

    public void InstantiatorOfClon()
    {

        GameObject clon;

        for (int i = 0; i < int.Parse(maxCant.text); i++)
        {
            clon = Instantiate(cubePrefab);
        }
    }
}
