using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccionesCupon : MonoBehaviour
{
    //variables
    private GameObject obj;

    //accion cerrar cuadro de informacion
    public void CCerrar()
    {
        obj = GameObject.Find("CanvasCupon(Clone)");
        GameObject.Destroy(obj);
    }

}
