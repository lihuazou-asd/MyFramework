using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//��������ͬһ�������Ϲ��ض����ͬ�ű�
[DisallowMultipleComponent]
public class Test2Mgr : SingletonMono<Test2Mgr>
{
    private int i;


    protected override void Awake()
    {
        //��дAwakeʱ ��һ������ʡ�Ի�ɾ��
        base.Awake();

        i = 10;
    }

    public void TestLog()
    {
        print("Test2Mgr " + i);
    }
}
