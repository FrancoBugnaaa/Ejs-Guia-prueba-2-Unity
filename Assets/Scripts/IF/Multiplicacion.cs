using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Multiplicacion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Text Texto;
    public Text InputField;
    int multiplicacion;

    public void multiplica()
    {
        if(InputField.text != "")
        {
            multiplicacion = int.Parse(InputField.text) * int.Parse(InputField.text);
            Texto.text = multiplicacion.ToString();
        }
        else
        {
            Debug.Log("No Puede estar vacio el InputField");
        }
    }
}
