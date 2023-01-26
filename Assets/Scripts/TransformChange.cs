using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Rootobject
{
    public Trasnsform trasnsform;
}

[Serializable]
public class Trasnsform
{
    public Position position;
    public Rotation rotation;
    public Scale scale;
}

[Serializable]
public class Position
{
    public int x;
    public int y;
    public int z;
}

[Serializable]
public class Rotation
{
    public int x;
    public int y;
    public int z;
}

[Serializable]
public class Scale
{
    public int x;
    public int y;
    public int z;
}

public class TransformChange : MonoBehaviour
{
    private void Start()
    {
        string jsonStr = Resources.Load<TextAsset>("TestArrayJson").ToString();
        var data = JsonUtility.FromJson<Rootobject>(jsonStr);

        transform.position = new Vector3(data.trasnsform.position.x, data.trasnsform.position.y, data.trasnsform.position.z);

        transform.rotation = new Quaternion(data.trasnsform.rotation.x, data.trasnsform.rotation.y, data.trasnsform.rotation.z, 0);

        transform.localScale = new Vector3(data.trasnsform.scale.x, data.trasnsform.scale.y, data.trasnsform.scale.z);
    }
}