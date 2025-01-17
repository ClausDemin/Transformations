using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _angularSpeed;

    private void Update()
    {
        Rotate();
    }

    public void Rotate() 
    {
        float angle = _angularSpeed * Time.deltaTime;

        transform.Rotate(Vector3.up, angle);
    }
}
