using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class Phrase : MonoBehaviour
{
    public Image sujeto;
    public Image verbo;
    public Image complemento;
    public Sprite[] palabras;
    public TextMeshProUGUI frase;
    void Start()
    {
        Cambiar();
    }

    void Cambiar(){
        if(GlobalVariables.verbo == "Camina"){
            frase.text = GlobalVariables.sujeto + " " + GlobalVariables.verbo + " a la " + GlobalVariables.complemento;
        }else{
            frase.text = GlobalVariables.sujeto + " " + GlobalVariables.verbo + " " + GlobalVariables.complemento;}
        
        foreach (Sprite sprite in palabras)
        {
            if (sprite.name == GlobalVariables.sujeto)
            {
                sujeto.sprite = sprite;
            }

            if (sprite.name == GlobalVariables.verbo)
            {
                verbo.sprite = sprite;
            }

            if (sprite.name == GlobalVariables.complemento)
            {
                complemento.sprite = sprite;
            }
        }
    }
}
