using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] Transform target; //estas son las banderas
    [SerializeField] float speed;

    void Update()
    {
        Vector3 position = transform.position; //posicion actual
        position.x = MyMoveTowards(position.x, target.position.x, speed * Time.deltaTime); //se mueve
        transform.position = position; //actualiza
    }
    
    float MyMoveTowards(float current, float target, float maxDelta)
    {
        var move = (current - target);
        current = move * maxDelta;
        
        return current;
    }
}
