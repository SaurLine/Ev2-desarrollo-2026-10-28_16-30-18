using UnityEngine;

public class Camara : MonoBehaviour
{
    public Transform jugador; 
    public Vector3 offset = new Vector3(0, 2, -10);

    void LateUpdate()
    {
        if (jugador != null)
        {
            transform.position = jugador.position + offset;
        }
    }
}
