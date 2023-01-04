using UdonSharp;
using UnityEngine;

/// <summary>マインドキューブ受容体オブジェクト。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public sealed class MindAccepter : UdonSharpBehaviour
{
#pragma warning disable IDE0044
    /// <summary>マインドキューブの一時スタック。</summary>
    [SerializeField]
    private MindStack stack;
#pragma warning restore IDE0044

    /// <summary>
    /// 任意の当たり判定を持つオブジェクトが、
    /// ライターの有効範囲に進入した際に呼び出す、コールバック。
    /// </summary>
    /// <param name="collider">当たり判定情報。</param>
#pragma warning disable IDE0051
    private void OnTriggerEnter(Collider collider)
    {
        if (stack == null)
        {
            return;
        }
#pragma warning disable IDE0031
        MindCube mindcube =
            collider == null ? null : collider.GetComponent<MindCube>();
#pragma warning restore IDE0031
        if (mindcube == null || !stack.Acceptable)
        {
            return;
        }
        stack.MindCube = mindcube;
    }
#pragma warning restore IDE0051
}
