using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonTutorial2 : MonoBehaviour
{
    public GameObject panelPause; // Referência ao PanelPause
    public GameObject panelTutorial2; // Referência ao PanelTutorial2

    void Start()
    {
        // Garante que o PanelTutorial2 comece não aparecendo
        panelTutorial2.SetActive(false);
    }

    // Método chamado pelo botão Tutorial para mostrar o PanelTutorial2
    public void AbrirTutorial()
    {
        panelPause.SetActive(false); // Esconde o painel de pausa
        panelTutorial2.SetActive(true); // Mostra o painel do tutorial
        // O jogo deve continuar pausado, então não altere Time.timeScale aqui
    }

    // Método para fechar o painel do tutorial e voltar ao painel de pausa
    public void FecharTutorial()
    {
        panelTutorial2.SetActive(false); // Esconde o painel do tutorial
        panelPause.SetActive(true); // Mostra o painel de pausa novamente
    }

    // Método para retomar o jogo
    public void RetomarJogo()
    {
        panelTutorial2.SetActive(false); // Garante que o painel do tutorial está fechado
        panelPause.SetActive(false); // Garante que o painel de pausa está fechado
        Time.timeScale = 1; // Retoma o jogo
    }

    // Método para reiniciar o jogo
    public void ReiniciarJogo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1; // Certifica-se de que o tempo do jogo está retomado
    }
}
