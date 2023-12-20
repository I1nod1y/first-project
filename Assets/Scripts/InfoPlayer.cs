using UnityEngine;
using UnityEngine.UI;

public class InfoPlayer: MonoBehaviour
{
    public float HP = 74f;
    public float maxHP = 100f;
    public int damage = 50;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            EnemyController enemy = collision.gameObject.GetComponent<EnemyController>();
            enemy.TakeDamage(damage);
        }
        void Start()
        {
        gameObject.tag = "Player";
        }
    } 
}