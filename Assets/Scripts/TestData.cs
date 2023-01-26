using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class MonstersArray
{
    public Monster[] monsters;
}

[Serializable]
public class Monster
{
    public int id;
    public string name;
    public bool isHuman;
    public int hp;
    public int attackPoint;
}

public class TestData : MonoBehaviour
{
    void Start()
    {
        string jsonStr = Resources.Load<TextAsset>("TestArrayJson").ToString();
        var data = JsonUtility.FromJson<MonstersArray>(jsonStr);

        foreach (var monster in data.monsters)
        {
            Debug.Log("id " + monster.id);
            Debug.Log("name " + monster.name);
            Debug.Log("isHuman " + monster.isHuman);
        }
    }
}
