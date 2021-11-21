using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Zork;
using Newtonsoft.Json;
public class GameManager : MonoBehaviour
{
    [SerializeField]
    private string ZorkGameFileAssetName = "Zork";

    [SerializeField]
    private UnityOutputService OutputService;

    [SerializeField]
    private UnityInputService InputService;

    [SerializeField]
    private TextMeshProUGUI CurrentLocationText;

    [SerializeField]
    private TextMeshProUGUI MovesText;

    [SerializeField]
    private TextMeshProUGUI ScoreText;

    private Game game;

    private bool QuitCheck;

    void Awake()
    {
        TextAsset gamejsonasset = Resources.Load<TextAsset>(ZorkGameFileAssetName);

        game = JsonConvert.DeserializeObject<Game>(gamejsonasset.text);

        Game.Start(gamejsonasset.text, InputService, OutputService);

        OutputService.WriteLine(game.WelcomeMessage);

        OutputService.WriteLine(game.Player.CurrentRoom.Name);

        OutputService.WriteLine(game.Player.CurrentRoom.Description);
    }

    void Update()
    {
        if(Game.Instance.Player.CurrentRoom != Game.Instance.Player.PerviousRoom)
        {
            CurrentLocationText.text = Game.Instance.Player.CurrentRoom.ToString();

            Game.Instance.Player.PerviousRoom = Game.Instance.Player.CurrentRoom;
        }

        MovesText.text = $"Moves: {Game.Instance.Player.Movement}";

        ScoreText.text = $"Socre: {Game.Instance.Player.Score}";

        if (!Game.Instance.IsRunning && !QuitCheck)
        {
            OutputService.WriteLine("Press any key to quit");
            QuitCheck = true;
        }

        if (QuitCheck && Input.anyKeyDown)
        { 
            Application.Quit();
        }
    }
}
