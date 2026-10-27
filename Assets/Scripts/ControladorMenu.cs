using UnityEngine;
using UnityEngine.SceneManagement; 

public class ControladorMenu : MonoBehaviour
{
    
    public void Jugar()
    {
        
        SceneManager.LoadScene(1); 
        
       
    }

    public void Salir()
    {
        Debug.Log("Saliendo del juego...");
        Application.Quit();
    }
}