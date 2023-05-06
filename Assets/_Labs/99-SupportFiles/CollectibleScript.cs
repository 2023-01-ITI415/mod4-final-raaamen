using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleScript : MonoBehaviour
{
    public float hoverSpeed;
    public float hoverMagnitude;

    private AudioSource src;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hover = Mathf.Sin(Time.time/hoverSpeed)*hoverMagnitude;
        transform.position = new Vector3(transform.position.x, 1+hover, transform.position.z);
    }

    private void OnDestroy() {
        
    }
}
