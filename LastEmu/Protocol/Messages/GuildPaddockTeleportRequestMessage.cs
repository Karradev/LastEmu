using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GuildPaddockTeleportRequestMessage : NetworkMessage
	{
		public const uint Id = 5957;

		public int paddockId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5957;
			}
		}

		public GuildPaddockTeleportRequestMessage()
		{
		}

		public GuildPaddockTeleportRequestMessage(int paddockId)
		{
			this.paddockId = paddockId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.paddockId = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.paddockId);
		}
	}
}