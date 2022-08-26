using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerSeguir : MonoBehaviour
{
    public GameObject target;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            transform.position = Vector3.Lerp(Transform.position,
       target.transform.position, Time.deltatime * moveSpeed);
        }
    }
}