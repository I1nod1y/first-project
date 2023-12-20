using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 10f;
    public float lifetime = 2f;
    public int damage = 1;

    private float timer;

    private void Start()
    {
        timer = lifetime;
    }

    private void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Добавь код для нанесения урона игроку
            // Например: collision.GetComponent<PlayerController>().TakeDamage(damage);

            Destroy(gameObject);
        }
    }
}