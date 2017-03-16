using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeCraftResultMessage : NetworkMessage
	{
		public const uint Id = 5790;

		public sbyte craftResult;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5790;
			}
		}

		public ExchangeCraftResultMessage()
		{
		}

		public ExchangeCraftResultMessage(sbyte craftResult)
		{
			this.craftResult = craftResult;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.craftResult = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.craftResult);
		}
	}
}