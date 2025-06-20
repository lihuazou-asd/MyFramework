using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson17 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region Resources重要知识回顾
        //Resources加载一次资源过后
        //该资源就一直存放在内存中作为缓存
        //第二次加载时发现缓存中存在该资源
        //会直接取出来进行使用
        //所以 多次重复加载不会浪费内存
        //但是 会浪费性能（每次加载都会去查找取出，始终伴随一些性能消耗）

        //Resources.UnloadAsset 卸载指定资源 但不能卸载GameObject对象
        //它只能用于一些 不需要实例化的内容 比如 图片 和 音效 文本等等

        //Resources.UnloadUnusedAssets 卸载未使用资源 一般过场景时配合GC使用
        #endregion

        #region 知识点一 异步加载问题指的是什么？
        //每次进行异步加载时，都会开启一个协同程序
        //虽然Resources资源会在内部进行缓存，加载已加载过的资源，性能消耗不会太大
        //但是每次开启协程的过程也会浪费性能
        //因此我们希望对上节课的ResMgr进行优化
        //不依赖Resources内部的缓存机制
        //而是自己来管理已经加载过的资源
        //从而解决异步加载时协同程序的频繁开启造成的性能浪费


        //我们想要达到的目的是
        //通过一个字典记录已经加载过的资源
        //每次在进行资源加载时，如果发现是已经加载过的资源
        //我们直接使用即可
        #endregion

        #region 知识点二 制作思路和具体实现
        //1.字典容器结构设计
        //  主要考虑点
        //  key - 资源名（路径 + 类型 拼接而成）
        //  value - 自定义数据结构类：资源、委托、协程对象等

        //2.修改异步加载相关逻辑
        //  字典中不存在资源记录时
        //      开启协同程序进行加载，并且此时就要记录进字典中（这样可以避免重复异步加载）
        //  字典中存在资源记录时
        //      1-资源还没加载完 —— 记录委托
        //      2-资源已经加载完 —— 直接使用

        //3.修改同步加载相关逻辑
        //  字典中不存在资源记录时
        //      直接同步加载资源记录即可
        //  字典中存在资源记录时    
        //      1-资源还没加载完 —— 停止协程
        //      2-资源已经加载完 —— 直接使用

        //4.修改卸载资源相关逻辑
        //  字典中存在资源记录时
        //      1-资源还没加载完 —— 记录删除标识，待加载完后真正移除 或者 停止协程，并且移除 
        //      2-资源已经加载完 —— 直接卸载，并且移除字典中资源记录
        #endregion

        #region 知识点三 存在的问题
        //1.在卸载资源时，我们并不知道是否还有地方使用着该资源
        //2.UnloadUnusedAssets是卸载没有使用的资源，我们无法判断是否使用
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
