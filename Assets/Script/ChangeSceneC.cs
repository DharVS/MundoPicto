using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneC : MonoBehaviour
{
    public void LoadScene(string next)
    {
        if(GlobalVariables.origen == "Levels"){
            SceneManager.LoadScene("Level"+GlobalVariables.nivel);
        }else{
        SceneManager.LoadScene(next);}
    }
}
