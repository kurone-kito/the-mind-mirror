
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDK3.Components;
using VRC.SDKBase;

/// <summary>マインドキューブに情報を書き出すクラス。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public class MindWriter : UdonSharpBehaviour
{
    /// <summary>排出先の接続不備における、エラーメッセージ。</summary>
    private const string ERR_NO_DESTINATION =
        "排出先へのリンクが設定されていません。";

    /// <summary>フォームの接続不備における、エラーメッセージ。</summary>
    private const string ERR_NO_FORM =
        "フォームへのリンクが設定されていません。";

#pragma warning disable IDE0044
    /// <summary>排出口。</summary>
    [SerializeField]
    private Transform destination;

    /// <summary>フォーム。</summary>
    [SerializeField]
    private GameObject form;

    /// <summary>名前入力フィールド。</summary>
    [SerializeField]
    private InputField nameInput;
#pragma warning restore IDE0044

    /// <summary>マインドキューブ。</summary>
    private MindCube mindcube;

    /// <summary>マインドキューブを取得または設定します。</summary>
    public MindCube MindCube
    {
        get => mindcube;
        set
        {
            mindcube = value;
            UpdateRender();
        }
    }

    /// <summary>プレイヤーの表示名を取得します。</summary>
    private string PlayerName
    {
        get
        {
            VRCPlayerApi player = Networking.LocalPlayer;
            return player == null ? string.Empty : player.displayName;
        }
    }

    /// <summary>
    /// フォーム入力をキャンセルする際に呼び出す、コールバック。
    /// </summary>
    public void OnCancel()
    {
        PutoutMindCube();
    }

    /// <summary>
    /// フォーム入力を確定する際に呼び出す、コールバック。
    /// </summary>
    public void OnDecide()
    {
        WriteToMindCube();
        PutoutMindCube();
    }

    /// <summary>名前入力が完了した際に呼び出す、コールバック。</summary>
    public void OnEndNameInput()
    {
        if (nameInput != null && string.IsNullOrWhiteSpace(nameInput.text))
        {
            nameInput.text = PlayerName;
        }
    }

    /// <summary>マインドキューブを排出します。</summary>
    private void PutoutMindCube()
    {
        if (MindCube == null)
        {
            return;
        }
        if (destination == null)
        {
            Debug.LogWarning(ERR_NO_DESTINATION);
            return;
        }
        MindCube.gameObject.SetActive(true);
        VRCObjectSync objSync = MindCube.GetComponent<VRCObjectSync>();
        if (objSync == null)
        {
            MindCube.transform.position = destination.position;
            MindCube.transform.rotation = destination.rotation;
        }
        else
        {
            objSync.TeleportTo(destination);
        }
        MindCube = null;
    }

    /// <summary>描画状態を更新します。</summary>
    private void UpdateRender()
    {
        if (form == null)
        {
            Debug.LogWarning(ERR_NO_FORM);
            return;
        }
        form.SetActive(MindCube != null);
        if (MindCube == null)
        {
            return;
        }
        MindCube.gameObject.SetActive(false);
        if (nameInput != null)
        {
            nameInput.text = PlayerName;
        }
    }

    private void WriteToMindCube()
    {
        if (MindCube == null)
        {
            return;
        }
        MindCube.Variables.ChangeOwner();
        MindCube.Variables.CubeName =
            nameInput == null ? PlayerName : nameInput.text.Trim();
        MindCube.Variables.Parameter = (uint)Random.Range(0, int.MaxValue);
        MindCube.Variables.Sync();
    }

    /// <summary>
    /// プレイヤーがワールドに入室した際に呼び出される、コールバック。
    /// </summary>
    /// <param name="player">プレイヤー情報。</param>
    public override void OnPlayerJoined(VRCPlayerApi player)
    {
        if (Networking.LocalPlayer == player && form != null)
        {
            form.SetActive(MindCube != null);
        }
    }
}
