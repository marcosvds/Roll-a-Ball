using UnityEngine;
using UnityEngine.UI; // Importante para trabalhar com a UI

public class ButtonImageToggle : MonoBehaviour
{
    public Button button; // Referência ao botão
    public Sprite imageNormal; // Imagem para o estado normal
    public Sprite imageClicked; // Imagem para o estado clicado
    private bool isClicked = false; // Estado do botão

    void Start()
    {
        button.onClick.AddListener(ToggleImage); // Adiciona um ouvinte ao clique do botão
    }

    void ToggleImage()
    {
        if (!isClicked)
        {
            button.GetComponent<Image>().sprite = imageClicked;
            isClicked = true;
        }
        else
        {
            button.GetComponent<Image>().sprite = imageNormal;
            isClicked = false;
        }
    }
}
