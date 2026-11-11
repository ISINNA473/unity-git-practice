using UnityEngine;

public class Player : MonoBehaviour
{
    float health = 100.0f;

    private void TakeDamege(int value)
    {
        health -= value;
        if (health <= 0)
        {
            Die();
        }

        Debug.Log("Player Health : " + health);
    }

    void Die()
    {
        //EventManager.RunEnemydieEvent();
        Destroy(this.gameObject);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        TakeDamege(20);
        Destroy(collision.gameObject);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
