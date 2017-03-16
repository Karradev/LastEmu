using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GuildPaddockRemovedMessage : NetworkMessage
	{
		public const uint Id = 5955;

		public int paddockId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5955;
			}
		}

		public GuildPaddockRemovedMessage()
		{
		}

		public GuildPaddockRemovedMessage(int paddockId)
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