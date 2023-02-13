using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class CubeData : MonoBehaviour
{
    [SerializeField]
    private Button _saveButton;

    [SerializeField]
    private Button _loadButton;

    string _savePosPath;
    string _saveVelocityPath;

    Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _savePosPath = Application.persistentDataPath + "/CubePosSave.json";
        _saveVelocityPath = Application.persistentDataPath + "CubeVelocity.json";
        _saveButton.onClick.AddListener(SaveMyPos);
        _loadButton.onClick.AddListener(LoadMyPos);
    }

    private void SaveMyPos()
    {
        var posData = transform.position;
        string savePosJson = JsonUtility.ToJson(posData);

        using (StreamWriter streamWriter = new(_savePosPath))
        {
            streamWriter.Write(savePosJson);
        }

        var velocityData = _rb.velocity;
        string saveVelocityJson = JsonUtility.ToJson(velocityData);

        using (StreamWriter writer = new(_saveVelocityPath))
        {
            writer.Write(saveVelocityJson);
        }

        Debug.Log(posData);
        Debug.Log(velocityData);
    }

    private void LoadMyPos()
    {
        Vector3 posData;

        using (StreamReader streamReader = new(_savePosPath))
        {
            var loadPosJson = streamReader.ReadToEnd();
            posData = JsonUtility.FromJson<Vector3>(loadPosJson);
        }

        transform.position = posData;

        Vector3 velocityData;

        using (StreamReader reader = new(_saveVelocityPath))
        {
            var loadVelocityJson = reader.ReadToEnd();
            velocityData = JsonUtility.FromJson<Vector3>(loadVelocityJson);
        }

        _rb.velocity = velocityData;

        Debug.Log(posData);
        Debug.Log(velocityData);
    }
}
