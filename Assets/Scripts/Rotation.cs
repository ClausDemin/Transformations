using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _angularSpeed;

    void Update()
    {
        Rotate();
    }

    public void Rotate() 
    {
        float angle = _angularSpeed * Time.deltaTime;

        transform.Rotate(Vector3.up, angle);
    }
}
