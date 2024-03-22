using UnityEngine;
using UnityEngine.SceneManagement; // Necessário para carregar cenas

public class PanelPauseController : MonoBehaviour
{
    public GameObject panelPause; // Referência ao PanelPause

    void Start()
    {
        // Garante que o PanelPause comece não aparecendo
        panelPause.SetActive(false);
    }

    // Método para alternar a visibilidade do painel de pausa e pausar/retomar o jogo
    public void TogglePause()
    {
        panelPause.SetActive(!panelPause.activeSelf);

        // Pausa ou retoma o tempo do jogo baseado na visibilidade do painel
        if (panelPause.activeSelf)
        {
            Time.timeScale = 0; // Pausa o jogo
        }
        else
        {
            Time.timeScale = 1; // Retoma o jogo
        }
    }

    // Método para retomar o jogo chamado pelo botão de retomar no painel de pausa
    public void RetomarJogo()
    {
        panelPause.SetActive(false);
        Time.timeScale = 1; // Retoma o jogo
    }

    // Método para reiniciar o jogo chamado pelo botão de reiniciar no painel de pausa
    public void ReiniciarJogo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1; // Certifica-se de que o tempo do jogo está retomado
    }
}
