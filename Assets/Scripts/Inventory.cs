using UnityEngine;

public class Inventory : MonoBehaviour
{
    private int coinCount;
    private GameObject currentItem;

    public void AddCoin()
    {
        coinCount++;
        Debug.Log("Монетка добавлена в инвентарь.");
    }

    public void AddItem(GameObject item)
    {
        if (currentItem == null)
        {
            currentItem = item;
            currentItem.SetActive(false);
        }
    }

    public void UseCurrentItem()
    {
        if (currentItem != null)
        {
            currentItem.SetActive(true);
            currentItem = null;
        }
    }
}