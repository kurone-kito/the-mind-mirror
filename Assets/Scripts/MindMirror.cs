using UdonSharp;
using UnityEngine;

/// <summary>マインドキューブの情報ビューア。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.Manual)]
public sealed class MindMirror : MindStack
{
    /// <summary>
    /// マインドキューブ マネージャーの接続不備における、エラーメッセージ。
    /// </summary>
    private const string WARN_NO_CUBES =
        "マインドキューブ マネージャーへのリンクが設定されていません。";

    /// <summary>
    /// グローバル スタックの接続不備における、エラーメッセージ。
    /// </summary>
    private const string WARN_NO_GLOBAL_MANAGER =
        "グローバル スタックへのリンクが設定されていません。";

#pragma warning disable IDE0044
    /// <summary>ページネーションのラベル。</summary>
    [SerializeField]
    private GlobalStackManager globalStackManager;

    /// <summary>マインドキューブ マネージャー。</summary>
    [SerializeField]
    private MindCubes cubes;
#pragma warning restore IDE0044

    /// <summary>
    /// マインドキューブの有無が変化した際に呼び出す、コールバック。
    /// </summary>
    protected override void OnUpdateMindCube()
    {
        base.OnUpdateMindCube();
        if (cubes == null)
        {
            Debug.LogWarning(WARN_NO_CUBES);
            return;
        }
        if (globalStackManager == null)
        {
            Debug.LogWarning(WARN_NO_GLOBAL_MANAGER);
            return;
        }
        globalStackManager.ChangeOwner();
        globalStackManager.Index = cubes.FindIndex(MindCube);
        globalStackManager.Sync();
    }
}
