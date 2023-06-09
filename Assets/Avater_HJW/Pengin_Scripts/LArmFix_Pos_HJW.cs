using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LArmFix_Pos_HJW : MonoBehaviour
{
    public GameObject targetObject;  // 고정시킬 게임 오브젝트

    private Vector3 fixedPosition = new Vector3(-0.524f, 0.4f, -0.0774f);  // 고정할 위치 값

    private void Start()
    {
        if (targetObject == null)
        {
            Debug.LogError("Target object is not assigned!");
            return;
        }

        // 타겟 오브젝트의 위치 값을 고정된 값으로 설정합니다.
        targetObject.transform.position = fixedPosition;
    }
}
