using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSaw : MonoBehaviour
{
    [SerializeField] private float speed = 1.5f;
    private void Update()
    {
        transform.Rotate(0f, 0f, 360 * speed * Time.deltaTime) ;
    }
}
