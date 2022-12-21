using UdonSharp;
using UnityEngine;

/// <summary>マインドキューブへのリンクを管理するクラス。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.Manual)]
public sealed class MindCubes : ResourcesObserver
{
#pragma warning disable IDE0044
    /// <summary>マインドキューブ一覧。</summary>
    [SerializeField]
    private MindCube[] cubes = new MindCube[0];
#pragma warning restore IDE0044

    /// <summary>マインドキューブ一覧を取得します。</summary>
    public MindCube[] Cubes => cubes;

    /// <summary>
    /// マインドキューブを検索して、インデックスを取得します。
    /// </summary>
    /// <param name="target">マインドキューブ。</param>
    /// <returns>インデックス。見つからなかった場合、<c>-1</c>。</returns>
    public sbyte FindIndex(MindCube target)
    {
        if (target == null)
        {
            return -1;
        }
        for (sbyte i = 0; i < cubes.Length; i++)
        {
            if (cubes[i].GetInstanceID() == target.GetInstanceID())
            {
                return i;
            }
        }
        return -1;
    }
}
