using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon.Common.Interfaces;

/// <summary>マインドキューブのプール。</summary>
/// <remarks>
/// このクラスに同期するフィールドはありませんが、
/// <see cref="VRCObjectPool"/>
/// の同期阻害を避けるために、明示的に同期設定を行っています。
/// </remarks>
[UdonBehaviourSyncMode(BehaviourSyncMode.Continuous)]
public sealed class MindCube : SyncBase
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

    /// <summary>アクティブ化します。</summary>
    public void Active()
    {
        gameObject.SetActive(true);
    }

    /// <summary>非アクティブ化します。</summary>
    public void DeActive()
    {
        VRC_Pickup pickup = GetComponent<VRC_Pickup>();
#pragma warning disable IDE0031
        if (pickup != null)
        {
            pickup.Drop();
        }
#pragma warning restore IDE0031
        gameObject.SetActive(false);
    }

    /// <summary>全ユーザーにアクティブ状態を送信します。</summary>
    /// <param name="active">アクティブ化するかどうか。</param>
    public void NotifyActive(bool active)
    {
        string command = active ? nameof(Active) : nameof(DeActive);
        SendCustomNetworkEvent(NetworkEventTarget.All, command);
        SendCustomEventDelayedFrames(command, 1);
    }

    /// <summary>同期変数のアップデートを通知します。</summary>
    protected override void Notify()
    {
    }
}
