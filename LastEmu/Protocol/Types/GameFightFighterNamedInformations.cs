using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class GameFightFighterNamedInformations : GameFightFighterInformations
	{
		public const short Id = 158;

		public string name;

		public PlayerStatus status;

		public override short TypeId
		{
			get
			{
				return 158;
			}
		}

		public GameFightFighterNamedInformations()
		{
		}

		public GameFightFighterNamedInformations(double contextualId, EntityLook look, EntityDispositionInformations disposition, sbyte teamId, sbyte wave, bool alive, GameFightMinimalStats stats, uint[] previousPositions, string name, PlayerStatus status) : base(contextualId, look, disposition, teamId, wave, alive, stats, previousPositions)
		{
			this.name = name;
			this.status = status;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.name = reader.ReadUTF();
			this.status = new PlayerStatus();
			this.status.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUTF(this.name);
			this.status.Serialize(writer);
		}
	}
}