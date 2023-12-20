using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int health = 100;
    public float moveSpeed = 5f;
    public float leftPoint = -10f;
    public float rightPoint = 10f;
    private int direction = 1;
    public float shootDistance = 10f;
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    public float bulletSpeed = 10f;

     void Update()
    {
        transform.Translate(Vector2.right * moveSpeed * direction * Time.deltaTime);

        if (transform.position.x <= leftPoint)
        {
            direction = 1; // Изменяем направление движения на право
        }
        else if (transform.position.x >= rightPoint)
        {
            direction = -1; // Изменяем направление движения на лево
        }

        // Движение врага
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);

        // Стрельба
        if (Vector2.Distance(transform.position, bulletSpawnPoint.position) <= shootDistance)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * bulletSpeed;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // Код для смерти врага
        Destroy(gameObject);
    }
}