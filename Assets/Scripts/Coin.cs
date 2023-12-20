using UnityEngine;

public class Coin : MonoBehaviour
{
    private Inventory playerInventory; // Ссылка на скрипт инвентаря игрока

    private void Start()
    {
        // Получение ссылки на инвентарь игрока
        Inventory inventory = FindObjectOfType<Inventory>(); // Найти экземпляр класса Inventory

if (inventory != null)
{
    inventory.AddCoin(); // Добавить монету в инвентарь
}
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Проверка, что инвентарь доступен
            if (playerInventory != null)
            {
                // Добавление монетки в инвентарь
                playerInventory.AddCoin();

                // Уничтожение объекта монетки
                Destroy(gameObject);
            }
        }
    }
}