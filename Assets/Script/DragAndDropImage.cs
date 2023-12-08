using System;
using UnityEngine;
using UnityEngine.UI;

public class DragAndDropImage : MonoBehaviour
{
    public GameObject objectToDrag;
    public GameObject objectDragToPos;
    public GameObject next;
    public GameObject actual;
    public GameObject n2;
    public AudioSource sonido;

    public float DropDistance;
    public bool islocked;

    Vector2 objectinitpos;

    public delegate void OnDropAction();
    public event OnDropAction OnDrop;

    private void Start()
    {
        objectinitpos = objectToDrag.transform.position;
    }

    public void DragObject()
    {
        if (!islocked)
        {
            if (!sonido.isPlaying)
            {
                sonido.Play();
            }
            objectToDrag.transform.position = Input.mousePosition;
        }
    }

    public void DropObject()
    {
        float Distance = Vector3.Distance(objectToDrag.transform.position, objectDragToPos.transform.position);

        if (Distance < DropDistance)
        {
            islocked = true;

            objectToDrag.transform.position = objectDragToPos.transform.position;

            // Emitir el evento de drop
            if (OnDrop != null)
            {
                OnDrop();
            }

            next.SetActive(true);
            actual.SetActive(false);
            if(n2 != null){
                n2.SetActive(false);
            }
        }
        else
        {
            objectToDrag.transform.position = objectinitpos;
        }
    }
}
