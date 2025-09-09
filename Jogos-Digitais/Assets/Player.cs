using UnityEngine;

public class Player : MonoBehaviour
{
    // Public = aparece no inspector, private = não aparece.

    // Variáveis Animação
    public Animator anim;
    public float a = 10;

    // Variáveis Movimentação
    private Rigidbody2D rigid;
    public float speed;

    // Variáveis Pulo
    public float jumpforce = 5f;
    public bool isground;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        float teclas = Input.GetAxis("Horizontal");
        rigid.linearVelocity = new Vector2(teclas * speed, rigid.linearVelocity.y);

        if (teclas > 0 && isground == true)
        {
            transform.eulerAngles = new Vector2(0, 0);
            anim.SetInteger("transition", 1);
        }
        if (teclas < 0 && isground == true)
        {
            transform.eulerAngles = new Vector2(0, 180);
            anim.SetInteger("transition", 1);
        }
        if (teclas == 0 && isground == true)
        {
            transform.eulerAngles = new Vector2(0, 0);
            anim.SetInteger("transition", 0);
        }
    }

        void Jump()
        {
            if (Input.GetKeyDown(KeyCode.Space) && isground == true)
        {
            rigid.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
            anim.SetInteger("transition", 2);
            isground = false;
        }

        }

        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "ground")
        {
            isground = true;
            Debug.Log("está no chao");
        }

        }
}
