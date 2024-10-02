    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.Rendering.Universal.Internal;

    public class PLayer : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public Transform camara;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 forward = camara.forward;
        Vector3 right = camara.right;

        forward.y = 0;
        right.y = 0;

        forward.Normalize();
        right.Normalize();

        Vector3 moveDirection = (forward * moveZ + right * moveX);

        rb.AddForce(moveDirection * moveSpeed, ForceMode.Acceleration);
    }
}
