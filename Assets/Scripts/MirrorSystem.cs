
using UdonSharp;
using UnityEngine;

/// <summary>鏡のオンオフを管理するクラス。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public class MirrorSystem : UdonSharpBehaviour
{
    /// <summary>
    /// トグル スイッチの操作に対して呼び出す、コールバック。
    /// </summary>
    public void OnToggle()
    {
        Debug.Log("MirrorSystem::OnToggle");
    }
}
