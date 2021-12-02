using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager inst;

    private void Awake()
    {
        inst = this;
    }

    #region Sound Settings
    private const string SOUND_SETTINGS = "SoundSettings";
    private const string MUSIC_SETTINGS = "MusicSettings";

    public bool SoundSettings
    {
        get => PlayerPrefs.GetInt(SOUND_SETTINGS, 1) == 1;
        set => PlayerPrefs.SetInt(SOUND_SETTINGS, value ? 1 : 0);
    }

    public bool MusicSettings
    {
        get => PlayerPrefs.GetInt(MUSIC_SETTINGS, 1) == 1;
        set => PlayerPrefs.SetInt(MUSIC_SETTINGS, value ? 1 : 0);
    }
    #endregion
}

public static class GameMeaning
{
    #region Old game
    #region Build Settings
    public const int INTRO = 0; // id ����� � ���� ��������)
    public const int MENU = 2;
    public const int SCENEFIRST = 2; 
    public const int SCENESECOND = 2; // not
    public const int SCENETHIRD = 3; // not
    #endregion

    #region Intro
    public const int INTROTIMELOAD = 1100; //milliseq
    #endregion

    #region Menu
    public static bool hasPickedTeam; 
    public static int teamID;
    public static int timingNewScenes = 1000;
    public static int QuitGame = 120;

    #endregion

    #region GameSettings
    internal static bool FPSUI;
    #endregion

    #region Game Process (in Scene)
    public const float TIMEGAME = 480000f; //����� ������ 8 �����  

    public const int FINDPLAYERFORSCENE = 1000; //milliseq, �������� ��� ���������� � ����

    public const int TIMINGLOADGAMESTART = 1100; // �������� �������� ������ � milliseq
    public const int TIMINGLEAVEROOM = 800; // �������� �������� ������ � milliseq
    public const int TIMINGLEAVEGAME = 700; // �������� �������� ������ � milliseq. ���� �������� � ���� � ����

    public const float MAXHEALTHPLAYER = 250; // �� ������
    public const float MAXHEALTHENEMY = 10000; // �� �������

    public static float destroyGameInteractions = 0.2f; // ����� ����������� ������� �� ����� 
    #endregion

    #region Loot
    public static bool INTERACTIONSLOOT; //����������� ������� ���� � ����.
    public static bool CONNECTLOOT; 

    public static int GUNZERO = 0; // ���������� ����� ������ ��� ������
    public static int GUNFIRST = 1;  
    public static int GUNSECOND = 2;
    public static int GUNTHIRD = 3;
    public static int GUNFOURTH = 4;
    public static int GUNFIFTH = 5;
    public static int GUNSIXTH = 6;
    public static int GUNSEVENTH = 7;
    public static int GUNEIGHTH = 8;
    public static int GUNNINTH = 9;
    public static int GUNTENTH = 10;
    #endregion

    #region Controlls
    public const float MOUSESENSETIVITY = 3F; // ������ ���� - ����������������

    public const float SPINTSPEED = 6F;
    public const float WALKSPEED = 3F;
    public const float QUIETSPEED = 1.0F;
    public const float JUMPFORCE = 400F;
    public const float SMOOTHTIME = 0.15F;

    public const float QUIETSTEP = 1.4F; //�������� ����� �� ����� 
    public const float STEPTIMER = 0.6F; //�������� ����� ����
    public const float RUNSPEED = 0.3F; //�������� ����� ����
    public const float VALUENORMAL = 1F; //��������� (������������ �������� = 1,0)
    public const float VALUEGAME = 0.1F; // �� �����
    public const float VALUESHIFT = 0.001F; // �� �����
    #endregion

    #region Gun
    public const float BULLETDRAWINGTIME = 20f; //sec , ����� ��������� ���� �� �������
    #endregion

    #region  Animations TIMING sync
    public const int DIETIME = 1000; //milliseq
    #endregion
    #endregion

    #region New Game
    #region Intro

    #endregion
    #region Menu/Lobby
    public const int AUTOMATCHTIMER = 2;
    #endregion


    #endregion
}
