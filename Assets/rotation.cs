using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class rotation : MonoBehaviour
{

    public Vector3 rotationTransform;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(rotationTransform * Time.deltaTime);
    }
}
