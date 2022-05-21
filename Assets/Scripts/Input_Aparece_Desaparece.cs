using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Input_Aparece_Desaparece : MonoBehaviour
{
    public GameObject escribi;
    bool Activo = true;

  public void Inputaa()
    {
        if (Activo)
        {
           escribi.SetActive(false);
            Activo = false;
        }
        else
        {
            escribi.SetActive(true);
            Activo = true;
        }
    }
}
