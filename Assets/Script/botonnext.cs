using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class MostrarBoton : MonoBehaviour
{
    public Button botonNext;
    public List<DragAndDropImage> dragObjects = new List<DragAndDropImage>();
    public int cantidadObjetosRequeridos = 3;


    private void Start()
    {
        // Desactivar el botón al inicio
        botonNext.gameObject.SetActive(false);

        // Suscribirse a los eventos de drop para cada objeto en la lista
        foreach (var dragObject in dragObjects)
        {
            dragObject.OnDrop += VerificarMostrarBoton;
        }

        // Configurar el evento de clic en el botón
        botonNext.onClick.AddListener(OnBotonClick);
    }

    private void VerificarMostrarBoton()
    {
        // Contar cuántos objetos tienen islocked en true
        int objetosDropeados = 0;

        foreach (var dragObject in dragObjects)
        {
            if (dragObject.islocked)
            {
                objetosDropeados++;
            }
        }

        // Activar o desactivar el botón según la cantidad de objetos dropeados
        botonNext.gameObject.SetActive(objetosDropeados >= cantidadObjetosRequeridos);
    }

    private void OnBotonClick()
    {
        int objetosConEtiquetaCorrecta = 0;

        foreach (var dragObject in dragObjects)
        {
            if (dragObject.islocked)
            {
                if (dragObject.gameObject.tag == "El" || dragObject.gameObject.tag == "Come" || dragObject.gameObject.tag == "Manzana")
                {
                    objetosConEtiquetaCorrecta++;
                }
            }
        }

        // Redirigir o reiniciar la escena según la cantidad de objetos con etiquetas correctas
        if (objetosConEtiquetaCorrecta == cantidadObjetosRequeridos)
        {
            SceneManager.LoadScene("Inicio");
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}

