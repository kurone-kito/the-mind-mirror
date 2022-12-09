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
    private MindMirror root;
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

    /// <summary>
    /// マインドキューブを取得します。
    /// </summary>
    /// <returns>マインドキューブ。</returns>
    private MindCube GetMindCube()
    {
        if (root == null)
        {
            Debug.LogError(ERR_NO_CORE);
            return null;
        }
        MindCube[] cubes = root.Cubes.Cubes;
        return (
            cubes == null ||
            index < 0 ||
            index >= cubes.Length ||
            cubes[index] == null
        ) ? null : cubes[index];
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
        MindCube cube = GetMindCube();
        if (cube != null && root.MindCube == null)
        {
            root.MindCube = cube;
        }
        else if (cube == null && root.MindCube != null)
        {
            root.MindCube = null;
        }
        base.Notify();
    }
}
