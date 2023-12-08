using System.Collections;
using System.Collections.Generic;
using Mono.CompilerServices.SymbolWriter;
using UnityEngine;
using UnityEngine.UI;

public class ImageCharacter : MonoBehaviour
{
    public Image characterImage;
    public Sprite Sofia;
    public Sprite Matteo;

    void Start()
    {
        string seleccionado = GlobalVariables.personaje;
        if(seleccionado == "Sofia"){
            characterImage.sprite = Sofia;
        }
        if(seleccionado == "Matteo"){
            characterImage.sprite = Matteo;
        }
    }
}
