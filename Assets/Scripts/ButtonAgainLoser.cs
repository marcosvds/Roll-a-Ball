using UnityEngine;
using UnityEngine.SceneManagement; // Importante para trabalhar com a mudança de cenas

public class ButtonAgainLoser : MonoBehaviour
{
    // Método para carregar a cena do minigame
    public void LoadMinigameScene()
    {
        SceneManager.LoadScene("Minigame");
    }
}
