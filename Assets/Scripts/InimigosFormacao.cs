using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private Vector3 startPosition2 = new Vector3(9f, 0.5f, 9f); // Posição inicial da esfera

    void Start()
    {
        transform.position = this.startPosition2; // Configura a posição inicial da esfera using the fully qualified name
    }
}