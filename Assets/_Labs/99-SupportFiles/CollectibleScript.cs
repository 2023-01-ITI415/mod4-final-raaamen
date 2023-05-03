using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleScript : MonoBehaviour
{
    public float hoverSpeed;
    public float hoverMagnitude;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hover = Mathf.Sin(Mathf.PingPong(0,1))*hoverMagnitude;
        transform.position = new Vector3(transform.position.x, transform.position.y+hover, transform.position.z);
    }
}
