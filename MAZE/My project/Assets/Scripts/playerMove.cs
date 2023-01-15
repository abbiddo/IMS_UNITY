using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public float moveSpeed;
    public float jumpPower;

    public bool isGround;

    Rigidbody rigid;

    //public GameObject maincamera;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 5;
        jumpPower = 5;

        isGround = false;

        rigid = this.GetComponent<Rigidbody>();

        transform.position = new Vector3(-17.5f, 0, -17.5f);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    public void Move()
    {
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(new Vector3(0, -90 * Time.deltaTime, 0));
            //maincamera.transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(new Vector3(0, 90 * Time.deltaTime, 0));
            //maincamera.transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
            //maincamera.transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.back * Time.deltaTime * moveSpeed);
            //maincamera.transform.Translate(Vector3.back * Time.deltaTime * moveSpeed);
        }
    }
   
    public void Jump()
    {
        if (isGround) {
            if (Input.GetKey(KeyCode.Space))
            {
                rigid.AddForce(this.transform.up * jumpPower, ForceMode.Impulse);
                isGround = false;
            }
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            Debug.Log("땅에 닿음");
            isGround = true;
        }

        if (collision.gameObject.CompareTag("tele1"))
            transform.position = new Vector3(2.5f, 0, -15f);
        else if (collision.gameObject.CompareTag("tele2"))
            transform.position = new Vector3(7.5f, 0, 17.5f);
        else if (collision.gameObject.CompareTag("tele3"))
            transform.position = new Vector3(7.5f, 0, 10f);
    }
}
