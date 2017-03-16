using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GameFightSynchronizeMessage : NetworkMessage
	{
		public const uint Id = 5921;

		public GameFightFighterInformations[] fighters;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5921;
			}
		}

		public GameFightSynchronizeMessage()
		{
		}

		public GameFightSynchronizeMessage(GameFightFighterInformations[] fighters)
		{
			this.fighters = fighters;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.fighters = new GameFightFighterInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.fighters[i] = ProtocolTypeManager.GetInstance<GameFightFighterInformations>(reader.ReadUShort());
				this.fighters[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.fighters.Length));
			GameFightFighterInformations[] gameFightFighterInformationsArray = this.fighters;
			for (int i = 0; i < (int)gameFightFighterInformationsArray.Length; i++)
			{
				GameFightFighterInformations gameFightFighterInformation = gameFightFighterInformationsArray[i];
				writer.WriteShort(gameFightFighterInformation.TypeId);
				gameFightFighterInformation.Serialize(writer);
			}
		}
	}
}