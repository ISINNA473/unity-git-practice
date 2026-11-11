using JetBrains.Annotations;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float health = 50.0f;

    public float speed;

    private void TakeDamege(int value)
    {
        health -= value;
        if (health <= 0)
        {
            Die();
        }

        Debug.Log("Enemy Health : " + health);
    }

    //public void TakeDamege(float ratio)
    //{
    //    health -= (int)(health * ratio);
    //    if (health <= 0)
    //    {
    //        Die();
    //    }
    //}

    public float GetHealth()
    {
        return health;
    }

    void Die()
    {
        //EventManager.RunEnemydieEvent();
        Destroy(this.gameObject);
    }

    public void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Bullet"))
        {
            TakeDamege(10);
            coll.gameObject.SetActive(false);
        }
    }

    public virtual void Move()
    {

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
