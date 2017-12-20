using UnityEngine;

public class WaterFlow : MonoBehaviour
{

    [SerializeField] private Transform fan;
    private Rigidbody r;
    private float distance;

    public void Start()
    {
        r = GetComponent<Rigidbody>();
    }

    public void Update()
    {
        distance = Vector3.Distance(fan.position, transform.position);
        if (distance < 50.0f)
        {

            r.AddForce(Vector3.down*10000.0f / distance);
        }
    }
}
