using UnityEngine;

public class ThrowObject : MonoBehaviour
{
    private Rigidbody rb;
    public float fuerzaLanzamiento = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            rb.AddForce(Vector3.forward * fuerzaLanzamiento, ForceMode.Impulse);
        }
    }
}
