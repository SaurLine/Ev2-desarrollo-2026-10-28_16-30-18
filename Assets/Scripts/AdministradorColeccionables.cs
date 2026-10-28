using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class AdministradorColeccionables : MonoBehaviour
{
    public static AdministradorColeccionables Instance;

    public int totalColeccionablesEnNivel = 5; 
    private int coleccionablesRecogidos = 0;

    public TMP_Text textoContador; 
    public GameObject panelGanaste;

    public AudioSource musicaFondo; 
    public AudioSource reproductorEfectos; 
    public AudioClip sonidoVictoria; 

    void Awake()
    {
        
        if (Instance == null) Instance = this;
    }

    void Start()
    {
        ActualizarTexto();
    }

    public void RecogerItem()
    {
        coleccionablesRecogidos++;
        ActualizarTexto();

        if (coleccionablesRecogidos >= totalColeccionablesEnNivel)
        {
            GanarJuego();
        }
    }

    void ActualizarTexto()
    {
        if (textoContador != null)
        {
            textoContador.text = "Monedas: " + coleccionablesRecogidos + " / " + totalColeccionablesEnNivel;
        }
    }

    void GanarJuego()
    {
        if (panelGanaste != null)
        {
            panelGanaste.SetActive(true);
        }

        if (musicaFondo != null)
        {
            musicaFondo.Stop();
        }

        if (reproductorEfectos != null && sonidoVictoria != null)
        {
            reproductorEfectos.PlayOneShot(sonidoVictoria);
        }
        
        Time.timeScale = 0f;
    }

    public void IrAlMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}