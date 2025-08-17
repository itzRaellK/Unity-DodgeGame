using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    // Quando o objeto colide com outro ele recebe a referência do objeto colidido
    private void OnCollisionEnter(Collision other)
    {
        // Essa referência é comparada com a tag do objeto colidido
        if (other.gameObject.tag == "Player")
        {
            // Se a tag for igual a "Player", o objeto colidido muda de cor
            GetComponent<MeshRenderer>().material.color = Color.grey;
            gameObject.tag = "Hit";
            //Debug.Log("Colidiu com: " + collision.gameObject.name);
        }
    }
}
