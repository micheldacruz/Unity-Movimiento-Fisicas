using UnityEngine;

public class CatchCylinder : MonoBehaviour
{
    public Transform objetivoCilindro;
    public Transform obstaculoCubo;
    public float velocidad = 5f;
    public float distanciaImpacto = 1f; // Distancia a la que consideramos que "tocó" el cubo
    
    private bool yaChoco = false;

    void Update()
    {
        transform.LookAt(objetivoCilindro);
        transform.Translate(Vector3.forward * velocidad * Time.deltaTime);

        if (!yaChoco)
        {
            float distanciaAlCubo = Vector3.Distance(transform.position, obstaculoCubo.position);
            
            if (distanciaAlCubo <= distanciaImpacto)
            {
                obstaculoCubo.GetComponent<Renderer>().material.color = Color.red;
                yaChoco = true;
            }
        }
    }
}
