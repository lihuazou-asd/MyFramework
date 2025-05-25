using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TestMgr.Instance.TestLog();

        Test2Mgr2.Instance.TestLog();

        //破坏单例模式唯一性 我们能够自己去new对应的单例模式类对象 这样是不安全
        //TestMgr t = new TestMgr();
        //BaseManager<TestMgr> t2 = new BaseManager<TestMgr>();

        ResMgr.Instance.LoadAsync<GameObject>("Test", TestFun);
        Debug.Log(ResMgr.Instance.GetRefCount<GameObject>("Test"));

        ResMgr.Instance.LoadAsync<GameObject>("Test", TestFun);
        Debug.Log(ResMgr.Instance.GetRefCount<GameObject>("Test"));

        ResMgr.Instance.UnloadAsset<GameObject>("Test", false, TestFun);
        Debug.Log(ResMgr.Instance.GetRefCount<GameObject>("Test"));

        ResMgr.Instance.UnloadAsset<GameObject>("Test", false, TestFun);
        Debug.Log(ResMgr.Instance.GetRefCount<GameObject>("Test"));

        //Instantiate(ResMgr.Instance.Load<GameObject>("Test"));
        //Debug.Log(ResMgr.Instance.GetRefCount<GameObject>("Test"));

        Instantiate(EditorResMgr.Instance.LoadEditorRes<GameObject>("Cube"));

        Coroutine c = StartCoroutine(TestFun());
        StopCoroutine(c);
        AssetBundle.LoadFromFile(Application.streamingAssetsPath + "/PC/test");
    }

    IEnumerator TestFun()
    {
        AssetBundleCreateRequest req = AssetBundle.LoadFromFileAsync(Application.streamingAssetsPath + "/PC/test");
        yield return req;
        print(req.assetBundle.name);
    }

    private void TestFun(GameObject obj)
    {
        Instantiate(obj);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Test6Mgr.Instance.ICanUpdateAndCoroutine();

        if (Input.GetKeyUp(KeyCode.Space))
            Test6Mgr.Instance.ICanStopUpdateAndCoroutine();

        if (Input.GetKeyDown(KeyCode.X))
        {
            GameObject.Find("Monster").GetComponent<Monster>().Dead();
            EventCenter.Instance.EventTrigger(E_EventType.E_Test);
        }
            


        #region 缓存池测试
        if(Input.GetMouseButtonDown(0))
        {
            GameObject obj = PoolMgr.Instance.GetObj("Test/Cube");
            obj.transform.position = Vector3.zero;
        }

        if(Input.GetMouseButtonDown(1))
        {
            PoolMgr.Instance.GetObj("Test/Sphere");
        }
        #endregion
    }
}
