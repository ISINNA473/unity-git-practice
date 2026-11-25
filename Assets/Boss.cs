
using UnityEngine;

public class Boss : Enemy
{
    public float minHorizontalSpeed = 0.5f;
    public float maxHorizontalSpeed = 3.0f;

    private float horizontalSpeed;
    private float direction;
    private float minX;
    private float maxX;
    private float minY;
    private float halfWidth;

    private Rigidbody2D rb;
    private SpriteRenderer sr;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();

        // 최초 이동 방향 및 속도 랜덤 설정
        direction = Random.Range(0, 2) == 0 ? -1 : 1;
        SetRandomSpeed();

        // 카메라 경계 계산
        Camera cam = Camera.main;

        minX = cam.transform.position.x
            - cam.orthographicSize * cam.aspect;

        maxX = cam.transform.position.x
            + cam.orthographicSize * cam.aspect;

        // 카메라 아래쪽 경계 계산
        minY = cam.transform.position.y
            - cam.orthographicSize;

        halfWidth = sr.bounds.extents.x;
    }

    public override void Move()
    {
        Vector2 nextPosition = rb.position;

        // 좌우 이동
        nextPosition.x += direction * horizontalSpeed
            * Time.fixedDeltaTime;

        // 일정한 속도로 하강
        nextPosition.y -= speed * Time.fixedDeltaTime;

        // 왼쪽 경계 충돌
        if (nextPosition.x <= minX + halfWidth && direction < 0)
        {
            nextPosition.x = minX + halfWidth;
            direction = 1;

            SetRandomSpeed();
        }
        // 오른쪽 경계 충돌
        else if (nextPosition.x >= maxX - halfWidth && direction > 0)
        {
            nextPosition.x = maxX - halfWidth;
            direction = -1;

            SetRandomSpeed();
        }

        // 카메라 아래쪽으로 완전히 벗어나면 제거
        if (sr.bounds.max.y < minY)
        {
            Destroy(gameObject);
            return;
        }

        rb.MovePosition(nextPosition);
    }

    void SetRandomSpeed()
    {
        horizontalSpeed = Random.Range(
            minHorizontalSpeed,
            maxHorizontalSpeed
        );
    }
}
