using UnityEngine;

public class Teleport : MonoBehaviour
{
    public float новаяXПозиция; // Новая позиция X для телепорта второго
    public float новаяYПозиция; // Новая позиция Y для телепорта второго

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Transform playerTransform = other.GetComponent<Transform>();
            playerTransform.position = new Vector2(новаяXПозиция, новаяYПозиция); // Телепортируем игрока в новую позицию второго телепорта
        }
    }
}
