using System;
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;

/// <summary>生年月日ドロップダウンのインデックス。</summary>
internal enum BirthIndex
{
    /// <summary>生まれた年の上 2 桁。</summary>
    YearHi,
    /// <summary>生まれた年の 3 桁目。</summary>
    YearLo1,
    /// <summary>生まれた年の下 1 桁。</summary>
    YearLo2,
    /// <summary>生まれた月。</summary>
    Month,
    /// <summary>生まれた日の上桁。</summary>
    DayHi,
    /// <summary>生まれた日の下桁。</summary>
    DayLo,
    /// <summary>配列長。</summary>
    /// <remarks>この値は、インデックスとしては無効です。</remarks>
    MAX_VALUE,
}

/// <summary>マインドキューブに情報を書き出すクラス。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public sealed class MindWriter : MindStack
{
    /// <summary>
    /// 生年月日入力コントロールの接続不備における、エラーメッセージ。
    /// </summary>
    private const string ERR_NO_BIRTH =
        "生年月日入力コントロールへのリンクが設定されていません。";

    /// <summary>決定ボタンの接続不備における、エラーメッセージ。</summary>
    private const string ERR_NO_DECIDE =
        "決定ボタンへのリンクが設定されていません。";

    /// <summary>生年月日の範囲外不備における、エラーメッセージ。</summary>
    private const string WARN_BIRTH_OUT_OF_RANGE =
        "生年月日の入力値が範囲外です。";

#pragma warning disable IDE0090
    /// <summary>初期設定の生年月日。</summary>
    private readonly DateTime INITIAL_DATE = new DateTime(2000, 1, 1);

    /// <summary>有効な最も過去の生年月日。</summary>
    private readonly DateTime MIN_DATE = new DateTime(1873, 2, 1);

    /// <summary>有効な最も未来の生年月日。</summary>
    private readonly DateTime MAX_DATE = new DateTime(2050, 12, 31);
#pragma warning restore IDE0090

#pragma warning disable IDE0044
    /// <summary>生年月日入力フィールド。</summary>
    [SerializeField]
    private Dropdown[] birthInput;

    /// <summary>決定ボタン。</summary>
    [SerializeField]
    private Button decideButton;

    /// <summary>名前入力フィールド。</summary>
    [SerializeField]
    private InputField nameInput;
#pragma warning restore IDE0044

    /// <summary>生年月日。</summary>
    private DateTime birth;

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
    /// フォーム入力を確定する際に呼び出す、コールバック。
    /// </summary>
    public void OnDecide()
    {
        WriteToMindCube(false);
        PutoutMindCube();
    }

    /// <summary>
    /// 生年月日入力が完了した際に呼び出す、コールバック。
    /// </summary>
    public void OnEndBirthInput()
    {
        if (decideButton == null)
        {
            Debug.LogWarning(ERR_NO_DECIDE);
            return;
        }
        decideButton.interactable = false;
        if (
            !DateTime.TryParse(GetBirthString(), out DateTime birth)
            || birth < MIN_DATE
            || birth > MAX_DATE
        )
        {
            Debug.LogWarning(WARN_BIRTH_OUT_OF_RANGE);
            return;
        }
        this.birth = birth;
        decideButton.interactable = true;
    }

    /// <summary>名前入力が完了した際に呼び出す、コールバック。</summary>
    public void OnEndNameInput()
    {
        if (nameInput != null && string.IsNullOrWhiteSpace(nameInput.text))
        {
            nameInput.text = PlayerName;
        }
    }

    /// <summary>内容を消去する際に呼び出す、コールバック。</summary>
    public void OnErase()
    {
        WriteToMindCube(true);
        PutoutMindCube();
    }

    /// <summary>
    /// フォームの内容から、生年月日を文字列で取得します。
    /// </summary>
    /// <returns>生年月日。</returns>
    private string GetBirthString()
    {
        if (
            birthInput == null ||
            birthInput.Length < (int)BirthIndex.MAX_VALUE
        )
        {
            Debug.LogWarning(ERR_NO_BIRTH);
            return string.Empty;
        }
        int year =
            ((birthInput[(int)BirthIndex.YearHi].value + 18) * 100) +
            (birthInput[(int)BirthIndex.YearLo1].value * 10) +
            birthInput[(int)BirthIndex.YearLo2].value;
        int month = birthInput[(int)BirthIndex.Month].value + 1;
        int day =
            (birthInput[(int)BirthIndex.DayHi].value * 10) +
            birthInput[(int)BirthIndex.DayLo].value;
        return $"{year:0000}-{month:00}-{day:00}";
    }

    /// <summary>生年月日コントロールの選択状態をリセットします。</summary>
    private void ResetBirth()
    {
        birth = INITIAL_DATE;
        if (
            birthInput != null &&
            birthInput.Length == (int)BirthIndex.MAX_VALUE
        )
        {
            if (birthInput[(int)BirthIndex.YearHi] != null)
            {
                birthInput[(int)BirthIndex.YearHi].value =
                    (DateTime.Now.Year / 100) - 18;
            }
            if (birthInput[(int)BirthIndex.YearLo1] != null)
            {
                birthInput[(int)BirthIndex.YearLo1].value =
                    INITIAL_DATE.Year % 100 / 10;
            }
            if (birthInput[(int)BirthIndex.YearLo2] != null)
            {
                birthInput[(int)BirthIndex.YearLo2].value =
                    INITIAL_DATE.Year % 10;
            }
            if (birthInput[(int)BirthIndex.Month] != null)
            {
                birthInput[(int)BirthIndex.Month].value =
                    INITIAL_DATE.Month - 1;
            }
            if (birthInput[(int)BirthIndex.DayHi] != null)
            {
                birthInput[(int)BirthIndex.DayHi].value =
                    INITIAL_DATE.Day / 10;
            }
            if (birthInput[(int)BirthIndex.DayLo] != null)
            {
                birthInput[(int)BirthIndex.DayLo].value =
                    INITIAL_DATE.Day % 10;
            }
        }
    }

    /// <summary>描画状態を更新します。</summary>
    protected override void OnUpdateMindCube()
    {
        ResetBirth();
        if (!(MindCube == null || nameInput == null))
        {
            nameInput.text = PlayerName;
        }
        base.OnUpdateMindCube();
    }

    /// <summary>マインドキューブに入力内容を書き込みます。</summary>
    /// <param name="erase">消去するかどうか。</param>
    private void WriteToMindCube(bool erase)
    {
        if (MindCube == null)
        {
            return;
        }
        MindCube.Variables.ChangeOwner();
        MindCube.Variables.CubeName =
            erase ? string.Empty :
            nameInput == null ? PlayerName :
            nameInput.text.Trim();
        MindCube.Variables.Parameter =
            erase ? uint.MaxValue : birth.GetPersonality();
        MindCube.Variables.Sync();
    }

#pragma warning disable IDE0051
    /// <summary>初期化時に呼び出される、コールバック。</summary>
    protected override void Start()
    {
        base.Start();
        ResetBirth();
    }
#pragma warning restore IDE0051
}
