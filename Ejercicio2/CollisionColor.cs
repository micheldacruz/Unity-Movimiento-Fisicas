using UnityEngine;

public class CollisionColor : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Suelo"))
        {
            Debug.Log(gameObject.name + " chocó contra: " + collision.gameObject.name);
            GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}
