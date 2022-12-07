
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;

/// <summary>鏡のオンオフを管理するクラス。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public sealed class MirrorSystem : UdonSharpBehaviour
{
    /// <summary>
    /// 鏡オブジェクトの接続不備における、エラーメッセージ。
    /// </summary>
    private const string ERR_NO_MIRROR = "鏡のオブジェクトが設定されていません。";

    /// <summary>
    /// トグル スイッチ オブジェクトの接続不備における、エラーメッセージ。
    /// </summary>
    private const string ERR_NO_TOGGLE = "トグル スイッチへのリンクが設定されていません。";

#pragma warning disable IDE0044
    /// <summary>鏡本体オブジェクト。</summary>
    [SerializeField]
    private GameObject body = null;

    /// <summary>トグル スイッチ。</summary>
    [SerializeField]
    private Toggle toggle = null;
#pragma warning restore IDE0044

    /// <summary>
    /// トグル スイッチの操作に対して呼び出す、コールバック。
    /// </summary>
    public void OnToggle()
    {
        if (body == null)
        {
            Debug.LogWarning(ERR_NO_MIRROR);
            return;
        }
        body.SetActive(toggle != null && toggle.isOn);
    }

    /// <summary>
    /// 鏡の有効範囲に進入した際に呼び出す、コールバック。
    /// </summary>
    /// <param name="player">進入したプレイヤーの情報。</param>
    public override void OnPlayerTriggerEnter(VRCPlayerApi player)
    {
        if (player == Networking.LocalPlayer)
        {
            EnableToggle();
        }
        base.OnPlayerTriggerEnter(player);
    }

    /// <summary>
    /// 鏡の有効範囲から退出した際に呼び出す、コールバック。
    /// </summary>
    /// <param name="player">退出したプレイヤーの情報。</param>
    public override void OnPlayerTriggerExit(VRCPlayerApi player)
    {
        if (player == Networking.LocalPlayer)
        {
            DisableToggle();
        }
        base.OnPlayerTriggerExit(player);
    }

    /// <summary>
    /// プレイヤーがリスポーンした際に呼び出す、コールバック。
    /// </summary>
    /// <param name="player">リスポーンしたプレイヤーの情報。</param>
    public override void OnPlayerRespawn(VRCPlayerApi player)
    {
        if (player == Networking.LocalPlayer)
        {
            DisableToggle();
        }
        base.OnPlayerRespawn(player);
    }

    /// <summary>トグル スイッチを非活性化します。</summary>
    private void DisableToggle()
    {
        if (toggle == null)
        {
            Debug.LogWarning(ERR_NO_TOGGLE);
            return;
        }
        toggle.isOn = false;
        toggle.interactable = false;
    }

    /// <summary>トグル スイッチを活性化します。</summary>
    private void EnableToggle()
    {
        if (toggle == null)
        {
            Debug.LogWarning(ERR_NO_TOGGLE);
            return;
        }
        toggle.interactable = true;
    }

    /// <summary>
    /// プレイヤーがワールドに入室した際に呼び出される、コールバック。
    /// </summary>
    /// <param name="player">プレイヤー情報。</param>
    public override void OnPlayerJoined(VRCPlayerApi player)
    {
        if (Networking.LocalPlayer == player)
        {
            body.SetActive(toggle != null && toggle.isOn);
        }
    }
}
