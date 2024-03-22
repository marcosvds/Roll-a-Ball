using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement; // Importante para trabalhar com mudança de cenas

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody rb;
    private float movementX;
    private float movementY;

    public int points;

    public TextMeshProUGUI pointsText;
    public GameObject winText;
    public int totalPoints = 20; // Ajuste para o total de pontos desejado para a vitória

    public AudioClip sfxPedgouCoin;
    public AudioController2 audioController2;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        points = 0;
        SetPointsText();
        winText.SetActive(false); // Garante que o texto de vitória não é mostrado no início
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    private void Update() 
    {
        // Verifica se o jogador caiu do tabuleiro
        if (transform.position.y < 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickup"))
        {
            audioController2.ToqueSoundCoin(sfxPedgouCoin);
            points += 1;
            SetPointsText();
            other.gameObject.SetActive(false);
        }
    }

    void SetPointsText()
    {
        pointsText.text = "cubes: " + points;
        // Mudança para a cena de GameWinner se atingir o total de pontos
        if (points >= totalPoints)
        {
            SceneManager.LoadScene("GameWinner");
        }
    }
}
