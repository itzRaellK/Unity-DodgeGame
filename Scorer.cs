using UnityEngine;

public class Scorer : MonoBehaviour
{
    // Conta quantas vezes o jogador colidiu com objetos que não sejam o chão ou objetos já atingidos
    int hits = 0;
    
    // Quando o objeto colide com outro ele recebe a referência do objeto colidido
    private void OnCollisionEnter(Collision other)
    {
        // Essa referência é comparada com a tag do objeto colidido
        if (other.gameObject.tag != "Ground" && other.gameObject.tag != "Hit")
        {
            // Se a tag for diferente de "Ground" e "Hit", o contador de colisões aumenta
            hits++;
            Debug.Log("Você colidiu " + hits + " vezes!");
        }
    }
}
