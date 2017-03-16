using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GuildCreationResultMessage : NetworkMessage
	{
		public const uint Id = 5554;

		public sbyte result;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5554;
			}
		}

		public GuildCreationResultMessage()
		{
		}

		public GuildCreationResultMessage(sbyte result)
		{
			this.result = result;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.result = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.result);
		}
	}
}