using UnityEngine;
using UnityEngine.SceneManagement; // Importante para trabalhar com a mudança de cenas

public class ButtonAgainWinner : MonoBehaviour
{
    // Método para carregar a cena do minigame
    public void LoadMinigameScene()
    {
        SceneManager.LoadScene("Minigame");
    }
}
