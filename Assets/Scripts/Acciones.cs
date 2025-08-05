using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Acciones : MonoBehaviour
{
    //variables iniciar pausar
    public Button btn_no;
    public bool estado = true;
    public Sprite si, no;

    //variables prefabs
    public GameObject letreroSi;
    public GameObject cupon;

    private GameObject objetoSi;
    private GameObject objetoIncognita;

    public void AbrirSi()
    {
        objetoSi = Instantiate(letreroSi);
    }

    public void EveSiNo()
    {
        if (estado.Equals(true))
        {
            //cambiar a estado si
            btn_no.GetComponent<Image>().sprite = si;      

            estado = !estado;
        }
        else
        {
            //cargar letrero si una vez presionado el boton no
            AbrirSi();
        }
        /*else
        {
            //cambiar  a estado si
            btn_no.GetComponent<Image>().sprite = no;
            
            estado = !estado;
        }*/
    }
    public void AbrirIncognita()
    {
        objetoIncognita = Instantiate(cupon);
    }


}
