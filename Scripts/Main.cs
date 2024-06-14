using Godot;
using Locations;
using ProcessHandling;
using System;
using System.Threading;
using System.Threading.Tasks;

public partial class Main : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Test.RunTest();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	private void _on_line_edit_text_submitted(string new_text)
	{
		GameState gameState = GameHandler.GetGameState();
		Hand hand = gameState.GetPlayer(0).GetHand();
		hand.PlayByInt(new_text.ToInt());
	}

	static int input = 0;

	private void _on_line_edit_2_text_submitted(string new_text)
	{
		input = new_text.ToInt();
	}

	public static async Task<int> HandleTargeting()
	{
		while(input == 0)
		{
			//do nothing
		}
		int i = input;
		input = 0;
		return i;
	}

}
