
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;

/// <summary>鏡のオンオフを管理するクラス。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public class MirrorSystem : UdonSharpBehaviour
{
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
            Debug.LogWarning("鏡のオブジェクトが設定されていません。");
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
            Debug.LogWarning("トグル スイッチへのリンクが設定されていません。");
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
            Debug.LogWarning("トグル スイッチへのリンクが設定されていません。");
            return;
        }
        toggle.interactable = true;
    }

#pragma warning disable IDE0051
    /// <summary>
    /// 紐づくオブジェクトの初期化が完了した際に呼び出される、コールバック。
    /// </summary>
    private void Start()
    {
        body.SetActive(toggle != null && toggle.isOn);
    }
#pragma warning restore IDE0051
}
