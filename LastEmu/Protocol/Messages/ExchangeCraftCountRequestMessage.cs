using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeCraftCountRequestMessage : NetworkMessage
	{
		public const uint Id = 6597;

		public int count;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6597;
			}
		}

		public ExchangeCraftCountRequestMessage()
		{
		}

		public ExchangeCraftCountRequestMessage(int count)
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