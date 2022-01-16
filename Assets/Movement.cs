using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public CharacterController cc;
    public float speed = 3f;
    public float gravedad = -9.81f;
    public Vector3 velocity;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask floorMask;
    bool isGrounded;
    public int height = 10;

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();


    }

    // Update is called once per frame
    void Update()
    {
      isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, floorMask);

        if (isGrounded && velocity.y <0)
        {
            velocity.y = -2f;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            print("Clicked");
            velocity.y = Mathf.Sqrt(height * -2 * gravedad);
        }


        float mx = Input.GetAxis("Horizontal");
        float mz = Input.GetAxis("Vertical");

        Vector3 move = transform.right * mx + transform.forward * mz;
        cc.Move(move * speed * Time.deltaTime);


        velocity.y += gravedad * Time.deltaTime;
        cc.Move(velocity * Time.deltaTime);

    }
}
