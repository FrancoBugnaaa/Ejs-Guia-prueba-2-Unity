using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowInputText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public Text InputField;
    public Text Texto;

    public void Mensaje()
    {
        if(InputField.text != "")
        {
            Texto.text = InputField.text;
        }
        else
        {
            Debug.Log("No puede estar vacio el InputField");
        }
    }
}
