using UdonSharp;
using UnityEngine;

/// <summary>マインドキューブの情報ビューア。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.Manual)]
public sealed class MindMirror : MindStack
{
    /// <summary>
    /// グローバル スタックの接続不備における、エラーメッセージ。
    /// </summary>
    private const string WARN_NO_GLOBAL_MANAGER =
        "グローバル スタックへのリンクが設定されていません。";

#pragma warning disable IDE0044
    /// <summary>ページネーションのラベル。</summary>
    [SerializeField]
    private GlobalStackManager globalStackManager;
#pragma warning restore IDE0044

    /// <summary>
    /// マインドキューブの有無が変化した際に呼び出す、コールバック。
    /// </summary>
    protected override void OnUpdateMindCube()
    {
        base.OnUpdateMindCube();
        if (globalStackManager == null)
        {
            Debug.LogWarning(WARN_NO_GLOBAL_MANAGER);
            return;
        }
        globalStackManager.SyncMindCube(MindCube);
    }
}
