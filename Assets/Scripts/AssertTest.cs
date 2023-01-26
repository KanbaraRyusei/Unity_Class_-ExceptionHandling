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
        Assert.IsNotNull(rb, "RigidBody‚ªNull‚Å‚·");
        Assert.IsNotNull(gb, "GameObject‚ªNull");
    }
}
