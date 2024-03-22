using UnityEngine;
using UnityEngine.SceneManagement;

public class ColisaoInimigo : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Inimigo")) // Verifica se o objeto tem a tag "Inimigo"
        {
            Debug.Log("Houve uma colisão: " + other.name);
            SceneManager.LoadScene("GameOver"); // Carrega a cena de GameOver
        }
    }
}
