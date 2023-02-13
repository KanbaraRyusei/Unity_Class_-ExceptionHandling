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
                Debug.Log("‚±‚¿‚ç‚ÍBoxCollider‚Å‚·");
                break;
            case SphereCollider:
                Debug.Log("‚±‚¿‚ç‚ÍSphereCollider‚Å‚·");
                break;
            case CapsuleCollider:
                Debug.Log("‚±‚¿‚ç‚ÍCapsuleCollider‚Å‚·");
                break;
        }

        switch (_collider, _col)
        {
            case (BoxCollider, BoxCollider):

                break;
        }
    }
}
