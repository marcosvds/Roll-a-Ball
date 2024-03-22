using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private TMP_Text txtTime;
    [SerializeField] private float timeValue;
    private PlayerController playerController;

    void Start()
    {
        playerController = FindObjectOfType<PlayerController>(); // Encontra a instância do PlayerController na cena
        DisplayTime(timeValue); // Exibe o tempo inicialmente
    }

    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime; // Decrementa o tempo
            DisplayTime(timeValue);
        }
        else
        {
            // Chama FinishGame quando o tempo acabar
            FinishGame();
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0) timeToDisplay = 0; // Garante que o tempo não vá para negativo

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        txtTime.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void FinishGame()
    {
        if (playerController.points >= playerController.totalPoints)
        {
            SceneManager.LoadScene("GameWinner"); // Carrega a cena de vitória
        }
        else
        {
            SceneManager.LoadScene("GameOver"); // Carrega a cena de derrota
        }
    }
}
