using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        GetComponent<MeshRenderer>().material.color = Color.grey;
        //Debug.Log("Colidiu com: " + collision.gameObject.name);
    }
}
