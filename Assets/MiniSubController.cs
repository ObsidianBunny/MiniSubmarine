using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniSubController : MonoBehaviour {

    [SerializeField] private GameObject cam;
    private Rigidbody r;
    [SerializeField] private float speed = 4f;
    private float rtSpeed;
    Vector3 dirForward, dirStrafe;

    private void Start()
    {
        r = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update () {
        //float step = Time.deltaTime * speed;

        rtSpeed = speed;

        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
            rtSpeed *= 2;

        dirForward = (transform.position - cam.transform.position).normalized;

        r.AddForce(50 * rtSpeed * dirForward * Input.GetAxis("Vertical"));

        //Vector3.RotateTowards(submarine.transform.rotation, dirForward, step, 0.0F);

        //r.AddForce(100 * Vector3.right * Input.GetAxis("Horizontal"));
    }
}
