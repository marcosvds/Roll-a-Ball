using UnityEngine;
using UnityEngine.SceneManagement; // Importante para trabalhar com mudanças de cena

public class ButtonStart : MonoBehaviour
{
    public void LoadGame()
    {
        // Altere "GameScene" para o nome da cena que você quer carregar
        SceneManager.LoadScene("Minigame");
    }
}
