using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSwitch : MonoBehaviour
{
    [SerializeField]
    private Collider _collider;

    [SerializeField]
    private Collider _col;

    private void Start()
    {
        switch (_collider)
        {
            case BoxCollider:
                Debug.Log("こちらはBoxColliderです");
                break;
            case SphereCollider:
                Debug.Log("こちらはSphereColliderです");
                break;
            case CapsuleCollider:
                Debug.Log("こちらはCapsuleColliderです");
                break;
        }

        switch (_collider, _col)
        {
            case (BoxCollider, BoxCollider):

                break;
        }
    }
}
