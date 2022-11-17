
using UdonSharp;
using UnityEngine;

/// <summary>マインドキューブ ライター本体オブジェクト。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public class MindWriterBody : UdonSharpBehaviour
{
#pragma warning disable IDE0044
#pragma warning disable IDE0051
    /// <summary>マインドキューブ ライター。</summary>
    [SerializeField]
    private MindWriter root;
#pragma warning restore IDE0044

    /// <summary>
    /// 任意の当たり判定を持つオブジェクトが、
    /// ライターの有効範囲に進入した際に呼び出す、コールバック。
    /// </summary>
    /// <param name="collider">当たり判定情報。</param>
    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log($"OnTriggerEnter: {collider.gameObject.name}");
    }
#pragma warning restore IDE0051
}
