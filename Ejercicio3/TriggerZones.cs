using UnityEngine;

public class TriggerZones : MonoBehaviour
{
private Renderer renderer;
    private Color OriginalColor;
    public int TotalDamage = 0; 

    void Start()
    {
        renderer = GetComponent<Renderer>();
        OriginalColor = renderer.material.color;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("LightZone"))
        {
            renderer.material.color = Color.yellow;
        }

        if (other.CompareTag("DamageZone"))
        {
            TotalDamage += 10;
            Debug.Log("¡Entraste en la zona de peligro! Daño total: " + TotalDamage);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("LightZone"))
        {
            renderer.material.color = OriginalColor;
        }
    }
}
