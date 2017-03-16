using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeCraftCountModifiedMessage : NetworkMessage
	{
		public const uint Id = 6595;

		public int count;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6595;
			}
		}

		public ExchangeCraftCountModifiedMessage()
		{
		}

		public ExchangeCraftCountModifiedMessage(int count)
		{
			this.count = count;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.count = reader.ReadVarInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt(this.count);
		}
	}
}