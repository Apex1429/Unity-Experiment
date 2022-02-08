using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float rotateXSpeed = 0;
    [SerializeField] float rotateYSpeed = 0;
    [SerializeField] float rotateZSpeed = 0;

    void Update()
    {
        transform.Rotate(rotateXSpeed, rotateYSpeed, rotateZSpeed);
    }
}
