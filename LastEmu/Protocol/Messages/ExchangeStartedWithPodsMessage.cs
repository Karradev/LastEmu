using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class ExchangeStartedWithPodsMessage : ExchangeStartedMessage
	{
		public const uint Id = 6129;

		public double firstCharacterId;

		public uint firstCharacterCurrentWeight;

		public uint firstCharacterMaxWeight;

		public double secondCharacterId;

		public uint secondCharacterCurrentWeight;

		public uint secondCharacterMaxWeight;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6129;
			}
		}

		public ExchangeStartedWithPodsMessage()
		{
		}

		public ExchangeStartedWithPodsMessage(sbyte exchangeType, double firstCharacterId, uint firstCharacterCurrentWeight, uint firstCharacterMaxWeight, double secondCharacterId, uint secondCharacterCurrentWeight, uint secondCharacterMaxWeight) : base(exchangeType)
		{
			this.firstCharacterId = firstCharacterId;
			this.firstCharacterCurrentWeight = firstCharacterCurrentWeight;
			this.firstCharacterMaxWeight = firstCharacterMaxWeight;
			this.secondCharacterId = secondCharacterId;
			this.secondCharacterCurrentWeight = secondCharacterCurrentWeight;
			this.secondCharacterMaxWeight = secondCharacterMaxWeight;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.firstCharacterId = reader.ReadDouble();
			this.firstCharacterCurrentWeight = reader.ReadVarUhInt();
			this.firstCharacterMaxWeight = reader.ReadVarUhInt();
			this.secondCharacterId = reader.ReadDouble();
			this.secondCharacterCurrentWeight = reader.ReadVarUhInt();
			this.secondCharacterMaxWeight = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(this.firstCharacterId);
			writer.WriteVarInt((int)this.firstCharacterCurrentWeight);
			writer.WriteVarInt((int)this.firstCharacterMaxWeight);
			writer.WriteDouble(this.secondCharacterId);
			writer.WriteVarInt((int)this.secondCharacterCurrentWeight);
			writer.WriteVarInt((int)this.secondCharacterMaxWeight);
		}
	}
}