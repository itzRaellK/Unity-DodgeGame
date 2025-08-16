using Unity.VisualScripting;
using UnityEngine;

public class DropObject : MonoBehaviour
{
    public float time = 0f;
    public string timePassed = "";
    void Start()
    {
        GetComponent<Rigidbody>().useGravity = false;
    } 
    void Update()
    {
        time = Time.time;
        timePassed = time.ToString("F0");
        Debug.Log("Tempo: " + timePassed + " segundos!");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().useGravity = true;
            Debug.Log("Ativou gravidade!");
        }
    }
}
