using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fail : MonoBehaviour
{
    private Animator anim;

    private void Awake()
    {
        if (!TryGetComponent(out anim))
        {
            Debug.Log("Alert.cs - Awake() - anim ���� ����");
        }
    }

    public void MatchFail()
    {
        anim.SetTrigger("Fail");
    }
}
