using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeErrorMessage : NetworkMessage
	{
		public const uint Id = 5513;

		public sbyte errorType;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5513;
			}
		}

		public ExchangeErrorMessage()
		{
		}

		public ExchangeErrorMessage(sbyte errorType)
		{
			this.errorType = errorType;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.errorType = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.errorType);
		}
	}
}