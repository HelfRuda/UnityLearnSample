using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour
{
    [ContextMenu("������������ ������")]
    public void Use()
    {

        var objects = FindObjectsOfType<SampleScript>();
        foreach (var script in objects)
        {
            script.Use();
        }
    }
}
