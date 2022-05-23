using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PreFabEj06 : MonoBehaviour
{
    public Text cloneAmoount;
    public GameObject Capsule;
    int amount;
    GameObject clon;

    float xOffset = 0;
    int counter = 0;

    public void LineGenerator()
    {
        if(cloneAmoount.text == "")
        {
            clon = Instantiate(Capsule);
            clon.transform.position += new Vector3(xOffset, 0, 0);
            xOffset += 1.1f;
            counter++;
        }
        else
        {
            amount = int.Parse(cloneAmoount.text);

            if(amount < 0)
            {
                Debug.Log("No se puede crear una linea negativa");
                return;
            }
            if(counter < amount)
            {
                clon = Instantiate(Capsule);
                clon.transform.position += new Vector3(xOffset, 0, 0);
                xOffset += 1.1f;
                counter++;
            }

        }
        
    }
}
