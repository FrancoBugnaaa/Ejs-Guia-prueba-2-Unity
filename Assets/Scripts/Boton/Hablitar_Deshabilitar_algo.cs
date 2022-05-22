using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hablitar_Deshabilitar_algo : MonoBehaviour
{
    public InputField escribi;
    bool Activo = true;

    public void Inputaa()
    {
        if (Activo)
        {
            escribi.enabled = false;
            Activo = false;
        }
        else
        {
            escribi.enabled =true;
            Activo = true;
        }
    }
}
