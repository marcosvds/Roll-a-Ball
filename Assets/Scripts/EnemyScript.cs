using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float speed = 5f; // Velocidade de movimento do inimigo
    public Vector3 startPoint = new Vector3(-9f, 0.5f, -9f); // Ponto de saída
    public Vector3 endPoint = new Vector3(9f, 0.5f, -9f); // Ponto de chegada

    private Vector3 targetPoint; // Ponto para onde o inimigo está se movendo
    private bool movingToEnd = true; // Indica se o inimigo está se movendo para o ponto de chegada

    void Start()
    {
        // Inicializa o movimento para o ponto de chegada
        targetPoint = endPoint;
    }

    void Update()
    {
        // Calcula a direção do movimento
        Vector3 direction = (targetPoint - transform.position).normalized;

        // Calcula a nova posição baseada na direção e na velocidade
        Vector3 newPosition = transform.position + direction * speed * Time.deltaTime;

        // Verifica se o inimigo alcançou o ponto de chegada ou saída
        if (movingToEnd && Vector3.Distance(newPosition, endPoint) < 0.1f)
        {
            targetPoint = startPoint; // Define o ponto de saída como próximo alvo
            movingToEnd = false; // Altera a direção do movimento
        }
        else if (!movingToEnd && Vector3.Distance(newPosition, startPoint) < 0.1f)
        {
            targetPoint = endPoint; // Define o ponto de chegada como próximo alvo
            movingToEnd = true; // Altera a direção do movimento
        }

        // Atualiza a posição do inimigo
        transform.position = newPosition;
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Inimigo"))
        {
            Debug.Log("Inimigo colidiu com outro inimigo!");
        }
    }

}
