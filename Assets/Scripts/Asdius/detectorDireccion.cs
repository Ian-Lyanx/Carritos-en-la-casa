using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectorDireccion : MonoBehaviour
{
    [SerializeField] GameObject zPositive, zNegative, xPositive, xNegative;

    private void Start()
    {
        zPositive.SetActive(true);  //por defecto el vehiculo debe empezar mirando hacia el Z positivo del mundo.
        zNegative.SetActive(false);
        xPositive.SetActive(false);
        xNegative.SetActive(false);
    }
    public void ChangeDirection(float direction)   //Habra una forma mas eficiente de lograr el cambio de direccion?
    {
        if (zPositive.activeSelf == true)   //Si el vehiculo va en direccion Z+
        {
            if (direction > 0)  //si gira a la derecha
            {
                xPositive.SetActive(true);
                zPositive.SetActive(false);
            }
            else if (direction < 0)  //si gira a la izquierda
            {
                xNegative.SetActive(true);
                zPositive.SetActive(false);
            }
        }
        else if (zNegative.activeSelf == true) //si el vehiculo va en direccion Z-
        {
            if (direction > 0)//si gira a la derecha
            {
                xNegative.SetActive(true);
                zNegative.SetActive(false);
            }
            else if (direction < 0) //si gira a la izquierda
            {
                xPositive.SetActive(true);
                zNegative.SetActive(false);
            }// --------- direccion X
        }
        else if (xPositive.activeSelf == true)   //Si el vehiculo va en direccion X+
        {
            if (direction > 0)  //si gira a la derecha
            {
                xPositive.SetActive(false);
                zNegative.SetActive(true);
            }
            else if (direction < 0)  //si gira a la izquierda
            {
                xPositive.SetActive(false);
                zPositive.SetActive(true);
            }
        }
        else if (xNegative.activeSelf == true) //si el vehiculo va en direccion X-
        {
            if (direction > 0)//si gira a la derecha
            {
                xNegative.SetActive(false);
                zPositive.SetActive(true);
            }
            else if (direction < 0) //si gira a la izquierda
            {
                xNegative.SetActive(false);
                zNegative.SetActive(true);
            }
        }
    }
}
