using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorGameOver : MonoBehaviour
{
    public GameObject panelGameOver;
    public AudioSource musicaFondo;
    public AudioSource reproductorEfectos; 
    public AudioClip sonidoGameOver;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ActivarGameOver();
        }
    }

    public void ActivarGameOver()
    {
        if (panelGameOver != null)
        {
            panelGameOver.SetActive(true);
        }

        if (musicaFondo != null)
        {
            musicaFondo.Stop();
        }

        if (reproductorEfectos != null && sonidoGameOver != null)
        {
            reproductorEfectos.PlayOneShot(sonidoGameOver);
        }

        Time.timeScale = 0f;
    }

    public void ReiniciarNivel()
    {
        Time.timeScale = 1f; 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void IrAlMenu()
    {
        Time.timeScale = 1f; 
        SceneManager.LoadScene(0);
    }
}
