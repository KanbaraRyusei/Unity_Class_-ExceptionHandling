using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class AssertTest : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] GameObject gb;

    private void Start()
    {
        Assert.IsNotNull(rb, "RigidBody��Null�ł�");
        Assert.IsNotNull(gb, "GameObject��Null");
    }
}
