using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMgr2 : BaseManager<TestMgr2>
{
    private TestMgr2()
    {

    }

    public void TestLog()
    {
        Debug.Log("TestMgr2");
    }
}
