using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monster : MonoBehaviour
{
    public string monsterName = "123123";
    public int monsterID = 1;

    // Start is called before the first frame update
    void Start()
    {
        //Dead();
    }

    public void Dead()
    {
        Debug.Log("����������");
        //���������ڹ�������ʱ����������
        EventCenter.Instance.EventTrigger<Monster>(E_EventType.E_Monster_Dead, this);
        ////����
        ////1.�������
        //GameObject.Find("Task").GetComponent<Task>().TaskWaitMonsterDeadDo();
        ////2.��ҵý���
        //GameObject.Find("Player").GetComponent<Player>().PlayerWaitMonsterDeadDo();
        ////3.�������ϵͳ
        //GameObject.Find("Other").GetComponent<Other>().OtherWaitMonsterDeadDo();
        ////n��������ش���
    }
}
