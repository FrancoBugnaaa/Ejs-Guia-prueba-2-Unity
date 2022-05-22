using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PreFabEj05 : MonoBehaviour
{
    public GameObject Cube;
    public GameObject Sphere;
    public GameObject Cylinder;
    public Text txtPreFab;
    int PreFab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    //Se usa una doble funcion dentro del boton
    public void InstantiateCube()
    {
        txtPreFab.text = "Prefab Cube Activado";
        PreFab = 1;
    }

    public void InstantiateSphere()
    {
        txtPreFab.text = "Prefab Sphere Activado";
        PreFab = 2;
    }

    public void InstantiateCylinder()
    {
        txtPreFab.text = "Prefab Cylinder Activado";
        PreFab = 3;
    }

    public void InstantiatePreFab()
    {
        if (PreFab == 1)
        {
            GameObject CubeClone;
            CubeClone = Instantiate(Cube);
            Destroy(CubeClone, 2);
        }

        if (PreFab == 2)
        {
            GameObject SphereClone;
            SphereClone = Instantiate(Sphere);
            Destroy(SphereClone, 2);
        }

        if (PreFab == 3)
        {
            GameObject CylinderClone;
            CylinderClone = Instantiate(Cylinder);
            Destroy(CylinderClone, 2);
        }
    }
}
