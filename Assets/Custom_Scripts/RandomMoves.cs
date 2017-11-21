using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMoves : MonoBehaviour
{
    public float vitesse_translation = 1.2f;
    public float vitesse_rotation = 10.0f;
    float angle;
    Collider collider;
    // Use this for initialization
    void Start()
    {
        collider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (collider.Raycast(ray, out hit, 100.00f))
        {
            Vector3 newPosition = Random.insideUnitCircle * 5;
            angle = Mathf.Lerp(angle, Random.Range(-20.0f, 20.0f), Time.deltaTime);
            transform.position.Set(newPosition.x, newPosition.y, newPosition.z);
            transform.Rotate(0, vitesse_rotation * angle * Time.deltaTime, 0);
        }

        transform.Translate(Vector3.forward * vitesse_translation * Time.deltaTime);

    }
}

