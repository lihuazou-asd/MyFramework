using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region ���ڿ�ʹ�õ�֪ʶ��
        //ϸ��֪ʶ��
        //C#�г������֪ʶ�㣨C#�Ĳ���֮C#���ģ�
        //C#�з������֪ʶ�㣨C#�Ĳ���֮C#���ף�
        #endregion

        #region ֪ʶ��һ ���캯��������Ψһ������ָʲô��
        //1.���ڲ��̳�MonoBehaviour�ĵ���ģʽ����
        //  ����Ҫ�������ⲿ new ����ģʽ�����

        //2.���ڼ̳�MonoBehaviour�ĵ���ģʽ����
        //  ���ڼ̳�MonoBehaviour�Ľű�����ͨ��new��������˲��ù��࿼��
        #endregion

        #region ֪ʶ��� ������캯�������İ�ȫ����
        //1.�����Ϊ������

        //2.�涨�̳е���ģʽ������������ʾʵ��˽���޲ι��캯��

        //3.�ڻ�����ͨ������������˽�й��캯��ʵ��������
        //  ��Ҫ֪ʶ�㣺
        //  ����Type�е� GetConstructor(Լ������, �󶨶���, ��������, �������η�)����
        //  ����ȡ˽���޲ι��캯��
        //  ConstructorInfo constructor = typeof(T).GetConstructor(
        //  BindingFlags.Instance | BindingFlags.NonPublic, //��ʾ��Ա˽�з���
        //    null,                                         //��ʾû�а󶨶���
        //    Type.EmptyTypes,                              //��ʾû�в���
        //    null);                                        //��ʾû�в������η�
        //          
        #endregion

        #region �ܽ�
        //��Ȼ�������캯�����ܸ����Ǵ����ƻ�Ψһ�Եİ�ȫ����
        //������ʵ�ʿ�����
        //����ģʽ�Ƿǳ�������֪ʶ��
        //����˵�ǳ���Ա�ıر�����֪ʶ
        //��ʹ��ʱ�����������������Լ�ȥnew����ģʽ����

        //��˼�ʹ���ǲ�����Щ��ȫ�ԵĴ���
        //��ʵҲ������̫������
        //����ʵ����������������Ƽ���
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
