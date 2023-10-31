using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController1 : MonoBehaviour
{
public int maxLives = 3; // Максимальное количество жизней
private int currentLives; // Текущее количество жизней


private void Start()
{
    currentLives = maxLives;
}

private void OnCollisionEnter2D(Collision2D collision)
{
    if (collision.gameObject.CompareTag("Obstacle"))
    {
        LoseLife();
    }
}

private void LoseLife()
{
    currentLives--;

    if (currentLives <= 0)
    {
        Die();
    }
}

private void Die()
{
    // Код для смерти персонажа
    // Например, можно отключить управление и воспроизвести анимацию смерти
    // Затем перезагрузить текущую сцену
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}

// Добавьте этот метод, чтобы восстановить жизни персонажа
public void RestoreLives()
{
    currentLives = maxLives;
}

// Добавьте этот метод, чтобы добавить жизнь персонажу
public void AddLife()
{
    currentLives++;
}

// Добавьте этот метод, чтобы получить текущее количество жизней
public int GetCurrentLives()
{
    return currentLives;
}
}