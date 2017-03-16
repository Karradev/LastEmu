using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GameFightRefreshFighterMessage : NetworkMessage
	{
		public const uint Id = 6309;

		public GameContextActorInformations informations;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6309;
			}
		}

		public GameFightRefreshFighterMessage()
		{
		}

		public GameFightRefreshFighterMessage(GameContextActorInformations informations)
		{
			this.informations = informations;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.informations = ProtocolTypeManager.GetInstance<GameContextActorInformations>(reader.ReadUShort());
			this.informations.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort(this.informations.TypeId);
			this.informations.Serialize(writer);
		}
	}
}