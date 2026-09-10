using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{   
    //UISelectToGameVersusAI script Instance;
    UISelectToGameVersusAI UISelectToGameVersusAIVar;

    //Main/first menu
    GameObject mainMenuCanvasObject;
    Canvas mainMenuCanvas;
    GameObject BGPanelGameObject;
    GameObject BackButtonGameObject;
    Button BackButton;
    GameObject PlayButtonGameObject;
    Button PlayButton;
    GameObject VersusAIButtonGameObject;
    Button VersusAIButton;
    GameObject VersusFriendsButtonGameObject;
    Button VersusFriendsButton;
    GameObject StoryModeGameObject;
    GameObject WIPOverlayGameObject;
    GameObject SettingsButtonGameObject;
    Button SettingsButton;
    GameObject ExitButtonGameObject;
    Button ExitButton;

    //Settings Overlay
    GameObject SettingsOverlay;
    GameObject SettingsExitButtonGameObject;
    Button SettingsExitButton;

    //Versus AI Menu
    GameObject VersusAICanvasGameObject;
    Canvas VSAIMenuCanvas;
    GameObject ReturnToMMButtonGameObject;
    Button ReturnToMMButton;
    GameObject EasyDifficultyButtonGameObject;
    Button EasyDifficultyButton;
    GameObject NormalDifficultyButtonGameObject;
    Button NormalDifficultyButton;
    GameObject HardDifficultyButtonGameObject;
    Button HardDifficultyButton;
    GameObject PlayerBattleBotType1ButtonGameObject;
    Button PlayerBattleBotType1Button;
    GameObject PlayerBattleBotType2ButtonGameObject;
    Button PlayerBattleBotType2Button;
    GameObject PlayerBattleBotType3ButtonGameObject;
    Button PlayerBattleBotType3Button;
    GameObject PlayerBattleBotType4ButtonGameObject;
    Button PlayerBattleBotType4Button;
    GameObject StartBattleButtonGameObject;
    Button StartBattleButton;
    GameObject OutlineEasyDifficultyButtonGameObject;
    Image OutlineEasyDifficultyButtonImage;
    GameObject OutlineNormalDifficultyButtonGameObject;
    Image OutlineNormalDifficultyButtonImage;
    GameObject OutlineHardDifficultyButtonGameObject;
    Image OutlineHardDifficultyButtonImage;
    GameObject OutlinePlayerBattleBotType1ButtonGameObject;
    Image OutlinePlayerBattleBotType1ButtonImage;
    GameObject OutlinePlayerBattleBotType2ButtonGameObject;
    Image OutlinePlayerBattleBotType2ButtonImage;
    GameObject OutlinePlayerBattleBotType3ButtonGameObject;
    Image OutlinePlayerBattleBotType3ButtonImage;
    GameObject OutlinePlayerBattleBotType4ButtonGameObject;
    Image OutlinePlayerBattleBotType4ButtonImage;


    void Start()
    {

        //UISelectToGameVersusAI Script Instance
        UISelectToGameVersusAIVar = GameObject.Find("MainManager").GetComponent<UISelectToGameVersusAI>();

        //Main/First menu
        mainMenuCanvasObject = GameObject.Find("StartMenuCanvas");
        mainMenuCanvas = mainMenuCanvasObject.GetComponent<Canvas>();

        BGPanelGameObject = mainMenuCanvasObject.transform.Find("BGPanel").gameObject;
        BackButtonGameObject = BGPanelGameObject.transform.Find("BackButton").gameObject;
        BackButton = BackButtonGameObject.GetComponent<Button>();
        PlayButtonGameObject = BGPanelGameObject.transform.Find("PlayButton").gameObject;
        PlayButton = PlayButtonGameObject.GetComponent<Button>();
        VersusAIButtonGameObject = BGPanelGameObject.transform.Find("VersusAIButton").gameObject;
        VersusAIButton = VersusAIButtonGameObject.GetComponent<Button>();
        WIPOverlayGameObject = BGPanelGameObject.transform.Find("WIPPanel").gameObject;
        StoryModeGameObject = BGPanelGameObject.transform.Find("StoryModeButton").gameObject;
        SettingsButtonGameObject = BGPanelGameObject.transform.Find("SettingsButton").gameObject;
        ExitButtonGameObject = BGPanelGameObject.transform.Find("ExitButton").gameObject;
        ExitButton = ExitButtonGameObject.GetComponent<Button>();
        VersusFriendsButtonGameObject = BGPanelGameObject.transform.Find("VersusFriendsButton").gameObject;
        VersusFriendsButton = VersusFriendsButtonGameObject.GetComponent<Button>();
        SettingsButton = SettingsButtonGameObject.GetComponent<Button>();

        //Settings Overlay
        SettingsOverlay = mainMenuCanvasObject.transform.Find("SettingsOverlay").gameObject;
        SettingsExitButtonGameObject = SettingsOverlay.transform.Find("CloseSettingsButton").gameObject;
        SettingsExitButton = SettingsExitButtonGameObject.GetComponent<Button>();

        //Versus AI Menu
        VersusAICanvasGameObject = GameObject.Find("VersusAICanvas");
        VSAIMenuCanvas = VersusAICanvasGameObject.GetComponent<Canvas>();
        ReturnToMMButtonGameObject = GameObject.Find("ReturnToMMButton");
        ReturnToMMButton = ReturnToMMButtonGameObject.GetComponent<Button>();
        EasyDifficultyButtonGameObject = GameObject.Find("DifficultyEasyButton");
        EasyDifficultyButton = EasyDifficultyButtonGameObject.GetComponent<Button>();
        NormalDifficultyButtonGameObject = GameObject.Find("DifficultyNormalButton");
        NormalDifficultyButton = NormalDifficultyButtonGameObject.GetComponent<Button>();
        HardDifficultyButtonGameObject = GameObject.Find("DifficultyHardButton");
        HardDifficultyButton = HardDifficultyButtonGameObject.GetComponent<Button>();
        PlayerBattleBotType1ButtonGameObject = GameObject.Find("BBot1Button");
        PlayerBattleBotType1Button = PlayerBattleBotType1ButtonGameObject.GetComponent<Button>();
        PlayerBattleBotType2ButtonGameObject = GameObject.Find("BBot2Button");
        PlayerBattleBotType2Button = PlayerBattleBotType2ButtonGameObject.GetComponent<Button>();
        PlayerBattleBotType3ButtonGameObject = GameObject.Find("BBot3Button");
        PlayerBattleBotType3Button = PlayerBattleBotType3ButtonGameObject.GetComponent<Button>();
        PlayerBattleBotType4ButtonGameObject = GameObject.Find("BBot4Button");
        PlayerBattleBotType4Button = PlayerBattleBotType4ButtonGameObject.GetComponent<Button>();
        StartBattleButtonGameObject = GameObject.Find("ToBattleButton");
        StartBattleButton = StartBattleButtonGameObject.GetComponent<Button>();
        //Versus AI Menu | Button outlines
        OutlineEasyDifficultyButtonGameObject = GameObject.Find("DifficultyEasyOutline");
        OutlineEasyDifficultyButtonImage = OutlineEasyDifficultyButtonGameObject.GetComponent<Image>();
        OutlineNormalDifficultyButtonGameObject = GameObject.Find("DifficultyNormalOutline");
        OutlineNormalDifficultyButtonImage = OutlineNormalDifficultyButtonGameObject.GetComponent<Image>();
        OutlineHardDifficultyButtonGameObject = GameObject.Find("DifficultyHardOutline");
        OutlineHardDifficultyButtonImage = OutlineHardDifficultyButtonGameObject.GetComponent<Image>();
        OutlinePlayerBattleBotType1ButtonGameObject = GameObject.Find("BBot1Outline");
        OutlinePlayerBattleBotType1ButtonImage = OutlinePlayerBattleBotType1ButtonGameObject.GetComponent<Image>();
        OutlinePlayerBattleBotType2ButtonGameObject = GameObject.Find("BBot2Outline");
        OutlinePlayerBattleBotType2ButtonImage = OutlinePlayerBattleBotType2ButtonGameObject.GetComponent<Image>();
        OutlinePlayerBattleBotType3ButtonGameObject = GameObject.Find("BBot3Outline");
        OutlinePlayerBattleBotType3ButtonImage = OutlinePlayerBattleBotType3ButtonGameObject.GetComponent<Image>();
        OutlinePlayerBattleBotType4ButtonGameObject = GameObject.Find("BBot4Outline");
        OutlinePlayerBattleBotType4ButtonImage = OutlinePlayerBattleBotType4ButtonGameObject.GetComponent<Image>();

        


        //Event listeners
        //Swap between Play selection buttons and main menu buttons
        PlayButton.onClick.AddListener(() => { VersusFriendsButtonGameObject.SetActive(true); ExitButtonGameObject.SetActive(false); StoryModeGameObject.SetActive(true); WIPOverlayGameObject.SetActive(true); VersusAIButtonGameObject.SetActive(true); BackButtonGameObject.SetActive(true); PlayButtonGameObject.SetActive(false); SettingsButtonGameObject.SetActive(false); BackButtonGameObject.SetActive(true); });
        BackButton.onClick.AddListener(() => { VersusFriendsButtonGameObject.SetActive(false); ExitButtonGameObject.SetActive(true); StoryModeGameObject.SetActive(false); WIPOverlayGameObject.SetActive(false); VersusAIButtonGameObject.SetActive(false); BackButtonGameObject.SetActive(false); PlayButtonGameObject.SetActive(true); SettingsButtonGameObject.SetActive(true); BackButtonGameObject.SetActive(false); });
        
        //Settings open/close (In main menu)
        SettingsExitButton.onClick.AddListener(() => SettingsOverlay.SetActive(false));
        SettingsButton.onClick.AddListener(() => SettingsOverlay.SetActive(true));

        //Exit game
        ExitButton.onClick.AddListener(() => Application.Quit());

        //Switch between main menu and Versus AI menu
        ReturnToMMButton.onClick.AddListener(() => SwitchCanvas(VSAIMenuCanvas, mainMenuCanvas));
        VersusAIButton.onClick.AddListener(() => SwitchCanvas(mainMenuCanvas, VSAIMenuCanvas));

        //Versus AI menu | Difficulty selection
        EasyDifficultyButton.onClick.AddListener(() => 
        { 
            if (UISelectToGameVersusAIVar.selectedDifficulty != UISelectToGameVersusAI.Difficulty.Easy)
            {
            OutlineEasyDifficultyButtonImage.enabled = true; 
            OutlineNormalDifficultyButtonImage.enabled = false; 
            OutlineHardDifficultyButtonImage.enabled = false; 
            UISelectToGameVersusAIVar.OnDifficultyButtonClicked(0);
            }
        }
        );

        NormalDifficultyButton.onClick.AddListener(() => 
        { 
            if (UISelectToGameVersusAIVar.selectedDifficulty != UISelectToGameVersusAI.Difficulty.Normal)
            {
                OutlineEasyDifficultyButtonImage.enabled = false; 
                OutlineNormalDifficultyButtonImage.enabled = true; 
                OutlineHardDifficultyButtonImage.enabled = false; 
                UISelectToGameVersusAIVar.OnDifficultyButtonClicked(1);
            }
        }
        );
        HardDifficultyButton.onClick.AddListener(() => 
        { 
            if (UISelectToGameVersusAIVar.selectedDifficulty != UISelectToGameVersusAI.Difficulty.Hard)
            {
                OutlineEasyDifficultyButtonImage.enabled = false; 
                OutlineNormalDifficultyButtonImage.enabled = false; 
                OutlineHardDifficultyButtonImage.enabled = true; 
                UISelectToGameVersusAIVar.OnDifficultyButtonClicked(2);
            }
        });

        //Versus AI menu | Battle-bot selection
        PlayerBattleBotType1Button.onClick.AddListener(() => { 
            if (UISelectToGameVersusAIVar.playerSelectedBattleBotType != UISelectToGameVersusAI.BattleBotType.Explo1)
            {
                OutlinePlayerBattleBotType1ButtonImage.enabled = true; 
                OutlinePlayerBattleBotType2ButtonImage.enabled = false; 
                OutlinePlayerBattleBotType3ButtonImage.enabled = false; 
                OutlinePlayerBattleBotType4ButtonImage.enabled = false; 
                UISelectToGameVersusAIVar.OnPlayerBattleBotButtonClicked(0);
            }
        });
        PlayerBattleBotType2Button.onClick.AddListener(() => { 
            if (UISelectToGameVersusAIVar.playerSelectedBattleBotType != UISelectToGameVersusAI.BattleBotType.Explo2)
            {
                OutlinePlayerBattleBotType1ButtonImage.enabled = false; 
                OutlinePlayerBattleBotType2ButtonImage.enabled = true; 
                OutlinePlayerBattleBotType3ButtonImage.enabled = false; 
                OutlinePlayerBattleBotType4ButtonImage.enabled = false; 
                UISelectToGameVersusAIVar.OnPlayerBattleBotButtonClicked(1);
            }
        });
        PlayerBattleBotType3Button.onClick.AddListener(() => { 
            if (UISelectToGameVersusAIVar.playerSelectedBattleBotType != UISelectToGameVersusAI.BattleBotType.Mage1)
            {
                OutlinePlayerBattleBotType1ButtonImage.enabled = false; 
                OutlinePlayerBattleBotType2ButtonImage.enabled = false; 
                OutlinePlayerBattleBotType3ButtonImage.enabled = true; 
                OutlinePlayerBattleBotType4ButtonImage.enabled = false; 
                UISelectToGameVersusAIVar.OnPlayerBattleBotButtonClicked(2);
            }
        });
        PlayerBattleBotType4Button.onClick.AddListener(() => { 
            if (UISelectToGameVersusAIVar.playerSelectedBattleBotType != UISelectToGameVersusAI.BattleBotType.Mage2)
            {
                OutlinePlayerBattleBotType1ButtonImage.enabled = false; 
                OutlinePlayerBattleBotType2ButtonImage.enabled = false; 
                OutlinePlayerBattleBotType3ButtonImage.enabled = false; 
                OutlinePlayerBattleBotType4ButtonImage.enabled = true; 
                UISelectToGameVersusAIVar.OnPlayerBattleBotButtonClicked(3);
            }
        });
    }
    void SwitchCanvas(Canvas aCanvas, Canvas bCanvas)
    {
        aCanvas.enabled = false;
        bCanvas.enabled = true;
    }
}
