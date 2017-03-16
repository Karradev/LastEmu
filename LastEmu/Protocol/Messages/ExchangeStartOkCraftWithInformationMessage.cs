using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class ExchangeStartOkCraftWithInformationMessage : ExchangeStartOkCraftMessage
	{
		public const uint Id = 5941;

		public uint skillId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5941;
			}
		}

		public ExchangeStartOkCraftWithInformationMessage()
		{
		}

		public ExchangeStartOkCraftWithInformationMessage(uint skillId)
		{
			this.skillId = skillId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.skillId = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((int)this.skillId);
		}
	}
}