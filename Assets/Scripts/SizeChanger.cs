using UnityEngine;

public class SizeChanger : MonoBehaviour
{
    [SerializeField] private float _scaleGrowthSpeed;

    private void Update()
    {
        IncreaseScale();
    }

    public void IncreaseScale() 
    {
        transform.localScale += Vector3.one * _scaleGrowthSpeed * Time.deltaTime;
    }
}
