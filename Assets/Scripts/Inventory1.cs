using UnityEngine;

public class Inventory1 : MonoBehaviour
{
    private int coinCount;

    public void AddCoin()
    {
        coinCount++;
        Debug.Log("Монетка добавлена в инвентарь.");
    }
}