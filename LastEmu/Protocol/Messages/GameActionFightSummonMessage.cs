using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GameActionFightSummonMessage : AbstractGameActionMessage
	{
		public const uint Id = 5825;

		public GameFightFighterInformations[] summons;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5825;
			}
		}

		public GameActionFightSummonMessage()
		{
		}

		public GameActionFightSummonMessage(uint actionId, double sourceId, GameFightFighterInformations[] summons) : base(actionId, sourceId)
		{
			this.summons = summons;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ushort num = reader.ReadUShort();
			this.summons = new GameFightFighterInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.summons[i] = ProtocolTypeManager.GetInstance<GameFightFighterInformations>(reader.ReadUShort());
				this.summons[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort((short)((int)this.summons.Length));
			GameFightFighterInformations[] gameFightFighterInformationsArray = this.summons;
			for (int i = 0; i < (int)gameFightFighterInformationsArray.Length; i++)
			{
				GameFightFighterInformations gameFightFighterInformation = gameFightFighterInformationsArray[i];
				writer.WriteShort(gameFightFighterInformation.TypeId);
				gameFightFighterInformation.Serialize(writer);
			}
		}
	}
}