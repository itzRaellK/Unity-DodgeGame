using UnityEngine;

public class Spinner : MonoBehaviour
{
    // Velocidade de rotação em cada eixo
    [SerializeField] float xRotation = 0f;
    [SerializeField] float yRotation = 0f;
    [SerializeField] float zRotation = 0f;
    void Start()
    {
        
    }

    void Update()
    {
        // Gira o objeto em torno dos eixos X, Y e Z
        transform.Rotate(xRotation, yRotation, zRotation);
    }
}
