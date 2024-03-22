using UnityEngine;
using TMPro;

public class ScoreGame : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private PlayerController playerController;
    private bool foundPlayerController = false;

    void Update()
    {
        if (!foundPlayerController)
        {
            playerController = FindObjectOfType<PlayerController>();
            foundPlayerController = (playerController != null);

            if (!foundPlayerController)
            {
                Debug.LogWarning("Procurando PlayerController...");
                return; // Tenta novamente no próximo frame
            }
        }

        // Atualiza o texto de pontuação se o PlayerController foi encontrado
        scoreText.text = "SCORE: " + playerController.points.ToString("00");
    }
}
