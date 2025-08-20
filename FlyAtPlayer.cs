using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    // Referência ao jogador e velocidade de movimento
    [SerializeField] Transform player;
    [SerializeField] float speed = 1.0f;
    Vector3 playerPosition;
    void Start()
    {
        // Pega a posição inicial do jogador
        playerPosition = player.transform.position;
    }

    void Update()
    {
        // Move o objeto em direção ao jogador e destrói quando alcança
        MoveToPlayer();
        DestroyWhenReached();
    }

    // Método que move o objeto em direção ao jogador
    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
    }

    // Método que destroi o objeto quando alcança a posição do jogador
    void DestroyWhenReached()
    {
        // Verifica se o objeto alcançou a posição do jogador
        if (transform.position == playerPosition)
        {
            // Destrói o objeto
            Destroy(gameObject);
        }
    }
}