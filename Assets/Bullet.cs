using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("DestroySelf", 2.0f);
    }

    // Update is called once per frame
    void DestroySelf()
    {
        Destroy(gameObject);
    }
}
