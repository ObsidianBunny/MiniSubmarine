using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniSubController : MonoBehaviour {

    [SerializeField] private GameObject cam;
    private Rigidbody r;
    [SerializeField] private float speed = 4f;
    [SerializeField] private float step = .1f;

    private float rtSpeed;
    Vector3 dirForward, dirStrafe;

    private void Start()
    {
        r = GetComponent<Rigidbody>();
        rtSpeed = speed;
    }

    // Update is called once per frame
    void Update () {
        if ((Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) & rtSpeed < 4*speed)
            rtSpeed *= 1.05f;
        if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.RightShift))
            rtSpeed = speed;


        dirForward = (transform.position - cam.transform.position).normalized;

        r.AddForce(50 * rtSpeed * dirForward * Input.GetAxis("Vertical"));
        r.AddForce(30 * rtSpeed * transform.right * Input.GetAxis("Horizontal"));
        r.AddForce(30 * rtSpeed * transform.up * Input.GetAxis("UpDown"));

        Vector3 dir = Vector3.RotateTowards(transform.forward, cam.transform.forward, step, 0.0F);

        transform.rotation = Quaternion.LookRotation(dir);
    }
}
