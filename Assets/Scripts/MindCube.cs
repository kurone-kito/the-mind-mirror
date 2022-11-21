using UdonSharp;
using UnityEngine;

/// <summary>マインドキューブのプール。</summary>
/// <remarks>
/// このクラスに同期するフィールドはありませんが、
/// <see cref="VRC.SDK3.Components.VRCObjectPool"/>
/// の同期阻害を避けるために、明示的に同期設定を行っています。
/// </remarks>
[UdonBehaviourSyncMode(BehaviourSyncMode.Continuous)]
public sealed class MindCube : UdonSharpBehaviour
{
    /// <summary>
    /// 変数管理クラスの接続不備における、エラーメッセージ。
    /// </summary>
    private const string ERR_NO_VARIABLE =
        "変数管理クラスへのリンクが設定されていません。";

#pragma warning disable IDE0044
    /// <summary>変数管理クラス。</summary>
    [SerializeField]
    private MindCubeVariables variables;
#pragma warning restore IDE0044

    /// <summary>変数管理クラスを取得します。</summary>
    public MindCubeVariables Variables
    {
        get
        {
            if (variables == null)
            {
                Debug.LogError(ERR_NO_VARIABLE);
            }
            return variables;
        }
    }
}
