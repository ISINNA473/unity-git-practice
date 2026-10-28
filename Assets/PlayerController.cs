using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; //public 외부 공용, private 비공개
    public GameObject BulletPrefab;
    public float bulletSpeed = 100f;

    //int[] scores = new int[5];

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i = 1; i < 6; i++)
        {
            Debug.Log(i);
        }
        //int a = 1;
        //switch(a < 5)
        //{
        //    case true:
        //        Debug.Log(a);
        //        break;
        //    case false:
        //        Debug.Log("a가 5보다 큽니다");
        //        break;
        //    default:
        //        break;
        //}
        //int a = 8;
        //if (a <= 5)
        //{
        //    Debug.Log(a);
        //}
        //else if(a < 10)
        //{
        //    Debug.Log("a가 5보다 크고 10보다 작습니다.");
        //}
        //else
        //{
        //    Debug.Log("a가 10보다 크거나 같습니다.");
        //}
        //int a = 8;
        //if (a <= 5)
        //{
        //    Debug.Log(a);
        //}
        //else
        //{
        //    Debug.Log("a가 5보다 큽니다");
        //}
        //for (int i = 0; i <= scores.Length; i++)
        //    scores[i - 1] = (i + 1) * 10;
        //Debug.Log(scores[0]);
        //Debug.Log(scores[1]);
        //Debug.Log(scores[2]);
        //Debug.Log(scores[3]);
        //Debug.Log(scores[4]);
        //bool a = true;
        //bool b = false;
        //gameObject.SetActive(a || b);
        //Vector2 newPos = transform.position;
        //newPos.x = newPos.x + 5;
        //transform.position = newPos;
        //transform.position = Vector3.one;   //(1, 1, 1)
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    this.transform.Translate(0, speed, 0);
        //}
        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    this.transform.Translate(0, -speed, 0);
        //}
        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    this.transform.Translate(speed, 0, 0);
        //}
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    this.transform.Translate(-speed, 0, 0);
        //}
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(x, y, 0);
        transform.position += direction.normalized * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < 3; i++)
            {
                GameObject Bullet = Instantiate(BulletPrefab);
                Bullet.transform.position = transform.position;
                Bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bulletSpeed);
            }
        }
    }
}
