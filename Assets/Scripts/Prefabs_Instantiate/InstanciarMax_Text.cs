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
    //intanciar copias prefab hasta que no se pueda mas
    public GameObject cubePrefab;
    public Text maxCant;
    int cantidad = 0;
    GameObject clone;
    public Text lbl;
    int clonea;

    public void Clonar()
    {
        if (maxCant.text != "")
        {

            clonea = (int.Parse(maxCant.text));

            if (cantidad < clonea)
            {

                clone = Instantiate(cubePrefab);
                cantidad++;
                lbl.text = (clonea - cantidad).ToString();

            }
            else
            {
                lbl.text = ("Ya ingreso la cantidad maxima");
            }
        }
        else
        {
            lbl.text = ("Ingrese una cantidad valida");
        }
    }
}
