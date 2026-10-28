using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    
    public float velocidad = 5f;
    public Animator animator;

    public float fuerzaSalto = 10f;
    public float distanciaSuelo = 0.1f;

    public LayerMask Suelo;

    public bool tocandoSuelo = true;

    private Rigidbody2D rb;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float velocidadH = Input.GetAxis("Horizontal")* velocidad * Time.deltaTime;
        animator.SetFloat("velocidad",Mathf.Abs(velocidadH));
        Debug.Log(velocidadH);

        if (velocidadH > 0)
        {
            transform.localScale = new Vector3(4, 4, 4);
        }
        else if (velocidadH < 0)
        {
            transform.localScale = new Vector3(-4, 4, 4);
        }

        Vector3 movimiento = transform.position;
        transform.position = new Vector3(movimiento.x + velocidadH , movimiento.y, movimiento.z);
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, distanciaSuelo , 
        Suelo);
        tocandoSuelo = hit.collider != null;

        if (Input.GetKeyDown(KeyCode.Space) && tocandoSuelo)
        {
            rb.AddForce(new Vector2(0, fuerzaSalto), ForceMode2D.Impulse);

            animator.SetTrigger("Saltar");
        }
    }
}
