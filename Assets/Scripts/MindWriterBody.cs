using UdonSharp;
using UnityEngine;

/// <summary>マインドキューブ スタック本体オブジェクト。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public class MindWriterBody : UdonSharpBehaviour
{
    /// <summary>
    /// コア オブジェクトの接続不備における、エラーメッセージ。
    /// </summary>
    private const string ERR_NO_CORE =
        "コア オブジェクトへのリンクが設定されていません。";

#pragma warning disable IDE0044
    /// <summary>
    /// マインドキューブをスタックできるコア オブジェクト。
    /// </summary>
    [SerializeField]
    private MindStack root;
#pragma warning restore IDE0044

    /// <summary>
    /// 任意の当たり判定を持つオブジェクトが、
    /// ライターの有効範囲に進入した際に呼び出す、コールバック。
    /// </summary>
    /// <param name="collider">当たり判定情報。</param>
#pragma warning disable IDE0051
    private void OnTriggerEnter(Collider collider)
    {
        if (root == null)
        {
            Debug.LogWarning(ERR_NO_CORE);
            return;
        }
#pragma warning disable IDE0031
        MindCube mindcube =
            collider == null ? null : collider.GetComponent<MindCube>();
#pragma warning restore IDE0031
        if (mindcube == null || root.MindCube != null)
        {
            return;
        }
        root.MindCube = mindcube;
    }
#pragma warning restore IDE0051
}
