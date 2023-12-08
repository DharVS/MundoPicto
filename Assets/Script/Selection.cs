using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selection : MonoBehaviour
{
    public void SelectCharacter(string characterName)
    {
        GlobalVariables.personaje = characterName;
    }
}
