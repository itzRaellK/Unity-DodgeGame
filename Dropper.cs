using Unity.VisualScripting;
using UnityEngine;

public class DropObject : MonoBehaviour
{
    private float time = 0f;
    //public string timePassed = "";
    [SerializeField] float timeToWait = 3f;
    MeshRenderer dropperMeshRenderer; // Jeito correto de declarar variáveis do tipo MeshRenderer
    Rigidbody dropperRigidbody; // Jeito correto de declarar variáveis do tipo Rigidbody
    void Start()
    {
        dropperMeshRenderer = GetComponent<MeshRenderer>();
        dropperRigidbody = GetComponent<Rigidbody>();

        dropperMeshRenderer.enabled = false; // é o mesmo que GetComponent<MeshRenderer>().enabled = false;
        dropperRigidbody.useGravity = false; // é o mesmo que GetComponent<Rigidbody>().useGravity = false;
        
    } 
    void Update()
    {
        time = Time.time;
        //timePassed = time.ToString("F0");
        //Debug.Log("Tempo: " + time.ToString("F0") + " segundos!");

        if (time > timeToWait)
        {
            dropperRigidbody.useGravity = true; // Ativa a gravidade da variável dropperRigidbody
            dropperMeshRenderer.enabled = true; // Ativa o MeshRenderer da variável dropperMeshRenderer
            Debug.Log("Ativou a Mesh e Gravity do objeto!");
        }
    }
}
