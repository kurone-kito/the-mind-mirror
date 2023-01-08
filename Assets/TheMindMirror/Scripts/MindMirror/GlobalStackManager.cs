using System;
using UdonSharp;
using UnityEngine;

/// <summary>
/// グローバルにマインドキューブのスタックを管理するクラス。
/// </summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.Manual)]
public sealed class GlobalStackManager : SyncBase
{
    /// <summary>
    /// マインドキューブ マネージャーの接続不備における、エラーメッセージ。
    /// </summary>
    private const string WARN_NO_CUBES =
        "マインドキューブ マネージャーへのリンクが設定されていません。";

    /// <summary>スタックの接続不備における、エラーメッセージ。</summary>
    private const string ERR_NO_STACK =
        "一時スタックへのリンクが設定されていません。";

#pragma warning disable IDE0044
    /// <summary>マインドキューブ マネージャー。</summary>
    [SerializeField]
    private MindCubes cubes;

    /// <summary>
    /// マインドキューブをスタックできるコア オブジェクト。
    /// </summary>
    [SerializeField]
    private MindStack stack;
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
            SendCustomEventDelayedFrames(nameof(OnNotify), 1);
        }
    }

    /// <summary>
    /// マインドキューブの同期的変数群を取得します。
    /// </summary>
    /// <returns>マインドキューブの同期的変数群。</returns>
    public MindCubeVariables GetMindCubeVariables()
    {
        MindCube cube = GetMindCube();
#pragma warning disable IDE0031
        return cube == null ? null : cube.Variables;
#pragma warning restore IDE0031
    }

    /// <summary>マインドキューブ情報を同期します。</summary>
    /// <param name="cube">マインドキューブ。</param>
    public void SyncMindCube(MindCube cube)
    {
        if (cubes == null)
        {
            Debug.LogWarning(WARN_NO_CUBES);
            return;
        }
        ChangeOwner();
        Index = cubes.FindIndex(cube);
        Sync();
    }

    /// <summary>
    /// マインドキューブを取得します。
    /// </summary>
    /// <returns>マインドキューブ。</returns>
    private MindCube GetMindCube()
    {
        if (stack == null)
        {
            Debug.LogError(ERR_NO_STACK);
            return null;
        }
#pragma warning disable IDE0031
        MindCube[] cubeArray = cubes == null ? null : cubes.Cubes;
#pragma warning restore IDE0031
        return (
            cubeArray == null ||
            index < 0 ||
            index >= cubeArray.Length ||
            cubeArray[index] == null
        ) ? null : cubeArray[index];
    }

    /// <summary>同期した際に呼び出されます。</summary>
    private void OnSynced()
    {
        if (stack == null)
        {
            Debug.LogWarning(ERR_NO_STACK);
            return;
        }
        stack.Forbid = index >= 0;
        MindCube cube = GetMindCube();
        if (cube != null && stack.MindCube == null)
        {
            stack.MindCube = cube;
        }
        else if (cube == null && stack.MindCube != null)
        {
            stack.MindCube = null;
        }
    }

    /// <summary>
    /// サブジェクトからの呼び出しを受けた際に呼び出す、コールバック。
    /// </summary>
    /// <param name="caller">
    /// サブジェクト本体。同期状態の更新で呼ばれた場合は、<c>null</c>。
    /// </param>
    public override void OnNotify(Subject caller)
    {
        if (caller == null)
        {
            OnSynced();
            return;
        }
#pragma warning disable IDE0031
        MindStack stack =
            caller == null ? null : caller.GetComponent<MindStack>();
#pragma warning restore IDE0031
        if (stack != null)
        {
            SyncMindCube(stack.MindCube);
        }
    }
}
