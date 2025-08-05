using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccionesLetrero : MonoBehaviour
{
    //variables
    private GameObject obj;

    //accion cerrar cuadro de informacion
    public void LCerrar()
    {
        obj = GameObject.Find("CanvasLetrero(Clone)");
        GameObject.Destroy(obj);
    }

}
