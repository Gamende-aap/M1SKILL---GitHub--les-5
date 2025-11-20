using UnityEngine;
using TMPro;

public class PlayerLife : MonoBehaviour
{
    public int lives = 3;
    public TMP_Text livesText;

    public float invincibilityTime = 3f;   // seconds of invincibility after hit
    private bool isInvincible = false;

    void Start()
    {
        UpdateLivesUI();
    }


    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.CompareTag("Enemy") && !isInvincible)
        {
            LoseLife(1);
        }
        //feedbackText.text = "Hey, ik bots tegen de " + collision.gameObject.name;
    }



    public void LoseLife(int amount)
    {
        lives -= amount;
        UpdateLivesUI();

        if (lives <= 0)
        {
            Die();
        }
        else
        {
            // Start invincibility period
            StartCoroutine(Invincibility());
        }
    }

    void UpdateLivesUI()
    {
        if (livesText != null)
        {
            livesText.text = "Lives: " + lives;
        }
    }

    void Die()
    {
        Debug.Log("Game Over!");
        // TODO: Respawn, reload scene, or show Game Over UI
    }

    System.Collections.IEnumerator Invincibility()
    {
        isInvincible = true;
        yield return new WaitForSeconds(invincibilityTime);
        isInvincible = false;
    }
}
