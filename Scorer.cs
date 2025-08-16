using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision other)
    {
        if (hits > 0)
        {
            Debug.Log("Você colidiu " + hits + " vezes!");
        }
        hits++;
    }
}
