using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GameRolePlayShowActorMessage : NetworkMessage
	{
		public const uint Id = 5632;

		public GameRolePlayActorInformations informations;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5632;
			}
		}

		public GameRolePlayShowActorMessage()
		{
		}

		public GameRolePlayShowActorMessage(GameRolePlayActorInformations informations)
		{
			this.informations = informations;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.informations = ProtocolTypeManager.GetInstance<GameRolePlayActorInformations>(reader.ReadUShort());
			this.informations.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort(this.informations.TypeId);
			this.informations.Serialize(writer);
		}
	}
}