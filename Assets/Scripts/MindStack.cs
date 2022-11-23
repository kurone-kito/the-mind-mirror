using UdonSharp;
using UnityEngine;
using VRC.SDK3.Components;
using VRC.SDKBase;

/// <summary>マインドキューブを一時預かりするスタック。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public class MindStack : UdonSharpBehaviour
{
    /// <summary>排出物不備における、エラーメッセージ。</summary>
    private const string WARN_NO_CUBE =
        "排出するマインドキューブがありません。";

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
#pragma warning restore IDE0044

    /// <summary>マインドキューブ。</summary>
    private MindCube mindcube;

    /// <summary>フォーム オブジェクトを取得します。</summary>
    public GameObject Form => form;

    /// <summary>マインドキューブを取得または設定します。</summary>
    public MindCube MindCube
    {
        get => mindcube;
        set
        {
            mindcube = value;
            OnUpdateMindCube();
        }
    }

    /// <summary>
    /// マインドキューブの有無が変化した際に呼び出す、コールバック。
    /// </summary>
    protected virtual void OnUpdateMindCube()
    {
        if (form == null)
        {
            Debug.LogWarning(ERR_NO_FORM);
            return;
        }
        form.SetActive(MindCube != null);
#pragma warning disable IDE0031
        if (MindCube != null)
        {
            MindCube.gameObject.SetActive(false);
        }
#pragma warning restore IDE0031
    }

    /// <summary>マインドキューブを排出します。</summary>
    public virtual void PutoutMindCube()
    {
        MindCube cube = MindCube;
        if (cube == null)
        {
            Debug.LogWarning(WARN_NO_CUBE);
            return;
        }
        if (destination == null)
        {
            Debug.LogWarning(ERR_NO_DESTINATION);
            return;
        }
        cube.gameObject.SetActive(true);
        Rigidbody rigidbody = cube.GetComponent<Rigidbody>();
        if (rigidbody != null)
        {
            rigidbody.velocity = Vector3.zero;
            rigidbody.angularVelocity = Vector3.zero;
        }
        VRCObjectSync objSync = cube.GetComponent<VRCObjectSync>();
        if (objSync == null)
        {
            cube.transform.position = destination.position;
            cube.transform.rotation = destination.rotation;
        }
        else
        {
            objSync.FlagDiscontinuity();
            objSync.TeleportTo(destination);
        }
        MindCube = null;
    }

    /// <summary>
    /// プレイヤーがワールドに入室した際に呼び出される、コールバック。
    /// </summary>
    /// <param name="player">プレイヤー情報。</param>
    public override void OnPlayerJoined(VRCPlayerApi player)
    {
        VRCPlayerApi localPlayer = Networking.LocalPlayer;
        if (!(localPlayer == null || localPlayer == player))
        {
            return;
        }
#pragma warning disable IDE0031
        if (form != null)
        {
            form.SetActive(MindCube != null);
        }
#pragma warning restore IDE0031
    }
}
