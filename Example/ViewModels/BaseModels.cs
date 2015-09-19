using System;
using System.Collections.Generic;
namespace Darkthread
{
	
	/// <summary>
	/// The player data
	/// </summary>
	public partial class Player
	{
		/// <summary>
		/// Identity
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// Player name
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Date of registration
		/// </summary>
		public DateTime RegDate { get; set; }
		/// <summary>
		/// Highest score
		/// </summary>
		public int? HighScore { get; set; }
		/// <summary>
		/// Rate of player
		/// </summary>
		public float? Rate { get; set; }
		/// <summary>
		/// Is VIP?
		/// </summary>
		public bool IsVIP { get; set; }
		
	}
	
	/// <summary>
	/// Game data
	/// </summary>
	public partial class Game
	{
		/// <summary>
		/// Sequencial number
		/// </summary>
		public int Seq { get; set; }
		/// <summary>
		/// Game id
		/// </summary>
		public string GameId { get; set; }
		/// <summary>
		/// Player id
		/// </summary>
		public string PlayerId { get; set; }
		/// <summary>
		/// Date of game
		/// </summary>
		public DateTime DateTime { get; set; }
		/// <summary>
		/// Score
		/// </summary>
		public int Score { get; set; }
		
	}
}