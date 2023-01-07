using UdonSharp;
using UnityEngine;
using VRC.SDK3.Components;

/// <summary>マインドキューブを一時預かりするスタック。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public class MindStack : Subject
{
    /// <summary>排出物不備における、エラーメッセージ。</summary>
    private const string WARN_NO_CUBE =
        "排出するマインドキューブがありません。";

    /// <summary>排出先の接続不備における、エラーメッセージ。</summary>
    private const string ERR_NO_DESTINATION =
        "排出先へのリンクが設定されていません。";

#pragma warning disable IDE0044
    /// <summary>受け入れ可能であることを示すサイン。</summary>
    [SerializeField]
    private GameObject acceptableSign;

    /// <summary>排出口。</summary>
    [SerializeField]
    private Transform destination;

    /// <summary>
    /// フォームが表示中に非表示化する物体があれば指定します。
    /// </summary>
    [SerializeField]
    private GameObject hiddenOnFormShown;

    /// <summary>フォーム。</summary>
    [SerializeField]
    private GameObject form;
#pragma warning restore IDE0044

    /// <summary>受け入れを拒否するかどうか。</summary>
    private bool forbid;

    /// <summary>マインドキューブ。</summary>
    private MindCube mindcube;

    /// <summary>受け入れ可能かどうか。</summary>
    public bool Acceptable => !Forbid && MindCube == null;

    /// <summary>受け入れを拒否するかどうか。</summary>
    public bool Forbid
    {
        get => forbid;
        set
        {
            forbid = value;
            UpdateAcceptable();
        }
    }

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
            UpdateAcceptable();
        }
    }

    /// <summary>
    /// 受け入れ可否状態が変化した際に、サインの有効状態を更新します。
    /// </summary>
    private void UpdateAcceptable()
    {
        bool acceptable = !Forbid && MindCube == null;
#pragma warning disable IDE0031
        if (acceptableSign != null)
        {
            acceptableSign.SetActive(acceptable);
        }
#pragma warning restore IDE0031
    }

    /// <summary>
    /// マインドキューブの有無が変化した際に呼び出す、コールバック。
    /// </summary>
    protected virtual void OnUpdateMindCube()
    {
        UpdateShowForm();
#pragma warning disable IDE0031
        if (MindCube != null)
        {
            MindCube.NotifyActive(false);
        }
#pragma warning restore IDE0031
        Notify();
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
        cube.ChangeOwner();
        cube.NotifyActive(true);
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

    /// <summary>初期化時に呼び出される、コールバック。</summary>
    protected virtual void Start()
    {
        UpdateAcceptable();
        UpdateShowForm();
    }

    /// <summary>フォームの表示状態を更新します。</summary>
    private void UpdateShowForm()
    {
        bool showForm = MindCube != null;
#pragma warning disable IDE0031
        if (form != null)
        {
            form.SetActive(showForm);
        }
        if (hiddenOnFormShown != null)
        {
            hiddenOnFormShown.SetActive(!showForm);
        }
#pragma warning restore IDE0031
    }
}
