using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class MapRunningFightDetailsMessage : NetworkMessage
	{
		public const uint Id = 5751;

		public int fightId;

		public GameFightFighterLightInformations[] attackers;

		public GameFightFighterLightInformations[] defenders;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5751;
			}
		}

		public MapRunningFightDetailsMessage()
		{
		}

		public MapRunningFightDetailsMessage(int fightId, GameFightFighterLightInformations[] attackers, GameFightFighterLightInformations[] defenders)
		{
			this.fightId = fightId;
			this.attackers = attackers;
			this.defenders = defenders;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.fightId = reader.ReadInt();
			ushort num = reader.ReadUShort();
			this.attackers = new GameFightFighterLightInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.attackers[i] = ProtocolTypeManager.GetInstance<GameFightFighterLightInformations>(reader.ReadUShort());
				this.attackers[i].Deserialize(reader);
			}
			num = reader.ReadUShort();
			this.defenders = new GameFightFighterLightInformations[num];
			for (int j = 0; j < num; j++)
			{
				this.defenders[j] = ProtocolTypeManager.GetInstance<GameFightFighterLightInformations>(reader.ReadUShort());
				this.defenders[j].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.fightId);
			writer.WriteShort((short)((int)this.attackers.Length));
			GameFightFighterLightInformations[] gameFightFighterLightInformationsArray = this.attackers;
			for (int i = 0; i < (int)gameFightFighterLightInformationsArray.Length; i++)
			{
				GameFightFighterLightInformations gameFightFighterLightInformation = gameFightFighterLightInformationsArray[i];
				writer.WriteShort(gameFightFighterLightInformation.TypeId);
				gameFightFighterLightInformation.Serialize(writer);
			}
			writer.WriteShort((short)((int)this.defenders.Length));
			GameFightFighterLightInformations[] gameFightFighterLightInformationsArray1 = this.defenders;
			for (int j = 0; j < (int)gameFightFighterLightInformationsArray1.Length; j++)
			{
				GameFightFighterLightInformations gameFightFighterLightInformation1 = gameFightFighterLightInformationsArray1[j];
				writer.WriteShort(gameFightFighterLightInformation1.TypeId);
				gameFightFighterLightInformation1.Serialize(writer);
			}
		}
	}
}