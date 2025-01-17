using UnityEngine;

public class ScaleModifier : MonoBehaviour
{
    [SerializeField] private float _scaleGrowthSpeed;

    void Update()
    {
        IncreaseScale();
    }

    public void IncreaseScale() 
    {
        transform.localScale += Vector3.one * _scaleGrowthSpeed * Time.deltaTime;
    }
}
