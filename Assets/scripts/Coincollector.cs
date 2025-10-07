using UnityEngine;
using TMPro; // Make sure this line is included for TMP_Text

public class CoinCollector : MonoBehaviour
{
    public int coinsCollected = 0;
    public TMP_Text scoreText; // Assign this in Inspector

    void Start()
    {
        UpdateScoreUI();
    }

  void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Coin"))
    {
        coinsCollected++;
        UpdateScoreUI();

        // Start respawn coroutine on the coin
        StartCoroutine(RespawnCoin(other.gameObject));
    }
}

System.Collections.IEnumerator RespawnCoin(GameObject coin)
{
    // Hide coin
    coin.SetActive(false);

    // Wait 3 seconds
    yield return new WaitForSeconds(3f);

    // Show coin again
    coin.SetActive(true);
}

    void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text =  "x "+ coinsCollected;
        }
    }
}
