using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class ExchangePlayerMultiCraftRequestMessage : ExchangeRequestMessage
	{
		public const uint Id = 5784;

		public double target;

		public uint skillId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5784;
			}
		}

		public ExchangePlayerMultiCraftRequestMessage()
		{
		}

		public ExchangePlayerMultiCraftRequestMessage(sbyte exchangeType, double target, uint skillId) : base(exchangeType)
		{
			this.target = target;
			this.skillId = skillId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.target = reader.ReadVarUhLong();
			this.skillId = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarLong(this.target);
			writer.WriteVarInt((int)this.skillId);
		}
	}
}