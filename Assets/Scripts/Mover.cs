using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;

    private void Update()
    {
        Move();
    }

    public void Move() 
    {
        transform.position += transform.forward * _movementSpeed * Time.deltaTime;
    }
}
