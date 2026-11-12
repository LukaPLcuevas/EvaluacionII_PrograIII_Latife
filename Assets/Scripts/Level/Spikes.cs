using UnityEngine;

public class Spikes : MonoBehaviour
{
    [SerializeField] float knockbackForce;

    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerPhysics player = other.GetComponent<PlayerPhysics>();
        if (player != null)
        {
            Vector2 direction = (transform.position - other.transform.position).normalized;
            player.Hurt(direction * knockbackForce * -1); 
        }
    }
}
//tiene 2 soluciones, o el numero que se pone en el inspector es negativo (-10)
//o multiplicamos el knockbackForce por -1, lo que hace que el numero puesto en el inspector (10) se convierta en (-10)
