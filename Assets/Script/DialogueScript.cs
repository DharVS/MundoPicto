using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogueScript : MonoBehaviour
{
    public TextMeshProUGUI dialogueText; // referencia del texto desde unity
    public string[] lines; //lineas de texto
    public GameObject[] elementos;
    public float textSpeed = 0.1f; // velocidad del texto
    int index; //en que linea estamos
    public string next;
    void Start()
    {
        dialogueText.text = string.Empty;
        StartDialogue();
    }

    
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            if(true){
                if(dialogueText.text==lines[index]){
                    NextLine();
                }
                else{
                    StopAllCoroutines();
                    dialogueText.text = lines[index];
                }
            }
        }
    }

    public void StartDialogue(){
        index = 0;

        StartCoroutine(WriteLine());


    }

    //Corrutina o metodo a la que llamamos cada cierto tiempo
    IEnumerator WriteLine(){
        foreach (char letter in lines[index].ToCharArray()){ //caracter letra en lineas
            dialogueText.text += letter;

            yield return new WaitForSeconds(textSpeed);
        }
    }

    public void NextLine(){
        if(index < lines.Length-1){
            index++;
            elementos[index-1].SetActive(false);
            elementos[index].SetActive(true);
            dialogueText.text = string.Empty;
            StartCoroutine(WriteLine());
        }
        else {
            LoadNextScene();
        }
    }

    private void LoadNextScene()
    {
        if(GlobalVariables.origen == "Start"){
            SceneManager.LoadScene("Start");
        }else{
        SceneManager.LoadScene(next);}
    }

}
