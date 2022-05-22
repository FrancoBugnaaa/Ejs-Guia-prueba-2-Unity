using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Division : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public Text dividendo;
    public Text textholder;//divisor
    public Text textlbl;//resultado
    int divi;

    public void division()
    {
        if (textholder.text != "" && (int.Parse(textholder.text)) != 0)
        {
            divi = (int.Parse(dividendo.text)) / (int.Parse(textholder.text));

            textlbl.text = (divi.ToString());

        }
        else if (textholder.text == "")
        {
            textlbl.text = ("Error, ingrese algun valor");
        }

        else if ((int.Parse(textholder.text)) == 0)
        {
            textlbl.text = ("Error, no se puede divir entre 0");
        }
    }
}
