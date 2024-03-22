using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleFormation : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private int itensAmount;
    [SerializeField] private float distance;

    private static float pi = 3.14159f;

    // Start is called before the first frame update
    void Start()
    {
        PrefabCircleFormation();
    }

    private void PrefabCircleFormation()
    {
        for (int i =0; i < itensAmount; i++)
        {
            GameObject tempoObj = Instantiate(prefab, this.transform.position, Quaternion.identity);
            float angle = i * (2f * pi / itensAmount);
            float x = Mathf.Cos(angle) * distance;
            float z = Mathf.Sin(angle) * distance;
            Vector3 targetPosition = new Vector3(this.transform.position.x + x, 1f, this.transform.position.z + z);
            tempoObj.transform.position = targetPosition;
            tempoObj.transform.parent = this.transform;
        }
    }
}
