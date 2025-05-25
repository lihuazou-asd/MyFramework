using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

/// <summary>
/// 单例模式基类 主要目的是避免代码的冗余 方便我们实现单例模式的类
/// </summary>
/// <typeparam name="T"></typeparam>
public abstract class BaseManager<T> where T:class//,new()
{
    private static T instance;

    //用于加锁的对象
    protected static readonly object lockObj = new object();

    //属性的方式
    public static T Instance
    {
        get
        {
            if(instance == null)//这一次的加锁主要是优化性能，在已有instance的情况下直接返回，不再每次使用单例都走一遍加锁
            {
                lock (lockObj)
                {
                    if (instance == null)
                    {
                        //instance = new T();
                        //利用反射得到无参私有的构造函数 来用于对象的实例化
                        Type type = typeof(T);
                        ConstructorInfo info = type.GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic,
                                                                    null,
                                                                    Type.EmptyTypes,
                                                                    null);
                        if (info != null)
                            instance = info.Invoke(null) as T;
                        else
                            Debug.LogError("没有得到对应的无参构造函数");
                    }
                }
            }
            return instance;
        }
    }

    //方法的方式
    //public static T GetInstance()
    //{
    //    if (instance == null)
    //        instance = new T();
    //    return instance;
    //}
}
