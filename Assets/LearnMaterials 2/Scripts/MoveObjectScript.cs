using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectScript : SampleScript
{

    [Min(0)]
    public float moveSpeed = 1;
    public Vector3 translationPosition = new(4, 1, -6);

    [ContextMenu("������������ ������")]
    public override void Use()
    {
        StartCoroutine(Call());
    }

    private IEnumerator Call()
    {
        while (transform.position != translationPosition)
        {
            var objTransform = gameObject.transform;
            var direction = translationPosition - objTransform.position;
            objTransform.position += direction.normalized * Time.deltaTime * moveSpeed;
            yield return null;
        }
    }
}
