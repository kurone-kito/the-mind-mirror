using System;
using UdonSharp;
using UnityEngine;

/// <summary>
/// グローバルにマインドキューブのスタックを管理するクラス。
/// </summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.Manual)]
public sealed class GlobalStackManager : Subject
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

    /// <summary>マインドキューブのインデックス。</summary>
    [NonSerialized, UdonSynced, FieldChangeCallback(nameof(Index))]
    public sbyte index = -1;

    /// <summary>
    /// マインドキューブのインデックスを取得、または設定します。
    /// </summary>
    public sbyte Index
    {
        get => index;
        set
        {
            index = value;
            SendCustomEventDelayedFrames(nameof(Notify), 1);
        }
    }

    /// <summary>オブザーバーを呼び出します。</summary>
    protected override void Notify()
    {
        if (root == null)
        {
            Debug.LogWarning(ERR_NO_CORE);
        }
        else
        {
            root.Forbid = index >= 0;
        }
        base.Notify();
    }
}
