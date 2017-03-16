using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class PlayerStatusUpdateRequestMessage : NetworkMessage
	{
		public const uint Id = 6387;

		public PlayerStatus status;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6387;
			}
		}

		public PlayerStatusUpdateRequestMessage()
		{
		}

		public PlayerStatusUpdateRequestMessage(PlayerStatus status)
		{
			this.status = status;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.status = ProtocolTypeManager.GetInstance<PlayerStatus>(reader.ReadUShort());
			this.status.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort(this.status.TypeId);
			this.status.Serialize(writer);
		}
	}
}