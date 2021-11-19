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

    private Room LastLocation;

    private Game game;

    void Awake()
    {
        TextAsset gamejsonasset = Resources.Load<TextAsset>(ZorkGameFileAssetName);

        game = JsonConvert.DeserializeObject<Game>(gamejsonasset.text);

        Game.Start(gamejsonasset.text, InputService, OutputService);

    }

    private void Update()
    {
        if(game.Player.CurrentRoom != LastLocation)
        {
            CurrentLocationText.text = game.Player.CurrentRoom.ToString();
            LastLocation = game.Player.CurrentRoom;
        }

        MovesText.text = $"Moves: {game.Player.Movement}";

        ScoreText.text = $"Socre: {game.Player.Score}";
    }
}
