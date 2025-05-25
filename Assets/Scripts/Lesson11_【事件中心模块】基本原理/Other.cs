using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Other : MonoBehaviour
{
    private void Awake()
    {
        EventCenter.Instance.AddEventListener<Monster>(E_EventType.E_Monster_Dead, OtherWaitMonsterDeadDo);
    }

    public void OtherWaitMonsterDeadDo(Monster info)
    {
        Debug.Log("������ش���" + info.monsterID);
    }

    private void OnDestroy()
    {
        EventCenter.Instance.RemoveEventListener<Monster>(E_EventType.E_Monster_Dead, OtherWaitMonsterDeadDo);
    }
}
