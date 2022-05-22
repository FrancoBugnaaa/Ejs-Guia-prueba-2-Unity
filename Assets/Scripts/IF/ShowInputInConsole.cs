using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowInputInConsole : MonoBehaviour
{

    public Text holas;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void mensaje()
    {
        Debug.Log(holas.text);
    }

}