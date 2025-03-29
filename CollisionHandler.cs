using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private Renderer playerRenderer;

    void Start()
    {
        playerRenderer = GetComponent<Renderer>();

        if (playerRenderer == null)
        {
            Debug.LogError("Renderer component is missing on PlayerBall!");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ColorGate")) // Check if it collides with a color gate
        {
            Renderer gateRenderer = other.GetComponent<Renderer>();
            if (gateRenderer != null)
            {
                // Fix: Trim "(Instance)" from material names before comparing
                string playerColor = playerRenderer.material.name.Replace(" (Instance)", "");
                string gateColor = gateRenderer.material.name.Replace(" (Instance)", "");

                if (playerColor == gateColor)
                {
                    Debug.Log("Color Matched! Pass through.");
                }
                else
                {
                    Debug.Log("Game Over! Wrong Color.");
                    GameOver();
                }
            }
        }
    }

    void GameOver()
    {
        Debug.Log("Game Over Triggered!");
        // Alternative: Instead of freezing everything, call a Game Over UI
        // You can replace this with an actual game over screen
        Time.timeScale = 0; // Stops the game
    }
}
