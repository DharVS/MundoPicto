using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Check2 : MonoBehaviour
{
    public GameObject sujeto;
    public GameObject verbo;
    public GameObject complemento;
    public void Checar(string next)
    {
        if ((EstaActivo("Bebe") && EstaActivo("Agua")) || (EstaActivo("Camina") && EstaActivo("Casa")) || (EstaActivo("Camina") && EstaActivo("Escuela")))
        {
            foreach (Transform s in sujeto.transform)
            {
            if (s.gameObject.activeSelf)
            {
                GlobalVariables.sujeto = s.gameObject.name;
            }
            }

            foreach (Transform v in verbo.transform)
            {
            if (v.gameObject.activeSelf)
            {
                GlobalVariables.verbo = v.gameObject.name;
            }
            }

            foreach (Transform c in complemento.transform)
            {
            if (c.gameObject.activeSelf)
            {
                GlobalVariables.complemento = c.gameObject.name;
            }
            }

            SceneManager.LoadScene(next);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    bool EstaActivo(string nombre)
    {
        GameObject objeto = GameObject.Find(nombre);

        return objeto != null && objeto.activeSelf;
    }
}
