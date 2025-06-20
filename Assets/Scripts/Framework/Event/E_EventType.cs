using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 事件类型 枚举
/// </summary>
public enum E_EventType
{
    /// <summary>
    /// 怪物死亡事件 —— 参数：Monster
    /// </summary>
    E_Monster_Dead,
    /// <summary>
    /// 玩家获取奖励 —— 参数：int
    /// </summary>
    E_Player_GetReward,
    /// <summary>
    /// 测试用事件 —— 参数：无
    /// </summary>
    E_Test,
    E_SceneLoadChange,
    E_Input_Horizontal,
    E_Input_Vertical,
    E_Keyboard_Down,
    E_Keyboard_Up,
    E_Keyboard,
    E_Mouse_Down,
    E_Mouse_Up,
    E_Mouse,
}
