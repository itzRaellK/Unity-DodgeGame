using System.IO.Compression;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float speed = 0.0f;
    [SerializeField] float maxSpeed = 7.0f;
    //[SerializeField] float minSpeed = 1.0f;
    [SerializeField] float acceleration = 0.05f;
    //[SerializeField] float decelaration = 20.0f;


    void Start()
    {
        // Executa ao iniciar o jogo
        //PrintInstructions();
    }

    void Update()
    {
        // Executa a cada frame do jogo
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Oi!");
        Debug.Log("Use os botões WASD para mover o player.");
        Debug.Log("Evite obstáculos. Sim, este é o objetivo principal do jogo.");
        Debug.Log("Boa sorte!");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal");
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(xValue, yValue, zValue) * speed * Time.deltaTime;

        if (xValue != 0 || zValue != 0)
        {
            speed += acceleration;
            if (speed > maxSpeed)
            {
                speed = maxSpeed;
            }
        }
        else
        {
            speed = 0;
            /*if (speed < minSpeed)
            {
                speed = minSpeed;
            }*/
        }

        transform.Translate(move, Space.World);

        // Faz a bola girar se estiver se movendo
        if (move != Vector3.zero)
        {
            // Velocidade angular proporcional à velocidade linear
            float rotationSpeed = speed * 50f; // ajuste conforme achar melhor

            // Eixo de rotação perpendicular ao movimento
            Vector3 rotationAxis = Vector3.Cross(Vector3.up, move.normalized);

            // Rotaciona no mundo para não alterar a lógica de direção
            transform.Rotate(rotationAxis, rotationSpeed * Time.deltaTime, Space.World);
        }
    }
}
