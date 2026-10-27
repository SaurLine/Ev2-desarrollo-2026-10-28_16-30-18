using UnityEngine;

public class Coleccionables : MonoBehaviour
{
    public AudioClip sonidoRecoger;
    public float volumen = 1f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            if (AdministradorColeccionables.Instance != null)
            {
                AdministradorColeccionables.Instance.RecogerItem();
            }

            if (sonidoRecoger != null)
            {
                AudioSource.PlayClipAtPoint(sonidoRecoger, transform.position, volumen);
            }

            
            Destroy(gameObject);
        }
    }
}
