using UnityEngine;

public class RandomItem : MonoBehaviour
{
    // Maak de array zichtbaar in de Inspector en geef standaardwaarden.
    [SerializeField] private string[] items = new string[10];

    void Update()
    {
        // Enter en Space drukken printen een willekeurig item
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Space)) PrintRandomItem();

        // Escape print alle items
        if (Input.GetKeyDown(KeyCode.Escape)) PrintAllItems();
    }

    private void PrintRandomItem()
    {
        if (items == null || items.Length == 0)
        {
            Debug.LogWarning("Items array is leeg. Vul items in via de Inspector of in de code.");
            return;
        }

        int i = Random.Range(0, items.Length); // 0 t/m items.Length-1
        Debug.Log("Random item: " + items[i]);
    }

    private void PrintAllItems()
    {
        if (items == null || items.Length == 0)
        {
            Debug.LogWarning("Items array is leeg. Vul items in via de Inspector of in de code.");
            return;
        }

        for (int i = 0; i < items.Length; i++)
        {
            Debug.Log("Item " + i + ": " + items[i]);
        }
    }

}