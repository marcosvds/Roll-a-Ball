using UnityEngine;

public class ButtonTutorial : MonoBehaviour
{
    public GameObject panelTutorial; // Referência ao painel que queremos mostrar/ocultar

    void Start()
    {
        // Garante que o painel comece desativado/invisível
        panelTutorial.SetActive(false);
    }

    // Método para ser chamado quando o botão for clicado
    public void ToggleTutorialPanel()
    {
        // Verifica se o painel está ativo e alterna seu estado
        panelTutorial.SetActive(!panelTutorial.activeSelf);
    }
}
