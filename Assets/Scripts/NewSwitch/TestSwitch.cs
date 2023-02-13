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
                Debug.Log("�������BoxCollider�ł�");
                break;
            case SphereCollider:
                Debug.Log("�������SphereCollider�ł�");
                break;
            case CapsuleCollider:
                Debug.Log("�������CapsuleCollider�ł�");
                break;
        }

        switch (_collider, _col)
        {
            case (BoxCollider, BoxCollider):

                break;
        }
    }
}
