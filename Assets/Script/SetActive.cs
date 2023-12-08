using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive : MonoBehaviour
{
    public GameObject hide;
    public GameObject show;
    public GameObject actual;

    public void Mostrar(){
        hide.SetActive(false);
        show.SetActive(true);
        
        if(actual != null){
            actual.SetActive(false);
        }
    }
}
