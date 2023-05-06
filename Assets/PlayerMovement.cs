using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int collectCount;
    public Vector3 moveDirection;
    public float speed;
    public GameManager gmScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate() {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");


        moveDirection = new Vector3(x, 0, z);
        transform.Translate(moveDirection * Time.deltaTime * speed);
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Collectible")
        {
            gmScript.ChangeMeter();
            other.gameObject.GetComponent<AudioSource>().Play();
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Skateboard")
        {
            other.gameObject.transform.parent = this.gameObject.transform;
            other.gameObject.transform.localPosition = new Vector3(0,-1,0);
            other.gameObject.transform.localEulerAngles = Vector3.zero;
            speed*=2;
        }
    }
}
