using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour
{
    void Start()
    {
        var image = GetComponent<Image>();

        try
        {
            image.color = Color.black;
        }
        catch (System.NullReferenceException)
        {
            Debug.Log("ImageÇ™ë∂ç›ÇµÇ»Ç¢");
        }
    }
}
