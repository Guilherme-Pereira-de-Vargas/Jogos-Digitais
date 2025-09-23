using UnityEngine;

public class Coin : MonoBehaviour
{
    private int coin = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            coin++;
            Debug.Log(coin);
        }
    }
}
