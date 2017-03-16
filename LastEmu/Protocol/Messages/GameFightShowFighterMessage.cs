using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GameFightShowFighterMessage : NetworkMessage
	{
		public const uint Id = 5864;

		public GameFightFighterInformations informations;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5864;
			}
		}

		public GameFightShowFighterMessage()
		{
		}

		public GameFightShowFighterMessage(GameFightFighterInformations informations)
		{
			this.informations = informations;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.informations = ProtocolTypeManager.GetInstance<GameFightFighterInformations>(reader.ReadUShort());
			this.informations.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort(this.informations.TypeId);
			this.informations.Serialize(writer);
		}
	}
}